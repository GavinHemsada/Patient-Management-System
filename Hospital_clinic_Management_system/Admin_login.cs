using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_clinic_Management_system
{
    public partial class Admin_login : Form
    {
        public Admin_login()
        {
            InitializeComponent();
        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox.Checked)
            {
                password_txt.PasswordChar = '\0';
            }
            else
            {
                password_txt.PasswordChar = '*';
            }
        }

        private void username_txt_Enter(object sender, EventArgs e)
        {
            if (username_txt.Text.Trim().Equals("User Name"))
            {
                username_txt.Text = "";
                username_txt.ForeColor = Color.Black;
            }
        }

        private void username_txt_Leave(object sender, EventArgs e)
        {
            if (username_txt.Text.Equals(""))
            {
                username_txt.Text = "        User Name";
                username_txt.ForeColor = Color.Silver;
            }
        }

        private void password_txt_Enter(object sender, EventArgs e)
        {
            if (password_txt.Text.Trim().Equals("Password"))
            {
                password_txt.Text = "";
                password_txt.PasswordChar = '*';
                password_txt.ForeColor = Color.Black;
            }
        }

        private void password_txt_Leave(object sender, EventArgs e)
        {
            if (password_txt.Text.Equals(""))
            {
                password_txt.PasswordChar = '\0';
                password_txt.Text = "        Password";
                password_txt.ForeColor = Color.Silver;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Connection db = new Connection();
            string uname, password;
            uname = username_txt.Text;
            password = password_txt.Text;
            try
            {
                systemError.Clear();

                if (uname.Trim().Equals("User Name"))
                {
                    systemError.SetError(username_txt, "Fill User Name");
                }
                if (password.Trim().Equals("Password"))
                {
                    systemError.SetError(password_txt, "Fill Password");
                }
                if (string.IsNullOrEmpty(systemError.GetError(username_txt)) && string.IsNullOrEmpty(systemError.GetError(password_txt)))
                {
                    db.OpenConnection();
                    string query = "SELECT * FROM admin WHERE User_Name = '" + username_txt.Text + "' AND Password = '" + password_txt.Text + "'";
                    MySqlDataAdapter cmd = new MySqlDataAdapter(query, db.getConnection());
                    DataTable dtable = new DataTable();
                    cmd.Fill(dtable);
                    if (dtable.Rows.Count > 0)
                    {
                        if (username_txt.Text.Equals("staff"))
                        {
                            this.Hide();
                            DashBoard paycal = new DashBoard(1);
                            paycal.Show();
                        }
                        else if(username_txt.Text.Equals("admin")){
                            this.Hide();
                            DashBoard paycal = new DashBoard(2);
                            paycal.Show();
                        }
                    }
                    else
                    {
                        DialogResult error = MessageBox.Show("Invalid Username and Password, Try again", " try again", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                        if (error.Equals(DialogResult.OK))
                        {
                            username_txt.Clear();
                            username_txt.Text = "        User Name";
                            username_txt.ForeColor = Color.Silver;
                            password_txt.Clear();
                            password_txt.PasswordChar = '\0';
                            password_txt.Text = "        Password";
                            password_txt.ForeColor = Color.Silver;
                        }
                        else if (error.Equals(DialogResult.Cancel))
                        {
                            Application.Exit();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show(" Server not respond", " 502 Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                db.CloseConnection();
            }
        }
    }
}
