namespace LabEquipmentCheckout
{
    partial class FormLabCheckout
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
            statusStrip1 = new StatusStrip();
            lblStatusInfo = new ToolStripStatusLabel();
            panelTop = new FlowLayoutPanel();
            btnExportCsv = new Button();
            grpInput = new GroupBox();
            panelInput = new TableLayoutPanel();
            lblMaPhieu = new Label();
            txtMaPhieu = new TextBox();
            lblMaSV = new Label();
            txtMaSV = new TextBox();
            lblHoTenSV = new Label();
            txtHoTenSV = new TextBox();
            lblThietBi = new Label();
            cboThietBi = new ComboBox();
            lblSoLuong = new Label();
            nudSoLuong = new NumericUpDown();
            lblNgayMuon = new Label();
            dtpNgayMuon = new DateTimePicker();
            lblHanTra = new Label();
            dtpHanTra = new DateTimePicker();
            chkDaTra = new CheckBox();
            dtpNgayTraThucTe = new DateTimePicker();
            panelBtns = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnMarkReturn = new Button();
            grpFilter = new GroupBox();
            flowFilter = new FlowLayoutPanel();
            lblSearch = new Label();
            txtSearch = new TextBox();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            dgvTickets = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            statusStrip1.SuspendLayout();
            panelTop.SuspendLayout();
            grpInput.SuspendLayout();
            panelInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).BeginInit();
            panelBtns.SuspendLayout();
            grpFilter.SuspendLayout();
            flowFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusInfo });
            statusStrip1.Location = new Point(0, 625);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1034, 26);
            statusStrip1.TabIndex = 4;
            // 
            // lblStatusInfo
            // 
            lblStatusInfo.Name = "lblStatusInfo";
            lblStatusInfo.Size = new Size(159, 20);
            lblStatusInfo.Text = "Tổng số: 0 | Quá hạn: 0";
            // 
            // panelTop
            // 
            panelTop.Controls.Add(btnExportCsv);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1034, 35);
            panelTop.TabIndex = 3;
            // 
            // btnExportCsv
            // 
            btnExportCsv.AutoSize = true;
            btnExportCsv.Location = new Point(3, 3);
            btnExportCsv.Name = "btnExportCsv";
            btnExportCsv.Size = new Size(166, 30);
            btnExportCsv.TabIndex = 0;
            btnExportCsv.Text = "Xuất danh sách ra CSV";
            btnExportCsv.Click += btnExportCsv_Click;
            // 
            // grpInput
            // 
            grpInput.Controls.Add(panelInput);
            grpInput.Dock = DockStyle.Top;
            grpInput.Location = new Point(0, 35);
            grpInput.Name = "grpInput";
            grpInput.Size = new Size(1034, 160);
            grpInput.TabIndex = 2;
            grpInput.TabStop = false;
            grpInput.Text = "Thông tin phiếu mượn";
            // 
            // panelInput
            // 
            panelInput.ColumnCount = 6;
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21F));
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12F));
            panelInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            panelInput.Controls.Add(lblMaPhieu, 0, 0);
            panelInput.Controls.Add(txtMaPhieu, 1, 0);
            panelInput.Controls.Add(lblMaSV, 2, 0);
            panelInput.Controls.Add(txtMaSV, 3, 0);
            panelInput.Controls.Add(lblHoTenSV, 4, 0);
            panelInput.Controls.Add(txtHoTenSV, 5, 0);
            panelInput.Controls.Add(lblThietBi, 0, 1);
            panelInput.Controls.Add(cboThietBi, 1, 1);
            panelInput.Controls.Add(lblSoLuong, 2, 1);
            panelInput.Controls.Add(nudSoLuong, 3, 1);
            panelInput.Controls.Add(lblNgayMuon, 4, 1);
            panelInput.Controls.Add(dtpNgayMuon, 5, 1);
            panelInput.Controls.Add(lblHanTra, 0, 2);
            panelInput.Controls.Add(dtpHanTra, 1, 2);
            panelInput.Controls.Add(chkDaTra, 2, 2);
            panelInput.Controls.Add(dtpNgayTraThucTe, 3, 2);
            panelInput.Controls.Add(panelBtns, 4, 2);
            panelInput.Dock = DockStyle.Fill;
            panelInput.Location = new Point(3, 23);
            panelInput.Name = "panelInput";
            panelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            panelInput.Size = new Size(1028, 134);
            panelInput.TabIndex = 0;
            // 
            // lblMaPhieu
            // 
            lblMaPhieu.Location = new Point(3, 0);
            lblMaPhieu.Name = "lblMaPhieu";
            lblMaPhieu.Size = new Size(100, 20);
            lblMaPhieu.TabIndex = 0;
            lblMaPhieu.Text = "Mã phiếu:";
            // 
            // txtMaPhieu
            // 
            txtMaPhieu.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaPhieu.Location = new Point(126, 3);
            txtMaPhieu.Name = "txtMaPhieu";
            txtMaPhieu.Size = new Size(209, 27);
            txtMaPhieu.TabIndex = 1;
            // 
            // lblMaSV
            // 
            lblMaSV.Location = new Point(341, 0);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(100, 20);
            lblMaSV.TabIndex = 2;
            lblMaSV.Text = "Mã SV:";
            // 
            // txtMaSV
            // 
            txtMaSV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaSV.Location = new Point(464, 3);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(209, 27);
            txtMaSV.TabIndex = 3;
            // 
            // lblHoTenSV
            // 
            lblHoTenSV.Location = new Point(679, 0);
            lblHoTenSV.Name = "lblHoTenSV";
            lblHoTenSV.Size = new Size(100, 20);
            lblHoTenSV.TabIndex = 4;
            lblHoTenSV.Text = "Họ tên SV:";
            // 
            // txtHoTenSV
            // 
            txtHoTenSV.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtHoTenSV.Location = new Point(802, 3);
            txtHoTenSV.Name = "txtHoTenSV";
            txtHoTenSV.Size = new Size(223, 27);
            txtHoTenSV.TabIndex = 5;
            // 
            // lblThietBi
            // 
            lblThietBi.Location = new Point(3, 20);
            lblThietBi.Name = "lblThietBi";
            lblThietBi.Size = new Size(100, 20);
            lblThietBi.TabIndex = 6;
            lblThietBi.Text = "Thiết bị:";
            // 
            // cboThietBi
            // 
            cboThietBi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboThietBi.Location = new Point(126, 23);
            cboThietBi.Name = "cboThietBi";
            cboThietBi.Size = new Size(209, 28);
            cboThietBi.TabIndex = 7;
            // 
            // lblSoLuong
            // 
            lblSoLuong.Location = new Point(341, 20);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(100, 20);
            lblSoLuong.TabIndex = 8;
            lblSoLuong.Text = "Số lượng:";
            // 
            // nudSoLuong
            // 
            nudSoLuong.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudSoLuong.Location = new Point(464, 23);
            nudSoLuong.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSoLuong.Name = "nudSoLuong";
            nudSoLuong.Size = new Size(209, 27);
            nudSoLuong.TabIndex = 9;
            nudSoLuong.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblNgayMuon
            // 
            lblNgayMuon.Location = new Point(679, 20);
            lblNgayMuon.Name = "lblNgayMuon";
            lblNgayMuon.Size = new Size(100, 20);
            lblNgayMuon.TabIndex = 10;
            lblNgayMuon.Text = "Ngày mượn:";
            // 
            // dtpNgayMuon
            // 
            dtpNgayMuon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayMuon.Format = DateTimePickerFormat.Short;
            dtpNgayMuon.Location = new Point(802, 23);
            dtpNgayMuon.Name = "dtpNgayMuon";
            dtpNgayMuon.Size = new Size(223, 27);
            dtpNgayMuon.TabIndex = 11;
            // 
            // lblHanTra
            // 
            lblHanTra.Location = new Point(3, 40);
            lblHanTra.Name = "lblHanTra";
            lblHanTra.Size = new Size(100, 23);
            lblHanTra.TabIndex = 12;
            lblHanTra.Text = "Hạn trả:";
            // 
            // dtpHanTra
            // 
            dtpHanTra.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpHanTra.Format = DateTimePickerFormat.Short;
            dtpHanTra.Location = new Point(126, 73);
            dtpHanTra.Name = "dtpHanTra";
            dtpHanTra.Size = new Size(209, 27);
            dtpHanTra.TabIndex = 13;
            // 
            // chkDaTra
            // 
            chkDaTra.AutoSize = true;
            chkDaTra.Location = new Point(341, 43);
            chkDaTra.Name = "chkDaTra";
            chkDaTra.Size = new Size(109, 24);
            chkDaTra.TabIndex = 14;
            chkDaTra.Text = "Đã hoàn trả";
            chkDaTra.CheckedChanged += chkDaTra_CheckedChanged;
            // 
            // dtpNgayTraThucTe
            // 
            dtpNgayTraThucTe.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayTraThucTe.Enabled = false;
            dtpNgayTraThucTe.Format = DateTimePickerFormat.Short;
            dtpNgayTraThucTe.Location = new Point(464, 73);
            dtpNgayTraThucTe.Name = "dtpNgayTraThucTe";
            dtpNgayTraThucTe.Size = new Size(209, 27);
            dtpNgayTraThucTe.TabIndex = 15;
            // 
            // panelBtns
            // 
            panelInput.SetColumnSpan(panelBtns, 2);
            panelBtns.Controls.Add(btnAdd);
            panelBtns.Controls.Add(btnUpdate);
            panelBtns.Controls.Add(btnDelete);
            panelBtns.Controls.Add(btnMarkReturn);
            panelBtns.Location = new Point(679, 43);
            panelBtns.Name = "panelBtns";
            panelBtns.Size = new Size(200, 88);
            panelBtns.TabIndex = 16;
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
            btnDelete.Location = new Point(3, 32);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Xóa";
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkReturn
            // 
            btnMarkReturn.Location = new Point(84, 32);
            btnMarkReturn.Name = "btnMarkReturn";
            btnMarkReturn.Size = new Size(110, 23);
            btnMarkReturn.TabIndex = 3;
            btnMarkReturn.Text = "Đánh dấu đã trả";
            btnMarkReturn.Click += btnMarkReturn_Click;
            // 
            // grpFilter
            // 
            grpFilter.Controls.Add(flowFilter);
            grpFilter.Dock = DockStyle.Top;
            grpFilter.Location = new Point(0, 195);
            grpFilter.Name = "grpFilter";
            grpFilter.Size = new Size(1034, 55);
            grpFilter.TabIndex = 1;
            grpFilter.TabStop = false;
            grpFilter.Text = "Tìm kiếm & Lọc";
            // 
            // flowFilter
            // 
            flowFilter.Controls.Add(lblSearch);
            flowFilter.Controls.Add(txtSearch);
            flowFilter.Controls.Add(lblFilterStatus);
            flowFilter.Controls.Add(cboFilterStatus);
            flowFilter.Dock = DockStyle.Fill;
            flowFilter.Location = new Point(3, 23);
            flowFilter.Name = "flowFilter";
            flowFilter.Size = new Size(1028, 29);
            flowFilter.TabIndex = 0;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(3, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(149, 20);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Tìm (Mã SV/Thiết bị):";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(158, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 27);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(314, 0);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(78, 20);
            lblFilterStatus.TabIndex = 2;
            lblFilterStatus.Text = "Trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Location = new Point(398, 3);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(130, 28);
            cboFilterStatus.TabIndex = 3;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // dgvTickets
            // 
            dgvTickets.AllowUserToAddRows = false;
            dgvTickets.ColumnHeadersHeight = 29;
            dgvTickets.Dock = DockStyle.Fill;
            dgvTickets.Location = new Point(0, 250);
            dgvTickets.MultiSelect = false;
            dgvTickets.Name = "dgvTickets";
            dgvTickets.ReadOnly = true;
            dgvTickets.RowHeadersWidth = 51;
            dgvTickets.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTickets.Size = new Size(1034, 375);
            dgvTickets.TabIndex = 0;
            dgvTickets.SelectionChanged += dgvTickets_SelectionChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormLabCheckout
            // 
            ClientSize = new Size(1034, 651);
            Controls.Add(dgvTickets);
            Controls.Add(grpFilter);
            Controls.Add(grpInput);
            Controls.Add(panelTop);
            Controls.Add(statusStrip1);
            Name = "FormLabCheckout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab Equipment Checkout - Quản lý mượn trả thiết bị";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            grpInput.ResumeLayout(false);
            panelInput.ResumeLayout(false);
            panelInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudSoLuong).EndInit();
            panelBtns.ResumeLayout(false);
            grpFilter.ResumeLayout(false);
            flowFilter.ResumeLayout(false);
            flowFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTickets).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusInfo;
        private System.Windows.Forms.FlowLayoutPanel panelTop;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.GroupBox grpInput;
        private System.Windows.Forms.TableLayoutPanel panelInput;
        private System.Windows.Forms.Label lblMaPhieu, lblMaSV, lblHoTenSV, lblThietBi, lblSoLuong, lblNgayMuon, lblHanTra;
        private System.Windows.Forms.TextBox txtMaPhieu, txtMaSV, txtHoTenSV;
        private System.Windows.Forms.ComboBox cboThietBi;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.DateTimePicker dtpNgayMuon, dtpHanTra, dtpNgayTraThucTe;
        private System.Windows.Forms.CheckBox chkDaTra;
        private System.Windows.Forms.FlowLayoutPanel panelBtns;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnMarkReturn;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.FlowLayoutPanel flowFilter;
        private System.Windows.Forms.Label lblSearch, lblFilterStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox cboFilterStatus;
        private System.Windows.Forms.DataGridView dgvTickets;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}