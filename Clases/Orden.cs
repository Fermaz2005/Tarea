using System;
using System.Collections.Generic;

namespace MiniEcommerce.clases
{
    public class Orden
    {
        public Cliente Cliente { get; private set; }
        public List<Producto> Productos { get; private set; }
        public decimal Total { get; private set; }
        public bool Confirmada { get; private set; }

        public Orden(Cliente cliente, List<Producto> productos, decimal total)
        {
            Cliente = cliente;
            Productos = productos;
            Total = total;
            Confirmada = false;
        }

        public void MostrarResumen()
        {
            Console.WriteLine($"Orden para {Cliente.Nombre} ({Cliente.Email}):");
            foreach (var p in Productos)
            {
                Console.WriteLine(p);
            }
            Console.WriteLine($"Total a pagar: {Total:C}");
        }

        public void Confirmar(IPago metodoPago)
        {
            if (metodoPago.ProcesarPago(Total))
            {
                Confirmada = true;
                Console.WriteLine("Orden confirmada y pagada.");
            }
            else
            {
                Console.WriteLine("No se pudo confirmar la orden.");
            }
        }

        public void Cancelar()
        {
            Confirmada = false;
            Console.WriteLine("Orden cancelada.");
        }
    }
}