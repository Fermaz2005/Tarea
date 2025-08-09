using System;

namespace MiniEcommerce.clases
{
    public class PagoConTarjeta : IPago
    {
        public string NumeroTarjeta { get; private set; }
        public decimal SaldoDisponible { get; private set; }

        public PagoConTarjeta(string numeroTarjeta, decimal saldo)
        {
            NumeroTarjeta = numeroTarjeta;
            SaldoDisponible = saldo;
        }

        public bool ProcesarPago(decimal monto)
        {
            if (SaldoDisponible >= monto)
            {
                SaldoDisponible -= monto;
                Console.WriteLine($"Pago con tarjeta aprobado. Nuevo saldo: {SaldoDisponible:C}");
                return true;
            }
            Console.WriteLine("Pago con tarjeta rechazado: fondos insuficientes.");
            return false;
        }
    }
}