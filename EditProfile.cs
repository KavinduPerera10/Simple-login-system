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
    public partial class EditProfile : Form
    {
        String username;
        SqlConnection con;
        SqlDataReader da;
        SqlCommand cmd;
        public EditProfile(String ulg)
        {
            InitializeComponent();
            this.username = ulg;
        }

        private void EditProfile_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(Properties.Settings.Default.LoginDB1ConnectionString);
            con.Open();
            cmd = new SqlCommand("SELECT * FROM tbllog1 WHERE Username='" + username + "'", con);
            da = cmd.ExecuteReader();
            if (da.Read())
            {
                
                txt_Username.Text = da["Username"].ToString();
                txt_role.Text = da["Role"].ToString();
                txt_address.Text = da["Address"].ToString();
                txt_mobile.Text = da["Mobile_Number"].ToString();
                da.Close();

            }
            else
            {
                da.Close();
            }
           
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (txt_Username.Text != string.Empty || txt_role.Text != string.Empty || txt_address.Text != string.Empty || txt_mobile.Text != string.Empty)
            {


              
                
                    cmd = new SqlCommand("UPDATE tbllog1 SET Username= @Username, Role= @Role, Address= @Address, Mobile_Number= @Mobile_Number WHERE Username='" + txt_Username.Text + "'", con);
                    cmd.Parameters.AddWithValue("Username", txt_Username.Text);
                    cmd.Parameters.AddWithValue("Role", txt_role.Text);
                    cmd.Parameters.AddWithValue("Address", txt_address.Text);
                    cmd.Parameters.AddWithValue("Mobile_Number", txt_mobile.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Account is Succesfully updated.", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    frm_Home home = new frm_Home(username);
                    home.ShowDialog();

            }
            else
            {
                //da.Close();
                MessageBox.Show("No Account avilable with this username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   
                    
            
          
        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Home log = new frm_Home(username);
            log.ShowDialog();
        }
    }
}
