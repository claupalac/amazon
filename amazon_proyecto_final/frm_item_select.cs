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
    public partial class frm_item_select : Form
    {
        DataGridView dgdAux;
        int posSelec;
        client_menu fPadre;
        string client_id;
        string stock;
        public frm_item_select(DataGridView vdgdUser, int vposSelec, client_menu vfPadre, string vclientid)
        {
            dgdAux = vdgdUser;
            posSelec = vposSelec;
            fPadre = vfPadre;
            client_id = vclientid;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frm_item_select_Load(object sender, EventArgs e)
        {
            string consulta = "Select * from Product where productId = " + dgdAux.Rows[posSelec].Cells["productId"].Value;
            DataSet dstCliente = new DataSet();
            
            dstCliente = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            if (dstCliente != null)
            {
                itemName.Text = dstCliente.Tables[0].Rows[0][1].ToString();
                lbPrice.Text = dstCliente.Tables[0].Rows[0][4].ToString();
                txtStock.Text = dstCliente.Tables[0].Rows[0][3].ToString();
                txtDescr.Text = dstCliente.Tables[0].Rows[0][2].ToString();
                txtSellerId.Text = dstCliente.Tables[0].Rows[0][7].ToString();



            }

            





            /*
            string consulta = "Select * from Product where name = " + dgdAux.Rows[posSelec].Cells["name"].Value.ToString();
            MessageBox.Show(consulta);
            DataSet dstCliente = new DataSet();
            dstCliente = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(consulta);
            if (dstCliente != null)
            {
                lbPrice.Text = dstCliente.Tables[0].Rows[0][4].ToString();
                itemName.Text = dstCliente.Tables[0].Rows[0][1].ToString() + ' ' + dstCliente.Tables[0].Rows[0][2].ToString();
                txtSellerId.Text = dstCliente.Tables[0].Rows[0][7].ToString();
                txtStock.Text = dstCliente.Tables[0].Rows[0][3].ToString();


            }


            lbPrice.Text = dgdAux.Rows[posSelec].Cells["price"].Value.ToString();
            itemName.Text = dgdAux.Rows[posSelec].Cells["name"].Value.ToString();
            //txtSellerId.Text = dgdAux.Rows[posSelec].Cells["sellerId"].Value.ToString();
            //txtDescr.Text = dgdAux.Rows[posSelec].Cells["description"].Value.ToString();
            txtStock.Text = dgdAux.Rows[posSelec].Cells["stock"].Value.ToString();
            */
        }

        private void add_user_Click(object sender, EventArgs e)
        {

            string[] vec = txtStock.Text.Split(' ');
            if (vec[0] == "out")
            {
                MessageBox.Show("Mana kanchu");
                Close();





                
            }

            else
            {
                StringBuilder strInsert = new StringBuilder();
                strInsert.AppendFormat("insert into List(listId, name, type, clientId, productId) values('" + client_id + "001' , 'cart', 'private', '" + client_id + "'," + dgdAux.Rows[posSelec].Cells["productId"].Value + ")");
                int cantMatsInsertadas = GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
                MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() + " registro(s)", "Mensaje");
                Close();


            }

        }
    }
}
