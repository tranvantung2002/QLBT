
namespace Phan_mem_quan_ly_ban_thuoc
{
    partial class test
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
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.txtDem = new System.Windows.Forms.MaskedTextBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(122, 104);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(505, 22);
            this.txtHoten.TabIndex = 0;
            // 
            // txtDem
            // 
            this.txtDem.Location = new System.Drawing.Point(185, 293);
            this.txtDem.Name = "txtDem";
            this.txtDem.Size = new System.Drawing.Size(359, 22);
            this.txtDem.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(226, 180);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(300, 67);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Ấn";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.txtDem);
            this.Controls.Add(this.txtHoten);
            this.Name = "test";
            this.Text = "test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.MaskedTextBox txtDem;
        private System.Windows.Forms.Button btn1;
    }
}