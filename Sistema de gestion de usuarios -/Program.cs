using System;

class Program 
{
    static void Main(string[] args)
    {
        List<Credenciales> listaUsuarios = new List<Credenciales>();
        Console.WriteLine("Bienvenidos a mi sistema de gestion de usuarios :D");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine(@"Menu de opciones: 
1.Ingresar al sistema
2.Salir");
        Console.WriteLine("-------------------------------------------------------------------------------");
        Console.WriteLine("Por favor ingresa el numero de tu eleccion");
        int opcion = Convert.ToInt32(Console.ReadLine());
        switch (opcion)
        {
            case 1:
                Console.WriteLine("Ingresa el nombre de usuario: ");
                string usuario = Console.ReadLine();
                Console.WriteLine("Ingresa la contraseña: ");
                string contrasena = Console.ReadLine();
                listaUsuarios.Add();
                break;

            case 2:
                Console.WriteLine("Gracias por venir :D, nos vemos");
                break;

        }

    }

}
class Credenciales
{
    string usuario {  get; set; }
    string contrasena { get; set; }

    public Credenciales(string Usuario, string Contrasena)
    {
        Usuario = usuario;
        Contrasena = contrasena;
    }

}
