using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LabEquipmentCheckout
{
    public partial class FormLabCheckout : Form
    {
        private BindingList<EquipmentTicket> _tickets = new BindingList<EquipmentTicket>();
        private BindingSource _bindingSource = new BindingSource();

        public FormLabCheckout()
        {
            InitializeComponent();
            SetupControlsData();
            SetupDataGridView();
            _bindingSource.DataSource = _tickets;
            dgvTickets.DataSource = _bindingSource;
            LoadSampleData();
            ApplyFilter();
        }

        private void SetupControlsData()
        {
            cboThietBi.Items.AddRange(new object[] { "Oscilloscope Tektronix", "Vạn năng kế Digital", "Bo mạch Arduino Uno", "Bộ Raspberry Pi 4", "Nguồn Dòng DC" });
            cboThietBi.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả phiếu", "Đang mượn", "Quá hạn", "Đã trả" });
            cboFilterStatus.SelectedIndex = 0;

            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
        }

        private void SetupDataGridView()
        {
            dgvTickets.Columns.Clear();
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaPhieu", HeaderText = "Mã Phiếu", Width = 90 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaSV", HeaderText = "Mã SV", Width = 90 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTenSV", HeaderText = "Họ Tên SV", Width = 140 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ThietBi", HeaderText = "Thiết Bị", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoLuong", HeaderText = "SL", Width = 50 });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayMuon", HeaderText = "Ngày Mượn", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HanTra", HeaderText = "Hạn Trả", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayTraThucTe", HeaderText = "Ngày Trả TT", Width = 100, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy" } });
            dgvTickets.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 100 });
        }

        private void LoadSampleData()
        {
            _tickets.Add(new EquipmentTicket
            {
                MaPhieu = "PM001",
                MaSV = "SV101",
                HoTenSV = "Trần Văn B",
                ThietBi = "Oscilloscope Tektronix",
                SoLuong = 1,
                NgayMuon = DateTime.Today.AddDays(-10),
                HanTra = DateTime.Today.AddDays(-2),
                NgayTraThucTe = null,
                TrangThai = "Đang mượn"
            });
        }

        private void CheckAndUpdateOverdueStatus()
        {
            foreach (var ticket in _tickets)
            {
                if (ticket.NgayTraThucTe == null && ticket.HanTra.Date < DateTime.Today.Date)
                {
                    ticket.TrangThai = "Quá hạn";
                }
            }
        }

        private bool ValidateInput(bool isNew)
        {
            bool valid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                errorProvider1.SetError(txtMaPhieu, "Mã phiếu không được trống.");
                valid = false;
            }
            else if (isNew && _tickets.Any(t => t.MaPhieu.Equals(txtMaPhieu.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaPhieu, "Mã phiếu trùng lặp.");
                valid = false;
            }

            if (string.IsNullOrWhiteSpace(txtMaSV.Text))
            {
                errorProvider1.SetError(txtMaSV, "Mã sinh viên không được trống.");
                valid = false;
            }

            if (dtpHanTra.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider1.SetError(dtpHanTra, "Hạn trả không được trước ngày mượn.");
                valid = false;
            }

            if (chkDaTra.Checked && dtpNgayTraThucTe.Value.Date < dtpNgayMuon.Value.Date)
            {
                errorProvider1.SetError(dtpNgayTraThucTe, "Ngày trả thực tế không trước ngày mượn.");
                valid = false;
            }

            return valid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            string status = chkDaTra.Checked ? "Đã trả" : (dtpHanTra.Value.Date < DateTime.Today.Date ? "Quá hạn" : "Đang mượn");

            _tickets.Add(new EquipmentTicket
            {
                MaPhieu = txtMaPhieu.Text.Trim(),
                MaSV = txtMaSV.Text.Trim(),
                HoTenSV = txtHoTenSV.Text.Trim(),
                ThietBi = cboThietBi.SelectedItem.ToString(),
                SoLuong = (int)nudSoLuong.Value,
                NgayMuon = dtpNgayMuon.Value.Date,
                HanTra = dtpHanTra.Value.Date,
                NgayTraThucTe = chkDaTra.Checked ? (DateTime?)dtpNgayTraThucTe.Value.Date : null,
                TrangThai = status
            });

            ApplyFilter();
            ClearInputs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is EquipmentTicket t)
            {
                if (!ValidateInput(isNew: false)) return;

                if (MessageBox.Show("Xác nhận cập nhật phiếu mượn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    t.MaSV = txtMaSV.Text.Trim();
                    t.HoTenSV = txtHoTenSV.Text.Trim();
                    t.ThietBi = cboThietBi.SelectedItem.ToString();
                    t.SoLuong = (int)nudSoLuong.Value;
                    t.NgayMuon = dtpNgayMuon.Value.Date;
                    t.HanTra = dtpHanTra.Value.Date;
                    t.NgayTraThucTe = chkDaTra.Checked ? (DateTime?)dtpNgayTraThucTe.Value.Date : null;

                    if (t.NgayTraThucTe != null) t.TrangThai = "Đã trả";
                    else if (t.HanTra.Date < DateTime.Today.Date) t.TrangThai = "Quá hạn";
                    else t.TrangThai = "Đang mượn";

                    _bindingSource.ResetBindings(false);
                    ApplyFilter();
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is EquipmentTicket t)
            {
                if (MessageBox.Show($"Xóa phiếu mượn {t.MaPhieu}?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _tickets.Remove(t);
                    ApplyFilter();
                    ClearInputs();
                }
            }
        }

        private void btnMarkReturn_Click(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is EquipmentTicket t)
            {
                t.NgayTraThucTe = DateTime.Now.Date;
                t.TrangThai = "Đã trả";
                _bindingSource.ResetBindings(false);
                ApplyFilter();
                dgvTickets_SelectionChanged(null, null);
                MessageBox.Show("Đã cập nhật trạng thái phiếu thành 'Đã trả'!", "Thông báo");
            }
        }

        private void dgvTickets_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTickets.CurrentRow?.DataBoundItem is EquipmentTicket t)
            {
                txtMaPhieu.Text = t.MaPhieu;
                txtMaPhieu.ReadOnly = true;
                txtMaSV.Text = t.MaSV;
                txtHoTenSV.Text = t.HoTenSV;
                cboThietBi.SelectedItem = t.ThietBi;
                nudSoLuong.Value = t.SoLuong;
                dtpNgayMuon.Value = t.NgayMuon;
                dtpHanTra.Value = t.HanTra;
                chkDaTra.Checked = t.NgayTraThucTe.HasValue;
                if (t.NgayTraThucTe.HasValue) dtpNgayTraThucTe.Value = t.NgayTraThucTe.Value;
            }
        }

        private void chkDaTra_CheckedChanged(object sender, EventArgs e)
        {
            dtpNgayTraThucTe.Enabled = chkDaTra.Checked;
            if (chkDaTra.Checked) dtpNgayTraThucTe.Value = DateTime.Now;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            CheckAndUpdateOverdueStatus();
            string key = txtSearch.Text.Trim().ToLower();
            string status = cboFilterStatus.SelectedItem?.ToString();

            var list = _tickets.Where(t =>
                (string.IsNullOrEmpty(key) || t.MaSV.ToLower().Contains(key) || t.ThietBi.ToLower().Contains(key)) &&
                (status == "Tất cả phiếu" || string.IsNullOrEmpty(status) || t.TrangThai == status)
            ).ToList();

            _bindingSource.DataSource = new BindingList<EquipmentTicket>(list);

            int totalCount = _tickets.Count;
            int overdueCount = _tickets.Count(t => t.TrangThai == "Quá hạn");
            lblStatusInfo.Text = $"Hiển thị: {list.Count} | Tổng số phiếu: {totalCount} | Phiếu quá hạn: {overdueCount}";
        }

        private void ClearInputs()
        {
            txtMaPhieu.ReadOnly = false;
            txtMaPhieu.Clear();
            txtMaSV.Clear();
            txtHoTenSV.Clear();
            nudSoLuong.Value = 1;
            dtpNgayMuon.Value = DateTime.Today;
            dtpHanTra.Value = DateTime.Today.AddDays(7);
            chkDaTra.Checked = false;
            errorProvider1.Clear();
        }

        private void btnExportCsv_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv", FileName = "DanhSachPhieuMuon.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã Phiếu,Mã SV,Họ Tên SV,Thiết Bị,Số Lượng,Ngày Mượn,Hạn Trả,Ngày Trả Thực Tế,Trạng Thái");
                    if (_bindingSource.DataSource is BindingList<EquipmentTicket> currentList)
                    {
                        foreach (var t in currentList)
                        {
                            string ngayTraStr = t.NgayTraThucTe.HasValue ? t.NgayTraThucTe.Value.ToString("dd/MM/yyyy") : "";
                            sb.AppendLine($"\"{t.MaPhieu}\",\"{t.MaSV}\",\"{t.HoTenSV}\",\"{t.ThietBi}\",{t.SoLuong},\"{t.NgayMuon:dd/MM/yyyy}\",\"{t.HanTra:dd/MM/yyyy}\",\"{ngayTraStr}\",\"{t.TrangThai}\"");
                        }
                    }
                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất danh sách ra CSV thành công!");
                }
            }
        }
    }
}