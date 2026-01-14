/* 
 Haz un programa de consola que:
Maneje un arreglo de números enteros con un tamaño fijo (por ejemplo, 5 o 10).
Muestre un menú repetitivo con opciones como:

1.Agregar un número al arreglo
2.Mostrar todos los números almacenados
3.Mostrar la suma de los números
4.Mostrar el promedio
5.Salir

El programa debe:

Controlar la posición actual del arreglo (no sobrescribir valores).
No permitir agregar más números cuando el arreglo esté lleno.
Calcular suma y promedio recorriendo el arreglo con un ciclo.
Validar las entradas del usuario.*/
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        int cantidad = 0;
        int[] enteros = new int[10];
        int sumatoria = 0;
        double promedio;
        bool bucleEstado = true;
        Console.WriteLine("Bienvenidos al sistema #6 :D");
        while (bucleEstado)
        {
            Guiones();
            Console.WriteLine(@"Menu de opciones: 
1.Agregar un número al arreglo
2.Mostrar todos los números almacenados
3.Mostrar la suma de los números
4.Mostrar el promedio
5.Salir
");
            Console.Write("Por favor ingresa el numero de tu eleccion: ");
            string input = Console.ReadLine();
            bool inputVal = int.TryParse(input, out int opcion);
            if (inputVal)
            {
                switch (opcion)
                {
                    case 1:
                        Guiones();
                        Console.WriteLine("Elegiste agregar numero al arreglo");
                        bool estadoBucle2 = true;
                        while (estadoBucle2)
                        {
                            Console.Write("Por favor ingresa el numero: ");
                            string entrada = Console.ReadLine();
                            bool valEntrada = int.TryParse(entrada, out int num);
                            if (cantidad >= 10)
                            {
                                Console.WriteLine("No se pueden agregar mas numeros, saliendo al menu...");
                                Guiones();
                                break;
                            }
                            else if (valEntrada)
                            {
                                enteros[cantidad++] = num;
                                Console.WriteLine("Numero agregado, saliendo al menu...");
                                estadoBucle2 = false;
                                Guiones();
                            }
                            else
                            {
                                Console.WriteLine("Dato invalido. Por favor ingresa un numero");
                                Guiones();
                            }
                        }
                        break;
                    case 2:
                        Guiones();
                        Console.WriteLine("Elegiste mostrar numeros almacenados");
                        for (int i = 0; i < enteros.Length; i++)
                        {
                            Console.Write(enteros[i] + "\t");
                        }
                        Console.WriteLine();
                        break;
                    case 3:
                        Guiones();
                        Console.WriteLine("Elegiste mostrar sumatoria de numeros ");
                        /*for (int i = 0; i < enteros.Length; i++)
                        {
                            sumatoria += enteros[i];
                        }
                        Console.WriteLine($"La sumatoria de numeros es: {sumatoria}");
                        */
                        sumatoria = Sumatoria(enteros);
                        Console.WriteLine($"La sumatoria de numeros es: {sumatoria}");
                        break;
                    case 4:
                        Guiones();
                        Console.WriteLine("Elegiste mostrar sumatoria de numeros ");
                        if (cantidad != 0)
                        {
                            sumatoria = Sumatoria(enteros);
                            promedio = (double)sumatoria / cantidad;
                            Console.WriteLine("EL promedio de numeros es: " + promedio);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("No se puede calcular el promedio porque no hay datos ingresados");
                        }
                        break;

                    case 5:
                        Guiones();
                        Console.WriteLine("Gracias por venir :D");
                        bucleEstado = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, por favor ingresa una opcion valida.");
                        break;
                }

            }
        }
    }
    static void Guiones()
    {
        Console.WriteLine("--------------------------------------------------------");
    }
    static int Sumatoria(int[] enterosArr)
    {
        int total = 0;
        for (int i = 0; i < enterosArr.Length; i++)
        {
            total += enterosArr[i];
        }
        return total;
    }
}