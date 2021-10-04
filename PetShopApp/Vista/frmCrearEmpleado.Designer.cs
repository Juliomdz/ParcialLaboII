
namespace Vista
{
    partial class frmCrearEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCrearEmpleado));
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRepetirPassword = new System.Windows.Forms.Label();
            this.txtbReingresePassword = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAceptar.FlatAppearance.BorderSize = 5;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.LightYellow;
            this.btnAceptar.Location = new System.Drawing.Point(254, 382);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(107, 28);
            this.btnAceptar.TabIndex = 0;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUser.Location = new System.Drawing.Point(188, 252);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PlaceholderText = "Ingrese el Usuario";
            this.txtbUser.Size = new System.Drawing.Size(173, 26);
            this.txtbUser.TabIndex = 1;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(188, 302);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '¿';
            this.txtbPassword.PlaceholderText = "Ingrese la Contraseña";
            this.txtbPassword.Size = new System.Drawing.Size(173, 26);
            this.txtbPassword.TabIndex = 2;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(188, 231);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 18);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Nombre de Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(188, 281);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(12, 209);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(316, 19);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "SE VA A DAR DE ALTA UN NUEVO EMPLEADO.";
            // 
            // lblRepetirPassword
            // 
            this.lblRepetirPassword.AutoSize = true;
            this.lblRepetirPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRepetirPassword.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepetirPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRepetirPassword.Location = new System.Drawing.Point(188, 331);
            this.lblRepetirPassword.Name = "lblRepetirPassword";
            this.lblRepetirPassword.Size = new System.Drawing.Size(142, 18);
            this.lblRepetirPassword.TabIndex = 9;
            this.lblRepetirPassword.Text = "Repita su Contraseña:";
            // 
            // txtbReingresePassword
            // 
            this.txtbReingresePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbReingresePassword.Location = new System.Drawing.Point(188, 352);
            this.txtbReingresePassword.Name = "txtbReingresePassword";
            this.txtbReingresePassword.PasswordChar = '¿';
            this.txtbReingresePassword.PlaceholderText = "Reingrese la Contraseña";
            this.txtbReingresePassword.Size = new System.Drawing.Size(173, 26);
            this.txtbReingresePassword.TabIndex = 8;
            this.txtbReingresePassword.UseSystemPasswordChar = true;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDni.Location = new System.Drawing.Point(12, 331);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(89, 18);
            this.lblDni.TabIndex = 15;
            this.lblDni.Text = "Numero DNI:";
            // 
            // txtbDni
            // 
            this.txtbDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDni.Location = new System.Drawing.Point(12, 352);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.PlaceholderText = "Ingrese el DNI";
            this.txtbDni.Size = new System.Drawing.Size(156, 26);
            this.txtbDni.TabIndex = 14;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(12, 281);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreReal.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreReal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreReal.Location = new System.Drawing.Point(12, 231);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(63, 18);
            this.lblNombreReal.TabIndex = 12;
            this.lblNombreReal.Text = "Nombre:";
            this.lblNombreReal.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtbApellido
            // 
            this.txtbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbApellido.Location = new System.Drawing.Point(12, 302);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.PlaceholderText = "Ingrese el Apellido";
            this.txtbApellido.Size = new System.Drawing.Size(156, 26);
            this.txtbApellido.TabIndex = 11;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(12, 252);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.PlaceholderText = "Ingrese el Nombre";
            this.txtbNombre.Size = new System.Drawing.Size(156, 26);
            this.txtbNombre.TabIndex = 10;
            // 
            // frmCrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Vista.Properties.Resources.LogIn;
            this.ClientSize = new System.Drawing.Size(373, 422);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtbDni);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblRepetirPassword);
            this.Controls.Add(this.txtbReingresePassword);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCrearEmpleado";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Alta de Nuevo Empleado";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRepetirPassword;
        private System.Windows.Forms.TextBox txtbReingresePassword;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbDni;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
    }
}