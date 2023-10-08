using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        List<Producto> productos = new List<Producto>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarProductos_Click(object sender, EventArgs e)
        {
            string id = txtIdAlta.Text;
            string nombre = txtNombreAlta.Text;
            string stock = txtStockAlta.Text;
            string precio = txtPrecioAlta.Text;

            bool flag = ValidarDatos(id, nombre, stock, precio);

            if (flag)
            {
                Producto p = new Producto();

                p.Id = Convert.ToInt32(id);
                p.Nombre = nombre;
                p.Stock = Convert.ToInt32(stock);
                p.Precio = Convert.ToInt32(precio);

                // Agregar en lista
                productos.Add(p);

                // Agregar en ListBox
                lstProductos.Items.Add(p.ToCSV());

                // Agregar en ComboBox 
                cmbNombrePedido.Items.Add(p.Nombre);

                MessageBox.Show("Se agregó el producto con Id: " + id, "Mensaje");
                LimpiarDatos();
            }
        }

        // Función para validar datos 

        private bool ValidarDatos(string id, string nombre, string stock, string precio)
        {
            bool flag = true;
            string acumulador = ""; // acumulador de mensajes de error

            acumulador += ValidarNumero(id, "Id");
            acumulador += ValidarVacio(nombre, "Nombre");
            acumulador += ValidarNumero(stock, "Stock");
            acumulador += ValidarDecimal(precio, "Precio");

            if (!string.IsNullOrEmpty(acumulador))
            {
                flag = false;
                MessageBox.Show(acumulador, "Error de datos");
                LimpiarDatos();
            }
            return flag;
        }

        private string ValidarNumero(string valor, string campo)
        {
            string mensajeError;

            if (!int.TryParse(valor, out int salida))
            {
                mensajeError = "El campo " + campo + " no es numérico." + System.Environment.NewLine;
            }
            else if (salida <= 0)
            {
                mensajeError = "El campo " + campo + " debe ser positivo y mayor a cero." + System.Environment.NewLine;
            }
            else
            {
                mensajeError = "";
            }
            return mensajeError;
        }

        private string ValidarVacio(string valor, string campo)
        {
            string mensajeError;

            if (string.IsNullOrEmpty(valor))
            {
                mensajeError = "El campo " + campo + " no debe estar vacío." + System.Environment.NewLine;
            }
            else
            {
                mensajeError = "";
            }
            return mensajeError;
        }

        private string ValidarDecimal(string valor, string campo)
        {
            string mensajeError;

            if (!int.TryParse(valor, out int salida))
            {
                mensajeError = "El campo " + campo + " no es un número decimal." + System.Environment.NewLine;
            }
            else if (salida <= 0)
            {
                mensajeError = "El campo " + campo + " debe ser positivo y mayor a cero." + System.Environment.NewLine;
            }
            else
            {
                mensajeError = "";
            }
            return mensajeError;
        }

        // Limpiar textBox 
        private void LimpiarDatos()
        {
            txtIdAlta.Clear();
            txtNombreAlta.Clear();
            txtStockAlta.Clear();
            txtPrecioAlta.Clear();
        }

        private void btnEliminarProductos_Click(object sender, EventArgs e)
        {
            if (lstProductos.Items.Count == 0)
            {
                MessageBox.Show("No hay ítems en la lista", "Mensaje");
            }
            else if (lstProductos.SelectedIndex == -1)
            {
                MessageBox.Show("No seleccionó ningún ítem", "Mensaje");
            }
            else
            {
                string[] item = lstProductos.SelectedItem.ToString().Split(';');
                Producto producto = BuscarProducto(Convert.ToInt32(item[0]));

                // Remover de lista
                productos.Remove(producto);

                // Remover de ListBox 
                lstProductos.Items.Remove(lstProductos.SelectedItem);

                // Remover de ComboBox 
                cmbNombrePedido.Items.Remove(producto.Nombre);

                MessageBox.Show("Se eliminó el producto con id: " + item[0], "Mensaje");
            }
        }

        private Producto BuscarProducto(int id)
        {
            return productos.Find(p => p.Id == id);
        }

        private void btnMostrarProductos_Click(object sender, EventArgs e)
        {
            string mensaje = "";

            foreach (Producto p in productos)
            {
                mensaje += p.ToString() + System.Environment.NewLine;
            }

            if (string.IsNullOrEmpty(mensaje))
            {
                MessageBox.Show("No hay productos", "Mensaje");
            }
            else
            {
                MessageBox.Show(mensaje, "Lista de productos");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string id = txtIdBuscar.Text;
            string mensajeError;

            mensajeError = ValidarNumero(id, "Id");

            if (string.IsNullOrEmpty(mensajeError))
            {
                Producto producto = BuscarProducto(Convert.ToInt32(id));

                if (producto == null)
                {
                    LimpiarCamposBuscar();
                    MessageBox.Show("No se encontro el producto con Id: " + id, "Mensaje");
                }
                else
                {
                    txtNombreDatos.Text = producto.Nombre;
                    txtStockDatos.Text = producto.Stock.ToString();
                    txtPrecioDatos.Text = producto.Precio.ToString();
                }
            }
            else
            {
                LimpiarCamposBuscar();
                MessageBox.Show(mensajeError, "Mensaje");
            }
        }

        private void LimpiarCamposBuscar()
        {
            txtIdBuscar.Clear();
            txtNombreDatos.Clear();
            txtStockDatos.Clear();
            txtPrecioDatos.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCamposBuscar();
        }

        private void btnAgregarPedidos_Click(object sender, EventArgs e)
        {
            string cantidad = txtCantidadPedido.Text;
            string mensajeError;

            mensajeError = ValidarNumero(cantidad, "Cantidad");

            Producto producto = BuscarProductoPorNombre(cmbNombrePedido.Text);

            if (producto == null)
            {
                MessageBox.Show("No existe el producto", "Mensaje");
            }
            else if (!string.IsNullOrEmpty(mensajeError))
            {
                MessageBox.Show(mensajeError, "Mensaje");
            }
            else if (producto.Stock < Convert.ToInt32(cantidad))
            {
                MessageBox.Show("No hay stock suficiente de " + producto.Nombre, "Mensaje");
            }
            else
            {
                // Agregar en ListBox
                lstPedidos.Items.Add(producto.ToCSVSubtotal(Convert.ToInt32(cantidad)));

                cmbNombrePedido.Items.Remove(cmbNombrePedido.SelectedItem);
                cmbNombrePedido.Text = "";
                txtCantidadPedido.Clear();

                MessageBox.Show("Se agrego el ítem al pedido", "Mensaje");
            }
        }

        private Producto BuscarProductoPorNombre(string nombre)
        {
            return productos.Find(p => p.Nombre == nombre);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void CargarProductos()
        {
            // ruta del archivo de texto
            string path = "C:\\Users\\ADM\\source\\repos\\WindowsFormsApp1\\productos.txt";

            FileInfo fi = new FileInfo(path);

            if (!fi.Exists)
            {
                MessageBox.Show("No se ha encontrado el archivo de texto", "¡Bienvenido!");
            }
            else
            {
                StreamReader sr = fi.OpenText();

                while (!sr.EndOfStream)
                {
                    string linea = sr.ReadLine();
                    string[] vector = linea.Split(';');

                    // Se usa constructor vacio
                    Producto producto = new Producto();

                    producto.Id = Convert.ToInt32(vector[0]);
                    producto.Nombre = vector[1];
                    producto.Stock = Convert.ToInt32(vector[2]);
                    producto.Precio = Convert.ToSingle(vector[3]);

                    // Agregar en lista
                    productos.Add(producto);

                    // Agregar en ListBox 
                    lstProductos.Items.Add(linea);

                    // Agergar en ComboBox
                    cmbNombrePedido.Items.Add(producto.Nombre);
                }

                sr.Close();

                MessageBox.Show("Se ha cargado el archivo de texto con éxito", "¡Bienvenido!");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GuardarProductos(); 
        }

        public void GuardarProductos()
        {
            // ruta del archivo de texto
            string path = "C:\\Users\\ADM\\source\\repos\\WindowsFormsApp1\\productos.txt";

            StreamWriter sw = new StreamWriter(path);

            foreach(Producto p in productos)
            {
                sw.WriteLine(p.ToCSV());
            }

            sw.Close();

            MessageBox.Show("El archivo se guardo correctamente.", "Mensaje"); 
        }
    }
}
