namespace WindowsFormsApp1
{
    partial class Form1
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
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarPedidos = new System.Windows.Forms.Button();
            this.lstPedidos = new System.Windows.Forms.ListBox();
            this.lblPedidosDatos = new System.Windows.Forms.Label();
            this.lblListaPedidos = new System.Windows.Forms.Label();
            this.txtCantidadPedido = new System.Windows.Forms.TextBox();
            this.lblCantidadPedido = new System.Windows.Forms.Label();
            this.cmbNombrePedido = new System.Windows.Forms.ComboBox();
            this.lblNombrePedido = new System.Windows.Forms.Label();
            this.grpBuscar = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtIdBuscar = new System.Windows.Forms.TextBox();
            this.lblIdBuscar = new System.Windows.Forms.Label();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtPrecioDatos = new System.Windows.Forms.TextBox();
            this.lblPrecioDatos = new System.Windows.Forms.Label();
            this.txtStockDatos = new System.Windows.Forms.TextBox();
            this.lblStockDatos = new System.Windows.Forms.Label();
            this.txtNombreDatos = new System.Windows.Forms.TextBox();
            this.lblNombredatos = new System.Windows.Forms.Label();
            this.grpAlta = new System.Windows.Forms.GroupBox();
            this.lblProductosDatos = new System.Windows.Forms.Label();
            this.btnMostrarProductos = new System.Windows.Forms.Button();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnAgregarProductos = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.lblListaProductos = new System.Windows.Forms.Label();
            this.txtPrecioAlta = new System.Windows.Forms.TextBox();
            this.lblPrecioAlta = new System.Windows.Forms.Label();
            this.txtStockAlta = new System.Windows.Forms.TextBox();
            this.lblStockAlta = new System.Windows.Forms.Label();
            this.txtNombreAlta = new System.Windows.Forms.TextBox();
            this.lblNombreAlta = new System.Windows.Forms.Label();
            this.txtIdAlta = new System.Windows.Forms.TextBox();
            this.lblIdAlta = new System.Windows.Forms.Label();
            this.grpPedido.SuspendLayout();
            this.grpBuscar.SuspendLayout();
            this.grpDatos.SuspendLayout();
            this.grpAlta.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.btnSalir);
            this.grpPedido.Controls.Add(this.btnAgregarPedidos);
            this.grpPedido.Controls.Add(this.lstPedidos);
            this.grpPedido.Controls.Add(this.lblPedidosDatos);
            this.grpPedido.Controls.Add(this.lblListaPedidos);
            this.grpPedido.Controls.Add(this.txtCantidadPedido);
            this.grpPedido.Controls.Add(this.lblCantidadPedido);
            this.grpPedido.Controls.Add(this.cmbNombrePedido);
            this.grpPedido.Controls.Add(this.lblNombrePedido);
            this.grpPedido.Location = new System.Drawing.Point(516, 14);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(261, 452);
            this.grpPedido.TabIndex = 5;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(171, 398);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarPedidos
            // 
            this.btnAgregarPedidos.Location = new System.Drawing.Point(81, 311);
            this.btnAgregarPedidos.Name = "btnAgregarPedidos";
            this.btnAgregarPedidos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPedidos.TabIndex = 7;
            this.btnAgregarPedidos.Text = "Agregar";
            this.btnAgregarPedidos.UseVisualStyleBackColor = true;
            this.btnAgregarPedidos.Click += new System.EventHandler(this.btnAgregarPedidos_Click);
            // 
            // lstPedidos
            // 
            this.lstPedidos.FormattingEnabled = true;
            this.lstPedidos.Location = new System.Drawing.Point(9, 188);
            this.lstPedidos.Name = "lstPedidos";
            this.lstPedidos.Size = new System.Drawing.Size(237, 108);
            this.lstPedidos.TabIndex = 6;
            // 
            // lblPedidosDatos
            // 
            this.lblPedidosDatos.AutoSize = true;
            this.lblPedidosDatos.Location = new System.Drawing.Point(6, 170);
            this.lblPedidosDatos.Name = "lblPedidosDatos";
            this.lblPedidosDatos.Size = new System.Drawing.Size(103, 13);
            this.lblPedidosDatos.TabIndex = 5;
            this.lblPedidosDatos.Text = "Id;Cantidad;Subtotal";
            // 
            // lblListaPedidos
            // 
            this.lblListaPedidos.AutoSize = true;
            this.lblListaPedidos.Location = new System.Drawing.Point(6, 151);
            this.lblListaPedidos.Name = "lblListaPedidos";
            this.lblListaPedidos.Size = new System.Drawing.Size(84, 13);
            this.lblListaPedidos.TabIndex = 4;
            this.lblListaPedidos.Text = "Lista de pedidos";
            // 
            // txtCantidadPedido
            // 
            this.txtCantidadPedido.Location = new System.Drawing.Point(9, 102);
            this.txtCantidadPedido.Name = "txtCantidadPedido";
            this.txtCantidadPedido.Size = new System.Drawing.Size(192, 20);
            this.txtCantidadPedido.TabIndex = 3;
            // 
            // lblCantidadPedido
            // 
            this.lblCantidadPedido.AutoSize = true;
            this.lblCantidadPedido.Location = new System.Drawing.Point(6, 86);
            this.lblCantidadPedido.Name = "lblCantidadPedido";
            this.lblCantidadPedido.Size = new System.Drawing.Size(49, 13);
            this.lblCantidadPedido.TabIndex = 2;
            this.lblCantidadPedido.Text = "Cantidad";
            // 
            // cmbNombrePedido
            // 
            this.cmbNombrePedido.FormattingEnabled = true;
            this.cmbNombrePedido.Location = new System.Drawing.Point(9, 37);
            this.cmbNombrePedido.Name = "cmbNombrePedido";
            this.cmbNombrePedido.Size = new System.Drawing.Size(192, 21);
            this.cmbNombrePedido.TabIndex = 1;
            // 
            // lblNombrePedido
            // 
            this.lblNombrePedido.AutoSize = true;
            this.lblNombrePedido.Location = new System.Drawing.Point(6, 20);
            this.lblNombrePedido.Name = "lblNombrePedido";
            this.lblNombrePedido.Size = new System.Drawing.Size(44, 13);
            this.lblNombrePedido.TabIndex = 0;
            this.lblNombrePedido.Text = "Nombre";
            // 
            // grpBuscar
            // 
            this.grpBuscar.Controls.Add(this.btnLimpiar);
            this.grpBuscar.Controls.Add(this.btnBuscar);
            this.grpBuscar.Controls.Add(this.txtIdBuscar);
            this.grpBuscar.Controls.Add(this.lblIdBuscar);
            this.grpBuscar.Controls.Add(this.grpDatos);
            this.grpBuscar.Location = new System.Drawing.Point(18, 255);
            this.grpBuscar.Name = "grpBuscar";
            this.grpBuscar.Size = new System.Drawing.Size(481, 211);
            this.grpBuscar.TabIndex = 4;
            this.grpBuscar.TabStop = false;
            this.grpBuscar.Text = "Buscar";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(27, 120);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(27, 91);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtIdBuscar
            // 
            this.txtIdBuscar.Location = new System.Drawing.Point(13, 49);
            this.txtIdBuscar.Name = "txtIdBuscar";
            this.txtIdBuscar.Size = new System.Drawing.Size(143, 20);
            this.txtIdBuscar.TabIndex = 2;
            // 
            // lblIdBuscar
            // 
            this.lblIdBuscar.AutoSize = true;
            this.lblIdBuscar.Location = new System.Drawing.Point(10, 32);
            this.lblIdBuscar.Name = "lblIdBuscar";
            this.lblIdBuscar.Size = new System.Drawing.Size(16, 13);
            this.lblIdBuscar.TabIndex = 1;
            this.lblIdBuscar.Text = "Id";
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtPrecioDatos);
            this.grpDatos.Controls.Add(this.lblPrecioDatos);
            this.grpDatos.Controls.Add(this.txtStockDatos);
            this.grpDatos.Controls.Add(this.lblStockDatos);
            this.grpDatos.Controls.Add(this.txtNombreDatos);
            this.grpDatos.Controls.Add(this.lblNombredatos);
            this.grpDatos.Location = new System.Drawing.Point(211, 19);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(250, 173);
            this.grpDatos.TabIndex = 0;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos";
            // 
            // txtPrecioDatos
            // 
            this.txtPrecioDatos.Location = new System.Drawing.Point(25, 141);
            this.txtPrecioDatos.Name = "txtPrecioDatos";
            this.txtPrecioDatos.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioDatos.TabIndex = 13;
            // 
            // lblPrecioDatos
            // 
            this.lblPrecioDatos.AutoSize = true;
            this.lblPrecioDatos.Location = new System.Drawing.Point(25, 124);
            this.lblPrecioDatos.Name = "lblPrecioDatos";
            this.lblPrecioDatos.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioDatos.TabIndex = 12;
            this.lblPrecioDatos.Text = "Precio";
            // 
            // txtStockDatos
            // 
            this.txtStockDatos.Location = new System.Drawing.Point(25, 91);
            this.txtStockDatos.Name = "txtStockDatos";
            this.txtStockDatos.Size = new System.Drawing.Size(177, 20);
            this.txtStockDatos.TabIndex = 11;
            // 
            // lblStockDatos
            // 
            this.lblStockDatos.AutoSize = true;
            this.lblStockDatos.Location = new System.Drawing.Point(25, 74);
            this.lblStockDatos.Name = "lblStockDatos";
            this.lblStockDatos.Size = new System.Drawing.Size(35, 13);
            this.lblStockDatos.TabIndex = 10;
            this.lblStockDatos.Text = "Stock";
            // 
            // txtNombreDatos
            // 
            this.txtNombreDatos.Location = new System.Drawing.Point(25, 40);
            this.txtNombreDatos.Name = "txtNombreDatos";
            this.txtNombreDatos.Size = new System.Drawing.Size(177, 20);
            this.txtNombreDatos.TabIndex = 9;
            // 
            // lblNombredatos
            // 
            this.lblNombredatos.AutoSize = true;
            this.lblNombredatos.Location = new System.Drawing.Point(25, 23);
            this.lblNombredatos.Name = "lblNombredatos";
            this.lblNombredatos.Size = new System.Drawing.Size(44, 13);
            this.lblNombredatos.TabIndex = 8;
            this.lblNombredatos.Text = "Nombre";
            // 
            // grpAlta
            // 
            this.grpAlta.Controls.Add(this.lblProductosDatos);
            this.grpAlta.Controls.Add(this.btnMostrarProductos);
            this.grpAlta.Controls.Add(this.btnEliminarProductos);
            this.grpAlta.Controls.Add(this.btnAgregarProductos);
            this.grpAlta.Controls.Add(this.lstProductos);
            this.grpAlta.Controls.Add(this.lblListaProductos);
            this.grpAlta.Controls.Add(this.txtPrecioAlta);
            this.grpAlta.Controls.Add(this.lblPrecioAlta);
            this.grpAlta.Controls.Add(this.txtStockAlta);
            this.grpAlta.Controls.Add(this.lblStockAlta);
            this.grpAlta.Controls.Add(this.txtNombreAlta);
            this.grpAlta.Controls.Add(this.lblNombreAlta);
            this.grpAlta.Controls.Add(this.txtIdAlta);
            this.grpAlta.Controls.Add(this.lblIdAlta);
            this.grpAlta.Location = new System.Drawing.Point(18, 12);
            this.grpAlta.Name = "grpAlta";
            this.grpAlta.Size = new System.Drawing.Size(481, 235);
            this.grpAlta.TabIndex = 3;
            this.grpAlta.TabStop = false;
            this.grpAlta.Text = "Alta";
            // 
            // lblProductosDatos
            // 
            this.lblProductosDatos.AutoSize = true;
            this.lblProductosDatos.Location = new System.Drawing.Point(222, 37);
            this.lblProductosDatos.Name = "lblProductosDatos";
            this.lblProductosDatos.Size = new System.Drawing.Size(120, 13);
            this.lblProductosDatos.TabIndex = 13;
            this.lblProductosDatos.Text = "Id;Nombre;Stock;Precio";
            // 
            // btnMostrarProductos
            // 
            this.btnMostrarProductos.Location = new System.Drawing.Point(387, 202);
            this.btnMostrarProductos.Name = "btnMostrarProductos";
            this.btnMostrarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnMostrarProductos.TabIndex = 12;
            this.btnMostrarProductos.Text = "Mostrar";
            this.btnMostrarProductos.UseVisualStyleBackColor = true;
            this.btnMostrarProductos.Click += new System.EventHandler(this.btnMostrarProductos_Click);
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Location = new System.Drawing.Point(306, 202);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProductos.TabIndex = 11;
            this.btnEliminarProductos.Text = "Eliminar";
            this.btnEliminarProductos.UseVisualStyleBackColor = true;
            this.btnEliminarProductos.Click += new System.EventHandler(this.btnEliminarProductos_Click);
            // 
            // btnAgregarProductos
            // 
            this.btnAgregarProductos.Location = new System.Drawing.Point(225, 202);
            this.btnAgregarProductos.Name = "btnAgregarProductos";
            this.btnAgregarProductos.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProductos.TabIndex = 10;
            this.btnAgregarProductos.Text = "Agregar";
            this.btnAgregarProductos.UseVisualStyleBackColor = true;
            this.btnAgregarProductos.Click += new System.EventHandler(this.btnAgregarProductos_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(224, 57);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(237, 121);
            this.lstProductos.TabIndex = 9;
            // 
            // lblListaProductos
            // 
            this.lblListaProductos.AutoSize = true;
            this.lblListaProductos.Location = new System.Drawing.Point(222, 20);
            this.lblListaProductos.Name = "lblListaProductos";
            this.lblListaProductos.Size = new System.Drawing.Size(94, 13);
            this.lblListaProductos.TabIndex = 8;
            this.lblListaProductos.Text = "Lista de productos";
            // 
            // txtPrecioAlta
            // 
            this.txtPrecioAlta.Location = new System.Drawing.Point(7, 187);
            this.txtPrecioAlta.Name = "txtPrecioAlta";
            this.txtPrecioAlta.Size = new System.Drawing.Size(177, 20);
            this.txtPrecioAlta.TabIndex = 7;
            // 
            // lblPrecioAlta
            // 
            this.lblPrecioAlta.AutoSize = true;
            this.lblPrecioAlta.Location = new System.Drawing.Point(7, 170);
            this.lblPrecioAlta.Name = "lblPrecioAlta";
            this.lblPrecioAlta.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioAlta.TabIndex = 6;
            this.lblPrecioAlta.Text = "Precio";
            // 
            // txtStockAlta
            // 
            this.txtStockAlta.Location = new System.Drawing.Point(7, 137);
            this.txtStockAlta.Name = "txtStockAlta";
            this.txtStockAlta.Size = new System.Drawing.Size(177, 20);
            this.txtStockAlta.TabIndex = 5;
            // 
            // lblStockAlta
            // 
            this.lblStockAlta.AutoSize = true;
            this.lblStockAlta.Location = new System.Drawing.Point(7, 120);
            this.lblStockAlta.Name = "lblStockAlta";
            this.lblStockAlta.Size = new System.Drawing.Size(35, 13);
            this.lblStockAlta.TabIndex = 4;
            this.lblStockAlta.Text = "Stock";
            // 
            // txtNombreAlta
            // 
            this.txtNombreAlta.Location = new System.Drawing.Point(7, 86);
            this.txtNombreAlta.Name = "txtNombreAlta";
            this.txtNombreAlta.Size = new System.Drawing.Size(177, 20);
            this.txtNombreAlta.TabIndex = 3;
            // 
            // lblNombreAlta
            // 
            this.lblNombreAlta.AutoSize = true;
            this.lblNombreAlta.Location = new System.Drawing.Point(7, 69);
            this.lblNombreAlta.Name = "lblNombreAlta";
            this.lblNombreAlta.Size = new System.Drawing.Size(44, 13);
            this.lblNombreAlta.TabIndex = 2;
            this.lblNombreAlta.Text = "Nombre";
            // 
            // txtIdAlta
            // 
            this.txtIdAlta.Location = new System.Drawing.Point(7, 37);
            this.txtIdAlta.Name = "txtIdAlta";
            this.txtIdAlta.Size = new System.Drawing.Size(177, 20);
            this.txtIdAlta.TabIndex = 1;
            // 
            // lblIdAlta
            // 
            this.lblIdAlta.AutoSize = true;
            this.lblIdAlta.Location = new System.Drawing.Point(7, 20);
            this.lblIdAlta.Name = "lblIdAlta";
            this.lblIdAlta.Size = new System.Drawing.Size(16, 13);
            this.lblIdAlta.TabIndex = 0;
            this.lblIdAlta.Text = "Id";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 478);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpBuscar);
            this.Controls.Add(this.grpAlta);
            this.Name = "Form1";
            this.Text = "Sistema de gestión de productos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.grpBuscar.ResumeLayout(false);
            this.grpBuscar.PerformLayout();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpAlta.ResumeLayout(false);
            this.grpAlta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarPedidos;
        private System.Windows.Forms.ListBox lstPedidos;
        private System.Windows.Forms.Label lblPedidosDatos;
        private System.Windows.Forms.Label lblListaPedidos;
        private System.Windows.Forms.TextBox txtCantidadPedido;
        private System.Windows.Forms.Label lblCantidadPedido;
        private System.Windows.Forms.ComboBox cmbNombrePedido;
        private System.Windows.Forms.Label lblNombrePedido;
        private System.Windows.Forms.GroupBox grpBuscar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtIdBuscar;
        private System.Windows.Forms.Label lblIdBuscar;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtPrecioDatos;
        private System.Windows.Forms.Label lblPrecioDatos;
        private System.Windows.Forms.TextBox txtStockDatos;
        private System.Windows.Forms.Label lblStockDatos;
        private System.Windows.Forms.TextBox txtNombreDatos;
        private System.Windows.Forms.Label lblNombredatos;
        private System.Windows.Forms.GroupBox grpAlta;
        private System.Windows.Forms.Label lblProductosDatos;
        private System.Windows.Forms.Button btnMostrarProductos;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.Button btnAgregarProductos;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.Label lblListaProductos;
        private System.Windows.Forms.TextBox txtPrecioAlta;
        private System.Windows.Forms.Label lblPrecioAlta;
        private System.Windows.Forms.TextBox txtStockAlta;
        private System.Windows.Forms.Label lblStockAlta;
        private System.Windows.Forms.TextBox txtNombreAlta;
        private System.Windows.Forms.Label lblNombreAlta;
        private System.Windows.Forms.TextBox txtIdAlta;
        private System.Windows.Forms.Label lblIdAlta;
    }
}

