
namespace Vista
{
    partial class frmLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogIn));
            this.btnLogIn = new System.Windows.Forms.Button();
            this.txtbUser = new System.Windows.Forms.TextBox();
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblAutocompletarAdmin = new System.Windows.Forms.LinkLabel();
            this.lblAutocompletarUsuario = new System.Windows.Forms.LinkLabel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblCredenciales = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLogIn
            // 
            this.btnLogIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogIn.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogIn.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnLogIn.FlatAppearance.BorderSize = 5;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogIn.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogIn.ForeColor = System.Drawing.Color.LightYellow;
            this.btnLogIn.Location = new System.Drawing.Point(229, 332);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(107, 28);
            this.btnLogIn.TabIndex = 0;
            this.btnLogIn.Text = "ACCEDER";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // txtbUser
            // 
            this.txtbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbUser.Location = new System.Drawing.Point(63, 226);
            this.txtbUser.Name = "txtbUser";
            this.txtbUser.PlaceholderText = "Ingrese Su Usuario";
            this.txtbUser.Size = new System.Drawing.Size(166, 26);
            this.txtbUser.TabIndex = 1;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtbPassword.Location = new System.Drawing.Point(63, 274);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.PasswordChar = '¿';
            this.txtbPassword.PlaceholderText = "Ingrese Su Contraseña";
            this.txtbPassword.Size = new System.Drawing.Size(166, 26);
            this.txtbPassword.TabIndex = 2;
            this.txtbPassword.UseSystemPasswordChar = true;
            // 
            // lblAutocompletarAdmin
            // 
            this.lblAutocompletarAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutocompletarAdmin.AutoSize = true;
            this.lblAutocompletarAdmin.BackColor = System.Drawing.Color.Transparent;
            this.lblAutocompletarAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutocompletarAdmin.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutocompletarAdmin.LinkColor = System.Drawing.Color.Goldenrod;
            this.lblAutocompletarAdmin.Location = new System.Drawing.Point(63, 348);
            this.lblAutocompletarAdmin.Name = "lblAutocompletarAdmin";
            this.lblAutocompletarAdmin.Size = new System.Drawing.Size(151, 18);
            this.lblAutocompletarAdmin.TabIndex = 3;
            this.lblAutocompletarAdmin.TabStop = true;
            this.lblAutocompletarAdmin.Text = "Credenciales de Admin";
            this.lblAutocompletarAdmin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lblAutocompletarUsuario
            // 
            this.lblAutocompletarUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAutocompletarUsuario.AutoSize = true;
            this.lblAutocompletarUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblAutocompletarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAutocompletarUsuario.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAutocompletarUsuario.LinkColor = System.Drawing.Color.Goldenrod;
            this.lblAutocompletarUsuario.Location = new System.Drawing.Point(63, 330);
            this.lblAutocompletarUsuario.Name = "lblAutocompletarUsuario";
            this.lblAutocompletarUsuario.Size = new System.Drawing.Size(153, 18);
            this.lblAutocompletarUsuario.TabIndex = 4;
            this.lblAutocompletarUsuario.TabStop = true;
            this.lblAutocompletarUsuario.Text = "Credenciales Empleado";
            this.lblAutocompletarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAutocompletarUsuario_LinkClicked);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblUsuario.Location = new System.Drawing.Point(63, 208);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(60, 18);
            this.lblUsuario.TabIndex = 5;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 8.765218F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPassword.Location = new System.Drawing.Point(63, 256);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 18);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Contraseña:";
            // 
            // lblCredenciales
            // 
            this.lblCredenciales.AutoSize = true;
            this.lblCredenciales.BackColor = System.Drawing.Color.Transparent;
            this.lblCredenciales.Font = new System.Drawing.Font("Calibri", 8.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCredenciales.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblCredenciales.Location = new System.Drawing.Point(63, 312);
            this.lblCredenciales.Name = "lblCredenciales";
            this.lblCredenciales.Size = new System.Drawing.Size(105, 18);
            this.lblCredenciales.TabIndex = 7;
            this.lblCredenciales.Text = "Autocompletar:";
            // 
            // frmLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Vista.Properties.Resources.LogIn;
            this.ClientSize = new System.Drawing.Size(348, 372);
            this.Controls.Add(this.lblCredenciales);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAutocompletarUsuario);
            this.Controls.Add(this.lblAutocompletarAdmin);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.txtbUser);
            this.Controls.Add(this.btnLogIn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogIn";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox txtbUser;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.LinkLabel lblAutocompletarAdmin;
        private System.Windows.Forms.LinkLabel lblAutocompletarUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblCredenciales;
    }
}