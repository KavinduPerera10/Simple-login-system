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
    public partial class frm_Home : Form
    {
        String roleType;
        String username;
        SqlConnection con;
        SqlDataReader da;
        SqlCommand cmd;
        public frm_Home(String ulg)
        {
            InitializeComponent();
            lbl_Log_User.Text = ulg;
            this.username = ulg;

        }

        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Login flog = new frm_Login();
            flog.ShowDialog();
            this.Hide();

        }

        private void lbl_Add_New_Click(object sender, EventArgs e)
        {
            if (roleType == "Teacher"|| roleType=="Admin")
            {
                frm_Add_New_User fdn = new frm_Add_New_User(username);
                fdn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Only users with Admin/ Teacher role types have permission!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            EditProfile edit = new EditProfile(lbl_Log_User.Text);
            edit.ShowDialog();
            this.Hide();
        }

        private void frm_Home_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.LoginDB1ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog1 WHERE Username='" + username + "'", con);
            da = cmd.ExecuteReader();
            if (da.Read())
            {

                
                roleType = da["Role"].ToString();
                Console.WriteLine(roleType);
              
                da.Close();

            }
            else
            {
                da.Close();
            }
        }

        //Change password in home page
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            ChangePassword changePwd = new ChangePassword();
            changePwd.ShowDialog();
        }

        private void lbl_Log_User_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
