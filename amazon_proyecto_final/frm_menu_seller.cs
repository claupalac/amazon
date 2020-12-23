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
    public partial class frm_menu_seller : Form
    {
        DataSet dst_user;
        public frm_menu_seller()
        {
            InitializeComponent();
        }

        private void frm_menu_seller_Load(object sender, EventArgs e)
        {
            dst_user = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect("select * from Seller");
            dgdUsers.DataSource = dst_user;
            dgdUsers.DataMember = dst_user.Tables[0].ToString();
        }

        private void search_Click(object sender, EventArgs e)
        {
            string sql = "select * from Seller where name like '" + txt_user.Text + "%'"; // si no funciona % use * string sql = "select * from alumno where nom = '" + txtAlumno.Text + "'";
            dst_user = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdUsers.DataSource = dst_user;
                dgdUsers.DataMember = dst_user.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            frm_add_seller fIngresarUnUsuario = new frm_add_seller();
            fIngresarUnUsuario.ShowDialog();
            this.Close();
            this.Dispose();
        }

        

        private void search_Click_1(object sender, EventArgs e)
        {
            string sql = "select * from Seller where name like '" + txt_user.Text + "%'"; // si no funciona % use * string sql = "select * from alumno where nom = '" + txtAlumno.Text + "'";
            dst_user = GestorDeBaseDeDatos.Instance.EjecutarConsultaSelect(sql);
            try
            {
                dgdUsers.DataSource = dst_user;
                dgdUsers.DataMember = dst_user.Tables[0].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void dgdUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int posSel = e.RowIndex;
            frm_edit_seller fEditUser = new frm_edit_seller(dgdUsers, posSel, this);
            fEditUser.ShowDialog();
        }
    }
}
