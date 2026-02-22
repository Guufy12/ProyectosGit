/*
 * Usa un arreglo de enteros.

Ordénalo primero (puedes reutilizar tu Bubble Sort).

Pide un número al usuario.

Implementa un método que:

Busque el número usando búsqueda binaria

Devuelva si el número existe o no

(Opcional) devuelva la posición donde se encontró

Muestra el resultado en consola.
 * */
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenidos al proyecto #10 - Binary Search :D");
        int[] arrayNum = new int[10];
        Random aleatorio = new Random();
        //int numAleatorio = aleatorio.Next(1,21);

        for(int i = 0; i < arrayNum.Length; i++ )
        {
            arrayNum[i] = aleatorio.Next(1,21);
        }
        Console.Write("Ingresa un numero: ");
        string input = Console.ReadLine();
        bool sucess = int.TryParse(input, out int numero);
        if (sucess)
        {

        }
    }

    static int BuesquedaBinaria(int[] arrayNum, int num)
    {
        Console.WriteLine("Arreglo original:");
        foreach(int numero in arrayNum)
        {
            Console.Write(numero + " ");
        }

        for(int i = 0; i < arrayNum.Length - 1; i++)
        {
            for(int j = 0;i < arrayNum.Length - 1; i++)
            {
                if (arrayNum[j] > arrayNum[j + 1])
                {
                    int temp = arrayNum[j];
                    arrayNum[j] = arrayNum[j + 1];
                    arrayNum[j + 1] = temp;
                }
            }
        }
        Console.WriteLine("Arreglo ordenado bubble sort:");
        foreach (int numero in arrayNum)
        {
            Console.Write(numero + " ");
        }

        int inicio = 0;
        int fin = arrayNum.Length;
        int medio = (inicio + fin) / 2;

        if (num == medio)
        {

        }


    }
}
