using System;

namespace MiniEcommerce.clases
{
    public abstract class Producto
    {
        public string Nombre { get; private set; }
        public decimal Precio { get; private set; }
        public string Categoria { get; private set; }
        public decimal Descuento { get; private set; }

        protected Producto(string nombre, decimal precio, string categoria, decimal descuento = 0)
        {
            Nombre = nombre;
            Precio = precio;
            Categoria = categoria;
            Descuento = descuento;
        }

        public virtual decimal ObtenerPrecioFinal()
        {
            return Precio - (Precio * Descuento / 100);
        }

        public override string ToString()
        {
            return $"{Nombre} - {Categoria} - {ObtenerPrecioFinal():C}";
        }
    }
}