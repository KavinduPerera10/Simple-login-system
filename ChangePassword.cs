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
using System.Configuration;

namespace WindowsFormsApp1
{
    public partial class ChangePassword : Form
    {
        SqlConnection con;
        SqlDataReader da;
        SqlCommand cmd;
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text != string.Empty || txt_newPwd.Text != string.Empty || txt_confirmPwd.Text != string.Empty)
            {
                if (txt_newPwd.Text == txt_confirmPwd.Text)
                {
                    cmd = new SqlCommand("SELECT * FROM tbllog1 WHERE Username='" + txt_Username.Text + "'", con);
                    da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        da.Close();
                        cmd = new SqlCommand("UPDATE tbllog1 SET Password= @Password WHERE Username='" + txt_Username.Text + "'", con);
                        cmd.Parameters.AddWithValue("Password", txt_newPwd.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Succesfully updated password. Login with new passord.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        frm_Login login = new frm_Login();
                        login.ShowDialog();

                    }
                    else
                    {
                        da.Close();
                        MessageBox.Show("No Account avilable with this username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChangePassword_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.LoginDB1ConnectionString);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
