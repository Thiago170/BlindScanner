using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Proyecto_BlindScanner
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnIniciaSesión_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM tbl_user WHERE username= '" + txtNomUsuario.Text + "' and password= '" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                menú menuForm = new menú();
                menuForm.UserName = txtNomUsuario.Text;
                menuForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Campo de usuario o contraseña inválido, Intente nuevamente", "Login fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNomUsuario.Text = "";
                txtContraseña.Text = "";
                txtNomUsuario.Focus();
            }
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            new frmRegistro().Show();
            this.Hide();
        }

        private void checkbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
            }
        }
    }
}
