namespace amazon_proyecto_final
{
    partial class frm_menu_clientes
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
            this.dgdUsers = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.add_user = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgdUsers
            // 
            this.dgdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUsers.Location = new System.Drawing.Point(54, 149);
            this.dgdUsers.Name = "dgdUsers";
            this.dgdUsers.Size = new System.Drawing.Size(643, 465);
            this.dgdUsers.TabIndex = 0;
            this.dgdUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdUsers_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(200, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "User name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(306, 32);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(250, 21);
            this.txt_user.TabIndex = 2;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(579, 29);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(61, 25);
            this.search.TabIndex = 3;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.White;
            this.add_user.Location = new System.Drawing.Point(218, 78);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(105, 31);
            this.add_user.TabIndex = 4;
            this.add_user.Text = "Add User";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // frm_menu_clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_search;
            this.ClientSize = new System.Drawing.Size(751, 639);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdUsers);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frm_menu_clientes";
            this.Text = "frm_menu_clientes";
            this.Load += new System.EventHandler(this.frm_menu_clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgdUsers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button add_user;
    }
}