using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicAppointmentManager
{
    public partial class FormClinicManager : Form
    {
        private BindingList<Appointment> _listAppointments = new BindingList<Appointment>();
        private BindingSource _bindingSource = new BindingSource();

        public FormClinicManager()
        {
            InitializeComponent();
            SetupControlsData();
            SetupDataGridViewColumns();
            SetupDataBindings();
            LoadSampleData();
            ApplyFilter();
        }

        private void SetupControlsData()
        {
            cboBacSi.Items.AddRange(new object[] { "BS. Nguyễn Văn A", "BS. Trần Thị B", "BS. Lê Hoàng C" });
            cboBacSi.SelectedIndex = 0;

            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboTrangThai.SelectedIndex = 0;

            cboFilterStatus.Items.AddRange(new object[] { "Tất cả trạng thái", "Chờ khám", "Đang khám", "Hoàn tất", "Đã hủy" });
            cboFilterStatus.SelectedIndex = 0;

            dtpNgayGioHen.Value = DateTime.Now.AddHours(1);
        }

        private void SetupDataGridViewColumns()
        {
            dgvAppointments.Columns.Clear();
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "MaLichHen", HeaderText = "Mã LH", Width = 80 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "HoTen", HeaderText = "Họ và Tên", Width = 150 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "SoDienThoai", HeaderText = "Số ĐT", Width = 100 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "NgayGioHen", HeaderText = "Ngày Giờ Hẹn", Width = 130, DefaultCellStyle = new DataGridViewCellStyle { Format = "dd/MM/yyyy HH:mm" } });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "BacSi", HeaderText = "Bác Sĩ", Width = 140 });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LyDoKham", HeaderText = "Lý Do Khám", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvAppointments.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "TrangThai", HeaderText = "Trạng Thái", Width = 100 });
        }

        private void SetupDataBindings()
        {
            _bindingSource.DataSource = _listAppointments;
            dgvAppointments.DataSource = _bindingSource;
        }

        private void LoadSampleData()
        {
            _listAppointments.Add(new Appointment
            {
                MaLichHen = "LH001",
                HoTen = "Nguyễn Văn An",
                SoDienThoai = "0912345678",
                NgayGioHen = DateTime.Now.AddDays(1),
                BacSi = "BS. Nguyễn Văn A",
                LyDoKham = "Khám sức khỏe định kỳ",
                TrangThai = "Chờ khám"
            });
        }

        private bool ValidateInput(bool isNew)
        {
            bool isValid = true;
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtMaLichHen.Text))
            {
                errorProvider1.SetError(txtMaLichHen, "Mã lịch hẹn không được để trống.");
                isValid = false;
            }
            else if (isNew && _listAppointments.Any(a => a.MaLichHen.Equals(txtMaLichHen.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            {
                errorProvider1.SetError(txtMaLichHen, "Mã lịch hẹn đã tồn tại.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                errorProvider1.SetError(txtHoTen, "Họ tên bệnh nhân không được để trống.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtSoDienThoai.Text) || !Regex.IsMatch(txtSoDienThoai.Text.Trim(), @"^0\d{9,10}$"))
            {
                errorProvider1.SetError(txtSoDienThoai, "Số điện thoại không hợp lệ (bắt đầu bằng 0, gồm 10-11 chữ số).");
                isValid = false;
            }

            if (dtpNgayGioHen.Value < DateTime.Now)
            {
                errorProvider1.SetError(dtpNgayGioHen, "Ngày giờ hẹn không được nằm trong quá khứ.");
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtLyDoKham.Text))
            {
                errorProvider1.SetError(txtLyDoKham, "Lý do khám không được để trống.");
                isValid = false;
            }

            return isValid;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInput(isNew: true)) return;

            var item = new Appointment
            {
                MaLichHen = txtMaLichHen.Text.Trim(),
                HoTen = txtHoTen.Text.Trim(),
                SoDienThoai = txtSoDienThoai.Text.Trim(),
                NgayGioHen = dtpNgayGioHen.Value,
                BacSi = cboBacSi.SelectedItem.ToString(),
                LyDoKham = txtLyDoKham.Text.Trim(),
                TrangThai = cboTrangThai.SelectedItem.ToString()
            };

            _listAppointments.Add(item);
            ApplyFilter();
            ClearInputs();
            MessageBox.Show("Thêm lịch hẹn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;
            var currentObj = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (currentObj == null) return;

            if (!ValidateInput(isNew: false)) return;

            if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật lịch hẹn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentObj.HoTen = txtHoTen.Text.Trim();
                currentObj.SoDienThoai = txtSoDienThoai.Text.Trim();
                currentObj.NgayGioHen = dtpNgayGioHen.Value;
                currentObj.BacSi = cboBacSi.SelectedItem.ToString();
                currentObj.LyDoKham = txtLyDoKham.Text.Trim();
                currentObj.TrangThai = cboTrangThai.SelectedItem.ToString();

                _bindingSource.ResetBindings(false);
                ApplyFilter();
                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow == null) return;
            var currentObj = dgvAppointments.CurrentRow.DataBoundItem as Appointment;
            if (currentObj == null) return;

            if (MessageBox.Show($"Bạn có chắc muốn xóa lịch hẹn mã: {currentObj.MaLichHen}?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _listAppointments.Remove(currentObj);
                ApplyFilter();
                ClearInputs();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvAppointments_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppointments.CurrentRow != null && dgvAppointments.CurrentRow.DataBoundItem is Appointment item)
            {
                txtMaLichHen.Text = item.MaLichHen;
                txtMaLichHen.ReadOnly = true;
                txtHoTen.Text = item.HoTen;
                txtSoDienThoai.Text = item.SoDienThoai;
                dtpNgayGioHen.Value = item.NgayGioHen > DateTime.Now ? item.NgayGioHen : DateTime.Now.AddMinutes(5);
                cboBacSi.SelectedItem = item.BacSi;
                txtLyDoKham.Text = item.LyDoKham;
                cboTrangThai.SelectedItem = item.TrangThai;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();
        private void cboFilterStatus_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilter();
        private void chkEnableDateFilter_CheckedChanged(object sender, EventArgs e) => ApplyFilter();
        private void dtpFilterDate_ValueChanged(object sender, EventArgs e) { if (chkEnableDateFilter.Checked) ApplyFilter(); }

        private void ApplyFilter()
        {
            string keyword = txtSearch.Text.Trim().ToLower();
            string selectedStatus = cboFilterStatus.SelectedItem?.ToString();
            bool useDate = chkEnableDateFilter.Checked;
            DateTime filterDate = dtpFilterDate.Value.Date;

            var filteredList = _listAppointments.Where(a =>
                (string.IsNullOrEmpty(keyword) || a.HoTen.ToLower().Contains(keyword) || a.SoDienThoai.Contains(keyword)) &&
                (selectedStatus == "Tất cả trạng thái" || string.IsNullOrEmpty(selectedStatus) || a.TrangThai == selectedStatus) &&
                (!useDate || a.NgayGioHen.Date == filterDate)
            ).ToList();

            _bindingSource.DataSource = new BindingList<Appointment>(filteredList);
            lblStatusCount.Text = $"Số lịch hẹn hiển thị: {filteredList.Count} / Tổng số: {_listAppointments.Count}";
        }

        private void ClearInputs()
        {
            txtMaLichHen.ReadOnly = false;
            txtMaLichHen.Clear();
            txtHoTen.Clear();
            txtSoDienThoai.Clear();
            txtLyDoKham.Clear();
            dtpNgayGioHen.Value = DateTime.Now.AddHours(1);
            cboBacSi.SelectedIndex = 0;
            cboTrangThai.SelectedIndex = 0;
            errorProvider1.Clear();
        }

        private void menuExportCsv_Click(object sender, EventArgs e)
        {
            using (var sfd = new SaveFileDialog { Filter = "CSV Files (*.csv)|*.csv", FileName = "DanhSachLichHen.csv" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Mã LH,Họ Tên,Số ĐT,Ngày Giờ Hẹn,Bác Sĩ,Lý Do Khám,Trạng Thái");

                    if (_bindingSource.DataSource is BindingList<Appointment> currentList)
                    {
                        foreach (var a in currentList)
                        {
                            sb.AppendLine($"\"{a.MaLichHen}\",\"{a.HoTen}\",\"{a.SoDienThoai}\",\"{a.NgayGioHen:dd/MM/yyyy HH:mm}\",\"{a.BacSi}\",\"{a.LyDoKham}\",\"{a.TrangThai}\"");
                        }
                    }

                    File.WriteAllText(sfd.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Xuất tập tin CSV thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}