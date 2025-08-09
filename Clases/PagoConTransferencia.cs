using System;

namespace MiniEcommerce.clases
{
    public class PagoConTransferencia : IPago
    {
        public string CuentaBancaria { get; private set; }
        public bool VerificacionExitosa { get; private set; }

        public PagoConTransferencia(string cuenta, bool verificado)
        {
            CuentaBancaria = cuenta;
            VerificacionExitosa = verificado;
        }

        public bool ProcesarPago(decimal monto)
        {
            if (VerificacionExitosa)
            {
                Console.WriteLine($"Transferencia de {monto:C} realizada desde {CuentaBancaria}.");
                return true;
            }
            Console.WriteLine("Transferencia rechazada: cuenta no verificada.");
            return false;
        }
    }
}