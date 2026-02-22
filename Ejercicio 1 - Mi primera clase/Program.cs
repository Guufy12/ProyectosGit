using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Persona persona1 = new Persona("erick", 18);
        Persona persona2 = new Persona("Mia", 12);

        Console.WriteLine("Hola " + persona1.Nombre+ " tienes " + persona1.Edad + " anyos");
        Console.WriteLine("Hola " + persona2.Nombre + " tienes " + persona2.Edad + " anyos");

    }
}
class Persona
{
    public string Nombre { get; set; }
    public int Edad { get; set; }

    public Persona(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }
}