using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    internal class Producto
    {
        // Propiedades autoimplementadas 

        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Stock { get; set; }
        public Single Precio { get; set; }

        // Constructor 

        public Producto()
        {

        }

        public Producto(int id, string nombre, int stock, Single precio)
        {
            Id = id;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", Id, Nombre, Stock, Precio);
        }

        public string ToCSV()
        {
            return string.Format("{0};{1};{2};{3}", Id, Nombre, Stock, Precio);
        }

        public string ToCSVSubtotal(int cantidad)
        {
            return string.Format("{0};{1};${2}", Id, cantidad, cantidad * Precio);
        }


    }
}
