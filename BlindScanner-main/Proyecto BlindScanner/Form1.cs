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
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            if (txtNomUsuario.Text == "" && txtContraseña.Text == "" && txtConfContraseña.Text == "")
            {
                MessageBox.Show("Campos de usuario y contraseña están incompletos", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (txtContraseña.Text == txtConfContraseña.Text)
            {
                con.Open();
                string register = "INSERT INTO tbl_user VALUES ('" + txtNomUsuario.Text + "','" + txtContraseña.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtNomUsuario.Text = "";
                txtContraseña.Text = "";
                txtConfContraseña.Text = "";

                MessageBox.Show("Tu cuenta ha sido creada exitosamente", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Las contraseñas no son iguales , Por favor, reescríbalas ", "Registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContraseña.Text = "";
                txtConfContraseña.Text = "";
                txtContraseña.Focus();
            }
        }

        private void lblCambiar_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }

        private void checkbxMC_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbxMC.Checked)
            {
                txtContraseña.PasswordChar = '\0';
                txtConfContraseña.PasswordChar = '\0';
            }
            else
            {
                txtContraseña.PasswordChar = '•';
                txtConfContraseña.PasswordChar = '•';
            }
        }
    }
}
