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
    public partial class frm_add_user : Form
    {
        public frm_add_user()
        {
            InitializeComponent();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            string sql = "insert into Client(clientId,name,lastName,email,gender)" + "values(" + txt_client_id.Text +",'" + txtname.Text + "','" + txtlastname.Text + "','" + txtemail.Text + "','" + txtgender.Text + "')";
            int cantAlumsIngresados = GestorDeBaseDeDatos.Instance.EjecutarConsulta(sql);
            this.Close();
            this.Dispose();
            frm_menu_clientes f_menuUser = new frm_menu_clientes();
            f_menuUser.ShowDialog();
        }

        private void frm_add_user_Load(object sender, EventArgs e)
        {

        }
    }
}
