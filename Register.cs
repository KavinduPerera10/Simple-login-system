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
    public partial class Register : Form
    {
        SqlConnection con = new SqlConnection(Properties.Settings.Default.LoginDB1ConnectionString);
        SqlDataReader da;
        SqlCommand cmd;
        public Register()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            
            con.Open();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Login login = new frm_Login();
            login.ShowDialog();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (txt_confirmPassword.Text != string.Empty || txt_password.Text != string.Empty || txt_Username.Text != string.Empty || txt_role.Text != string.Empty || txt_address.Text != string.Empty || txt_mobile.Text != string.Empty)
            {
                if (txt_password.Text == txt_confirmPassword.Text)
                {
                    cmd = new SqlCommand("select * from tbllog1 where username='" + txt_Username.Text + "'", con);
                    da = cmd.ExecuteReader();
                    if (da.Read())
                    {
                        da.Close();
                        MessageBox.Show("Username is Already taken, please try another! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        da.Close();
                        cmd = new SqlCommand("insert into tbllog1 (Username,Password,Role,Address,Mobile_Number) values(@Username,@Password,@Role,@Address,@Mobile_Number) SET IDENTITY_INSERT tbllog1 OFF ", con);
                        cmd.Parameters.AddWithValue("Username", txt_Username.Text);
                        cmd.Parameters.AddWithValue("Password", txt_password.Text);
                        cmd.Parameters.AddWithValue("Role", txt_role.Text);
                        cmd.Parameters.AddWithValue("Address", txt_address.Text);
                        cmd.Parameters.AddWithValue("Mobile_Number", txt_mobile.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Account is Succesfully created . You can login now.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Password and Confirm password does not match! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //con.Close();
                }
            }
            else
            {
                MessageBox.Show("Enter all required information!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //con.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
