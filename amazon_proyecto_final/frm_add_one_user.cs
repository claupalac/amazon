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
    public partial class frm_add_one_user : Form
    {
        public frm_add_one_user()
        {
            InitializeComponent();
        }

        private void add_user_Click(object sender, EventArgs e)
        {
            // para insertar un registro no necesitamos el dataset,
            // simplemente insertamos el texto que hemos ingresado.
            StringBuilder strInsert = new StringBuilder();
            // para probar hacemos la consulta para ingresar sólo la sigla:
            // insert into materia(sigla) values('inf-102')
            strInsert.AppendFormat("insert into Client(clientId, name, lastName, email, gender) values({0},'{1}','{2}','{3}','{4}');", txt_client_id.Text, txtname.Text, txtlastname.Text, txtemail.Text, txtgender.Text);
            //MessageBox.Show(strInsert.ToString());// para ver el sql generado
            int cantMatsInsertadas =
            GestorDeBaseDeDatos.Instance.EjecutarConsulta(strInsert.ToString());
            MessageBox.Show("se ingresó " + cantMatsInsertadas.ToString() +
            " registro(s)", "Mensaje");
            Close();

        }

        private void frm_add_one_user_Load(object sender, EventArgs e)
        {

        }
    }
}
