/*Ejercicio 1: Datos y estado (base de toda app)

Objetivo: manejar información como lo haría una app.
Tarea:
*Crea un programa de consola que:
-Guarde nombre, correo y edad de un usuario
-Valide que la edad sea mayor a 0
-Muestre los datos formateados

Qué estás entrenando:
Variables, tipos, validación, salida de datos
Dónde aparece en apps: registro de usuario, perfil, formularios*/
using System;
class Program
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Bienvenidos al ejercicio 1.1 datos y estados :D");
       
    }

}

class Persona
{
     public string Nombre { get; set; }
     public int Edad {  get; set; }
     public string Correo { get; set; }

    public Persona(string nombre, int edad, string correo)
    {
        Nombre = nombre;
        Edad = edad;
        Correo = correo;
    }

     public int MayorEdad()
    {
        int edad = 0;
        bool estado = true;
        while (estado)
        {
            Console.WriteLine("Ingrese su edad");
            string input = Console.ReadLine();
            bool sucess = int.TryParse(input, out edad);
            if (sucess)
            {
                if (edad >= 18)
                {
                    Console.WriteLine("La edad es valida. Es mayor de edad");
                    estado = false;
                }
                else if (edad < 0)
                {
                    Console.WriteLine("La edad es invalida. Edad pero negativo");
                    estado = false;
                }
                else
                {
                    Console.WriteLine("La edad es valida. Pero es menor de edad");
                    estado = false;
                }
            }
            else
            {
                Console.WriteLine("Edad invalidad. Favor ingresar un numero valido.");
            }
        }
        return edad;
    }
}