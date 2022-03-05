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

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        SqlConnection con;
        SqlDataReader da;
        SqlCommand cmd;
        public frm_Login()
        {
            InitializeComponent();
        }
        String ulg;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            if (txt_Password.Text != string.Empty || txt_Username.Text != string.Empty)
            {

                cmd = new SqlCommand("SELECT * FROM tbllog1 WHERE Username='" + txt_Username.Text +"' and Password='"+txt_Password.Text+"'", con);
                da = cmd.ExecuteReader();
                if (da.Read())
                {
                    ulg = txt_Username.Text;
                    da.Close();
                    this.Hide();
                    frm_Home homepage = new frm_Home(ulg);
                    homepage.ShowDialog();
                }
                else
                {
                   /* this.Hide();
                    frm_Home homepage = new frm_Home(txt_Username.Text);
                    homepage.ShowDialog();*/
                    da.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void changePassword_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.LoginDB1ConnectionString);
            con.Open();

        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
        }

        private void txt_Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePwd = new ChangePassword();
            changePwd.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt_Password_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
