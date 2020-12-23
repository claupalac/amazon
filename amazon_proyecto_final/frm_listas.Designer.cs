namespace amazon_proyecto_final
{
    partial class frm_listas
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
            this.label5 = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.Button();
            this.dgd_lista = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.shipping_cost = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.order_date = new System.Windows.Forms.Label();
            this.arrive_date = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgd_lista)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(282, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 35);
            this.label5.TabIndex = 59;
            this.label5.Text = "CART";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // buy
            // 
            this.buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(47)))), ((int)(((byte)(62)))));
            this.buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buy.Font = new System.Drawing.Font("Helvetica", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy.ForeColor = System.Drawing.Color.White;
            this.buy.Location = new System.Drawing.Point(369, 460);
            this.buy.Name = "buy";
            this.buy.Size = new System.Drawing.Size(221, 57);
            this.buy.TabIndex = 60;
            this.buy.Text = "BUY";
            this.buy.UseVisualStyleBackColor = false;
            this.buy.Click += new System.EventHandler(this.buy_Click);
            // 
            // dgd_lista
            // 
            this.dgd_lista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgd_lista.Location = new System.Drawing.Point(12, 95);
            this.dgd_lista.Name = "dgd_lista";
            this.dgd_lista.Size = new System.Drawing.Size(331, 422);
            this.dgd_lista.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(373, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 35);
            this.label1.TabIndex = 62;
            this.label1.Text = "Shipping:";
            // 
            // shipping_cost
            // 
            this.shipping_cost.AutoSize = true;
            this.shipping_cost.BackColor = System.Drawing.Color.Transparent;
            this.shipping_cost.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shipping_cost.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.shipping_cost.Location = new System.Drawing.Point(511, 263);
            this.shipping_cost.Name = "shipping_cost";
            this.shipping_cost.Size = new System.Drawing.Size(79, 35);
            this.shipping_cost.TabIndex = 63;
            this.shipping_cost.Text = "0000";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.BackColor = System.Drawing.Color.Transparent;
            this.total.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.total.Location = new System.Drawing.Point(428, 368);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(79, 35);
            this.total.TabIndex = 65;
            this.total.Text = "0000";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(373, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 35);
            this.label4.TabIndex = 64;
            this.label4.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(363, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 35);
            this.label2.TabIndex = 66;
            this.label2.Text = "Order Date:";
            // 
            // order_date
            // 
            this.order_date.AutoSize = true;
            this.order_date.BackColor = System.Drawing.Color.Transparent;
            this.order_date.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.order_date.Location = new System.Drawing.Point(363, 130);
            this.order_date.Name = "order_date";
            this.order_date.Size = new System.Drawing.Size(127, 35);
            this.order_date.TabIndex = 67;
            this.order_date.Text = "00/00/00";
            // 
            // arrive_date
            // 
            this.arrive_date.AutoSize = true;
            this.arrive_date.BackColor = System.Drawing.Color.Transparent;
            this.arrive_date.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrive_date.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.arrive_date.Location = new System.Drawing.Point(363, 200);
            this.arrive_date.Name = "arrive_date";
            this.arrive_date.Size = new System.Drawing.Size(127, 35);
            this.arrive_date.TabIndex = 69;
            this.arrive_date.Text = "00/00/00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(363, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 35);
            this.label7.TabIndex = 68;
            this.label7.Text = "Arrive:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Helvetica", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(566, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 35);
            this.label3.TabIndex = 70;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // frm_listas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::amazon_proyecto_final.Properties.Resources.backgr_small;
            this.ClientSize = new System.Drawing.Size(602, 529);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.arrive_date);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.order_date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.shipping_cost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgd_lista);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_listas";
            this.Text = "frm_listas";
            this.Load += new System.EventHandler(this.frm_listas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgd_lista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buy;
        private System.Windows.Forms.DataGridView dgd_lista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shipping_cost;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label order_date;
        private System.Windows.Forms.Label arrive_date;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
    }
}