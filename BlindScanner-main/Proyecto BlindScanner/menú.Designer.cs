
namespace Proyecto_BlindScanner
{
    partial class menú
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.btnAlarmasActivas = new System.Windows.Forms.Button();
            this.btnListasActivas = new System.Windows.Forms.Button();
            this.btnConfiguracion = new System.Windows.Forms.Button();
            this.btnAcercaApp = new System.Windows.Forms.Button();
            this.btnCalendario = new System.Windows.Forms.Button();
            this.btnProductos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(102, 63);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(31, 13);
            this.lblNomUsuario.TabIndex = 0;
            this.lblNomUsuario.Text = "aaaa";
            this.lblNomUsuario.Click += new System.EventHandler(this.lblNomUsuario_Click);
            // 
            // btnAlarmasActivas
            // 
            this.btnAlarmasActivas.Location = new System.Drawing.Point(105, 133);
            this.btnAlarmasActivas.Name = "btnAlarmasActivas";
            this.btnAlarmasActivas.Size = new System.Drawing.Size(133, 25);
            this.btnAlarmasActivas.TabIndex = 1;
            this.btnAlarmasActivas.Text = "Alarmas activas";
            this.btnAlarmasActivas.UseVisualStyleBackColor = true;
            this.btnAlarmasActivas.Click += new System.EventHandler(this.btnAlarmasActivas_Click);
            // 
            // btnListasActivas
            // 
            this.btnListasActivas.Location = new System.Drawing.Point(105, 178);
            this.btnListasActivas.Name = "btnListasActivas";
            this.btnListasActivas.Size = new System.Drawing.Size(133, 28);
            this.btnListasActivas.TabIndex = 2;
            this.btnListasActivas.Text = "Listas activas";
            this.btnListasActivas.UseVisualStyleBackColor = true;
            this.btnListasActivas.Click += new System.EventHandler(this.btnListasActivas_Click);
            // 
            // btnConfiguracion
            // 
            this.btnConfiguracion.Location = new System.Drawing.Point(105, 226);
            this.btnConfiguracion.Name = "btnConfiguracion";
            this.btnConfiguracion.Size = new System.Drawing.Size(133, 27);
            this.btnConfiguracion.TabIndex = 3;
            this.btnConfiguracion.Text = "Configuración";
            this.btnConfiguracion.UseVisualStyleBackColor = true;
            this.btnConfiguracion.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnAcercaApp
            // 
            this.btnAcercaApp.Location = new System.Drawing.Point(105, 275);
            this.btnAcercaApp.Name = "btnAcercaApp";
            this.btnAcercaApp.Size = new System.Drawing.Size(133, 33);
            this.btnAcercaApp.TabIndex = 4;
            this.btnAcercaApp.Text = "Acerca de la app";
            this.btnAcercaApp.UseVisualStyleBackColor = true;
            this.btnAcercaApp.Click += new System.EventHandler(this.btnAcercaApp_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.Location = new System.Drawing.Point(306, 326);
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(75, 23);
            this.btnCalendario.TabIndex = 5;
            this.btnCalendario.Text = "Calendario";
            this.btnCalendario.UseVisualStyleBackColor = true;
            this.btnCalendario.Click += new System.EventHandler(this.btnCalendario_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.Location = new System.Drawing.Point(440, 326);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(75, 23);
            this.btnProductos.TabIndex = 6;
            this.btnProductos.Text = "Productos";
            this.btnProductos.UseVisualStyleBackColor = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // menú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 643);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnCalendario);
            this.Controls.Add(this.btnAcercaApp);
            this.Controls.Add(this.btnConfiguracion);
            this.Controls.Add(this.btnListasActivas);
            this.Controls.Add(this.btnAlarmasActivas);
            this.Controls.Add(this.lblNomUsuario);
            this.Name = "menú";
            this.Text = "menú";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Button btnAlarmasActivas;
        private System.Windows.Forms.Button btnListasActivas;
        private System.Windows.Forms.Button btnConfiguracion;
        private System.Windows.Forms.Button btnAcercaApp;
        private System.Windows.Forms.Button btnCalendario;
        private System.Windows.Forms.Button btnProductos;
    }
}