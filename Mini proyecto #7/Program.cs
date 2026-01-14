/*
 * Haz un programa de consola que:

– Tenga un arreglo de enteros con tamaño fijo (por ejemplo, 10).
– Llene el arreglo solicitando los valores al usuario una sola vez.
– Implemente métodos separados para:

1.Calcular la suma
2.Calcular el promedio
3.Encontrar el número mayor
4.Encontrar el número menor

– Muestre todos los resultados al final.
*/
class Program
{
    static void Main(string[] args)
    {
        int[] vectores = new int[10];
        Console.WriteLine("Ingresa 10 valores.");
        for (int i = 0; i < vectores.Length; i++)
        {
            bool bucle = true;
            while (bucle)
            {
                Console.Write($"Valor {i + 1}: ");
                string input = Console.ReadLine();
                bool sucess = int.TryParse(input, out int num);
                if (sucess)
                {
                    vectores[i] = num;
                    bucle = false;
                }
                else
                {
                    Console.WriteLine("Digito invalido. Ingresa un numero valido.");
                    bucle = true;
                }
            }
        }
        int sumatoria = Suma(vectores);
        double promedio = Promedio(vectores);
        int numMayor = NumMayor(vectores);
        int numMenor = NumMenor(vectores);
        Console.WriteLine("La sumatoria es igual a: "+ sumatoria);
        Console.WriteLine("El promedio es igual a: " + promedio);
        Console.WriteLine("El numero mayor en el arreglo es igual a: " + numMayor);
        Console.WriteLine("El numero menor en el arreglo es igual a: " + numMenor);

    }

    static int Suma(int[] arregloNum)
    {
        int totalArreglo = 0;
        for (int i = 0; i < arregloNum.Length; i++) 
        {
            totalArreglo += arregloNum[i];
        }
        return totalArreglo;
    }

    static double Promedio(int[] arregloNum)
    {
        double promedio = 0;
        int cantidad = 0;
        int sumatoria = 0;
        for (int i = 0; i < arregloNum.Length; i++)
        {
            cantidad++;
            sumatoria += arregloNum[i];
        }
        promedio = (double)sumatoria / cantidad;
        return promedio;
    }

    static int NumMayor(int[] arregloNum)
    {
        int numMayor = 0;//error si los numeros son negativos
        for(int i = 0;i < arregloNum.Length; i++)
        {
            if (arregloNum[i] > numMayor)
            {
                numMayor = arregloNum[i];
            }
        }
        return numMayor;
    }
    static int NumMenor(int[] arregloNum)
    {
        int numMenor = arregloNum[0];
        for (int i = 0; i < arregloNum.Length; i++)
        {
            if (arregloNum[i] < numMenor)
            {
                numMenor = arregloNum[i];
            }
        }
        return numMenor;
    }
}