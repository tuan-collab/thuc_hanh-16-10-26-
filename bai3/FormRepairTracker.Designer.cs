namespace RepairServiceTracker
{
    partial class FormRepairTracker
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
            menuSystem = new ToolStripMenuItem();
            menuExportCsv = new ToolStripMenuItem();
            menuExit = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            lblStatusText = new ToolStripStatusLabel();
            mainLayout = new TableLayoutPanel();
            pnlLeftTop = new Panel();
            pnlInput = new TableLayoutPanel();
            lblMaDon = new Label();
            txtMaDon = new TextBox();
            lblTenKhach = new Label();
            txtTenKhachHang = new TextBox();
            lblSdt = new Label();
            txtSoDienThoai = new TextBox();
            lblLoaiThietBi = new Label();
            cboLoaiThietBi = new ComboBox();
            lblNgayNhan = new Label();
            dtpNgayTiepNhan = new DateTimePicker();
            lblChiPhi = new Label();
            txtChiPhi = new TextBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            lblMoTaLoi = new Label();
            txtMoTaLoi = new TextBox();
            pnlButtons = new FlowLayoutPanel();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            pnlImage = new GroupBox();
            picDevice = new PictureBox();
            btnBrowseImg = new Button();
            pnlBottom = new Panel();
            dgvOrders = new DataGridView();
            pnlSearch = new FlowLayoutPanel();
            lblSearch = new Label();
            lblFilterStatus = new Label();
            cboFilterStatus = new ComboBox();
            errorProvider1 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            mainLayout.SuspendLayout();
            pnlLeftTop.SuspendLayout();
            pnlInput.SuspendLayout();
            pnlButtons.SuspendLayout();
            pnlImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picDevice).BeginInit();
            pnlBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuSystem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1084, 28);
            menuStrip1.TabIndex = 2;
            // 
            // menuSystem
            // 
            menuSystem.DropDownItems.AddRange(new ToolStripItem[] { menuExportCsv, menuExit });
            menuSystem.Name = "menuSystem";
            menuSystem.Size = new Size(85, 24);
            menuSystem.Text = "Hệ thống";
            // 
            // menuExportCsv
            // 
            menuExportCsv.Name = "menuExportCsv";
            menuExportCsv.Size = new Size(152, 26);
            menuExportCsv.Text = "Xuất CSV";
            menuExportCsv.Click += menuExportCsv_Click;
            // 
            // menuExit
            // 
            menuExit.Name = "menuExit";
            menuExit.Size = new Size(152, 26);
            menuExit.Text = "Thoát";
            menuExit.Click += menuExit_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { lblStatusText });
            statusStrip1.Location = new Point(0, 635);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1084, 26);
            statusStrip1.TabIndex = 1;
            // 
            // lblStatusText
            // 
            lblStatusText.Name = "lblStatusText";
            lblStatusText.Size = new Size(393, 20);
            lblStatusText.Text = "Số đơn: 0 | Tổng chi phí dự kiến đơn chưa hoàn tất: 0 VNĐ";
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 65F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            mainLayout.Controls.Add(pnlLeftTop, 0, 0);
            mainLayout.Controls.Add(pnlImage, 1, 0);
            mainLayout.Controls.Add(pnlBottom, 0, 1);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 28);
            mainLayout.Name = "mainLayout";
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1084, 607);
            mainLayout.TabIndex = 0;
            // 
            // pnlLeftTop
            // 
            pnlLeftTop.Controls.Add(pnlInput);
            pnlLeftTop.Controls.Add(pnlButtons);
            pnlLeftTop.Dock = DockStyle.Fill;
            pnlLeftTop.Location = new Point(3, 3);
            pnlLeftTop.Name = "pnlLeftTop";
            pnlLeftTop.Size = new Size(698, 254);
            pnlLeftTop.TabIndex = 0;
            // 
            // pnlInput
            // 
            pnlInput.ColumnCount = 4;
            pnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            pnlInput.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            pnlInput.Controls.Add(lblMaDon, 0, 0);
            pnlInput.Controls.Add(txtMaDon, 1, 0);
            pnlInput.Controls.Add(lblTenKhach, 2, 0);
            pnlInput.Controls.Add(txtTenKhachHang, 3, 0);
            pnlInput.Controls.Add(lblSdt, 0, 1);
            pnlInput.Controls.Add(txtSoDienThoai, 1, 1);
            pnlInput.Controls.Add(lblLoaiThietBi, 2, 1);
            pnlInput.Controls.Add(cboLoaiThietBi, 3, 1);
            pnlInput.Controls.Add(lblNgayNhan, 0, 2);
            pnlInput.Controls.Add(dtpNgayTiepNhan, 1, 2);
            pnlInput.Controls.Add(lblChiPhi, 2, 2);
            pnlInput.Controls.Add(txtChiPhi, 3, 2);
            pnlInput.Controls.Add(lblTrangThai, 0, 3);
            pnlInput.Controls.Add(cboTrangThai, 1, 3);
            pnlInput.Controls.Add(lblMoTaLoi, 0, 4);
            pnlInput.Controls.Add(txtMoTaLoi, 1, 4);
            pnlInput.Dock = DockStyle.Fill;
            pnlInput.Location = new Point(0, 0);
            pnlInput.Name = "pnlInput";
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInput.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            pnlInput.Size = new Size(698, 225);
            pnlInput.TabIndex = 0;
            // 
            // lblMaDon
            // 
            lblMaDon.Location = new Point(3, 0);
            lblMaDon.Name = "lblMaDon";
            lblMaDon.Size = new Size(100, 20);
            lblMaDon.TabIndex = 0;
            lblMaDon.Text = "Mã đơn:";
            // 
            // txtMaDon
            // 
            txtMaDon.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtMaDon.Location = new Point(142, 3);
            txtMaDon.Name = "txtMaDon";
            txtMaDon.Size = new Size(203, 27);
            txtMaDon.TabIndex = 1;
            // 
            // lblTenKhach
            // 
            lblTenKhach.Location = new Point(351, 0);
            lblTenKhach.Name = "lblTenKhach";
            lblTenKhach.Size = new Size(100, 20);
            lblTenKhach.TabIndex = 2;
            lblTenKhach.Text = "Tên khách:";
            // 
            // txtTenKhachHang
            // 
            txtTenKhachHang.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtTenKhachHang.Location = new Point(490, 3);
            txtTenKhachHang.Name = "txtTenKhachHang";
            txtTenKhachHang.Size = new Size(205, 27);
            txtTenKhachHang.TabIndex = 3;
            // 
            // lblSdt
            // 
            lblSdt.Location = new Point(3, 20);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(100, 20);
            lblSdt.TabIndex = 4;
            lblSdt.Text = "SĐT:";
            // 
            // txtSoDienThoai
            // 
            txtSoDienThoai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtSoDienThoai.Location = new Point(142, 23);
            txtSoDienThoai.Name = "txtSoDienThoai";
            txtSoDienThoai.Size = new Size(203, 27);
            txtSoDienThoai.TabIndex = 5;
            // 
            // lblLoaiThietBi
            // 
            lblLoaiThietBi.Location = new Point(351, 20);
            lblLoaiThietBi.Name = "lblLoaiThietBi";
            lblLoaiThietBi.Size = new Size(100, 20);
            lblLoaiThietBi.TabIndex = 6;
            lblLoaiThietBi.Text = "Loại thiết bị:";
            // 
            // cboLoaiThietBi
            // 
            cboLoaiThietBi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboLoaiThietBi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiThietBi.Location = new Point(490, 23);
            cboLoaiThietBi.Name = "cboLoaiThietBi";
            cboLoaiThietBi.Size = new Size(205, 28);
            cboLoaiThietBi.TabIndex = 7;
            // 
            // lblNgayNhan
            // 
            lblNgayNhan.Location = new Point(3, 40);
            lblNgayNhan.Name = "lblNgayNhan";
            lblNgayNhan.Size = new Size(100, 20);
            lblNgayNhan.TabIndex = 8;
            lblNgayNhan.Text = "Ngày nhận:";
            // 
            // dtpNgayTiepNhan
            // 
            dtpNgayTiepNhan.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            dtpNgayTiepNhan.Format = DateTimePickerFormat.Short;
            dtpNgayTiepNhan.Location = new Point(142, 43);
            dtpNgayTiepNhan.Name = "dtpNgayTiepNhan";
            dtpNgayTiepNhan.Size = new Size(203, 27);
            dtpNgayTiepNhan.TabIndex = 9;
            // 
            // lblChiPhi
            // 
            lblChiPhi.Location = new Point(351, 40);
            lblChiPhi.Name = "lblChiPhi";
            lblChiPhi.Size = new Size(100, 20);
            lblChiPhi.TabIndex = 10;
            lblChiPhi.Text = "Chi phí dự kiến:";
            // 
            // txtChiPhi
            // 
            txtChiPhi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txtChiPhi.Location = new Point(490, 43);
            txtChiPhi.Name = "txtChiPhi";
            txtChiPhi.Size = new Size(205, 27);
            txtChiPhi.TabIndex = 11;
            txtChiPhi.Text = "0";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Location = new Point(3, 60);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(100, 20);
            lblTrangThai.TabIndex = 12;
            lblTrangThai.Text = "Trạng thái:";
            // 
            // cboTrangThai
            // 
            cboTrangThai.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Location = new Point(142, 63);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(203, 28);
            cboTrangThai.TabIndex = 13;
            // 
            // lblMoTaLoi
            // 
            lblMoTaLoi.Location = new Point(3, 80);
            lblMoTaLoi.Name = "lblMoTaLoi";
            lblMoTaLoi.Size = new Size(100, 23);
            lblMoTaLoi.TabIndex = 14;
            lblMoTaLoi.Text = "Mô tả lỗi:";
            // 
            // txtMoTaLoi
            // 
            txtMoTaLoi.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pnlInput.SetColumnSpan(txtMoTaLoi, 3);
            txtMoTaLoi.Location = new Point(142, 132);
            txtMoTaLoi.Multiline = true;
            txtMoTaLoi.Name = "txtMoTaLoi";
            txtMoTaLoi.Size = new Size(553, 40);
            txtMoTaLoi.TabIndex = 15;
            // 
            // pnlButtons
            // 
            pnlButtons.AutoSize = true;
            pnlButtons.Controls.Add(btnAdd);
            pnlButtons.Controls.Add(btnUpdate);
            pnlButtons.Controls.Add(btnDelete);
            pnlButtons.Dock = DockStyle.Bottom;
            pnlButtons.Location = new Point(0, 225);
            pnlButtons.Name = "pnlButtons";
            pnlButtons.Size = new Size(698, 29);
            pnlButtons.TabIndex = 1;
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
            // pnlImage
            // 
            pnlImage.Controls.Add(picDevice);
            pnlImage.Controls.Add(btnBrowseImg);
            pnlImage.Dock = DockStyle.Fill;
            pnlImage.Location = new Point(707, 3);
            pnlImage.Name = "pnlImage";
            pnlImage.Size = new Size(374, 254);
            pnlImage.TabIndex = 1;
            pnlImage.TabStop = false;
            pnlImage.Text = "Ảnh thiết bị";
            // 
            // picDevice
            // 
            picDevice.BorderStyle = BorderStyle.FixedSingle;
            picDevice.Dock = DockStyle.Fill;
            picDevice.Location = new Point(3, 23);
            picDevice.Name = "picDevice";
            picDevice.Size = new Size(368, 205);
            picDevice.SizeMode = PictureBoxSizeMode.Zoom;
            picDevice.TabIndex = 0;
            picDevice.TabStop = false;
            // 
            // btnBrowseImg
            // 
            btnBrowseImg.Dock = DockStyle.Bottom;
            btnBrowseImg.Location = new Point(3, 228);
            btnBrowseImg.Name = "btnBrowseImg";
            btnBrowseImg.Size = new Size(368, 23);
            btnBrowseImg.TabIndex = 1;
            btnBrowseImg.Text = "Chọn ảnh...";
            btnBrowseImg.Click += btnBrowseImg_Click;
            // 
            // pnlBottom
            // 
            mainLayout.SetColumnSpan(pnlBottom, 2);
            pnlBottom.Controls.Add(dgvOrders);
            pnlBottom.Controls.Add(pnlSearch);
            pnlBottom.Dock = DockStyle.Fill;
            pnlBottom.Location = new Point(3, 263);
            pnlBottom.Name = "pnlBottom";
            pnlBottom.Size = new Size(1078, 341);
            pnlBottom.TabIndex = 2;
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.ColumnHeadersHeight = 29;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 35);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1078, 306);
            dgvOrders.TabIndex = 0;
            dgvOrders.SelectionChanged += dgvOrders_SelectionChanged;
            // 
            // pnlSearch
            // 
            pnlSearch.Dock = DockStyle.Top;
            pnlSearch.Location = new Point(0, 0);
            pnlSearch.Name = "pnlSearch";
            pnlSearch.Size = new Size(1078, 35);
            pnlSearch.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.Location = new Point(0, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(100, 23);
            lblSearch.TabIndex = 0;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.Location = new Point(0, 0);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(100, 23);
            lblFilterStatus.TabIndex = 0;
            lblFilterStatus.Text = "Lọc trạng thái:";
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.Location = new Point(0, 0);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(120, 28);
            cboFilterStatus.TabIndex = 0;
            cboFilterStatus.SelectedIndexChanged += cboFilterStatus_SelectedIndexChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormRepairTracker
            // 
            ClientSize = new Size(1084, 661);
            Controls.Add(mainLayout);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormRepairTracker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Repair Service Tracker - Quản lý đơn sửa chữa";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            mainLayout.ResumeLayout(false);
            pnlLeftTop.ResumeLayout(false);
            pnlLeftTop.PerformLayout();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            pnlButtons.ResumeLayout(false);
            pnlImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picDevice).EndInit();
            pnlBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuSystem, menuExportCsv, menuExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatusText;
        private System.Windows.Forms.TableLayoutPanel mainLayout, pnlInput;
        private System.Windows.Forms.Panel pnlLeftTop, pnlBottom;
        private System.Windows.Forms.Label lblMaDon, lblTenKhach, lblSdt, lblLoaiThietBi, lblNgayNhan, lblChiPhi, lblTrangThai, lblMoTaLoi;
        private System.Windows.Forms.TextBox txtMaDon, txtTenKhachHang, txtSoDienThoai, txtChiPhi, txtMoTaLoi;
        private System.Windows.Forms.ComboBox cboLoaiThietBi, cboTrangThai, cboFilterStatus;
        private System.Windows.Forms.DateTimePicker dtpNgayTiepNhan;
        private System.Windows.Forms.FlowLayoutPanel pnlButtons, pnlSearch;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnBrowseImg;
        private System.Windows.Forms.GroupBox pnlImage;
        private System.Windows.Forms.PictureBox picDevice;
        private System.Windows.Forms.Label lblSearch, lblFilterStatus;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}