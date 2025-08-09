namespace MiniEcommerce.clases
{
    public class ProductoDigital : Producto
    {
        public double TamañoMB { get; private set; }

        public ProductoDigital(string nombre, decimal precio, string categoria, double tamañoMB, decimal descuento = 0)
            : base(nombre, precio, categoria, descuento)
        {
            TamañoMB = tamañoMB;
        }
    }
}