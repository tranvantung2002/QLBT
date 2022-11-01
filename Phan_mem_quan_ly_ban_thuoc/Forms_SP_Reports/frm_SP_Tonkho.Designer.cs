
namespace Phan_mem_quan_ly_ban_thuoc.Forms_SP_Reports
{
    partial class frm_SP_Tonkho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SP_Tonkho));
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtNguoidung = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Baocao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(675, 166);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(245, 22);
            this.txtTen.TabIndex = 18;
            this.txtTen.Visible = false;
            // 
            // txtNguoidung
            // 
            this.txtNguoidung.Location = new System.Drawing.Point(675, 96);
            this.txtNguoidung.Name = "txtNguoidung";
            this.txtNguoidung.Size = new System.Drawing.Size(245, 22);
            this.txtNguoidung.TabIndex = 17;
            this.txtNguoidung.Visible = false;
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.button1.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(163, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(296, 50);
            this.button1.TabIndex = 15;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nunito Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(107, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(405, 33);
            this.label3.TabIndex = 16;
            this.label3.Text = "Bạn có muốn lập báo cáo không ?";
            // 
            // btn_Baocao
            // 
            this.btn_Baocao.AccessibleDescription = "";
            this.btn_Baocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.btn_Baocao.Font = new System.Drawing.Font("Nunito Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Baocao.ForeColor = System.Drawing.Color.White;
            this.btn_Baocao.Location = new System.Drawing.Point(163, 129);
            this.btn_Baocao.Name = "btn_Baocao";
            this.btn_Baocao.Size = new System.Drawing.Size(296, 50);
            this.btn_Baocao.TabIndex = 14;
            this.btn_Baocao.Text = "Lập báo cáo";
            this.btn_Baocao.UseVisualStyleBackColor = false;
            this.btn_Baocao.Click += new System.EventHandler(this.btn_Baocao_Click);
            // 
            // frm_SP_Tonkho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(54)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(627, 307);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtNguoidung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Baocao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_SP_Tonkho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_SP_Tonkho";
            this.Load += new System.EventHandler(this.frm_SP_Tonkho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtNguoidung;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Baocao;
    }
}