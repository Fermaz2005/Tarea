using System;
using MiniEcommerce.clases;

namespace MiniEcommerce
{
    public class Program
    {
        public static void Main()
        {
            Cliente cliente = new Cliente("Fernando", "fercho099@gmail.com");

            Carrito carrito = new Carrito();
            carrito.AgregarProducto(new ProductoFisico("Laptop", 800m, "Electrónica", 2.5m, 10));
            carrito.AgregarProducto(new ProductoDigital("Curso C#", 50m, "Educación", 500, 0));

            carrito.ListarProductos();
            decimal total = carrito.CalcularTotal();
            Console.WriteLine($"Total con impuestos: {total:C}");

            Orden orden = new Orden(cliente, carrito.ObtenerProductos(), total);
            orden.MostrarResumen();

            IPago metodoPago = new PagoConTarjeta("1234-5678-9876-5432", 1000m);
            orden.Confirmar(metodoPago);
        }
    }
}