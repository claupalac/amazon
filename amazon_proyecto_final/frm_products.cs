using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace amazon_proyecto_final
{
    public partial class frm_products : Form
    {
        DataSet dst_items;
        public frm_products()
        {
            InitializeComponent();
        }

        private void frm_products_Load(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clothes_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='clothes'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void jewerly_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='jewerly'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void electronics_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='electronics'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();

        }

        private void house_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='house'or category='living' ");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();

        }

        private void sports_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='sports'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void office_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select name,stock,price from Product where category='office'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }
    }
}
