using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BlindScanner
{
    public partial class menú : Form
    {
        public string UserName;
        public menú()
        {
            InitializeComponent();
        }
        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            lblNomUsuario.Text = UserName;
        }
        
        private void btnAlarmasActivas_Click(object sender, EventArgs e)
        {
            Form form = new Alarmas_activas();
            form.Show();
            this.Close();
        }

        private void btnListasActivas_Click(object sender, EventArgs e)
        {
            Form form = new Listas_activas();
            form.Show();
            this.Close();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            Form form = new Configuración();
            form.Show();
            this.Close();
        }

        private void btnAcercaApp_Click(object sender, EventArgs e)
        {
            Form form = new AcercaApp();
            form.Show();
            this.Close();
        }

        private void btnCalendario_Click(object sender, EventArgs e)
        {
            Form form = new Calendario();
            form.Show();
            this.Close();
        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            Form form = new Productos();
            form.Show();
            this.Close();
        }

        private void lblNomUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
