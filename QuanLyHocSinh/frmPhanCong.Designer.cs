namespace QuanLyHocSinh
{
    partial class frmPhanCong
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhanCong));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnAdd = new DevComponents.DotNetBar.ButtonItem();
            this.btnRefesh = new DevComponents.DotNetBar.ButtonItem();
            this.btnDelete = new DevComponents.DotNetBar.ButtonItem();
            this.btnSave = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvPhanCong = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaNamHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaLop = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaMonHoc = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.colMaGiaoVien = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.bindingNavigatorPhanCong = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorExitItem = new System.Windows.Forms.ToolStripButton();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbMonHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbGiaoVien = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSTT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.navPanelTimKiem = new DevComponents.DotNetBar.NavigationPanePanel();
            this.label6 = new System.Windows.Forms.Label();
            this.chkTimTheoTenGV = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoTenLop = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.buttonItemTimKiem = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhanCong)).BeginInit();
            this.bindingNavigatorPhanCong.SuspendLayout();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.navPanelTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dgvPhanCong);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorPhanCong);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(764, 490);
            this.groupBoxDanhSach.TabIndex = 3;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách phân công giáo viên giảng dạy";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(372, 250);
            this.ctxMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(100, 29);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 4;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePaddingHorizontal = 8;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnAdd,
            this.btnRefesh,
            this.btnDelete,
            this.btnSave,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImagePaddingHorizontal = 8;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Ins);
            this.btnAdd.Text = "Thêm mới";
            this.btnAdd.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // btnRefesh
            // 
            this.btnRefesh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefesh.Image")));
            this.btnRefesh.ImagePaddingHorizontal = 8;
            this.btnRefesh.Name = "btnRefesh";
            this.btnRefesh.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.F5);
            this.btnRefesh.Text = "Làm tươi danh sách";
            this.btnRefesh.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImagePaddingHorizontal = 8;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.Del);
            this.btnDelete.Text = "Xóa dòng được chọn";
            this.btnDelete.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImagePaddingHorizontal = 8;
            this.btnSave.Name = "btnSave";
            this.btnSave.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnSave.Text = "Lưu danh sách";
            this.btnSave.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            this.btnClose.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // dgvPhanCong
            // 
            this.dgvPhanCong.AllowUserToAddRows = false;
            this.dgvPhanCong.AllowUserToResizeColumns = false;
            this.dgvPhanCong.AllowUserToResizeRows = false;
            this.dgvPhanCong.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvPhanCong.ColumnHeadersHeight = 29;
            this.dgvPhanCong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPhanCong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMaNamHoc,
            this.colMaLop,
            this.colMaMonHoc,
            this.colMaGiaoVien});
            this.ctxMenu.SetContextMenuEx(this.dgvPhanCong, this.btnMenu);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPhanCong.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPhanCong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPhanCong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvPhanCong.Location = new System.Drawing.Point(4, 62);
            this.dgvPhanCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvPhanCong.Name = "dgvPhanCong";
            this.dgvPhanCong.RowHeadersWidth = 51;
            this.dgvPhanCong.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPhanCong.Size = new System.Drawing.Size(756, 424);
            this.dgvPhanCong.TabIndex = 5;
            // 
            // colSTT
            // 
            this.colSTT.DataPropertyName = "STT";
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colSTT.Width = 60;
            // 
            // colMaNamHoc
            // 
            this.colMaNamHoc.DataPropertyName = "MaNamHoc";
            this.colMaNamHoc.HeaderText = "Năm học";
            this.colMaNamHoc.MinimumWidth = 6;
            this.colMaNamHoc.Name = "colMaNamHoc";
            this.colMaNamHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaNamHoc.Width = 125;
            // 
            // colMaLop
            // 
            this.colMaLop.DataPropertyName = "MaLop";
            this.colMaLop.HeaderText = "Mã lớp";
            this.colMaLop.MinimumWidth = 6;
            this.colMaLop.Name = "colMaLop";
            this.colMaLop.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaLop.Width = 125;
            // 
            // colMaMonHoc
            // 
            this.colMaMonHoc.DataPropertyName = "MaMonHoc";
            this.colMaMonHoc.HeaderText = "Môn học";
            this.colMaMonHoc.MinimumWidth = 6;
            this.colMaMonHoc.Name = "colMaMonHoc";
            this.colMaMonHoc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaMonHoc.Width = 125;
            // 
            // colMaGiaoVien
            // 
            this.colMaGiaoVien.DataPropertyName = "MaGiaoVien";
            this.colMaGiaoVien.HeaderText = "Giáo viên";
            this.colMaGiaoVien.MinimumWidth = 6;
            this.colMaGiaoVien.Name = "colMaGiaoVien";
            this.colMaGiaoVien.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaGiaoVien.Width = 160;
            // 
            // bindingNavigatorPhanCong
            // 
            this.bindingNavigatorPhanCong.AddNewItem = null;
            this.bindingNavigatorPhanCong.AutoSize = false;
            this.bindingNavigatorPhanCong.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorPhanCong.CountItemFormat = "của {0}";
            this.bindingNavigatorPhanCong.DeleteItem = null;
            this.bindingNavigatorPhanCong.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorPhanCong.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorSaveItem,
            this.bindingNavigatorExitItem});
            this.bindingNavigatorPhanCong.Location = new System.Drawing.Point(4, 19);
            this.bindingNavigatorPhanCong.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorPhanCong.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorPhanCong.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorPhanCong.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorPhanCong.Name = "bindingNavigatorPhanCong";
            this.bindingNavigatorPhanCong.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorPhanCong.Size = new System.Drawing.Size(756, 43);
            this.bindingNavigatorPhanCong.TabIndex = 4;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 40);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 43);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorAddNewItem.Text = "Thêm";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorRefreshItem.Text = "Làm tươi danh sách";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorDeleteItem.Text = "Xóa";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // bindingNavigatorExitItem
            // 
            this.bindingNavigatorExitItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorExitItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorExitItem.Image")));
            this.bindingNavigatorExitItem.Name = "bindingNavigatorExitItem";
            this.bindingNavigatorExitItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorExitItem.Size = new System.Drawing.Size(29, 40);
            this.bindingNavigatorExitItem.Text = "Thoát";
            this.bindingNavigatorExitItem.Click += new System.EventHandler(this.bindingNavigatorExitItem_Click);
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.Controls.Add(this.navPanelTimKiem);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemNhapDuLieu,
            this.buttonItemTimKiem});
            this.navPaneLeft.Location = new System.Drawing.Point(764, 0);
            this.navPaneLeft.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 61;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(356, 490);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 0;
            this.navPaneLeft.TitleButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(354, 30);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "    Nhập liệu thông tin";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.navPanelNhapDuLieu.Controls.Add(this.label1);
            this.navPanelNhapDuLieu.Controls.Add(this.label3);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbLop);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbMonHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbGiaoVien);
            this.navPanelNhapDuLieu.Controls.Add(this.label2);
            this.navPanelNhapDuLieu.Controls.Add(this.txtSTT);
            this.navPanelNhapDuLieu.Controls.Add(this.label5);
            this.navPanelNhapDuLieu.Controls.Add(this.label4);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 31);
            this.navPanelNhapDuLieu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItemNhapDuLieu;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(354, 397);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(15, 289);
            this.btnLuuVaoDS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(309, 28);
            this.btnLuuVaoDS.TabIndex = 11;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số thứ tự:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Lớp:";
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(15, 86);
            this.cmbNamHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(309, 20);
            this.cmbNamHoc.TabIndex = 3;
            this.cmbNamHoc.SelectedIndexChanged += new System.EventHandler(this.cmbNamHoc_SelectedIndexChanged);
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 14;
            this.cmbLop.Location = new System.Drawing.Point(15, 142);
            this.cmbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(309, 20);
            this.cmbLop.TabIndex = 5;
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DisplayMember = "Text";
            this.cmbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.ItemHeight = 14;
            this.cmbMonHoc.Location = new System.Drawing.Point(15, 197);
            this.cmbMonHoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(309, 20);
            this.cmbMonHoc.TabIndex = 7;
            // 
            // cmbGiaoVien
            // 
            this.cmbGiaoVien.DisplayMember = "Text";
            this.cmbGiaoVien.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGiaoVien.FormattingEnabled = true;
            this.cmbGiaoVien.ItemHeight = 14;
            this.cmbGiaoVien.Location = new System.Drawing.Point(15, 252);
            this.cmbGiaoVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbGiaoVien.Name = "cmbGiaoVien";
            this.cmbGiaoVien.Size = new System.Drawing.Size(309, 20);
            this.cmbGiaoVien.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Năm học:";
            // 
            // txtSTT
            // 
            // 
            // 
            // 
            this.txtSTT.Border.Class = "TextBoxBorder";
            this.txtSTT.Location = new System.Drawing.Point(15, 31);
            this.txtSTT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(309, 22);
            this.txtSTT.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 234);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giáo viên dạy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 178);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Môn học:";
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.Image = global::QuanLyHocSinh.Properties.Resources.thong_tin;
            this.buttonItemNhapDuLieu.ImagePaddingHorizontal = 8;
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "    Nhập liệu thông tin";
            // 
            // navPanelTimKiem
            // 
            this.navPanelTimKiem.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelTimKiem.Controls.Add(this.label6);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTenGV);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTenLop);
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.txtTimKiem);
            this.navPanelTimKiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelTimKiem.Location = new System.Drawing.Point(1, 1);
            this.navPanelTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.ParentItem = this.buttonItemTimKiem;
            this.navPanelTimKiem.Size = new System.Drawing.Size(354, 427);
            this.navPanelTimKiem.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelTimKiem.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelTimKiem.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelTimKiem.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelTimKiem.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelTimKiem.Style.GradientAngle = 90;
            this.navPanelTimKiem.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 12);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập thông tin tìm kiếm:";
            // 
            // chkTimTheoTenGV
            // 
            this.chkTimTheoTenGV.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTenGV.Location = new System.Drawing.Point(11, 92);
            this.chkTimTheoTenGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTimTheoTenGV.Name = "chkTimTheoTenGV";
            this.chkTimTheoTenGV.Size = new System.Drawing.Size(217, 28);
            this.chkTimTheoTenGV.TabIndex = 5;
            this.chkTimTheoTenGV.Text = "Tìm theo tên giáo viên";
            // 
            // chkTimTheoTenLop
            // 
            this.chkTimTheoTenLop.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTenLop.Checked = true;
            this.chkTimTheoTenLop.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimTheoTenLop.CheckValue = "Y";
            this.chkTimTheoTenLop.Location = new System.Drawing.Point(11, 62);
            this.chkTimTheoTenLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkTimTheoTenLop.Name = "chkTimTheoTenLop";
            this.chkTimTheoTenLop.Size = new System.Drawing.Size(217, 28);
            this.chkTimTheoTenLop.TabIndex = 4;
            this.chkTimTheoTenLop.Text = "Tìm theo tên lớp";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnTimKiem.Location = new System.Drawing.Point(15, 129);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(213, 28);
            this.btnTimKiem.TabIndex = 6;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(15, 31);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(213, 22);
            this.txtTimKiem.TabIndex = 3;
            // 
            // buttonItemTimKiem
            // 
            this.buttonItemTimKiem.Image = global::QuanLyHocSinh.Properties.Resources.thong_tin;
            this.buttonItemTimKiem.ImageFixedSize = new System.Drawing.Size(16, 16);
            this.buttonItemTimKiem.ImagePaddingHorizontal = 8;
            this.buttonItemTimKiem.Name = "buttonItemTimKiem";
            this.buttonItemTimKiem.OptionGroup = "navBar";
            this.buttonItemTimKiem.Text = "    Tìm kiếm thông tin";
            // 
            // frmPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 490);
            this.ctxMenu.SetContextMenuEx(this, this.btnMenu);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Controls.Add(this.navPaneLeft);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPhanCong";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PHÂN CÔNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhanCong_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanCong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorPhanCong)).EndInit();
            this.bindingNavigatorPhanCong.ResumeLayout(false);
            this.bindingNavigatorPhanCong.PerformLayout();
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        #region Components
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnAdd;
        private DevComponents.DotNetBar.ButtonItem btnDelete;
        private DevComponents.DotNetBar.ButtonItem btnSave;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.ButtonItem btnRefesh;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvPhanCong;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbGiaoVien;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSTT;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTenGV;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTenLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonHoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelTimKiem;
        private DevComponents.DotNetBar.ButtonItem buttonItemTimKiem;
        private System.Windows.Forms.BindingNavigator bindingNavigatorPhanCong;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorExitItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaNamHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaLop;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaMonHoc;
        private System.Windows.Forms.DataGridViewComboBoxColumn colMaGiaoVien;
    }
}