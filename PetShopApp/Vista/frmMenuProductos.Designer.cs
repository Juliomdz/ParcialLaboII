
namespace Vista
{
    partial class frmMenuProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuProductos));
            this.lbxDescripcion = new System.Windows.Forms.ListBox();
            this.lbxIdProducto = new System.Windows.Forms.ListBox();
            this.lbxCategoria = new System.Windows.Forms.ListBox();
            this.lbxNombre = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.txtbId = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnNuevoProducto = new System.Windows.Forms.Button();
            this.lbxStock = new System.Windows.Forms.ListBox();
            this.lbxPrecio = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbxDescripcion
            // 
            this.lbxDescripcion.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxDescripcion.FormattingEnabled = true;
            this.lbxDescripcion.ItemHeight = 19;
            this.lbxDescripcion.Items.AddRange(new object[] {
            "DESCRIPCION"});
            this.lbxDescripcion.Location = new System.Drawing.Point(284, 50);
            this.lbxDescripcion.Name = "lbxDescripcion";
            this.lbxDescripcion.Size = new System.Drawing.Size(286, 479);
            this.lbxDescripcion.TabIndex = 9;
            // 
            // lbxIdProducto
            // 
            this.lbxIdProducto.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxIdProducto.FormattingEnabled = true;
            this.lbxIdProducto.ItemHeight = 19;
            this.lbxIdProducto.Items.AddRange(new object[] {
            "ID"});
            this.lbxIdProducto.Location = new System.Drawing.Point(12, 50);
            this.lbxIdProducto.Name = "lbxIdProducto";
            this.lbxIdProducto.Size = new System.Drawing.Size(30, 479);
            this.lbxIdProducto.TabIndex = 7;
            // 
            // lbxCategoria
            // 
            this.lbxCategoria.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxCategoria.FormattingEnabled = true;
            this.lbxCategoria.ItemHeight = 19;
            this.lbxCategoria.Items.AddRange(new object[] {
            "CATEGORIA"});
            this.lbxCategoria.Location = new System.Drawing.Point(39, 50);
            this.lbxCategoria.Name = "lbxCategoria";
            this.lbxCategoria.Size = new System.Drawing.Size(83, 479);
            this.lbxCategoria.TabIndex = 6;
            // 
            // lbxNombre
            // 
            this.lbxNombre.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxNombre.FormattingEnabled = true;
            this.lbxNombre.ItemHeight = 19;
            this.lbxNombre.Items.AddRange(new object[] {
            "NOMBRE"});
            this.lbxNombre.Location = new System.Drawing.Point(119, 50);
            this.lbxNombre.Name = "lbxNombre";
            this.lbxNombre.Size = new System.Drawing.Size(169, 479);
            this.lbxNombre.TabIndex = 5;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Calibri", 18.15652F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.Chocolate;
            this.lblTitulo.Location = new System.Drawing.Point(12, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(360, 36);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "PRODUCTOS EN EL SISTEMA.";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.BackColor = System.Drawing.Color.Transparent;
            this.lblDni.Font = new System.Drawing.Font("Calibri", 13.77391F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDni.ForeColor = System.Drawing.Color.Red;
            this.lblDni.Location = new System.Drawing.Point(726, 405);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(253, 54);
            this.lblDni.TabIndex = 11;
            this.lblDni.Text = "Ingrese el ID del producto \n    a modificar/eliminar:";
            // 
            // txtbId
            // 
            this.txtbId.Font = new System.Drawing.Font("Segoe UI", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtbId.Location = new System.Drawing.Point(710, 462);
            this.txtbId.Name = "txtbId";
            this.txtbId.PlaceholderText = "ID del producto";
            this.txtbId.Size = new System.Drawing.Size(269, 33);
            this.txtbId.TabIndex = 12;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnEliminar.FlatAppearance.BorderSize = 5;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEliminar.ForeColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Location = new System.Drawing.Point(840, 513);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(180, 68);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnModificar.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnModificar.FlatAppearance.BorderSize = 5;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 18.78261F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.Maroon;
            this.btnModificar.Location = new System.Drawing.Point(654, 513);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(180, 68);
            this.btnModificar.TabIndex = 14;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoProducto.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnNuevoProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoProducto.FlatAppearance.BorderColor = System.Drawing.Color.DarkOrange;
            this.btnNuevoProducto.FlatAppearance.BorderSize = 5;
            this.btnNuevoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNuevoProducto.Font = new System.Drawing.Font("Calibri", 20.03478F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevoProducto.ForeColor = System.Drawing.Color.Maroon;
            this.btnNuevoProducto.Location = new System.Drawing.Point(737, 71);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(192, 93);
            this.btnNuevoProducto.TabIndex = 15;
            this.btnNuevoProducto.Text = "NUEVO PRODUCTO";
            this.btnNuevoProducto.UseVisualStyleBackColor = false;
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // lbxStock
            // 
            this.lbxStock.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxStock.FormattingEnabled = true;
            this.lbxStock.ItemHeight = 19;
            this.lbxStock.Items.AddRange(new object[] {
            "STOCK"});
            this.lbxStock.Location = new System.Drawing.Point(544, 50);
            this.lbxStock.Name = "lbxStock";
            this.lbxStock.Size = new System.Drawing.Size(51, 479);
            this.lbxStock.TabIndex = 16;
            // 
            // lbxPrecio
            // 
            this.lbxPrecio.Font = new System.Drawing.Font("Calibri", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbxPrecio.FormattingEnabled = true;
            this.lbxPrecio.ItemHeight = 19;
            this.lbxPrecio.Items.AddRange(new object[] {
            "PRECIO"});
            this.lbxPrecio.Location = new System.Drawing.Point(593, 50);
            this.lbxPrecio.Name = "lbxPrecio";
            this.lbxPrecio.Size = new System.Drawing.Size(55, 479);
            this.lbxPrecio.TabIndex = 17;
            // 
            // frmMenuProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo;
            this.ClientSize = new System.Drawing.Size(1032, 671);
            this.Controls.Add(this.lbxPrecio);
            this.Controls.Add(this.lbxStock);
            this.Controls.Add(this.btnNuevoProducto);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.lbxIdProducto);
            this.Controls.Add(this.lbxCategoria);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtbId);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lbxDescripcion);
            this.Controls.Add(this.lbxNombre);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenuProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PetShopApp - Menu Productos";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxDescripcion;
        private System.Windows.Forms.ListBox lbxIdProducto;
        private System.Windows.Forms.ListBox lbxCategoria;
        private System.Windows.Forms.ListBox lbxNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.TextBox txtbId;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnNuevoProducto;
        private System.Windows.Forms.ListBox lbxStock;
        private System.Windows.Forms.ListBox lbxPrecio;
    }
}