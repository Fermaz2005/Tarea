namespace MiniEcommerce.clases
{
    public class ProductoFisico : Producto
    {
        public decimal Peso { get; private set; }

        public ProductoFisico(string nombre, decimal precio, string categoria, decimal peso, decimal descuento = 0)
            : base(nombre, precio, categoria, descuento)
        {
            Peso = peso;
        }
    }
}