namespace amazon_proyecto_final
{
    partial class frm_add_one_user
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
            this.txt_client_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.add_user = new System.Windows.Forms.Button();
            this.txtgender = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtemail = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_client_id
            // 
            this.txt_client_id.Location = new System.Drawing.Point(152, 258);
            this.txt_client_id.Name = "txt_client_id";
            this.txt_client_id.Size = new System.Drawing.Size(100, 20);
            this.txt_client_id.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(171, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 24;
            this.label1.Text = "Client ID:";
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.White;
            this.add_user.Location = new System.Drawing.Point(31, 297);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(221, 31);
            this.add_user.TabIndex = 23;
            this.add_user.Text = "SEND";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // txtgender
            // 
            this.txtgender.Location = new System.Drawing.Point(31, 258);
            this.txtgender.Name = "txtgender";
            this.txtgender.Size = new System.Drawing.Size(38, 20);
            this.txtgender.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 19);
            this.label5.TabIndex = 21;
            this.label5.Text = "Gender (m/f):";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(31, 208);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(221, 20);
            this.txtemail.TabIndex = 20;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(27, 186);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(56, 19);
            this.email.TabIndex = 19;
            this.email.Text = "email:";
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(31, 158);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(221, 20);
            this.txtlastname.TabIndex = 18;
            // 
            // lastName
            // 
            this.lastName.AutoSize = true;
            this.lastName.BackColor = System.Drawing.Color.Transparent;
            this.lastName.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.ForeColor = System.Drawing.Color.Black;
            this.lastName.Location = new System.Drawing.Point(27, 136);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(97, 19);
            this.lastName.TabIndex = 17;
            this.lastName.Text = "Last Name:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(31, 111);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(221, 20);
            this.txtname.TabIndex = 16;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.Location = new System.Drawing.Point(27, 89);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(59, 19);
            this.name.TabIndex = 15;
            this.name.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(171, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "Add User";
            // 
            // frm_add_one_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.backgr_small;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(284, 364);
            this.Controls.Add(this.txt_client_id);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.txtgender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.email);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frm_add_one_user";
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.frm_add_one_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_client_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.TextBox txtgender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtemail;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.Label lastName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label label2;
    }
}