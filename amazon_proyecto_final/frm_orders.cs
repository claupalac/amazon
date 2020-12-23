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
    public partial class frm_orders : Form
    {
        DataSet dst_items;
        public frm_orders()
        {
            InitializeComponent();
        }

        private void frm_orders_Load(object sender, EventArgs e)
        {
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from pedido");
            dgd_items.DataSource = dst_items;
            dgd_items.DataMember = dst_items.Tables[0].ToString();
        }

        private void most_wanted_Click(object sender, EventArgs e)
        {
            DataSet aux;
            aux = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("create view outStock as select * from Product where stock='out'");
            dst_items=GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from outStock");
            if (dst_items != null)
            {
                dgd_items.DataSource = dst_items;
                dgd_items.DataMember = dst_items.Tables[0].ToString();
            }
            else
            {
                MessageBox.Show("no existen");
            }
            
        }

        private void most_wanted_cat_Click(object sender, EventArgs e)
        {
            DataSet aux;
            aux = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("create view prueba22 as select pedidoId, count(productId) as t from pedido group by pedidoId");
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from prueba22");
            if (dst_items != null)
            {
                dgd_items.DataSource = dst_items;
                dgd_items.DataMember = dst_items.Tables[0].ToString();
            }
            else
            {
                MessageBox.Show("no existen");
            }
        }

        private void caro_Click(object sender, EventArgs e)
        {
            DataSet aux;
            aux = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("create view caros as select * from Product where price>100");
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from caros");
            if (dst_items != null)
            {
                dgd_items.DataSource = dst_items;
                dgd_items.DataMember = dst_items.Tables[0].ToString();
            }
            else
            {
                MessageBox.Show("no existen");
            }
        }

        private void barato_Click(object sender, EventArgs e)
        {
            DataSet aux;
            aux = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("create view baratos as select * from Product where price<100");
            dst_items = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from baratos");
            if (dst_items != null)
            {
                dgd_items.DataSource = dst_items;
                dgd_items.DataMember = dst_items.Tables[0].ToString();
            }
            else
            {
                MessageBox.Show("no existen");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
