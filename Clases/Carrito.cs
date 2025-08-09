using System;
using System.Collections.Generic;

namespace MiniEcommerce.clases
{
    public class Carrito
    {
        private List<Producto> productos = new List<Producto>();
        private decimal impuesto = 0.12m;

        public void AgregarProducto(Producto producto)
        {
            productos.Add(producto);
            Console.WriteLine($"Producto agregado: {producto.Nombre}");
        }

        public void EliminarProducto(Producto producto)
        {
            productos.Remove(producto);
            Console.WriteLine($"Producto eliminado: {producto.Nombre}");
        }

        public void ListarProductos()
        {
            Console.WriteLine("--- Productos en el carrito ---");
            foreach (var p in productos)
            {
                Console.WriteLine(p);
            }
        }

        public decimal CalcularTotal()
        {
            decimal subtotal = 0;
            foreach (var p in productos)
            {
                subtotal += p.ObtenerPrecioFinal();
            }
            return subtotal + (subtotal * impuesto);
        }

        public List<Producto> ObtenerProductos()
        {
            return productos;
        }
    }
}