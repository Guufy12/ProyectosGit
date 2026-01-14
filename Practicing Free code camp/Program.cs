using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al ejercicio 4");
        bool estado = true;
        while (estado)
        {
            InsertarGuiones();
            Console.WriteLine(@"Menu de opciones
1.Sumar dos numeros
2.Restar dos numeros
3.Multiplicar dos numeros
4.Dividir dos numeros
5.Salir
");
            InsertarGuiones();
            Console.Write("Por favor ingresa el numero de tu eleccion: ");
            string entrada = Console.ReadLine();
            bool val = int.TryParse(entrada, out int opcion);
            if (val)
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ha seleccionado sumar dos numeros, ingrese los valores.");
                        while (true)
                        {
                            Console.Write("Ingrese el 1er valor: ");
                            string input = Console.ReadLine();
                            Console.Write("Ingrese el 2do valor: ");
                            string input2 = Console.ReadLine();

                            int resultado;
                            bool valS1 = int.TryParse(input, out int s1);
                            bool valS2 = int.TryParse(input2, out int s2);
                            if (valS1 && valS2)
                            {
                                resultado = s1 + s2;
                                Console.WriteLine($"Este es tu resultado: " + resultado);
                                InsertarGuiones();
                                Console.WriteLine("Saliendo al menu...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error de entrada, por favor digite numeros.");
                                InsertarGuiones();
                            }
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ha seleccionado resta dos numeros, ingrese los valores.");
                        while (true)
                        {
                            Console.Write("Ingrese el 1er valor: ");
                            string input = Console.ReadLine();
                            Console.Write("Ingrese el 2do valor: ");
                            string input2 = Console.ReadLine();

                            int resultado;
                            bool valS1 = int.TryParse(input, out int s1);
                            bool valS2 = int.TryParse(input2, out int s2);
                            if (valS1 && valS2)
                            {
                                resultado = s1 - s2;
                                Console.WriteLine($"Este es tu resultado: " + resultado);
                                InsertarGuiones();
                                Console.WriteLine("Saliendo al menu...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error de entrada, por favor digite numeros.");
                                InsertarGuiones();
                            }
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ha seleccionado multiplicar dos numeros, ingrese los valores.");
                        while (true)
                        {
                            Console.Write("Ingrese el 1er valor: ");
                            string input = Console.ReadLine();
                            Console.Write("Ingrese el 2do valor: ");
                            string input2 = Console.ReadLine();

                            int resultado;
                            bool valS1 = int.TryParse(input, out int s1);
                            bool valS2 = int.TryParse(input2, out int s2);
                            if (valS1 && valS2)
                            {
                                resultado = s1 * s2;
                                Console.WriteLine($"Este es tu resultado: " + resultado);
                                InsertarGuiones();
                                Console.WriteLine("Saliendo al menu...");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Error de entrada, por favor digite numeros.");
                                InsertarGuiones();
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Ha seleccionado dividir dos numeros, ingrese los valores.");
                        while (true)
                        {
                            Console.Write("Ingrese el 1er valor: ");
                            string input = Console.ReadLine();
                            Console.Write("Ingrese el 2do valor: ");
                            string input2 = Console.ReadLine();

                            double resultado;
                            bool valS1 = double.TryParse(input, out double s1);
                            bool valS2 = double.TryParse(input2, out double s2);
                            try
                            {
                                if (valS1 && valS2)
                                {
                                    resultado = s1 / s2;
                                    Console.WriteLine($"Este es tu resultado: " + resultado);
                                    InsertarGuiones();
                                    Console.WriteLine("Saliendo al menu...");
                                    break;
                                }


                                else
                                {
                                    Console.WriteLine("Error de entrada, por favor digite numeros.");
                                    InsertarGuiones();
                                }
                            }
                            catch (DivideByZeroException)
                            {
                                Console.WriteLine("no se puede dividir enre cero");
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ocurrio un error" + ex);
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Ha seleccionado salir, gracias por visitarnos...");
                        estado = false;
                        break;

                }
            }
            else
            {
                Console.WriteLine("Ingresa un numero valido por favor.");
            }
        }
    }

            public static void InsertarGuiones()
    {
        for (int i = 0; i <= 30; i++)
        {
            Console.Write("-");

            if (i == 30)
                Console.WriteLine();
        }
    }
    /*Ejercicio 3
    int num;
    int sumNum = 0;
    bool validacion = false;
    Console.WriteLine("Por favor ingrese diferentes numeros y el 0 cuando guste");
    bool condicion = true;
    int contador = 0;

    while (condicion)
    {        
      Console.Write("Ingresa el numero: ");
      validacion = !int.TryParse(Console.ReadLine(), out num);

        if (num != 0)
        {
            if (validacion)
            {
                Console.WriteLine("Error de formato, favor ingresa un numero: ");
            }
            else
            {
                sumNum += num;
                contador++;
            }
        }
        else if (num == 0 && validacion == false)
        {
            Console.WriteLine($"Conteo terminado, el resultado es : {sumNum} y se ingresaron {contador} numeros");
            condicion = false;
        }
        else 
        {
            Console.WriteLine("algo fallo,  favor ingresa un numero nuevamente: ");
        }
    }
    */

    /*Ejercicio 2
    string mensaje = "";

    Console.Write("Ingresa un numero de tu preferencia: ");
    int num; //= Convert.ToInt32(Console.ReadLine());
    bool estado = !int.TryParse(Console.ReadLine(), out num);
    bool condicion = false;

    if (estado)
    {
        Console.WriteLine("Error, por favor ingresa un numero");
        estado = false;
    }

    else
    {
        if (num == 0)
        {
            mensaje += "EL numero es 0";
            condicion = true;
        }

        else if (num < 0)
        {
            mensaje += "El numero es negativo";
            condicion = true;
        }
        else if (num > 0)
        {
            mensaje += "El numero es positivo";
            condicion = true;
        }
        else
            mensaje += "Hubo un error";

        if (condicion)
        {

            if (num % 2 == 0)
            {
                mensaje += " y es un numero par";
            }
            else if (num % 2 != 0)
            {
                mensaje += " y el numero es impar";
            }
            Console.WriteLine(mensaje);
        }
    }
    */
    /*Ejercicio 1 
    Console.Write("Por favor ingresa tu nombre: ");
    string nombre = Console.ReadLine();
    Console.WriteLine($"Un placer {nombre}, por favor ingresa tus calificaciones");
    int c1, c2, c3;
    Console.Write("Calificacion 1: ");
    c1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Calificacion 2: ");
    c2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Calificacion 3: ");
    c3 = Convert.ToInt32(Console.ReadLine());

    double prom = (c1 + c2 + c3) / 3;
    Console.WriteLine($"Tu promedio de calificacion es {prom}");
    if (prom >= 70 && prom <= 100)
        Console.WriteLine("Pasaste la materia");
    else if (prom < 70 && prom >= 0)
        Console.WriteLine("Mio usted se jodio");
    else
        Console.WriteLine("calificacion invalida, miraa ver que hiciste");

    */
    /*
    int num;
    for (int i = 1; i <= 100; i++)
    {
        num = i;
        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine($"the number {i} is FizzBuzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine($"the number {i} is Fizz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine($"the number {i} is Buzz");
        }
        else
        {
            Console.WriteLine(num);
        }
    }
    */
        /*
        bool sucess = true;

        while (sucess)
        {
            Console.WriteLine("Please introduce a number:");
            string tryNumber = Console.ReadLine();
            if (int.TryParse(tryNumber, out int num))
            {
                for (int i = 0; i < num; i++)
                {
                    Console.Write("X");
                }
                sucess = false;
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        } */
    }


