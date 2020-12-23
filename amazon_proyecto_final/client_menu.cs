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
    public partial class client_menu : Form
    {
        string client_id;
        DataSet dst_items;
        public client_menu(string vid)
        {
            client_id = vid;
            InitializeComponent();
        }

        private void client_menu_Load(object sender, EventArgs e)
        {
            string consulta = "Select clientId, name, lastName, email, balance from Client where clientId = " + client_id;
            DataSet dstCliente = new DataSet();
            dstCliente = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);

            if (dstCliente != null)
            {
                id_lb.Text = dstCliente.Tables[0].Rows[0][0].ToString();
                name_lb.Text = dstCliente.Tables[0].Rows[0][1].ToString() + dstCliente.Tables[0].Rows[0][2].ToString();
                email_lb.Text = dstCliente.Tables[0].Rows[0][3].ToString();
                balance_lb.Text = dstCliente.Tables[0].Rows[0][4].ToString();
                

            }
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void clothes_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='clothes'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void jewerly_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='jewerly'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void electronics_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='electronics'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();

        }

        private void sports_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='sports'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();

        }

        private void office_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='office'");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void house_Click(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select productId,name,stock,price from Product where category='house'or category='living' ");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

    

        private void label4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgd_items_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int posSel = e.RowIndex;
            frm_item_select fEditUser = new frm_item_select(dgd_items, posSel, this, client_id);
            fEditUser.ShowDialog();
        }

        private void name_lb_Click(object sender, EventArgs e)
        {

        }

        private void cart_Click(object sender, EventArgs e)
        {
            frm_listas carrito = new frm_listas(client_id);
            carrito.ShowDialog();
        }
    }
}
