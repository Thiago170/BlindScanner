
namespace Proyecto_BlindScanner
{
    partial class frmRegistro
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRegistrarse = new System.Windows.Forms.Label();
            this.lblNomUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblPreg = new System.Windows.Forms.Label();
            this.lblCambiar = new System.Windows.Forms.Label();
            this.txtNomUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.lblConfContraseña = new System.Windows.Forms.Label();
            this.txtConfContraseña = new System.Windows.Forms.TextBox();
            this.checkbxMC = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblRegistrarse
            // 
            this.lblRegistrarse.AutoSize = true;
            this.lblRegistrarse.Location = new System.Drawing.Point(70, 35);
            this.lblRegistrarse.Name = "lblRegistrarse";
            this.lblRegistrarse.Size = new System.Drawing.Size(57, 13);
            this.lblRegistrarse.TabIndex = 0;
            this.lblRegistrarse.Text = "Regístrate";
            // 
            // lblNomUsuario
            // 
            this.lblNomUsuario.AutoSize = true;
            this.lblNomUsuario.Location = new System.Drawing.Point(67, 84);
            this.lblNomUsuario.Name = "lblNomUsuario";
            this.lblNomUsuario.Size = new System.Drawing.Size(101, 13);
            this.lblNomUsuario.TabIndex = 1;
            this.lblNomUsuario.Text = "Nombre de Usuario:";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(67, 177);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 2;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblPreg
            // 
            this.lblPreg.AutoSize = true;
            this.lblPreg.Location = new System.Drawing.Point(67, 373);
            this.lblPreg.Name = "lblPreg";
            this.lblPreg.Size = new System.Drawing.Size(114, 13);
            this.lblPreg.TabIndex = 3;
            this.lblPreg.Text = "Ya tienes una cuenta?";
            // 
            // lblCambiar
            // 
            this.lblCambiar.AutoSize = true;
            this.lblCambiar.Location = new System.Drawing.Point(70, 407);
            this.lblCambiar.Name = "lblCambiar";
            this.lblCambiar.Size = new System.Drawing.Size(67, 13);
            this.lblCambiar.TabIndex = 4;
            this.lblCambiar.Text = "Inicia Sesión";
            this.lblCambiar.Click += new System.EventHandler(this.lblCambiar_Click);
            // 
            // txtNomUsuario
            // 
            this.txtNomUsuario.Location = new System.Drawing.Point(68, 109);
            this.txtNomUsuario.Name = "txtNomUsuario";
            this.txtNomUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtNomUsuario.TabIndex = 5;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(68, 193);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '●';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 6;
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(68, 307);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(100, 51);
            this.btnRegistrarse.TabIndex = 7;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // lblConfContraseña
            // 
            this.lblConfContraseña.AutoSize = true;
            this.lblConfContraseña.Location = new System.Drawing.Point(67, 230);
            this.lblConfContraseña.Name = "lblConfContraseña";
            this.lblConfContraseña.Size = new System.Drawing.Size(110, 13);
            this.lblConfContraseña.TabIndex = 8;
            this.lblConfContraseña.Text = "Confirmar contraseña:";
            // 
            // txtConfContraseña
            // 
            this.txtConfContraseña.Location = new System.Drawing.Point(68, 246);
            this.txtConfContraseña.Name = "txtConfContraseña";
            this.txtConfContraseña.PasswordChar = '●';
            this.txtConfContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtConfContraseña.TabIndex = 9;
            // 
            // checkbxMC
            // 
            this.checkbxMC.AutoSize = true;
            this.checkbxMC.Location = new System.Drawing.Point(198, 274);
            this.checkbxMC.Name = "checkbxMC";
            this.checkbxMC.Size = new System.Drawing.Size(117, 17);
            this.checkbxMC.TabIndex = 10;
            this.checkbxMC.Text = "Mostrar contraseña";
            this.checkbxMC.UseVisualStyleBackColor = true;
            this.checkbxMC.CheckedChanged += new System.EventHandler(this.checkbxMC_CheckedChanged);
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 458);
            this.Controls.Add(this.checkbxMC);
            this.Controls.Add(this.txtConfContraseña);
            this.Controls.Add(this.lblConfContraseña);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNomUsuario);
            this.Controls.Add(this.lblCambiar);
            this.Controls.Add(this.lblPreg);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblNomUsuario);
            this.Controls.Add(this.lblRegistrarse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistro";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRegistrarse;
        private System.Windows.Forms.Label lblNomUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblPreg;
        private System.Windows.Forms.Label lblCambiar;
        private System.Windows.Forms.TextBox txtNomUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Label lblConfContraseña;
        private System.Windows.Forms.TextBox txtConfContraseña;
        private System.Windows.Forms.CheckBox checkbxMC;
    }
}

