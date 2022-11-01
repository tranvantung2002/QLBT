using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Phan_mem_quan_ly_ban_thuoc
{
    public partial class frmLogin : Form
    {
        int i = 0;
        public bool islogin { get; set; }
        public string username { get; set; }
        public string fullname { get; set; }
        public string quyenhan { get; set; }
        public frmLogin()
        {
            InitializeComponent();
            islogin = false;
        }

        private void txtUser_Click(object sender, EventArgs e)
        {
            label2.Text = "";
            if (txtPass.Text == "")
            {
                label3.Text = "Password";
            }
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            if (txtUser.Text == "")
            {
                label2.Text = "Username";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            islogin = false;
            Class.Functions.Connect();
            txtPass.Text = "";
            txtUser.Text = "";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if((label2.Text=="Username") || (txtUser.Text == "")) 
            {            
                MessageBox.Show("Bạn chưa nhập tài khoản !!!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUser.Focus();
                return;
            }
            else if ((label3.Text == "Password") || (txtPass.Text==""))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu !!!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (i < 4)
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-GITFMCB6\SQLEXPRESS;Initial Catalog=THUOC;Integrated Security=True");
                    try
                    {
                        conn.Open();
                        string tk = txtUser.Text;
                        string mk = txtPass.Text;
                        string sql = "Select * From tblNhanvien where TAIKHOAN='" + tk + "' and MATKHAU='" + mk + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader dta = cmd.ExecuteReader();
                        if (dta.Read() == true)
                        {
                            islogin = true;
                            fullname = dta["TENNHANVIEN"].ToString();
                            quyenhan = dta["QUYEN"].ToString();
                            this.Close();
                        }
                        else
                        {
                            lblThongbao.Text = "Tài khoản không đúng hoặc sai mật khẩu";
                        }
                    }
                    catch /*(Exception ex)*/
                    {
                        MessageBox.Show("Lỗi kết nối");
                    }
                    i++;
                }
                else
                {
                    MessageBox.Show("Bạn đăng nhập quá 3 lần !!! Bye bye ","Cảnh báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    Application.Exit();
                }
                
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            txtPass.PasswordChar = '*';
            label3.Text = "";
            lblThongbao.Text = "";
        }

        private void lblQuen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Liên hệ: 0329238046 đề lấy lại mật khẩu !!!", "Quên mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            lblThongbao.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
