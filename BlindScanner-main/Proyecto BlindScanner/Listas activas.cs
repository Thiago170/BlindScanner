﻿using System;
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
    public partial class Listas_activas : Form
    {
        public Listas_activas()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form menuForm = new menú();
            menuForm.Show();
            this.Hide();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            new ListasCreador().Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
