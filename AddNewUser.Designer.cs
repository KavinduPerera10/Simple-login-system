
namespace WindowsFormsApp1
{
    partial class frm_Add_New_User
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
            this.components = new System.ComponentModel.Container();
            this.tbllog1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.loginDB1AppData = new WindowsFormsApp1.LoginDB1AppData();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbllog1TableAdapter = new WindowsFormsApp1.LoginDB1AppDataTableAdapters.tbllog1TableAdapter();
            this.tbllog1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.loginDB1DataSet = new WindowsFormsApp1.LoginDB1DataSet();
            this.tbllog1BindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tbllog1TableAdapter1 = new WindowsFormsApp1.LoginDB1DataSetTableAdapters.tbllog1TableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mobile_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_home = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDB1AppData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // tbllog1BindingSource
            // 
            this.tbllog1BindingSource.DataMember = "tbllog1";
            this.tbllog1BindingSource.DataSource = this.loginDB1AppData;
            // 
            // loginDB1AppData
            // 
            this.loginDB1AppData.DataSetName = "LoginDB1AppData";
            this.loginDB1AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.Role,
            this.Address,
            this.Mobile_Number});
            this.dataGridView1.DataSource = this.tbllog1BindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(25, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(739, 333);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tbllog1TableAdapter
            // 
            this.tbllog1TableAdapter.ClearBeforeFill = true;
            // 
            // tbllog1BindingSource1
            // 
            this.tbllog1BindingSource1.DataMember = "tbllog1";
            this.tbllog1BindingSource1.DataSource = this.loginDB1AppData;
            // 
            // loginDB1DataSet
            // 
            this.loginDB1DataSet.DataSetName = "LoginDB1DataSet";
            this.loginDB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbllog1BindingSource2
            // 
            this.tbllog1BindingSource2.DataMember = "tbllog1";
            this.tbllog1BindingSource2.DataSource = this.loginDB1DataSet;
            // 
            // tbllog1TableAdapter1
            // 
            this.tbllog1TableAdapter1.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 60;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 125;
            // 
            // Role
            // 
            this.Role.DataPropertyName = "Role";
            this.Role.HeaderText = "Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            this.Role.Width = 125;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 125;
            // 
            // Mobile_Number
            // 
            this.Mobile_Number.DataPropertyName = "Mobile_Number";
            this.Mobile_Number.HeaderText = "Mobile_Number";
            this.Mobile_Number.MinimumWidth = 6;
            this.Mobile_Number.Name = "Mobile_Number";
            this.Mobile_Number.ReadOnly = true;
            this.Mobile_Number.Width = 125;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(266, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 45);
            this.label5.TabIndex = 17;
            this.label5.Text = "View Profiles";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Location = new System.Drawing.Point(0, 1);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(826, 111);
            this.textBox1.TabIndex = 18;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(367, 486);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(75, 23);
            this.btn_home.TabIndex = 19;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // frm_Add_New_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 521);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frm_Add_New_User";
            this.Text = "AddNewUser";
            this.Load += new System.EventHandler(this.DGV_User_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDB1AppData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginDB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllog1BindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private LoginDB1AppData loginDB1AppData;
        private System.Windows.Forms.BindingSource tbllog1BindingSource;
        private LoginDB1AppDataTableAdapters.tbllog1TableAdapter tbllog1TableAdapter;
        private System.Windows.Forms.BindingSource tbllog1BindingSource1;
        private LoginDB1DataSet loginDB1DataSet;
        private System.Windows.Forms.BindingSource tbllog1BindingSource2;
        private LoginDB1DataSetTableAdapters.tbllog1TableAdapter tbllog1TableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mobile_Number;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_home;
    }
}