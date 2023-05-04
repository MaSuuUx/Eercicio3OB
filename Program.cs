class Program
{
    struct Cliente
    {
        public string nom;
        public string tel;
        public string direccion;
        public string correoElec;
        public bool nuevoCliente;

        public void PresentarDatos()
        {
            Console.WriteLine($"Nombre completo: {nom}");
            Console.WriteLine($"Teléfono: {tel}");
            Console.WriteLine($"Dirección: {direccion}");
            Console.WriteLine($"Email: {correoElec}");
            Console.WriteLine($"¿Nuevo cliente?: {nuevoCliente} ? Sí : No");
        }
    }
    static void Main(string[] args)
    {
        Cliente cliente1 = new Cliente();
        cliente1.nom = "Hector Marcelo Monge Caballero";
        cliente1.tel = "555-1234";
        cliente1.direccion = "John Doe 123 NW Street";
        cliente1.correoElec = "Hector.Monge@ejemplo.com";
        cliente1.nuevoCliente = true;

        Console.WriteLine("Datos del cliente:");
        cliente1.PresentarDatos();
    }
}
