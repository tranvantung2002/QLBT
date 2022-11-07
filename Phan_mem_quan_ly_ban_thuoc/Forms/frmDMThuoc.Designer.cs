
namespace Phan_mem_quan_ly_ban_thuoc.Forms
{
    partial class frmDMThuoc
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
            System.Windows.Forms.PictureBox pictureBox2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDMThuoc));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.lblThoigian = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblChuongtrinh = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblNguoidung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOATCHATCHINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HAMLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUOCSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUYCACHDONGGOI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblThuocBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUOCDataSet = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSet();
            this.tblThuocTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblThuocTableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.statusStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuocBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(-525, -311);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(348, 102);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // statusStrip3
            // 
            this.statusStrip3.AutoSize = false;
            this.statusStrip3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.statusStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblThoigian});
            this.statusStrip3.Location = new System.Drawing.Point(1516, 1120);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip3.Size = new System.Drawing.Size(342, 42);
            this.statusStrip3.TabIndex = 30;
            this.statusStrip3.Text = "statusStrip3";
            // 
            // lblThoigian
            // 
            this.lblThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoigian.ForeColor = System.Drawing.Color.White;
            this.lblThoigian.Name = "lblThoigian";
            this.lblThoigian.Size = new System.Drawing.Size(109, 35);
            this.lblThoigian.Text = "Thời gian";
            // 
            // lblChuongtrinh
            // 
            this.lblChuongtrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongtrinh.ForeColor = System.Drawing.Color.White;
            this.lblChuongtrinh.Name = "lblChuongtrinh";
            this.lblChuongtrinh.Size = new System.Drawing.Size(133, 35);
            this.lblChuongtrinh.Text = "Sẵn sàng !!";
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblChuongtrinh});
            this.statusStrip1.Location = new System.Drawing.Point(-468, 1120);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1984, 42);
            this.statusStrip1.TabIndex = 28;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblNguoidung
            // 
            this.lblNguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNguoidung.ForeColor = System.Drawing.Color.White;
            this.lblNguoidung.Name = "lblNguoidung";
            this.lblNguoidung.Size = new System.Drawing.Size(140, 35);
            this.lblNguoidung.Text = "Nhân viên : ";
            // 
            // lblQuyen
            // 
            this.lblQuyen.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblQuyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(93, 35);
            this.lblQuyen.Text = "Khương";
            // 
            // statusStrip2
            // 
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNguoidung,
            this.lblQuyen});
            this.statusStrip2.Location = new System.Drawing.Point(-468, 1076);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip2.Size = new System.Drawing.Size(393, 42);
            this.statusStrip2.TabIndex = 29;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(1195, 581);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(110, 25);
            this.lblTong.TabIndex = 72;
            this.lblTong.Text = "Tổng số : ";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(-190, 606);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(235, 31);
            this.txtMa.TabIndex = 71;
            this.txtMa.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(60, 581);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Kích đúp để sửa thông tin thuốc";
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnTK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(762, 27);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(152, 58);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "&Tìm lại";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(600, 27);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(152, 58);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "&Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            this.btnLoc.MouseLeave += new System.EventHandler(this.btnLoc_MouseLeave);
            this.btnLoc.MouseHover += new System.EventHandler(this.btnLoc_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(307, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Giá trị tìm kiếm";
            // 
            // comGT
            // 
            this.comGT.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(287, 38);
            this.comGT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(255, 32);
            this.comGT.TabIndex = 1;
            // 
            // comTruong
            // 
            this.comTruong.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "Mã thuốc",
            "Mã nhóm",
            "Hãng sản xuất",
            "Nước sản xuất"});
            this.comTruong.Location = new System.Drawing.Point(16, 38);
            this.comTruong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(250, 32);
            this.comTruong.TabIndex = 0;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(28, 6);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Tên trường";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1167, 652);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 58);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.ForeColor = System.Drawing.Color.White;
            this.btnAddnew.Location = new System.Drawing.Point(922, 27);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(166, 58);
            this.btnAddnew.TabIndex = 4;
            this.btnAddnew.Text = "&Thêm mới";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(553, 652);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(152, 58);
            this.btnLast.TabIndex = 61;
            this.btnLast.Text = "&Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(391, 652);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 58);
            this.btnNext.TabIndex = 60;
            this.btnNext.Text = "&Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnPrv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.ForeColor = System.Drawing.Color.White;
            this.btnPrv.Location = new System.Drawing.Point(227, 652);
            this.btnPrv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(152, 58);
            this.btnPrv.TabIndex = 59;
            this.btnPrv.Text = "&Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(65, 652);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(152, 58);
            this.btnFirst.TabIndex = 58;
            this.btnFirst.Text = "&Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grdData
            // 
            this.grdData.AllowUserToOrderColumns = true;
            this.grdData.AutoGenerateColumns = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            this.grdData.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeight = 30;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHUOC,
            this.MANHOM,
            this.TENTHUOC,
            this.HOATCHATCHINH,
            this.HAMLUONG,
            this.HANGSX,
            this.NUOCSX,
            this.QUYCACHDONGGOI,
            this.DVT,
            this.TENNHOM});
            this.grdData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.grdData.DataSource = this.tblThuocBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdData.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.Location = new System.Drawing.Point(13, 96);
            this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(1555, 449);
            this.grdData.TabIndex = 57;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            this.grdData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellDoubleClick);
            // 
            // MATHUOC
            // 
            this.MATHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MATHUOC.DataPropertyName = "MATHUOC";
            this.MATHUOC.HeaderText = "Mã thuốc";
            this.MATHUOC.MinimumWidth = 6;
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.Width = 137;
            // 
            // MANHOM
            // 
            this.MANHOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MANHOM.DataPropertyName = "MANHOM";
            this.MANHOM.HeaderText = "Nhóm thuốc";
            this.MANHOM.MinimumWidth = 6;
            this.MANHOM.Name = "MANHOM";
            this.MANHOM.Visible = false;
            this.MANHOM.Width = 163;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENTHUOC.DataPropertyName = "TENTHUOC";
            this.TENTHUOC.HeaderText = "Tên thuốc";
            this.TENTHUOC.MinimumWidth = 6;
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.Width = 145;
            // 
            // HOATCHATCHINH
            // 
            this.HOATCHATCHINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HOATCHATCHINH.DataPropertyName = "HOATCHATCHINH";
            this.HOATCHATCHINH.HeaderText = "Hoạt chất chính";
            this.HOATCHATCHINH.MinimumWidth = 6;
            this.HOATCHATCHINH.Name = "HOATCHATCHINH";
            this.HOATCHATCHINH.Width = 198;
            // 
            // HAMLUONG
            // 
            this.HAMLUONG.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HAMLUONG.DataPropertyName = "HAMLUONG";
            this.HAMLUONG.HeaderText = "Hàm lượng";
            this.HAMLUONG.MinimumWidth = 6;
            this.HAMLUONG.Name = "HAMLUONG";
            this.HAMLUONG.Width = 151;
            // 
            // HANGSX
            // 
            this.HANGSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HANGSX.DataPropertyName = "HANGSX";
            this.HANGSX.HeaderText = "Hãng sản xuất";
            this.HANGSX.MinimumWidth = 6;
            this.HANGSX.Name = "HANGSX";
            this.HANGSX.Width = 187;
            // 
            // NUOCSX
            // 
            this.NUOCSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NUOCSX.DataPropertyName = "NUOCSX";
            this.NUOCSX.HeaderText = "Nước sản xuất";
            this.NUOCSX.MinimumWidth = 6;
            this.NUOCSX.Name = "NUOCSX";
            this.NUOCSX.Width = 186;
            // 
            // QUYCACHDONGGOI
            // 
            this.QUYCACHDONGGOI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.QUYCACHDONGGOI.DataPropertyName = "QUYCACHDONGGOI";
            this.QUYCACHDONGGOI.HeaderText = "Quy cách đóng gói";
            this.QUYCACHDONGGOI.MinimumWidth = 6;
            this.QUYCACHDONGGOI.Name = "QUYCACHDONGGOI";
            this.QUYCACHDONGGOI.Width = 229;
            // 
            // DVT
            // 
            this.DVT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 150;
            // 
            // TENNHOM
            // 
            this.TENNHOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENNHOM.DataPropertyName = "TENNHOM";
            this.TENNHOM.HeaderText = "Tên nhóm";
            this.TENNHOM.MinimumWidth = 6;
            this.TENNHOM.Name = "TENNHOM";
            this.TENNHOM.Width = 145;
            // 
            // tblThuocBindingSource
            // 
            this.tblThuocBindingSource.DataMember = "tblThuoc";
            this.tblThuocBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // tHUOCDataSet
            // 
            this.tHUOCDataSet.DataSetName = "THUOCDataSet";
            this.tHUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblThuocTableAdapter
            // 
            this.tblThuocTableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(988, 652);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 58);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmDMThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1581, 760);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.comTruong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAddnew);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.grdData);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.statusStrip3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.statusStrip2);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmDMThuoc";
            this.Text = "frmDMThuoc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDMThuoc_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblThuocBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.ToolStripStatusLabel lblThoigian;
        private System.Windows.Forms.ToolStripStatusLabel lblChuongtrinh;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoidung;
        private System.Windows.Forms.ToolStripStatusLabel lblQuyen;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView grdData;
        private THUOCDataSet tHUOCDataSet;
        private System.Windows.Forms.BindingSource tblThuocBindingSource;
        private THUOCDataSetTableAdapters.tblThuocTableAdapter tblThuocTableAdapter;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHOM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOATCHATCHINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HAMLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUOCSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUYCACHDONGGOI;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
    }
}