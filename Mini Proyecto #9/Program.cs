/*
Mini-proyecto 9: Ordenamiento básico (Bubble Sort)

Usando un arreglo de enteros:

– Implementa un método que ordene el arreglo de menor a mayor
– NO uses Array.Sort, LINQ ni métodos del lenguaje
– Usa solo ciclos y comparaciones
– Muestra el arreglo antes y después del ordenamiento
 */
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos a mi sistema #9");
        int[] vectores = new int[10];
        Random aleatorio = new Random();
        for (int i = 0; i < vectores.Length; i++)
        {
            vectores[i] = aleatorio.Next(1,101);
        }
        /*
        for (int i = 0;i < vectores.Length; i++)
        {
            Console.Write(vectores[i] + "\t");
        }
        */
        Console.WriteLine();
        Ordenar(vectores);

    }
    static void Ordenar(int[] arrayNum)
    {
        //int[] ordenado = new int[arrayNum.Length];
        Console.WriteLine("Array Original: ");
        foreach (int numero in arrayNum) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        int num = arrayNum[0];
        int posicion = 0;
        for (int i = 0; i < arrayNum.Length - 1; i++)
        {           
                for (int j = 1; j < arrayNum.Length - 1; j++)
                {               
                if (num > arrayNum[j])
                {
                    num = arrayNum[j];
                    posicion = j;

                    int temp = arrayNum[i];
                    arrayNum[j] = num;
                    arrayNum[posicion] = temp;
                }

            }


            /*int temp = arrayNum[i];
            arrayNum[i] = num;
            //num = temp;
            arrayNum[posicion] = temp;
            //ordenado[i] = num;
            */
        }
        Console.WriteLine("Array Ordenado: ");
        foreach (int numero in arrayNum)
        {
        Console.Write(numero + " ");
        }

    }
}
