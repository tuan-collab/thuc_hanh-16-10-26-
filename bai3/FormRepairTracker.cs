using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RepairServiceTracker
{
    public partial class FormRepairTracker : Form
    {
        private BindingList<RepairOrder> _orders = new BindingList<RepairOrder>();
        private BindingSource _bindingSource = new BindingSource();
        private string _selectedImagePath = "";

        public FormRepairTracker()
        {
            InitializeComponent();
            SetupControlsData();
            SetupDataGridView();
            _bindingSource.DataSource = _orders;
            dgvOrders.DataSource = _bindingSource;
            LoadSampleData();
            ApplyFilter();
        }

        private void SetupControlsData()
        {
            cboLoaiThietBi.Items.AddRange(new object[] { "Laptop", "Điện thoại", "Máy tính bảng", "Màn hình", "Thiết bị ngoại vi" });
            cboLoaiThietBi.SelectedIndex = 0;

            cboTrangThai.Items.AddRange(new object[] { "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboTrangThai.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả", "Mới tiếp nhận", "Đang sửa", "Chờ linh kiện", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            dtpNgayTiepNhan.Value = DateTime.Today;
        }

        private void SetupDataGridView()
        {
            dgvOrders.Columns.Clear();
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaDon", HeaderText = "Mã Đơn", Width = 80 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TenKhachHang", HeaderText = "Tên Khách Hàng", Width = 140 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "SĐT", Width = 100 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LoaiThietBi", HeaderText = "Thiết Bị", Width = 110 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayTiepNhan", HeaderText = "Ngày Nhận", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ChiPhiDuKien", HeaderText = "Chi Phí Dự Kiến", Width = 120, DefaultCellStyle = new DataGridViewCellStyle { Format = "N0" } });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 110 });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MoTaLoi", HeaderText = "Mô Tả Lỗi", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
        }

        private void LoadSampleData()
        {
            _orders.Add(new RepairOrder
            {
                MaDon = "HD001",
                TenKhachHang = "Nguyễn Văn C",
                SoDienThoai = "0988777666",
                LoaiThietBi = "Laptop",
                NgayTiepNhan = DateTime.Today,
                ChiPhiDuKien = 500000,
                MoTaLoi = "Không lên nguồn, hỏng chân sạc",
                TrangThai = "Mới tiếp nhận",
                HinhAnhPath = ""
            });
        }

        private bool ValidateInput(bool isNew)
        {
            bool valid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtMaDon.Text))
            {
                errorProvider1.SetError(txtMaDon, "Mã đơn bắt buộc nhập.");
                valid = false;
            }
            else if (isNew && _orders.Any(o => o.MaDon.Equals(txtMaDon.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaDon, "Mã đơn đã tồn tại.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtTenKhachHang.Text))
            {
                errorProvider1.SetError(txtTenKhachHang, "Tên khách hàng không được để trống.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text))
            {
                errorProvider1.SetError(txtSoDienThoai, "Số điện thoại không được trống.");
                valid = false;
            }

            if (!decimal.TryParse(txtChiPhi.Text.Trim(), out decimal cost) || cost < 0)
            {
                errorProvider1.SetError(txtChiPhi, "Chi phí dự kiến phải là số không âm.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMoTaLoi.Text))
            {
                errorProvider1.SetError(txtMoTaLoi, "Mô tả lỗi bắt buộc nhập.");
                valid = false;
            }

            return valid;
        }

        private void btnBrowseImg_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog { Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = ofd.FileName;
                    picDevice.ImageLocation = ofd.FileName;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            _orders.Add(new RepairOrder
            {
                MaDon = txtMaDon.Text.Trim(),
                TenKhachHang = txtTenKhachHang.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString(),
                NgayTiepNhan = dtpNgayTiepNhan.Value.Date,
                ChiPhiDuKien = decimal.Parse(txtChiPhi.Text.Trim()),
                MoTaLoi = txtMoTaLoi.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem.ToString(),
                HinhAnhPath = _selectedImagePath
            });

            ApplyFilter();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is RepairOrder item)
            {
                if (!ValidateInput(isNew: false)) return;

                if (MessageBox.Show("Cập nhật đơn sửa chữa này?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    item.TenKhachHang = txtTenKhachHang.Text.Trim();
                    item.SoDienThoai = txtSoDienThoai.Text.Trim();
                    item.LoaiThietBi = cboLoaiThietBi.SelectedItem.ToString();
                    item.NgayTiepNhan = dtpNgayTiepNhan.Value.Date;
                    item.ChiPhiDuKien = decimal.Parse(txtChiPhi.Text.Trim());
                    item.MoTaLoi = txtMoTaLoi.Text.Trim();
                    item.TrangThai = cboTrangThai.SelectedItem.ToString();
                    item.HinhAnhPath = _selectedImagePath;

                    _bindingSource.ResetBindings(false);
                    ApplyFilter();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is RepairOrder item)
            {
                if (MessageBox.Show($"Xóa đơn sửa chữa {item.MaDon}?", "Xác nhận xóa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _orders.Remove(item);
                    ApplyFilter();
                    ClearInputs();
                }
            }
        }

        private void dgvOrders_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrders.CurrentRow?.DataBoundItem is RepairOrder item)
            {
                txtMaDon.Text = item.MaDon;
                txtMaDon.ReadOnly = true;
                txtTenKhachHang.Text = item.TenKhachHang;
                txtSoDienThoai.Text = item.SoDienThoai;
                cboLoaiThietBi.SelectedItem = item.LoaiThietBi;
                dtpNgayTiepNhan.Value = item.NgayTiepNhan;
                txtChiPhi.Text = item.ChiPhiDuKien.ToString("G0");
                cboTrangThai.SelectedItem = item.TrangThai;
                txtMoTaLoi.Text = item.MoTaLoi;
                _selectedImagePath = item.HinhAnhPath;

                if (!string.IsNullOrEmpty(item.HinhAnhPath) && File.Exists(item.HinhAnhPath))
                {
                    picDevice.ImageLocation = item.HinhAnhPath;
                }
                else
                {
                    picDevice.Image = null;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {

            
        }

        private void ClearInputs()
        {
            txtMaDon.ReadOnly = false;
            txtMaDon.Clear();
            txtTenKhachHang.Clear();
            txtSoDienThoai.Clear();
            txtChiPhi.Text = "0";
            txtMoTaLoi.Clear();
            _selectedImagePath = "";
            picDevice.Image = null;
            cboLoaiThietBi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            dtpNgayTiepNhan.Value = DateTime.Today;
            errorProvider1.Clear();
        }

        private void menuExportCsv_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv", FileName = "DanhSachDonSuaChua.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã Đơn,Tên Khách Hàng,Số ĐT,Loại Thiết Bị,Ngày Tiếp Nhận,Chi Phí Dự Kiến,Trạng Thái,Mô Tả Lỗi");
                    if (_bindingSource.DataSource is BindingList<RepairOrder> currentList)
                    {
                        foreach (var o in currentList)
                        {
                            sb.AppendLine($"\"{o.MaDon}\",\"{o.TenKhachHang}\",\"{o.SoDienThoai}\",\"{o.LoaiThietBi}\",\"{o.NgayTiepNhan:dd/MM/yyyy}\",{o.ChiPhiDuKien},\"{o.TrangThai}\",\"{o.MoTaLoi}\"");
                        }
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất dữ liệu ra tập tin CSV thành công!");
                }
            }
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}