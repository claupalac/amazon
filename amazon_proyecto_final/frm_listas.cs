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
    public partial class frm_listas : Form
    {
        DataSet dst_items;
        string client_id;
        public frm_listas(string vid)
        {
            client_id = vid;
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_listas_Load(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("Select L.productId, P.name, P.price from List L, Product P where L.name='cart' and L.productId=P.productId and L.clientId =" + client_id);

            if (dst_items != null)
            {
                dgd_lista.DataSource = dst_items;
                dgd_lista.DataMember = dst_items.Tables[0].ToString();
                order_date.Text = DateTime.UtcNow.ToString("MM-dd-yyyy");

                DateTime fecha = DateTime.Now;

                arrive_date.Text = fecha.AddDays(10).ToString("MM-dd-yyyy");

                shipping_cost.Text = "30";

                int i = 0;
                int precio_final = 0;
                while (dgd_lista.Rows[i].Cells["price"].Value != null)
                {
                    //MessageBox.Show(dgd_lista.Rows[i].Cells["price"].Value.ToString());
                    precio_final = precio_final + Convert.ToInt32(dgd_lista.Rows[i].Cells["price"].Value);
                    i++;
                }

                precio_final = precio_final + 30;

                total.Text = precio_final.ToString();

            }
            else
            {
                MessageBox.Show("Cart is Empty");
                Close();
            }

            
            



        }

        private void buy_Click(object sender, EventArgs e)
        {
            int i = 0;
            DataSet max_indice = new DataSet();           
            max_indice = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select pedidoId from pedido where clientId=" + client_id + " and pedidoId >=ALL (Select pedidoId from pedido) ");            
            string generator_id_order;
            if (max_indice == null)
            {
                generator_id_order = "0";
            }
            else
            {
                generator_id_order = max_indice.Tables[0].Rows[0][0].ToString();
                
            }
            int x = Convert.ToInt32(generator_id_order) + 1;

            //MessageBox.Show(generator_id_order);

            while (dgd_lista.Rows[i].Cells["productId"].Value != null)
            {
                string id_producto = dgd_lista.Rows[i].Cells["productId"].Value.ToString();
                string sql = "EXEC add_order " + client_id + ", " + id_producto + ", '" + x + "', '" + total.Text + "';";
                //MessageBox.Show(sql);
                int cantAlumsIngresados = GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
                i++;
            }

            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("delete from List where clientId=" + client_id + " and name='cart'");
            MessageBox.Show("Successful transaction");
            Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
   
    
        
    
    
    
    
    }





}
