class Program
{
  /*
     * Mini-proyecto 5
Muestre un menú repetitivo con las siguientes opciones:
1-Ingresar un número
2-Mostrar suma de los números ingresados
3-Mostrar promedio de los números ingresados
4-Mostrar cantidad de números ingresados
5-Reiniciar datos
6-Salir
El programa debe:
-Permitir ingresar números múltiples veces usando el menú.
-Ir acumulando la suma y la cantidad de números ingresados.
-Calcular el promedio solo cuando el usuario lo solicite.
-Reiniciar los valores cuando el usuario elija esa opción.
    */
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al mini proyecto #5, mi sistema");
        InsertarGuiones();
        int contador = 0;
        int acumulador = 0;
        bool estadoBucle = true;
        while (estadoBucle) {
            Console.WriteLine(@"Menu de opciones:
1.Ingresar un numero
2.Mostrar Suma de los numeros
3.Mostrar promedio de los numeros
4.Mostrar cantidad de numeros ingresados
5.Reiniciar datos
6.Salir
");
            InsertarGuiones();
            Console.Write("Por favor ingresa el numero de tu eleccion: ");
            string input = Console.ReadLine();
            bool valOpcion = int.TryParse(input, out int opcion);
            if (valOpcion)
            {
                switch (opcion)
                {
                    case 1:
                        bool estadoBulce2 = true;
                        while (estadoBulce2)
                        {
                            Console.Write("Has seleccionado ingresar un numero. Por favor, ingresa el de tu preferencia:");
                            string entrada = Console.ReadLine();
                            bool valEntrada = int.TryParse(entrada, out int num);
                            if (num == 0)
                            {
                                Console.WriteLine("No ingreses el numero 0, no tiene ninguna utilidad en este sistema.");
                                InsertarGuiones();
                            }
                            else if (valEntrada)
                            {
                                acumulador += num;
                                contador++;
                                estadoBulce2 = false;
                                Console.WriteLine("Numero agregado con exito, saliendo al menu...");
                                InsertarGuiones();
                            }
                            else
                            {
                                Console.WriteLine("Has ingresado un dato erroreo, por favor ingresa un numero.");
                                InsertarGuiones();
                            }
                        }
                        break;
                        case 2:
                                Console.WriteLine("Has seleccionado mostrar la sumatoria de numeros.");
                                Console.WriteLine($"La sumatoria de numeros ingresados es igual a: " + acumulador);
                                Console.Write("Presiona una tecla para regresar al menu.");
                                Console.ReadKey();
                                InsertarGuiones();
                                break;
                            case 3:
                                Console.WriteLine("Has seleccionado mostrar promedio de numeros.");
                                if (contador == 0 || acumulador == 0)
                                {
                                    Console.WriteLine("No hay ningun dato agregado.");
                                }
                                else
                                {
                            double prom = (double)acumulador / contador;
                            Console.WriteLine("El promedio de los numeros es igual a : " + prom);
                            Console.Write("Presiona una tecla para regresar al menu.");
                            Console.ReadKey();
                            InsertarGuiones();
                            }
                            break;
                    case 4:
                        Console.WriteLine("Has seleccionado mostrar la cantidad de numeros ingresados.");
                        Console.WriteLine($"La cantidad de numeros ingresados es igual a: " + contador);
                        Console.Write("Presiona una tecla para regresar al menu.");
                        Console.ReadKey();
                        InsertarGuiones();
                        break;

                    case 5:
                        Console.WriteLine("Has seleccionado reniciar los datos.");
                        contador = 0;
                        acumulador = 0;
                        Console.WriteLine("Datos eliminados, Volviendo al menu...");
                        InsertarGuiones();
                        break;
                    case 6:
                        Console.WriteLine("Gracias por utilizar el sistema :D, saliendo...");
                        estadoBucle = false;
                        break;
                    default:
                        Console.WriteLine("Opcion invalida, por favor ingresa un numero de las opciones disponibles.");
                        InsertarGuiones();
                        break;
                }
            }
            else
            {
                Console.WriteLine("el digito ingresado es invalido");
                Console.WriteLine();
            }
          }
        }
    static void InsertarGuiones()
    {
        Console.WriteLine("----------------------------------------------------------------------------------");
    }
}