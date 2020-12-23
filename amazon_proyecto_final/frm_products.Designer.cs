namespace amazon_proyecto_final
{
    partial class frm_products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_products));
            this.dgd_items = new System.Windows.Forms.DataGridView();
            this.clothes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.electronics = new System.Windows.Forms.Button();
            this.jewerly = new System.Windows.Forms.Button();
            this.sports = new System.Windows.Forms.Button();
            this.office = new System.Windows.Forms.Button();
            this.house = new System.Windows.Forms.Button();
            this.txt_cat_active = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_items)).BeginInit();
            this.SuspendLayout();
            // 
            // dgd_items
            // 
            this.dgd_items.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgd_items.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.dgd_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgd_items.ColumnHeadersHeight = 25;
            this.dgd_items.GridColor = System.Drawing.Color.Black;
            this.dgd_items.Location = new System.Drawing.Point(250, 110);
            this.dgd_items.Name = "dgd_items";
            this.dgd_items.Size = new System.Drawing.Size(550, 450);
            this.dgd_items.TabIndex = 0;
            // 
            // clothes
            // 
            this.clothes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.clothes.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.clothes.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clothes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clothes.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clothes.ForeColor = System.Drawing.Color.Transparent;
            this.clothes.Location = new System.Drawing.Point(0, 110);
            this.clothes.Name = "clothes";
            this.clothes.Size = new System.Drawing.Size(250, 50);
            this.clothes.TabIndex = 1;
            this.clothes.Text = "Clothes";
            this.clothes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clothes.UseVisualStyleBackColor = false;
            this.clothes.Click += new System.EventHandler(this.clothes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(326, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Items/Productos";
            // 
            // electronics
            // 
            this.electronics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.electronics.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.electronics.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.electronics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.electronics.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electronics.ForeColor = System.Drawing.Color.Transparent;
            this.electronics.Location = new System.Drawing.Point(0, 210);
            this.electronics.Name = "electronics";
            this.electronics.Size = new System.Drawing.Size(250, 50);
            this.electronics.TabIndex = 5;
            this.electronics.Text = "Electronics";
            this.electronics.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.electronics.UseVisualStyleBackColor = false;
            this.electronics.Click += new System.EventHandler(this.electronics_Click);
            // 
            // jewerly
            // 
            this.jewerly.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.jewerly.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.jewerly.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.jewerly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jewerly.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jewerly.ForeColor = System.Drawing.Color.Transparent;
            this.jewerly.Location = new System.Drawing.Point(0, 160);
            this.jewerly.Name = "jewerly";
            this.jewerly.Size = new System.Drawing.Size(250, 50);
            this.jewerly.TabIndex = 6;
            this.jewerly.Text = "Jewerly";
            this.jewerly.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.jewerly.UseVisualStyleBackColor = false;
            this.jewerly.Click += new System.EventHandler(this.jewerly_Click);
            // 
            // sports
            // 
            this.sports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.sports.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.sports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sports.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sports.ForeColor = System.Drawing.Color.Transparent;
            this.sports.Location = new System.Drawing.Point(0, 310);
            this.sports.Name = "sports";
            this.sports.Size = new System.Drawing.Size(250, 50);
            this.sports.TabIndex = 9;
            this.sports.Text = "Sports";
            this.sports.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sports.UseVisualStyleBackColor = false;
            this.sports.Click += new System.EventHandler(this.sports_Click);
            // 
            // office
            // 
            this.office.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.office.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.office.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.office.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.office.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.office.ForeColor = System.Drawing.Color.Transparent;
            this.office.Location = new System.Drawing.Point(0, 360);
            this.office.Name = "office";
            this.office.Size = new System.Drawing.Size(250, 50);
            this.office.TabIndex = 8;
            this.office.Text = "Office";
            this.office.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.office.UseVisualStyleBackColor = false;
            this.office.Click += new System.EventHandler(this.office_Click);
            // 
            // house
            // 
            this.house.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.house.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_1;
            this.house.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.house.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.house.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.house.ForeColor = System.Drawing.Color.Transparent;
            this.house.Location = new System.Drawing.Point(0, 260);
            this.house.Name = "house";
            this.house.Size = new System.Drawing.Size(250, 50);
            this.house.TabIndex = 7;
            this.house.Text = "House and Living";
            this.house.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.house.UseVisualStyleBackColor = false;
            this.house.Click += new System.EventHandler(this.house_Click);
            // 
            // txt_cat_active
            // 
            this.txt_cat_active.AutoSize = true;
            this.txt_cat_active.BackColor = System.Drawing.Color.Transparent;
            this.txt_cat_active.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cat_active.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txt_cat_active.Location = new System.Drawing.Point(557, 72);
            this.txt_cat_active.Name = "txt_cat_active";
            this.txt_cat_active.Size = new System.Drawing.Size(0, 35);
            this.txt_cat_active.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(738, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 44);
            this.label2.TabIndex = 11;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // frm_products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_search;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_cat_active);
            this.Controls.Add(this.sports);
            this.Controls.Add(this.office);
            this.Controls.Add(this.house);
            this.Controls.Add(this.jewerly);
            this.Controls.Add(this.electronics);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clothes);
            this.Controls.Add(this.dgd_items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_products";
            this.Text = "Items";
            this.Load += new System.EventHandler(this.frm_products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_items)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgd_items;
        private System.Windows.Forms.Button clothes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button electronics;
        private System.Windows.Forms.Button jewerly;
        private System.Windows.Forms.Button sports;
        private System.Windows.Forms.Button office;
        private System.Windows.Forms.Button house;
        private System.Windows.Forms.Label txt_cat_active;
        private System.Windows.Forms.Label label2;
    }
}