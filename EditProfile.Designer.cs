
namespace WindowsFormsApp1
{
    partial class EditProfile
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
            System.Windows.Forms.Label Address;
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.txt_mobile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_rol = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            Address = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Address.Location = new System.Drawing.Point(32, 313);
            Address.Name = "Address";
            Address.Size = new System.Drawing.Size(74, 23);
            Address.TabIndex = 22;
            Address.Text = "Address";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_cancel.Location = new System.Drawing.Point(91, 564);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(234, 35);
            this.btn_cancel.TabIndex = 28;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(192, 231);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(233, 22);
            this.txt_role.TabIndex = 27;
            this.txt_role.TextChanged += new System.EventHandler(this.txt_role_TextChanged);
            // 
            // txt_mobile
            // 
            this.txt_mobile.Location = new System.Drawing.Point(192, 398);
            this.txt_mobile.Name = "txt_mobile";
            this.txt_mobile.Size = new System.Drawing.Size(233, 22);
            this.txt_mobile.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 398);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 23);
            this.label6.TabIndex = 23;
            this.label6.Text = "Mobile Number";
            // 
            // txt_rol
            // 
            this.txt_rol.AutoSize = true;
            this.txt_rol.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rol.Location = new System.Drawing.Point(32, 231);
            this.txt_rol.Name = "txt_rol";
            this.txt_rol.Size = new System.Drawing.Size(45, 23);
            this.txt_rol.TabIndex = 21;
            this.txt_rol.Text = "Role";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(192, 313);
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(233, 22);
            this.txt_address.TabIndex = 20;
            this.txt_address.TextChanged += new System.EventHandler(this.txt_address_TextChanged);
            // 
            // btn_update
            // 
            this.btn_update.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.btn_update.Location = new System.Drawing.Point(91, 483);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(234, 35);
            this.btn_update.TabIndex = 17;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(192, 143);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(233, 22);
            this.txt_Username.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 15;
            this.label1.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Turquoise;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(145, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(190, 45);
            this.label5.TabIndex = 29;
            this.label5.Text = "Edit Profile";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Location = new System.Drawing.Point(-10, -3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(490, 111);
            this.textBox1.TabIndex = 30;
            // 
            // EditProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 676);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.txt_mobile);
            this.Controls.Add(this.label6);
            this.Controls.Add(Address);
            this.Controls.Add(this.txt_rol);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label1);
            this.Name = "EditProfile";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.EditProfile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.TextBox txt_mobile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_rol;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
    }
}