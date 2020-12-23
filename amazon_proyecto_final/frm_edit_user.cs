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
    public partial class frm_edit_user : Form
    {
        DataGridView dgd_u;
        int posSelec;
        frm_menu_clientes fPadre;

        public frm_edit_user(DataGridView vdgdUser, int vposSelec, frm_menu_clientes vfPadre)
        {
            dgd_u = vdgdUser;
            posSelec = vposSelec;
            fPadre = vfPadre;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frm_edit_user_Load(object sender, EventArgs e)
        {
            txtname.Text = dgd_u.Rows[posSelec].Cells["name"].Value.ToString();
            txtlastname.Text = dgd_u.Rows[posSelec].Cells["lastName"].Value.ToString();
            txtemail.Text = dgd_u.Rows[posSelec].Cells["email"].Value.ToString();
            txtgender.Text = dgd_u.Rows[posSelec].Cells["gender"].Value.ToString();
            txt_client_id.Text = dgd_u.Rows[posSelec].Cells["clientId"].Value.ToString();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            int exito = 0;
            string vconsulta = "update Client set name='" + txtname.Text + "',lastName='" + txtlastname.Text + "',email='" + txtemail.Text + "',gender='" + txtgender.Text + "' where clientId=" + txt_client_id.Text.Trim();
            exito = GestorDeBaseDeDatos.Instance.EjecutarConsulta(vconsulta);

            string mje = "Se actualizaron " + exito.ToString() + " registros.";
            MessageBox.Show(mje, "Actualización exitosa");
            // actualizamos el datagrid del formulario anterior
            dgd_u.Rows[posSelec].Cells["name"].Value = txtname.Text;
            dgd_u.Rows[posSelec].Cells["lastName"].Value = txtlastname.Text;
            // note que el índice de Cells puede ser el nombre del
            // campo o el número de campo:
            //dgdAlum.Rows[posSelec].Cells[1].Value = txtNom.Text;
            //dgdAlum.Rows[posSelec].Cells[2].Value = txtSexo.Text;
            Close();

        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult resp;
            resp = MessageBox.Show("Está Ud. seguro de querer borrar el registro?", "Confirmación");
            if (resp.ToString() == "OK")
            {
                int exito;
                string vconsulta = "delete from Client where clientId=" + txt_client_id.Text;
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
