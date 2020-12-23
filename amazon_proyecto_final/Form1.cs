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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_menu_clientes fUserMenu = new frm_menu_clientes();
            fUserMenu.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frm_add_one_user fAdduser = new frm_add_one_user();
            fAdduser.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frm_menu_seller fMenuSeller = new frm_menu_seller();
            fMenuSeller.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_products fitem = new frm_products();
            fitem.ShowDialog();
        }

        private void buy_Click(object sender, EventArgs e)
        {
            int valorId = Convert.ToInt32(txt_client_id.Text);
            string consulta = "Select * from Client where clientId =" + txt_client_id.Text;
            MessageBox.Show(consulta);
            DataSet dstCliente = new DataSet();
            dstCliente = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            if (dstCliente != null)
            {
                string client_id_num = dstCliente.Tables[0].Rows[0][0].ToString();
                client_menu cmenu = new client_menu(client_id_num);
                cmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("No existe el Cliente ID", "ERROR");
                 // equivale a this.Close(), que cierra el formulario actual
            }

        }

        private void pedido_Click(object sender, EventArgs e)
        {
            frm_orders or = new frm_orders();
            or.ShowDialog();
        }
    }
}
