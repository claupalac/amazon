namespace amazon_proyecto_final
{
    partial class frm_orders
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
            this.button1 = new System.Windows.Forms.Button();
            this.most_wanted = new System.Windows.Forms.Button();
            this.most_wanted_cat = new System.Windows.Forms.Button();
            this.caro = new System.Windows.Forms.Button();
            this.barato = new System.Windows.Forms.Button();
            this.dgd_items = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_items)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(785, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // most_wanted
            // 
            this.most_wanted.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.most_wanted.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.most_wanted.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.most_wanted.ForeColor = System.Drawing.Color.White;
            this.most_wanted.Location = new System.Drawing.Point(0, 100);
            this.most_wanted.Name = "most_wanted";
            this.most_wanted.Size = new System.Drawing.Size(155, 31);
            this.most_wanted.TabIndex = 24;
            this.most_wanted.Text = "Items Out of stock";
            this.most_wanted.UseVisualStyleBackColor = false;
            this.most_wanted.Click += new System.EventHandler(this.most_wanted_Click);
            // 
            // most_wanted_cat
            // 
            this.most_wanted_cat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.most_wanted_cat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.most_wanted_cat.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.most_wanted_cat.ForeColor = System.Drawing.Color.White;
            this.most_wanted_cat.Location = new System.Drawing.Point(161, 100);
            this.most_wanted_cat.Name = "most_wanted_cat";
            this.most_wanted_cat.Size = new System.Drawing.Size(212, 31);
            this.most_wanted_cat.TabIndex = 25;
            this.most_wanted_cat.Text = "Numero de productos por pedido";
            this.most_wanted_cat.UseVisualStyleBackColor = false;
            this.most_wanted_cat.Click += new System.EventHandler(this.most_wanted_cat_Click);
            // 
            // caro
            // 
            this.caro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.caro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caro.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caro.ForeColor = System.Drawing.Color.White;
            this.caro.Location = new System.Drawing.Point(379, 100);
            this.caro.Name = "caro";
            this.caro.Size = new System.Drawing.Size(189, 31);
            this.caro.TabIndex = 26;
            this.caro.Text = "Most expensive Products";
            this.caro.UseVisualStyleBackColor = false;
            this.caro.Click += new System.EventHandler(this.caro_Click);
            // 
            // barato
            // 
            this.barato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.barato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.barato.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barato.ForeColor = System.Drawing.Color.White;
            this.barato.Location = new System.Drawing.Point(574, 100);
            this.barato.Name = "barato";
            this.barato.Size = new System.Drawing.Size(189, 31);
            this.barato.TabIndex = 27;
            this.barato.Text = "Cheapest Products";
            this.barato.UseVisualStyleBackColor = false;
            this.barato.Click += new System.EventHandler(this.barato_Click);
            // 
            // dgd_items
            // 
            this.dgd_items.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgd_items.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgd_items.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_items.Location = new System.Drawing.Point(12, 137);
            this.dgd_items.Name = "dgd_items";
            this.dgd_items.Size = new System.Drawing.Size(839, 445);
            this.dgd_items.TabIndex = 28;
            // 
            // frm_orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.background_search;
            this.ClientSize = new System.Drawing.Size(863, 594);
            this.Controls.Add(this.dgd_items);
            this.Controls.Add(this.barato);
            this.Controls.Add(this.caro);
            this.Controls.Add(this.most_wanted_cat);
            this.Controls.Add(this.most_wanted);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_orders";
            this.Text = "frm_orders";
            this.Load += new System.EventHandler(this.frm_orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_items)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button most_wanted;
        private System.Windows.Forms.Button most_wanted_cat;
        private System.Windows.Forms.Button caro;
        private System.Windows.Forms.Button barato;
        private System.Windows.Forms.DataGridView dgd_items;
    }
}