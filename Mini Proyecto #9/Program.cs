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
            vectores[i] = aleatorio.Next(1, 101);
        }
        Console.WriteLine();
        Ordenar(vectores);

    }
    static void Ordenar(int[] arrayNum)
    {
        Console.WriteLine("Array Original: ");
        foreach (int numero in arrayNum) {
            Console.Write(numero + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < arrayNum.Length - 1; i++)
        {
            for (int j = 0; j < arrayNum.Length - 1; j++)
            {
                if (arrayNum[j] > arrayNum[j + 1])
                {
                    int temp = arrayNum[j];
                    arrayNum[j] = arrayNum[j + 1];
                    arrayNum[j + 1] = temp;
                }
            }

        }
    Console.WriteLine("Array Ordenado: ");
        foreach (int numero in arrayNum)
        {
            Console.Write(numero + " ");
        }
}
        

    
}
