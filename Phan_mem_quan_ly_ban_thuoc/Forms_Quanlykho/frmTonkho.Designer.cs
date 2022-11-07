
namespace Phan_mem_quan_ly_ban_thuoc.Forms_Quanlykho
{
    partial class frmTonkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTonkho));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblChuongtrinh = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.lblNguoidung = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQuyen = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblThoigian = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip3 = new System.Windows.Forms.StatusStrip();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTong = new System.Windows.Forms.Label();
            this.btnTK = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MATHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENTHUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLUONG2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLUONG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONKHO1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMa = new System.Windows.Forms.TextBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.statusStrip3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(-827, -321);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(348, 102);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.statusStrip1.Location = new System.Drawing.Point(-615, 1100);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1984, 42);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.UseWaitCursor = true;
            // 
            // lblChuongtrinh
            // 
            this.lblChuongtrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongtrinh.ForeColor = System.Drawing.Color.White;
            this.lblChuongtrinh.Name = "lblChuongtrinh";
            this.lblChuongtrinh.Size = new System.Drawing.Size(133, 35);
            this.lblChuongtrinh.Text = "Sẵn sàng !!";
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
            this.statusStrip2.Location = new System.Drawing.Point(-615, 1057);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip2.Size = new System.Drawing.Size(393, 42);
            this.statusStrip2.TabIndex = 34;
            this.statusStrip2.Text = "statusStrip2";
            this.statusStrip2.UseWaitCursor = true;
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
            // lblThoigian
            // 
            this.lblThoigian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThoigian.ForeColor = System.Drawing.Color.White;
            this.lblThoigian.Name = "lblThoigian";
            this.lblThoigian.Size = new System.Drawing.Size(109, 35);
            this.lblThoigian.Text = "Thời gian";
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
            this.statusStrip3.Location = new System.Drawing.Point(1369, 1100);
            this.statusStrip3.Name = "statusStrip3";
            this.statusStrip3.Padding = new System.Windows.Forms.Padding(1, 0, 15, 0);
            this.statusStrip3.Size = new System.Drawing.Size(342, 42);
            this.statusStrip3.TabIndex = 35;
            this.statusStrip3.Text = "statusStrip3";
            this.statusStrip3.UseWaitCursor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1226, 680);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 58);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.UseWaitCursor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(1270, 609);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(110, 25);
            this.lblTong.TabIndex = 88;
            this.lblTong.Text = "Tổng số : ";
            this.lblTong.UseWaitCursor = true;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(804, 33);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(152, 58);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "&Tìm lại";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.UseWaitCursor = true;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(642, 33);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(152, 58);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "&Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(349, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 84;
            this.label1.Text = "Giá trị tìm kiếm";
            this.label1.UseWaitCursor = true;
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(329, 46);
            this.comGT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(255, 32);
            this.comGT.TabIndex = 1;
            this.comGT.UseWaitCursor = true;
            // 
            // comTruong
            // 
            this.comTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "Mã thuốc",
            "Mã nhóm"});
            this.comTruong.Location = new System.Drawing.Point(12, 46);
            this.comTruong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(250, 32);
            this.comTruong.TabIndex = 0;
            this.comTruong.UseWaitCursor = true;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(24, 13);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 81;
            this.label8.Text = "Tên trường";
            this.label8.UseWaitCursor = true;
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(560, 590);
            this.btnLast.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(152, 58);
            this.btnLast.TabIndex = 78;
            this.btnLast.Text = "&Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.UseWaitCursor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(398, 590);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(152, 58);
            this.btnNext.TabIndex = 77;
            this.btnNext.Text = "&Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.UseWaitCursor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnPrv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.ForeColor = System.Drawing.Color.White;
            this.btnPrv.Location = new System.Drawing.Point(234, 590);
            this.btnPrv.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(152, 58);
            this.btnPrv.TabIndex = 76;
            this.btnPrv.Text = "&Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.UseWaitCursor = true;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnFirst.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.Color.White;
            this.btnFirst.Location = new System.Drawing.Point(72, 590);
            this.btnFirst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(152, 58);
            this.btnFirst.TabIndex = 75;
            this.btnFirst.Text = "&Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.UseWaitCursor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // grdData
            // 
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeight = 30;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MATHUOC,
            this.TENTHUOC,
            this.LOSX,
            this.DVT,
            this.DONGIA,
            this.SLUONG2,
            this.SLUONG1,
            this.TONKHO1,
            this.MANHOM});
            this.grdData.Cursor = System.Windows.Forms.Cursors.Default;
            this.grdData.Location = new System.Drawing.Point(11, 146);
            this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(1538, 412);
            this.grdData.TabIndex = 74;
            this.grdData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellContentClick);
            // 
            // MATHUOC
            // 
            this.MATHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MATHUOC.DataPropertyName = "MATHUOC";
            this.MATHUOC.HeaderText = "Mã thuốc";
            this.MATHUOC.MinimumWidth = 6;
            this.MATHUOC.Name = "MATHUOC";
            this.MATHUOC.Width = 120;
            // 
            // TENTHUOC
            // 
            this.TENTHUOC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TENTHUOC.DataPropertyName = "TENTHUOC";
            this.TENTHUOC.HeaderText = "Tên thuốc";
            this.TENTHUOC.MinimumWidth = 6;
            this.TENTHUOC.Name = "TENTHUOC";
            this.TENTHUOC.Width = 150;
            // 
            // LOSX
            // 
            this.LOSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.LOSX.DataPropertyName = "LOSX";
            this.LOSX.HeaderText = "Lô sản xuất";
            this.LOSX.MinimumWidth = 6;
            this.LOSX.Name = "LOSX";
            this.LOSX.Width = 120;
            // 
            // DVT
            // 
            this.DVT.DataPropertyName = "DVT";
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.MinimumWidth = 6;
            this.DVT.Name = "DVT";
            this.DVT.Width = 125;
            // 
            // DONGIA
            // 
            this.DONGIA.DataPropertyName = "DONGIA";
            this.DONGIA.HeaderText = "Đơn giá";
            this.DONGIA.MinimumWidth = 6;
            this.DONGIA.Name = "DONGIA";
            this.DONGIA.Width = 125;
            // 
            // SLUONG2
            // 
            this.SLUONG2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SLUONG2.DataPropertyName = "SLUONG2";
            this.SLUONG2.HeaderText = "Số lượng nhập";
            this.SLUONG2.MinimumWidth = 6;
            this.SLUONG2.Name = "SLUONG2";
            this.SLUONG2.Width = 120;
            // 
            // SLUONG1
            // 
            this.SLUONG1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SLUONG1.DataPropertyName = "SLUONG1";
            this.SLUONG1.HeaderText = "Số lượng bán";
            this.SLUONG1.MinimumWidth = 6;
            this.SLUONG1.Name = "SLUONG1";
            this.SLUONG1.Width = 120;
            // 
            // TONKHO1
            // 
            this.TONKHO1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TONKHO1.DataPropertyName = "TONKHO1";
            this.TONKHO1.HeaderText = "Tồn kho";
            this.TONKHO1.MinimumWidth = 6;
            this.TONKHO1.Name = "TONKHO1";
            this.TONKHO1.Width = 120;
            // 
            // MANHOM
            // 
            this.MANHOM.DataPropertyName = "MANHOM";
            this.MANHOM.HeaderText = "MANHOM";
            this.MANHOM.MinimumWidth = 6;
            this.MANHOM.Name = "MANHOM";
            this.MANHOM.Visible = false;
            this.MANHOM.Width = 125;
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(-364, 582);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(271, 31);
            this.txtMa.TabIndex = 90;
            this.txtMa.UseWaitCursor = true;
            this.txtMa.Visible = false;
            // 
            // frmTonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1581, 760);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.btnTK);
            this.Controls.Add(this.btnLoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comGT);
            this.Controls.Add(this.comTruong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(pictureBox2);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmTonkho";
            this.Text = "frmTonkho";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTonkho_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.statusStrip3.ResumeLayout(false);
            this.statusStrip3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblChuongtrinh;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel lblNguoidung;
        private System.Windows.Forms.ToolStripStatusLabel lblQuyen;
        private System.Windows.Forms.ToolStripStatusLabel lblThoigian;
        private System.Windows.Forms.StatusStrip statusStrip3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENTHUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIA;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLUONG2;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLUONG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONKHO1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHOM;
    }
}