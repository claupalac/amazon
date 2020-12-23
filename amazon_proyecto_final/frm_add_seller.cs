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
    public partial class frm_add_seller : Form
    {
        public frm_add_seller()
        {
            InitializeComponent();
        }

        private void frm_add_seller_Load(object sender, EventArgs e)
        {
            
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            string sql = "insert into Seller(sellerId, name, username, email, description, type)" + "values(" + txt_client_id.Text + ",'" + txtname.Text + "','" + txt_username.Text + "','" + txtemail.Text + "','" + txt_type.Text + "','" + txt_des.Text + "')";
            int cantAlumsIngresados = GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
            this.Close();
            this.Dispose();
            frm_menu_seller f_menuUser = new frm_menu_seller();
            f_menuUser.ShowDialog();
        }
    }
}
