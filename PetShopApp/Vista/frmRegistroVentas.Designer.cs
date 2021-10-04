
namespace Vista
{
    partial class frmRegistroVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistroVentas));
            this.lbxNombre = new System.Windows.Forms.ListBox();
            this.lbxApellido = new System.Windows.Forms.ListBox();
            this.lbxDni = new System.Windows.Forms.ListBox();
            this.lbxProducto = new System.Windows.Forms.ListBox();
            this.lbxCantidad = new System.Windows.Forms.ListBox();
            this.lbxFacturado = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbxNombre
            // 
            this.lbxNombre.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxNombre.FormattingEnabled = true;
            this.lbxNombre.ItemHeight = 19;
            this.lbxNombre.Items.AddRange(new object[] {
            "NOMBRE"});
            this.lbxNombre.Location = new System.Drawing.Point(12, 51);
            this.lbxNombre.Name = "lbxNombre";
            this.lbxNombre.Size = new System.Drawing.Size(83, 479);
            this.lbxNombre.TabIndex = 0;
            this.lbxNombre.SelectedIndexChanged += new System.EventHandler(this.lsbVentas_SelectedIndexChanged);
            // 
            // lbxApellido
            // 
            this.lbxApellido.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxApellido.FormattingEnabled = true;
            this.lbxApellido.ItemHeight = 19;
            this.lbxApellido.Items.AddRange(new object[] {
            "APELLIDO"});
            this.lbxApellido.Location = new System.Drawing.Point(93, 51);
            this.lbxApellido.Name = "lbxApellido";
            this.lbxApellido.Size = new System.Drawing.Size(82, 479);
            this.lbxApellido.TabIndex = 1;
            // 
            // lbxDni
            // 
            this.lbxDni.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDni.FormattingEnabled = true;
            this.lbxDni.ItemHeight = 19;
            this.lbxDni.Items.AddRange(new object[] {
            "DNI"});
            this.lbxDni.Location = new System.Drawing.Point(174, 51);
            this.lbxDni.Name = "lbxDni";
            this.lbxDni.Size = new System.Drawing.Size(102, 479);
            this.lbxDni.TabIndex = 2;
            // 
            // lbxProducto
            // 
            this.lbxProducto.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxProducto.FormattingEnabled = true;
            this.lbxProducto.ItemHeight = 19;
            this.lbxProducto.Items.AddRange(new object[] {
            "PRODUCTO"});
            this.lbxProducto.Location = new System.Drawing.Point(329, 51);
            this.lbxProducto.Name = "lbxProducto";
            this.lbxProducto.Size = new System.Drawing.Size(270, 479);
            this.lbxProducto.TabIndex = 3;
            // 
            // lbxCantidad
            // 
            this.lbxCantidad.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCantidad.FormattingEnabled = true;
            this.lbxCantidad.ItemHeight = 19;
            this.lbxCantidad.Items.AddRange(new object[] {
            "CANT."});
            this.lbxCantidad.Location = new System.Drawing.Point(271, 51);
            this.lbxCantidad.Name = "lbxCantidad";
            this.lbxCantidad.Size = new System.Drawing.Size(61, 479);
            this.lbxCantidad.TabIndex = 4;
            // 
            // lbxFacturado
            // 
            this.lbxFacturado.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxFacturado.FormattingEnabled = true;
            this.lbxFacturado.ItemHeight = 19;
            this.lbxFacturado.Items.AddRange(new object[] {
            "FACTURADO"});
            this.lbxFacturado.Location = new System.Drawing.Point(588, 51);
            this.lbxFacturado.Name = "lbxFacturado";
            this.lbxFacturado.Size = new System.Drawing.Size(88, 479);
            this.lbxFacturado.TabIndex = 5;
            this.lbxFacturado.SelectedIndexChanged += new System.EventHandler(this.lbxFacturado_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(501, 532);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(89, 25);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "TOTAL: $";
            // 
            // txtbTotal
            // 
            this.txtbTotal.Location = new System.Drawing.Point(588, 532);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.ReadOnly = true;
            this.txtbTotal.Size = new System.Drawing.Size(88, 26);
            this.txtbTotal.TabIndex = 7;
            // 
            // frmRegistroVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1032, 671);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbxFacturado);
            this.Controls.Add(this.lbxCantidad);
            this.Controls.Add(this.lbxProducto);
            this.Controls.Add(this.lbxDni);
            this.Controls.Add(this.lbxApellido);
            this.Controls.Add(this.lbxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistroVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Registro De Ventas";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxNombre;
        private System.Windows.Forms.ListBox lbxApellido;
        private System.Windows.Forms.ListBox lbxDni;
        private System.Windows.Forms.ListBox lbxProducto;
        private System.Windows.Forms.ListBox lbxCantidad;
        private System.Windows.Forms.ListBox lbxFacturado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtbTotal;
    }
}