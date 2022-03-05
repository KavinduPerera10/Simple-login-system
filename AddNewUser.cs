using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class frm_Add_New_User : Form
        
    {
        String username;
        public frm_Add_New_User(String uname)
        {
            InitializeComponent();
            this.username = uname;
        }

        private void DGV_User_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'loginDB1DataSet.tbllog1' table. You can move, or remove it, as needed.
            this.tbllog1TableAdapter1.Fill(this.loginDB1DataSet.tbllog1);
            // TODO: This line of code loads data into the 'loginDB1AppData.tbllog1' table. You can move, or remove it, as needed.
            this.tbllog1TableAdapter.Fill(this.loginDB1AppData.tbllog1);
            

        }
 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm_Home home = new frm_Home(username);
            home.ShowDialog();
        }
    }
}
