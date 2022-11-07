
namespace Phan_mem_quan_ly_ban_thuoc.Forms_Quanlykho
{
    partial class frmHDNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHDNhap));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tHUOCDataSet = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSet();
            this.tblPhieunhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhieunhapTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblPhieunhapTableAdapter();
            this.lblTong = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnAddnew = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.MANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MANCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPhieunhapBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tblPhieunhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnTK = new System.Windows.Forms.Button();
            this.tblCTPhieunhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCTPhieunhapTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblCTPhieunhapTableAdapter();
            this.tblCTPhieunhapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblCTPhieMANHA398D8EEEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblCTPhieMANHA398D8EEEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblCTPhieMANHA398D8EEEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKtblCTPhieMANHA398D8EEEBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.comTruong = new System.Windows.Forms.ComboBox();
            this.comGT = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTPhieunhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTPhieunhapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            pictureBox2.Location = new System.Drawing.Point(-785, -333);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(348, 102);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 32;
            pictureBox2.TabStop = false;
            // 
            // tHUOCDataSet
            // 
            this.tHUOCDataSet.DataSetName = "THUOCDataSet";
            this.tHUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblPhieunhapBindingSource
            // 
            this.tblPhieunhapBindingSource.DataMember = "tblPhieunhap";
            this.tblPhieunhapBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // tblPhieunhapTableAdapter
            // 
            this.tblPhieunhapTableAdapter.ClearBeforeFill = true;
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.Color.Red;
            this.lblTong.Location = new System.Drawing.Point(1324, 525);
            this.lblTong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(110, 25);
            this.lblTong.TabIndex = 72;
            this.lblTong.Text = "Tổng số : ";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(-516, 390);
            this.txtMa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(271, 31);
            this.txtMa.TabIndex = 71;
            this.txtMa.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(35, 525);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(469, 25);
            this.label3.TabIndex = 70;
            this.label3.Text = "Kích đúp để xem thông tin chi tiết hoá đơn nhập";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLoc.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoc.ForeColor = System.Drawing.Color.White;
            this.btnLoc.Location = new System.Drawing.Point(506, 30);
            this.btnLoc.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(152, 58);
            this.btnLoc.TabIndex = 2;
            this.btnLoc.Text = "&Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1285, 598);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(170, 58);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "&Xoá";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnAddnew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddnew.ForeColor = System.Drawing.Color.White;
            this.btnAddnew.Location = new System.Drawing.Point(1356, 23);
            this.btnAddnew.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(198, 71);
            this.btnAddnew.TabIndex = 6;
            this.btnAddnew.Text = "+   &Nhập hàng";
            this.btnAddnew.UseVisualStyleBackColor = false;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnLast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.Color.White;
            this.btnLast.Location = new System.Drawing.Point(528, 598);
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
            this.btnNext.Location = new System.Drawing.Point(366, 598);
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
            this.btnPrv.Location = new System.Drawing.Point(202, 598);
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
            this.btnFirst.Location = new System.Drawing.Point(40, 598);
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
            this.grdData.AllowUserToDeleteRows = false;
            this.grdData.AutoGenerateColumns = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdData.ColumnHeadersHeight = 30;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MANHAP,
            this.MANCC,
            this.NGAYNHAP,
            this.TENNCC,
            this.TONGTIEN,
            this.GHICHU});
            this.grdData.DataSource = this.tblPhieunhapBindingSource2;
            this.grdData.Location = new System.Drawing.Point(18, 129);
            this.grdData.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(1536, 344);
            this.grdData.TabIndex = 57;
            this.grdData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellClick);
            this.grdData.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdData_CellDoubleClick);
            // 
            // MANHAP
            // 
            this.MANHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MANHAP.DataPropertyName = "MANHAP";
            this.MANHAP.HeaderText = "Mã nhập";
            this.MANHAP.MinimumWidth = 6;
            this.MANHAP.Name = "MANHAP";
            this.MANHAP.Width = 250;
            // 
            // MANCC
            // 
            this.MANCC.DataPropertyName = "MANCC";
            this.MANCC.HeaderText = "MANCC";
            this.MANCC.MinimumWidth = 6;
            this.MANCC.Name = "MANCC";
            this.MANCC.Visible = false;
            this.MANCC.Width = 125;
            // 
            // NGAYNHAP
            // 
            this.NGAYNHAP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYNHAP.DataPropertyName = "NGAYNHAP";
            this.NGAYNHAP.HeaderText = "Ngày nhập";
            this.NGAYNHAP.MinimumWidth = 6;
            this.NGAYNHAP.Name = "NGAYNHAP";
            this.NGAYNHAP.Width = 152;
            // 
            // TENNCC
            // 
            this.TENNCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TENNCC.DataPropertyName = "TENNCC";
            this.TENNCC.HeaderText = "Nhà cung cấp";
            this.TENNCC.MinimumWidth = 6;
            this.TENNCC.Name = "TENNCC";
            this.TENNCC.Width = 300;
            // 
            // TONGTIEN
            // 
            this.TONGTIEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TONGTIEN.DataPropertyName = "TONGTIEN";
            this.TONGTIEN.HeaderText = "Tổng tiền";
            this.TONGTIEN.MinimumWidth = 6;
            this.TONGTIEN.Name = "TONGTIEN";
            this.TONGTIEN.Width = 150;
            // 
            // GHICHU
            // 
            this.GHICHU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 200;
            // 
            // tblPhieunhapBindingSource2
            // 
            this.tblPhieunhapBindingSource2.DataMember = "tblPhieunhap";
            this.tblPhieunhapBindingSource2.DataSource = this.tHUOCDataSet;
            // 
            // tblPhieunhapBindingSource1
            // 
            this.tblPhieunhapBindingSource1.DataMember = "tblPhieunhap";
            this.tblPhieunhapBindingSource1.DataSource = this.tHUOCDataSet;
            // 
            // btnTK
            // 
            this.btnTK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnTK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTK.ForeColor = System.Drawing.Color.White;
            this.btnTK.Location = new System.Drawing.Point(666, 30);
            this.btnTK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(152, 58);
            this.btnTK.TabIndex = 3;
            this.btnTK.Text = "&Tìm lại";
            this.btnTK.UseVisualStyleBackColor = false;
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // tblCTPhieunhapBindingSource
            // 
            this.tblCTPhieunhapBindingSource.DataMember = "tblCTPhieunhap";
            this.tblCTPhieunhapBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // tblCTPhieunhapTableAdapter
            // 
            this.tblCTPhieunhapTableAdapter.ClearBeforeFill = true;
            // 
            // tblCTPhieunhapBindingSource1
            // 
            this.tblCTPhieunhapBindingSource1.DataMember = "tblCTPhieunhap";
            this.tblCTPhieunhapBindingSource1.DataSource = this.tHUOCDataSet;
            // 
            // fKtblCTPhieMANHA398D8EEEBindingSource
            // 
            this.fKtblCTPhieMANHA398D8EEEBindingSource.DataMember = "FK__tblCTPhie__MANHA__398D8EEE";
            this.fKtblCTPhieMANHA398D8EEEBindingSource.DataSource = this.tblPhieunhapBindingSource1;
            // 
            // fKtblCTPhieMANHA398D8EEEBindingSource1
            // 
            this.fKtblCTPhieMANHA398D8EEEBindingSource1.DataMember = "FK__tblCTPhie__MANHA__398D8EEE";
            this.fKtblCTPhieMANHA398D8EEEBindingSource1.DataSource = this.tblPhieunhapBindingSource;
            // 
            // fKtblCTPhieMANHA398D8EEEBindingSource2
            // 
            this.fKtblCTPhieMANHA398D8EEEBindingSource2.DataMember = "FK__tblCTPhie__MANHA__398D8EEE";
            this.fKtblCTPhieMANHA398D8EEEBindingSource2.DataSource = this.tblPhieunhapBindingSource1;
            // 
            // fKtblCTPhieMANHA398D8EEEBindingSource3
            // 
            this.fKtblCTPhieMANHA398D8EEEBindingSource3.DataMember = "FK__tblCTPhie__MANHA__398D8EEE";
            this.fKtblCTPhieMANHA398D8EEEBindingSource3.DataSource = this.tblPhieunhapBindingSource;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkBlue;
            this.label8.Location = new System.Drawing.Point(13, 7);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 25);
            this.label8.TabIndex = 64;
            this.label8.Text = "Tên trường";
            // 
            // comTruong
            // 
            this.comTruong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTruong.FormattingEnabled = true;
            this.comTruong.Items.AddRange(new object[] {
            "Mã nhập",
            "Mã nhà cung cấp"});
            this.comTruong.Location = new System.Drawing.Point(18, 43);
            this.comTruong.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comTruong.Name = "comTruong";
            this.comTruong.Size = new System.Drawing.Size(184, 32);
            this.comTruong.TabIndex = 0;
            this.comTruong.SelectedIndexChanged += new System.EventHandler(this.comTruong_SelectedIndexChanged);
            // 
            // comGT
            // 
            this.comGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comGT.FormattingEnabled = true;
            this.comGT.Location = new System.Drawing.Point(245, 43);
            this.comGT.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comGT.Name = "comGT";
            this.comGT.Size = new System.Drawing.Size(234, 32);
            this.comGT.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(240, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 25);
            this.label1.TabIndex = 67;
            this.label1.Text = "Giá trị tìm kiếm";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1106, 598);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(170, 58);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "&Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // frmHDNhap
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
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmHDNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHDNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHDNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPhieunhapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTPhieunhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCTPhieunhapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKtblCTPhieMANHA398D8EEEBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private THUOCDataSet tHUOCDataSet;
        private System.Windows.Forms.BindingSource tblPhieunhapBindingSource;
        private THUOCDataSetTableAdapters.tblPhieunhapTableAdapter tblPhieunhapTableAdapter;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnAddnew;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.BindingSource tblPhieunhapBindingSource1;
        private System.Windows.Forms.Button btnTK;
        private System.Windows.Forms.BindingSource tblCTPhieunhapBindingSource;
        private THUOCDataSetTableAdapters.tblCTPhieunhapTableAdapter tblCTPhieunhapTableAdapter;
        private System.Windows.Forms.BindingSource fKtblCTPhieMANHA398D8EEEBindingSource;
        private System.Windows.Forms.BindingSource fKtblCTPhieMANHA398D8EEEBindingSource1;
        private System.Windows.Forms.BindingSource tblCTPhieunhapBindingSource1;
        private System.Windows.Forms.BindingSource tblPhieunhapBindingSource2;
        private System.Windows.Forms.BindingSource fKtblCTPhieMANHA398D8EEEBindingSource2;
        private System.Windows.Forms.BindingSource fKtblCTPhieMANHA398D8EEEBindingSource3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comTruong;
        private System.Windows.Forms.ComboBox comGT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MANCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGTIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.Button btnUpdate;
    }
}