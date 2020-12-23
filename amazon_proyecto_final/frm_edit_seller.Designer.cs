namespace amazon_proyecto_final
{
    partial class frm_edit_seller
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
            this.delete = new System.Windows.Forms.Button();
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.txt_type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_des = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(306, 338);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(166, 31);
            this.delete.TabIndex = 37;
            this.delete.Text = "DELETE";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click_1);
            // 
            // txt_client_id
            // 
            this.txt_client_id.Location = new System.Drawing.Point(12, 98);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.ReadOnly = true;
            this.txt_client_id.Size = new System.Drawing.Size(100, 20);
            this.txt_client_id.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "Seller ID:";
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.White;
            this.add_user.Location = new System.Drawing.Point(12, 338);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(288, 31);
            this.add_user.TabIndex = 34;
            this.add_user.Text = "SEND";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click_1);
            // 
            // txt_type
            // 
            this.txt_type.Location = new System.Drawing.Point(12, 296);
            this.txt_type.Name = "txt_type";
            this.txt_type.Size = new System.Drawing.Size(221, 20);
            this.txt_type.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(8, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 32;
            this.label5.Text = "Type:";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(12, 246);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 20);
            this.txtemail.TabIndex = 31;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(8, 224);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(56, 19);
            this.email.TabIndex = 30;
            this.email.Text = "email:";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(12, 196);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(221, 20);
            this.txt_username.TabIndex = 29;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Black;
            this.lastName.Location = new System.Drawing.Point(8, 174);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(95, 19);
            this.lastName.TabIndex = 28;
            this.lastName.Text = "Username:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(12, 149);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(221, 20);
            this.txtname.TabIndex = 27;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(8, 127);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 19);
            this.name.TabIndex = 26;
            this.name.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(383, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 25;
            this.label2.Text = "Edit Seller";
            // 
            // txt_des
            // 
            this.txt_des.Location = new System.Drawing.Point(251, 149);
            this.txt_des.Multiline = true;
            this.txt_des.Name = "txt_des";
            this.txt_des.Size = new System.Drawing.Size(221, 167);
            this.txt_des.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(247, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 19);
            this.label3.TabIndex = 38;
            this.label3.Text = "Description:";
            // 
            // frm_edit_seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.backgr_small;
            this.ClientSize = new System.Drawing.Size(489, 390);
            this.Controls.Add(this.txt_des);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.txt_client_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.txt_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.Name = "frm_edit_seller";
            this.Text = "frm_edit_seller";
            this.Load += new System.EventHandler(this.frm_edit_seller_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TextBox txt_client_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox txt_type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_des;
        private System.Windows.Forms.Label label3;
    }
}