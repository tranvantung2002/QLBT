
namespace Phan_mem_quan_ly_ban_thuoc.Forms_Update
{
    partial class frmUp_nhanvien
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUp_nhanvien));
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.grdData = new System.Windows.Forms.DataGridView();
            this.mANHANVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENNHANVIENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIACHIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tAIKHOANDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mATKHAUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qUYENDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblNhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tHUOCDataSet = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThemlai = new System.Windows.Forms.Button();
            this.tblNhanvienTableAdapter = new Phan_mem_quan_ly_ban_thuoc.THUOCDataSetTableAdapters.tblNhanvienTableAdapter();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMatkhau = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaikhoan = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdAdmin = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox5.Location = new System.Drawing.Point(-8, 678);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(1196, 15);
            this.pictureBox5.TabIndex = 60;
            this.pictureBox5.TabStop = false;
            // 
            // grdData
            // 
            this.grdData.AutoGenerateColumns = false;
            this.grdData.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Nunito Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdData.ColumnHeadersHeight = 30;
            this.grdData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mANHANVIENDataGridViewTextBoxColumn,
            this.tENNHANVIENDataGridViewTextBoxColumn,
            this.dIACHIDataGridViewTextBoxColumn,
            this.sDTDataGridViewTextBoxColumn,
            this.tAIKHOANDataGridViewTextBoxColumn,
            this.mATKHAUDataGridViewTextBoxColumn,
            this.qUYENDataGridViewTextBoxColumn});
            this.grdData.DataSource = this.tblNhanvienBindingSource;
            this.grdData.Location = new System.Drawing.Point(15, 702);
            this.grdData.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.grdData.Name = "grdData";
            this.grdData.RowHeadersWidth = 51;
            this.grdData.Size = new System.Drawing.Size(1360, 195);
            this.grdData.TabIndex = 57;
            // 
            // mANHANVIENDataGridViewTextBoxColumn
            // 
            this.mANHANVIENDataGridViewTextBoxColumn.DataPropertyName = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.HeaderText = "MANHANVIEN";
            this.mANHANVIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mANHANVIENDataGridViewTextBoxColumn.Name = "mANHANVIENDataGridViewTextBoxColumn";
            this.mANHANVIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // tENNHANVIENDataGridViewTextBoxColumn
            // 
            this.tENNHANVIENDataGridViewTextBoxColumn.DataPropertyName = "TENNHANVIEN";
            this.tENNHANVIENDataGridViewTextBoxColumn.HeaderText = "TENNHANVIEN";
            this.tENNHANVIENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tENNHANVIENDataGridViewTextBoxColumn.Name = "tENNHANVIENDataGridViewTextBoxColumn";
            this.tENNHANVIENDataGridViewTextBoxColumn.Width = 125;
            // 
            // dIACHIDataGridViewTextBoxColumn
            // 
            this.dIACHIDataGridViewTextBoxColumn.DataPropertyName = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.HeaderText = "DIACHI";
            this.dIACHIDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dIACHIDataGridViewTextBoxColumn.Name = "dIACHIDataGridViewTextBoxColumn";
            this.dIACHIDataGridViewTextBoxColumn.Width = 125;
            // 
            // sDTDataGridViewTextBoxColumn
            // 
            this.sDTDataGridViewTextBoxColumn.DataPropertyName = "SDT";
            this.sDTDataGridViewTextBoxColumn.HeaderText = "SDT";
            this.sDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sDTDataGridViewTextBoxColumn.Name = "sDTDataGridViewTextBoxColumn";
            this.sDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // tAIKHOANDataGridViewTextBoxColumn
            // 
            this.tAIKHOANDataGridViewTextBoxColumn.DataPropertyName = "TAIKHOAN";
            this.tAIKHOANDataGridViewTextBoxColumn.HeaderText = "TAIKHOAN";
            this.tAIKHOANDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tAIKHOANDataGridViewTextBoxColumn.Name = "tAIKHOANDataGridViewTextBoxColumn";
            this.tAIKHOANDataGridViewTextBoxColumn.Width = 125;
            // 
            // mATKHAUDataGridViewTextBoxColumn
            // 
            this.mATKHAUDataGridViewTextBoxColumn.DataPropertyName = "MATKHAU";
            this.mATKHAUDataGridViewTextBoxColumn.HeaderText = "MATKHAU";
            this.mATKHAUDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mATKHAUDataGridViewTextBoxColumn.Name = "mATKHAUDataGridViewTextBoxColumn";
            this.mATKHAUDataGridViewTextBoxColumn.Width = 125;
            // 
            // qUYENDataGridViewTextBoxColumn
            // 
            this.qUYENDataGridViewTextBoxColumn.DataPropertyName = "QUYEN";
            this.qUYENDataGridViewTextBoxColumn.HeaderText = "QUYEN";
            this.qUYENDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.qUYENDataGridViewTextBoxColumn.Name = "qUYENDataGridViewTextBoxColumn";
            this.qUYENDataGridViewTextBoxColumn.Width = 125;
            // 
            // tblNhanvienBindingSource
            // 
            this.tblNhanvienBindingSource.DataMember = "tblNhanvien";
            this.tblNhanvienBindingSource.DataSource = this.tHUOCDataSet;
            // 
            // tHUOCDataSet
            // 
            this.tHUOCDataSet.DataSetName = "THUOCDataSet";
            this.tHUOCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThoat.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(730, 515);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(208, 86);
            this.btnThoat.TabIndex = 9;
            this.btnThoat.Text = "Trở về";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThemlai
            // 
            this.btnThemlai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnThemlai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThemlai.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemlai.ForeColor = System.Drawing.Color.White;
            this.btnThemlai.Location = new System.Drawing.Point(246, 515);
            this.btnThemlai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnThemlai.Name = "btnThemlai";
            this.btnThemlai.Size = new System.Drawing.Size(208, 86);
            this.btnThemlai.TabIndex = 7;
            this.btnThemlai.Text = "Sửa lại";
            this.btnThemlai.UseVisualStyleBackColor = false;
            this.btnThemlai.Click += new System.EventHandler(this.btnThemlai_Click);
            // 
            // tblNhanvienTableAdapter
            // 
            this.tblNhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox4.Location = new System.Drawing.Point(1173, 35);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(15, 701);
            this.pictureBox4.TabIndex = 59;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox3.Location = new System.Drawing.Point(-4, 94);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(15, 701);
            this.pictureBox3.TabIndex = 58;
            this.pictureBox3.TabStop = false;
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskDienthoai.Location = new System.Drawing.Point(246, 326);
            this.mskDienthoai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(347, 35);
            this.mskDienthoai.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdate.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(489, 515);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(208, 86);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(666, 331);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 29);
            this.label6.TabIndex = 52;
            this.label6.Text = "Quyền :";
            // 
            // txtMatkhau
            // 
            this.txtMatkhau.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatkhau.Location = new System.Drawing.Point(780, 232);
            this.txtMatkhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMatkhau.Name = "txtMatkhau";
            this.txtMatkhau.Size = new System.Drawing.Size(347, 35);
            this.txtMatkhau.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(629, 238);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 29);
            this.label7.TabIndex = 50;
            this.label7.Text = "Mật khẩu :";
            // 
            // txtTaikhoan
            // 
            this.txtTaikhoan.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaikhoan.Location = new System.Drawing.Point(780, 142);
            this.txtTaikhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTaikhoan.Name = "txtTaikhoan";
            this.txtTaikhoan.Size = new System.Drawing.Size(347, 35);
            this.txtTaikhoan.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(622, 142);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 29);
            this.label8.TabIndex = 48;
            this.label8.Text = "Tài khoản :";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(244, 419);
            this.txtDiachi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(792, 35);
            this.txtDiachi.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(109, 419);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 29);
            this.label5.TabIndex = 46;
            this.label5.Text = "Địa chỉ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 331);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 29);
            this.label4.TabIndex = 45;
            this.label4.Text = "Số điện thoại :";
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(244, 235);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(347, 35);
            this.txtTen.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 238);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 29);
            this.label3.TabIndex = 43;
            this.label3.Text = "Tên nhân viên :";
            // 
            // txtMa
            // 
            this.txtMa.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMa.Location = new System.Drawing.Point(244, 142);
            this.txtMa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMa.Name = "txtMa";
            this.txtMa.Size = new System.Drawing.Size(347, 35);
            this.txtMa.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 29);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mã nhân viên :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.label1.Font = new System.Drawing.Font("Nunito Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(104, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 55);
            this.label1.TabIndex = 40;
            this.label1.Text = "Thông tin người sử dụng";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 39;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.pictureBox1.Location = new System.Drawing.Point(-8, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1196, 102);
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // rdAdmin
            // 
            this.rdAdmin.AutoSize = true;
            this.rdAdmin.Font = new System.Drawing.Font("Nunito Black", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdAdmin.Location = new System.Drawing.Point(780, 331);
            this.rdAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdAdmin.Name = "rdAdmin";
            this.rdAdmin.Size = new System.Drawing.Size(101, 32);
            this.rdAdmin.TabIndex = 5;
            this.rdAdmin.Text = "Admin";
            this.rdAdmin.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(750, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 29);
            this.label9.TabIndex = 103;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(204, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 29);
            this.label10.TabIndex = 104;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(204, 326);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 29);
            this.label11.TabIndex = 105;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(750, 232);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(23, 29);
            this.label12.TabIndex = 106;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(204, 419);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(23, 29);
            this.label13.TabIndex = 107;
            this.label13.Text = "*";
            // 
            // frmUp_nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 686);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.rdAdmin);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.grdData);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnThemlai);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMatkhau);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaikhoan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmUp_nhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUp_nhanvien";
            this.Load += new System.EventHandler(this.frmUp_nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblNhanvienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tHUOCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.DataGridView grdData;
        private System.Windows.Forms.DataGridViewTextBoxColumn mANHANVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENNHANVIENDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIACHIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tAIKHOANDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mATKHAUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qUYENDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tblNhanvienBindingSource;
        private THUOCDataSet tHUOCDataSet;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemlai;
        private THUOCDataSetTableAdapters.tblNhanvienTableAdapter tblNhanvienTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMatkhau;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaikhoan;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox rdAdmin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}