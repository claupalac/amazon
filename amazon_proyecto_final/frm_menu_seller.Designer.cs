namespace amazon_proyecto_final
{
    partial class frm_menu_seller
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
            this.add_user = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgdUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // add_user
            // 
            this.add_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.add_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_user.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_user.ForeColor = System.Drawing.Color.White;
            this.add_user.Location = new System.Drawing.Point(192, 79);
            this.add_user.Name = "add_user";
            this.add_user.Size = new System.Drawing.Size(105, 31);
            this.add_user.TabIndex = 9;
            this.add_user.Text = "Add Seller";
            this.add_user.UseVisualStyleBackColor = false;
            this.add_user.Click += new System.EventHandler(this.add_user_Click);
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(577, 31);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(61, 25);
            this.search.TabIndex = 8;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click_1);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(304, 34);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(250, 20);
            this.txt_user.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(198, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seller name:";
            // 
            // dgdUsers
            // 
            this.dgdUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdUsers.Location = new System.Drawing.Point(58, 146);
            this.dgdUsers.Name = "dgdUsers";
            this.dgdUsers.Size = new System.Drawing.Size(643, 465);
            this.dgdUsers.TabIndex = 5;
            this.dgdUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgdUsers_CellContentClick_1);
            // 
            // frm_menu_seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_search;
            this.ClientSize = new System.Drawing.Size(780, 634);
            this.Controls.Add(this.add_user);
            this.Controls.Add(this.search);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgdUsers);
            this.Name = "frm_menu_seller";
            this.Text = "frm_menu_seller";
            this.Load += new System.EventHandler(this.frm_menu_seller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgdUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_user;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgdUsers;
    }
}