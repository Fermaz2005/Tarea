namespace MiniEcommerce.clases
{
    public class Cliente
    {
        public string Nombre { get; private set; }
        public string Email { get; private set; }

        public Cliente(string nombre, string email)
        {
            Nombre = nombre;
            Email = email;
        }
    }
}