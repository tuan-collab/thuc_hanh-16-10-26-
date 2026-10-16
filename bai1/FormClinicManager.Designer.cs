namespace ClinicAppointmentManager
{
    partial class FormClinicManager
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            menuFile = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusCount = new ToolStripStatusLabel();
            tableLayoutPanelInput = new TableLayoutPanel();
            lblMaLichHen = new Label();
            txtMaLichHen = new TextBox();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSoDienThoai = new Label();
            txtSoDienThoai = new TextBox();
            lblNgayGioHen = new Label();
            dtpNgayGioHen = new DateTimePicker();
            lblBacSi = new Label();
            cboBacSi = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblLyDoKham = new Label();
            txtLyDoKham = new TextBox();
            flowBtnPanel = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            grpFilter = new GroupBox();
            flowFilterPanel = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            chkEnableDateFilter = new CheckBox();
            dtpFilterDate = new DateTimePicker();
            dgvAppointments = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tableLayoutPanelInput.SuspendLayout();
            flowBtnPanel.SuspendLayout();
            grpFilter.SuspendLayout();
            flowFilterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuFile });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(984, 28);
            menuStrip1.TabIndex = 0;
            // 
            // menuFile
            // 
            menuFile.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv });
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(69, 24);
            menuFile.Text = "Tệp tin";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.Size = new Size(239, 26);
            menuExportCsv.Text = "Xuất danh sách ra CSV";
            menuExportCsv.Click += menuExportCsv_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusCount });
            statusStrip1.Location = new Point(0, 585);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(984, 26);
            statusStrip1.TabIndex = 1;
            // 
            // lblStatusCount
            // 
            lblStatusCount.Name = "lblStatusCount";
            lblStatusCount.Size = new Size(149, 20);
            lblStatusCount.Text = "Số lịch hẹn hiển thị: 0";
            // 
            // tableLayoutPanelInput
            // 
            tableLayoutPanelInput.AutoSize = true;
            tableLayoutPanelInput.ColumnCount = 4;
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tableLayoutPanelInput.Controls.Add(lblMaLichHen, 0, 0);
            tableLayoutPanelInput.Controls.Add(txtMaLichHen, 1, 0);
            tableLayoutPanelInput.Controls.Add(lblHoTen, 2, 0);
            tableLayoutPanelInput.Controls.Add(txtHoTen, 3, 0);
            tableLayoutPanelInput.Controls.Add(lblSoDienThoai, 0, 1);
            tableLayoutPanelInput.Controls.Add(txtSoDienThoai, 1, 1);
            tableLayoutPanelInput.Controls.Add(lblNgayGioHen, 2, 1);
            tableLayoutPanelInput.Controls.Add(dtpNgayGioHen, 3, 1);
            tableLayoutPanelInput.Controls.Add(lblBacSi, 0, 2);
            tableLayoutPanelInput.Controls.Add(cboBacSi, 1, 2);
            tableLayoutPanelInput.Controls.Add(lblTrangThai, 2, 2);
            tableLayoutPanelInput.Controls.Add(cboTrangThai, 3, 2);
            tableLayoutPanelInput.Controls.Add(lblLyDoKham, 0, 3);
            tableLayoutPanelInput.Controls.Add(txtLyDoKham, 1, 3);
            tableLayoutPanelInput.Controls.Add(flowBtnPanel, 3, 4);
            tableLayoutPanelInput.Dock = DockStyle.Top;
            tableLayoutPanelInput.Location = new Point(0, 28);
            tableLayoutPanelInput.Name = "tableLayoutPanelInput";
            tableLayoutPanelInput.Padding = new Padding(10);
            tableLayoutPanelInput.RowCount = 5;
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutPanelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanelInput.Size = new Size(984, 195);
            tableLayoutPanelInput.TabIndex = 2;
            // 
            // lblMaLichHen
            // 
            lblMaLichHen.Anchor = AnchorStyles.Left;
            lblMaLichHen.Location = new Point(13, 13);
            lblMaLichHen.Name = "lblMaLichHen";
            lblMaLichHen.Size = new Size(100, 23);
            lblMaLichHen.TabIndex = 0;
            lblMaLichHen.Text = "Mã lịch hẹn:";
            // 
            // txtMaLichHen
            // 
            txtMaLichHen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaLichHen.Location = new Point(157, 13);
            txtMaLichHen.Name = "txtMaLichHen";
            txtMaLichHen.Size = new Size(331, 27);
            txtMaLichHen.TabIndex = 1;
            // 
            // lblHoTen
            // 
            lblHoTen.Anchor = AnchorStyles.Left;
            lblHoTen.Location = new Point(494, 13);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(100, 23);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên bệnh nhân:";
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(638, 13);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(333, 27);
            txtHoTen.TabIndex = 3;
            // 
            // lblSoDienThoai
            // 
            lblSoDienThoai.Anchor = AnchorStyles.Left;
            lblSoDienThoai.Location = new Point(13, 43);
            lblSoDienThoai.Name = "lblSoDienThoai";
            lblSoDienThoai.Size = new Size(100, 23);
            lblSoDienThoai.TabIndex = 4;
            lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoDienThoai.Location = new Point(157, 43);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(331, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblNgayGioHen
            // 
            lblNgayGioHen.Anchor = AnchorStyles.Left;
            lblNgayGioHen.Location = new Point(494, 43);
            lblNgayGioHen.Name = "lblNgayGioHen";
            lblNgayGioHen.Size = new Size(100, 23);
            lblNgayGioHen.TabIndex = 6;
            lblNgayGioHen.Text = "Ngày giờ hẹn:";
            // 
            // dtpNgayGioHen
            // 
            dtpNgayGioHen.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayGioHen.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpNgayGioHen.Format = DateTimePickerFormat.Custom;
            dtpNgayGioHen.Location = new Point(638, 43);
            dtpNgayGioHen.Name = "dtpNgayGioHen";
            dtpNgayGioHen.Size = new Size(333, 27);
            dtpNgayGioHen.TabIndex = 7;
            // 
            // lblBacSi
            // 
            lblBacSi.Anchor = AnchorStyles.Left;
            lblBacSi.Location = new Point(13, 73);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(100, 23);
            lblBacSi.TabIndex = 8;
            lblBacSi.Text = "Bác sĩ:";
            // 
            // cboBacSi
            // 
            cboBacSi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Location = new Point(157, 73);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(331, 28);
            cboBacSi.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Anchor = AnchorStyles.Left;
            lblTrangThai.Location = new Point(494, 73);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 23);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(638, 73);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(333, 28);
            cboTrangThai.TabIndex = 11;
            // 
            // lblLyDoKham
            // 
            lblLyDoKham.Anchor = AnchorStyles.Left;
            lblLyDoKham.Location = new Point(13, 111);
            lblLyDoKham.Name = "lblLyDoKham";
            lblLyDoKham.Size = new Size(100, 23);
            lblLyDoKham.TabIndex = 12;
            lblLyDoKham.Text = "Lý do khám:";
            // 
            // txtLyDoKham
            // 
            txtLyDoKham.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelInput.SetColumnSpan(txtLyDoKham, 3);
            txtLyDoKham.Location = new Point(157, 103);
            txtLyDoKham.Multiline = true;
            txtLyDoKham.Name = "txtLyDoKham";
            txtLyDoKham.Size = new Size(814, 39);
            txtLyDoKham.TabIndex = 13;
            // 
            // flowBtnPanel
            // 
            flowBtnPanel.Anchor = AnchorStyles.Right;
            flowBtnPanel.AutoSize = true;
            flowBtnPanel.Controls.Add(btnAdd);
            flowBtnPanel.Controls.Add(btnUpdate);
            flowBtnPanel.Controls.Add(btnDelete);
            flowBtnPanel.Controls.Add(btnClear);
            flowBtnPanel.Location = new Point(647, 150);
            flowBtnPanel.Name = "flowBtnPanel";
            flowBtnPanel.Size = new Size(324, 29);
            flowBtnPanel.TabIndex = 14;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(3, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Thêm";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(84, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(165, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(246, 3);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 3;
            btnClear.Text = "Làm mới";
            btnClear.Click += btnClear_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(flowFilterPanel);
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Location = new Point(0, 223);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(984, 60);
            grpFilter.TabIndex = 1;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc";
            // 
            // flowFilterPanel
            // 
            flowFilterPanel.Controls.Add(lblSearch);
            flowFilterPanel.Controls.Add(txtSearch);
            flowFilterPanel.Controls.Add(lblFilterStatus);
            flowFilterPanel.Controls.Add(cboFilterStatus);
            flowFilterPanel.Controls.Add(chkEnableDateFilter);
            flowFilterPanel.Controls.Add(dtpFilterDate);
            flowFilterPanel.Dock = DockStyle.Fill;
            flowFilterPanel.Location = new Point(3, 23);
            flowFilterPanel.Name = "flowFilterPanel";
            flowFilterPanel.Size = new Size(978, 34);
            flowFilterPanel.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(5, 5);
            lblSearch.Margin = new Padding(5, 5, 0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(107, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm (Tên/SĐT):";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(115, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(283, 5);
            lblFilterStatus.Margin = new Padding(15, 5, 0, 0);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(78, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Location = new Point(364, 3);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(120, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // chkEnableDateFilter
            // 
            chkEnableDateFilter.AutoSize = true;
            chkEnableDateFilter.Location = new Point(502, 5);
            chkEnableDateFilter.Margin = new Padding(15, 5, 0, 0);
            chkEnableDateFilter.Name = "chkEnableDateFilter";
            chkEnableDateFilter.Size = new Size(127, 24);
            chkEnableDateFilter.TabIndex = 4;
            chkEnableDateFilter.Text = "Lọc theo ngày:";
            chkEnableDateFilter.CheckedChanged += chkEnableDateFilter_CheckedChanged;
            // 
            // dtpFilterDate
            // 
            dtpFilterDate.Format = DateTimePickerFormat.Short;
            dtpFilterDate.Location = new Point(632, 3);
            dtpFilterDate.Name = "dtpFilterDate";
            dtpFilterDate.Size = new Size(110, 27);
            dtpFilterDate.TabIndex = 5;
            dtpFilterDate.ValueChanged += dtpFilterDate_ValueChanged;
            // 
            // dgvAppointments
            // 
            dgvAppointments.AllowUserToAddRows = false;
            dgvAppointments.ColumnHeadersHeight = 29;
            dgvAppointments.Dock = DockStyle.Fill;
            dgvAppointments.Location = new Point(0, 283);
            dgvAppointments.MultiSelect = false;
            dgvAppointments.Name = "dgvAppointments";
            dgvAppointments.ReadOnly = true;
            dgvAppointments.RowHeadersWidth = 51;
            dgvAppointments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAppointments.Size = new Size(984, 302);
            dgvAppointments.TabIndex = 0;
            dgvAppointments.SelectionChanged += dgvAppointments_SelectionChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormClinicManager
            // 
            ClientSize = new Size(984, 611);
            Controls.Add(dgvAppointments);
            Controls.Add(grpFilter);
            Controls.Add(tableLayoutPanelInput);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormClinicManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Clinic Appointment Manager - Quản lý lịch hẹn phòng khám";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tableLayoutPanelInput.ResumeLayout(false);
            tableLayoutPanelInput.PerformLayout();
            flowBtnPanel.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            flowFilterPanel.ResumeLayout(false);
            flowFilterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAppointments).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExportCsv;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusCount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelInput;
        private System.Windows.Forms.Label lblMaLichHen;
        private System.Windows.Forms.TextBox txtMaLichHen;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox txtSoDienThoai;
        private System.Windows.Forms.Label lblNgayGioHen;
        private System.Windows.Forms.DateTimePicker dtpNgayGioHen;
        private System.Windows.Forms.Label lblBacSi;
        private System.Windows.Forms.ComboBox cboBacSi;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.ComboBox cboTrangThai;
        private System.Windows.Forms.Label lblLyDoKham;
        private System.Windows.Forms.TextBox txtLyDoKham;
        private System.Windows.Forms.FlowLayoutPanel flowBtnPanel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.FlowLayoutPanel flowFilterPanel;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblFilterStatus;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.CheckBox chkEnableDateFilter;
        private System.Windows.Forms.DateTimePicker dtpFilterDate;
        private System.Windows.Forms.DataGridView dgvAppointments;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}