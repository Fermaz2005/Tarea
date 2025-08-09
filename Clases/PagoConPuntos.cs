using System;

namespace MiniEcommerce.clases
{
    public class PagoConPuntos : IPago
    {
        public int PuntosDisponibles { get; private set; }
        private decimal valorPorPunto = 0.05m;

        public PagoConPuntos(int puntos)
        {
            PuntosDisponibles = puntos;
        }

        public bool ProcesarPago(decimal monto)
        {
            int puntosNecesarios = (int)(monto / valorPorPunto);
            if (PuntosDisponibles >= puntosNecesarios)
            {
                PuntosDisponibles -= puntosNecesarios;
                Console.WriteLine($"Pago con puntos aprobado. Puntos restantes: {PuntosDisponibles}");
                return true;
            }
            Console.WriteLine("Pago con puntos rechazado: puntos insuficientes.");
            return false;
        }
    }
}