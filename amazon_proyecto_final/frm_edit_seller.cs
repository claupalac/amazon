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
    public partial class frm_edit_seller : Form
    {
        DataGridView dgd_u;
        int posSelec;
        frm_menu_seller fPadre;
        public frm_edit_seller(DataGridView vdgdUser, int vposSelec, frm_menu_seller vfPadre)
        {
            dgd_u = vdgdUser;
            posSelec = vposSelec;
            fPadre = vfPadre;
            InitializeComponent();
        }

        private void frm_edit_seller_Load(object sender, EventArgs e)
        {
            txtname.Text = dgd_u.Rows[posSelec].Cells["name"].Value.ToString();
            txt_username.Text = dgd_u.Rows[posSelec].Cells["username"].Value.ToString();
            txtemail.Text = dgd_u.Rows[posSelec].Cells["email"].Value.ToString();
            txt_type.Text = dgd_u.Rows[posSelec].Cells["type"].Value.ToString();
            txt_client_id.Text = dgd_u.Rows[posSelec].Cells["sellerId"].Value.ToString();
            txt_des.Text = dgd_u.Rows[posSelec].Cells["description"].Value.ToString();
        }
     

       

        private void add_user_Click_1(object sender, EventArgs e)
        {
            int exito = 0;
            string vconsulta = "update Seller set name='" + txtname.Text + "',username='" + txt_username.Text + "',email='" + txtemail.Text + "',type='" + txt_type.Text + "',description='" + txt_des.Text + "' where sellerId=" + txt_client_id.Text.Trim();
            exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(vconsulta);

            string mje = "Se actualizaron " + exito.ToString() + " registros.";
            MessageBox.Show(mje, "Actualización exitosa");
            // actualizamos el datagrid del formulario anterior
            dgd_u.Rows[posSelec].Cells["name"].Value = txtname.Text;
            dgd_u.Rows[posSelec].Cells["username"].Value = txt_username.Text;
            // note que el índice de Cells puede ser el nombre del
            // campo o el número de campo:
            //dgdAlum.Rows[posSelec].Cells[1].Value = txtNom.Text;
            //dgdAlum.Rows[posSelec].Cells[2].Value = txtSexo.Text;
            Close();
            fPadre.Close();
            frm_menu_seller fseller = new frm_menu_seller();
            fseller.ShowDialog();
        }

        private void delete_Click_1(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Está Ud. seguro de querer borrar el registro?", "Confirmación");
            if (resp.ToString() == "OK")
            {
                int exito;
                string vconsulta = "delete from Seller where sellerId=" + txt_client_id.Text;
                exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(vconsulta);
                string mje = "Se borró " + exito + " registros";
                MessageBox.Show(mje, "Eliminación exitosa");
                // falta actualizar el datagrid
                this.Close();
                fPadre.Close();

            }
        }
    }
}
