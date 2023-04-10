
using Hotel.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        WORKING work = new WORKING();
        private void btnLogin_MouseHover(object sender, EventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (txtUser.Text == "Username")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "Username";
                txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "Password";
                txtPass.ForeColor = Color.Silver;
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "Password")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.Black;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (txtPass.Text != "Password")
            {
                txtPass.UseSystemPasswordChar = false;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != "Password")
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (txtPass.Text != "Password")
            {
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckFill())
                {
                    DataTable dt = work.LogIn(txtUser.Text.Trim(), txtPass.Text.Trim());
                    if (dt.Rows.Count > 0)
                    {
                        GlobalVar._GlobalType = (int)dt.Rows[0][10];
                        GlobalVar._id = (int)dt.Rows[0][0];
                        dt = work.GetIdAssignment(GlobalVar._id);
                        if (dt.Rows.Count == 0)
                        {
                            if (MessageBox.Show("Bạn không lịch phân công vào lúc này. Vẫn tiếp tục đăng nhập?", "Đăng nhập",
                                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                this.Hide();
                                OpenForm(GlobalVar._GlobalType);
                                this.Show();
                            }
                        }
                        else
                        {
                            
                            try
                            {
                                GlobalVar._idAssignment = (int)dt.Rows[0][0];
                                work.ConfirmLogin(GlobalVar._idAssignment);
                            }
                            catch { }
                            this.Hide();
                            OpenForm(GlobalVar._GlobalType);
                            this.Show();
                        }


                    }
                    else
                    {
                        MessageBox.Show("Please Enter A Correct Username/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private bool CheckFill()
        {
            if (txtUser.Text == "Username" || txtPass.Text == "Password")
            {
                MessageBox.Show("Please Fill Username/Password", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void OpenForm(int phanquyen)
        {
            if (phanquyen == 1)
            {
                LTForm lt = new LTForm();
                lt.ShowDialog();
            }
            else
            {
                if (phanquyen == 0)
                {
                    QLForm ql = new QLForm();
                    ql.ShowDialog();
                }
                else
                {
                    LCNForm lCForm = new LCNForm(GlobalVar._id);
                    //lCForm.idQuanLy = id;
                    lCForm.ShowDialog();
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Exit Program", "Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
                this.Close();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = global::Hotel.Properties.Resources.shutdownHover_40px;

        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = global::Hotel.Properties.Resources.shutdown_40px;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                txtUser.Focus();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(btnLogin, e);
            }
        }
    }
}
