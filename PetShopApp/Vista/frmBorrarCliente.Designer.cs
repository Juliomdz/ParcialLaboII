
namespace Vista
{
    partial class frmBorrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrarCliente));
            this.lbxTotalGastado = new System.Windows.Forms.ListBox();
            this.lbxDni = new System.Windows.Forms.ListBox();
            this.lbxApellido = new System.Windows.Forms.ListBox();
            this.lbxNombre = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbDni = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxTotalGastado
            // 
            this.lbxTotalGastado.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxTotalGastado.FormattingEnabled = true;
            this.lbxTotalGastado.ItemHeight = 19;
            this.lbxTotalGastado.Items.AddRange(new object[] {
            "TOTAL GASTADO"});
            this.lbxTotalGastado.Location = new System.Drawing.Point(271, 50);
            this.lbxTotalGastado.Name = "lbxTotalGastado";
            this.lbxTotalGastado.Size = new System.Drawing.Size(178, 479);
            this.lbxTotalGastado.TabIndex = 9;
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
            this.lbxDni.Size = new System.Drawing.Size(102, 479);
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
            this.lblTitulo.Location = new System.Drawing.Point(455, 50);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(391, 36);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "SE VA A ELIMINAR UN CLIENTE.";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Calibri", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.Red;
            this.lblDni.Location = new System.Drawing.Point(455, 114);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(370, 23);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Ingrese el DNI del cliente que desea eliminar:";
            // 
            // txtbDni
            // 
            this.txtbDni.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbDni.Location = new System.Drawing.Point(455, 140);
            this.txtbDni.Name = "txtbDni";
            this.txtbDni.Size = new System.Drawing.Size(269, 33);
            this.txtbDni.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatAppearance.BorderSize = 5;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 26.29565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Location = new System.Drawing.Point(455, 191);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(233, 68);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmBorrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1032, 671);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtbDni);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbxTotalGastado);
            this.Controls.Add(this.lbxDni);
            this.Controls.Add(this.lbxApellido);
            this.Controls.Add(this.lbxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBorrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Eliminar un Cliente";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxTotalGastado;
        private System.Windows.Forms.ListBox lbxDni;
        private System.Windows.Forms.ListBox lbxApellido;
        private System.Windows.Forms.ListBox lbxNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbDni;
        private System.Windows.Forms.Button btnEliminar;
    }
}