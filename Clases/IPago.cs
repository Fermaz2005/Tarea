namespace MiniEcommerce.clases
{
    public interface IPago
    {
        bool ProcesarPago(decimal monto);
    }
}