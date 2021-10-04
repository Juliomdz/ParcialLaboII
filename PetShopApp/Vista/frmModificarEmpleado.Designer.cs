
namespace Vista
{
    partial class frmModificarEmpleado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarEmpleado));
            this.lbxUsuario = new System.Windows.Forms.ListBox();
            this.lbxDni = new System.Windows.Forms.ListBox();
            this.lbxApellido = new System.Windows.Forms.ListBox();
            this.lbxNombre = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbDniEmpleado = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombreReal = new System.Windows.Forms.Label();
            this.txtbApellido = new System.Windows.Forms.TextBox();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.lblRepetirPassword = new System.Windows.Forms.Label();
            this.txtbReingresePassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxUsuario
            // 
            this.lbxUsuario.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxUsuario.FormattingEnabled = true;
            this.lbxUsuario.ItemHeight = 19;
            this.lbxUsuario.Items.AddRange(new object[] {
            "USUARIO"});
            this.lbxUsuario.Location = new System.Drawing.Point(248, 50);
            this.lbxUsuario.Name = "lbxUsuario";
            this.lbxUsuario.Size = new System.Drawing.Size(93, 479);
            this.lbxUsuario.TabIndex = 9;
            // 
            // lbxDni
            // 
            this.lbxDni.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDni.FormattingEnabled = true;
            this.lbxDni.ItemHeight = 19;
            this.lbxDni.Items.AddRange(new object[] {
            "DNI"});
            this.lbxDni.Location = new System.Drawing.Point(174, 50);
            this.lbxDni.Name = "lbxDni";
            this.lbxDni.Size = new System.Drawing.Size(79, 479);
            this.lbxDni.TabIndex = 7;
            // 
            // lbxApellido
            // 
            this.lbxApellido.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxApellido.FormattingEnabled = true;
            this.lbxApellido.ItemHeight = 19;
            this.lbxApellido.Items.AddRange(new object[] {
            "APELLIDO"});
            this.lbxApellido.Location = new System.Drawing.Point(93, 50);
            this.lbxApellido.Name = "lbxApellido";
            this.lbxApellido.Size = new System.Drawing.Size(82, 479);
            this.lbxApellido.TabIndex = 6;
            // 
            // lbxNombre
            // 
            this.lbxNombre.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxNombre.FormattingEnabled = true;
            this.lbxNombre.ItemHeight = 19;
            this.lbxNombre.Items.AddRange(new object[] {
            "NOMBRE"});
            this.lbxNombre.Location = new System.Drawing.Point(12, 50);
            this.lbxNombre.Name = "lbxNombre";
            this.lbxNombre.Size = new System.Drawing.Size(83, 479);
            this.lbxNombre.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(340, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(452, 36);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "SE VA A MODIFICAR UN EMPLEADO.";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.Red;
            this.lblDni.Location = new System.Drawing.Point(347, 50);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(403, 23);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Ingrese el DNI del empleado que desea modificar:";
            // 
            // txtbDni
            // 
            this.txtbDni.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbDni.Location = new System.Drawing.Point(385, 85);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.Size = new System.Drawing.Size(269, 33);
            this.txtbDni.TabIndex = 12;
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnSeleccionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnSeleccionar.FlatAppearance.BorderSize = 5;
            this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeleccionar.Font = new System.Drawing.Font("Calibri", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSeleccionar.ForeColor = System.Drawing.Color.Maroon;
            this.btnSeleccionar.Location = new System.Drawing.Point(396, 124);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(233, 68);
            this.btnSeleccionar.TabIndex = 13;
            this.btnSeleccionar.Text = "SELECCIONAR";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionarDni_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(345, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Numero DNI:";
            // 
            // txtbDniEmpleado
            // 
            this.txtbDniEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbDniEmpleado.Location = new System.Drawing.Point(345, 368);
            this.txtbDniEmpleado.Name = "txtbDniEmpleado";
            this.txtbDniEmpleado.PlaceholderText = "Ingrese el DNI";
            this.txtbDniEmpleado.ReadOnly = true;
            this.txtbDniEmpleado.Size = new System.Drawing.Size(156, 26);
            this.txtbDniEmpleado.TabIndex = 27;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.BackColor = System.Drawing.Color.Transparent;
            this.lblApellido.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblApellido.Location = new System.Drawing.Point(345, 297);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(65, 18);
            this.lblApellido.TabIndex = 26;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombreReal
            // 
            this.lblNombreReal.AutoSize = true;
            this.lblNombreReal.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreReal.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombreReal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblNombreReal.Location = new System.Drawing.Point(345, 247);
            this.lblNombreReal.Name = "lblNombreReal";
            this.lblNombreReal.Size = new System.Drawing.Size(63, 18);
            this.lblNombreReal.TabIndex = 25;
            this.lblNombreReal.Text = "Nombre:";
            // 
            // txtbApellido
            // 
            this.txtbApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbApellido.Location = new System.Drawing.Point(345, 318);
            this.txtbApellido.Name = "txtbApellido";
            this.txtbApellido.PlaceholderText = "Ingrese el Apellido";
            this.txtbApellido.Size = new System.Drawing.Size(156, 26);
            this.txtbApellido.TabIndex = 24;
            // 
            // txtbNombre
            // 
            this.txtbNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbNombre.Location = new System.Drawing.Point(345, 268);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.PlaceholderText = "Ingrese el Nombre";
            this.txtbNombre.Size = new System.Drawing.Size(156, 26);
            this.txtbNombre.TabIndex = 23;
            // 
            // lblRepetirPassword
            // 
            this.lblRepetirPassword.AutoSize = true;
            this.lblRepetirPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblRepetirPassword.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRepetirPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblRepetirPassword.Location = new System.Drawing.Point(521, 347);
            this.lblRepetirPassword.Name = "lblRepetirPassword";
            this.lblRepetirPassword.Size = new System.Drawing.Size(142, 18);
            this.lblRepetirPassword.TabIndex = 22;
            this.lblRepetirPassword.Text = "Repita su Contraseña:";
            // 
            // txtbReingresePassword
            // 
            this.txtbReingresePassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbReingresePassword.Location = new System.Drawing.Point(521, 368);
            this.txtbReingresePassword.Name = "txtbReingresePassword";
            this.txtbReingresePassword.PasswordChar = '¿';
            this.txtbReingresePassword.PlaceholderText = "Reingrese la Contraseña";
            this.txtbReingresePassword.Size = new System.Drawing.Size(173, 26);
            this.txtbReingresePassword.TabIndex = 21;
            this.txtbReingresePassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(521, 297);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 18);
            this.lblPassword.TabIndex = 20;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(521, 247);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(133, 18);
            this.lblUsuario.TabIndex = 19;
            this.lblUsuario.Text = "Nombre de Usuario:";
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(521, 318);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '¿';
            this.txtbPassword.PlaceholderText = "Ingrese la Contraseña";
            this.txtbPassword.Size = new System.Drawing.Size(173, 26);
            this.txtbPassword.TabIndex = 18;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUser.Location = new System.Drawing.Point(521, 268);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PlaceholderText = "Ingrese el Usuario";
            this.txtbUser.Size = new System.Drawing.Size(173, 26);
            this.txtbUser.TabIndex = 17;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAceptar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnAceptar.FlatAppearance.BorderSize = 5;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAceptar.Font = new System.Drawing.Font("Calibri", 16.27826F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAceptar.ForeColor = System.Drawing.Color.DarkRed;
            this.btnAceptar.Location = new System.Drawing.Point(396, 416);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(233, 74);
            this.btnAceptar.TabIndex = 16;
            this.btnAceptar.Text = "GUARDAR CAMBIOS";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmModificarEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1032, 671);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDniEmpleado);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.lblNombreReal);
            this.Controls.Add(this.txtbApellido);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.lblRepetirPassword);
            this.Controls.Add(this.txtbReingresePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.txtbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbxUsuario);
            this.Controls.Add(this.lbxDni);
            this.Controls.Add(this.lbxApellido);
            this.Controls.Add(this.lbxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmModificarEmpleado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Modificar un Empleado";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxUsuario;
        private System.Windows.Forms.ListBox lbxDni;
        private System.Windows.Forms.ListBox lbxApellido;
        private System.Windows.Forms.ListBox lbxNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbDni;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbDniEmpleado;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombreReal;
        private System.Windows.Forms.TextBox txtbApellido;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.Label lblRepetirPassword;
        private System.Windows.Forms.TextBox txtbReingresePassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.Button btnAceptar;
    }
}