/*
 Mini-proyecto 8 (algoritmos básicos con arreglos)
Haz un programa que implemente métodos separados para:

– Buscar un número en el arreglo y devolver si existe o no
– Contar cuántas veces se repite un número dado
– Invertir el arreglo (primer elemento pasa a ser el último, etc.)

Luego, en Main:

– Pide un número al usuario
– Muestra si el número existe
– Muestra cuántas veces se repite
– Muestra el arreglo original
– Muestra el arreglo invertido
 */
class Program
{
    static void Main(string[] args)
    {
        //Random aleatorio = new Random();
        int[] vectores = { 17, 20, 31, 49, 12, 23, 45, 27, 9, 38, 17};
        Console.WriteLine("Bienvenidos al sistema #8 :D");
        bool bluce = true;
        while(bluce){
            Guiones();
            Console.Write("Inserta un numero: ");
            string input = Console.ReadLine();
            bool sucess = int.TryParse(input, out int num);
            if (sucess)
            {
                ExisteNUm(vectores, num);
                int veces = Contar(vectores, num);
                Console.WriteLine($"El numero se repite {veces} veces");
                MostrarArreglo(vectores);
                InvertirArreglo(vectores);
                bluce = false;
                Guiones();
            }
            else 
            {
                Console.WriteLine("Digito invalido.");
            }
        }

    }

    static void ExisteNUm(int[] arrayNum, int numero)
    {
        bool existe = false;
        for (int i = 0; i < arrayNum.Length; i++)
        {
            if(numero == arrayNum[i])
            {
                existe = true;
                break;
            }
        }
        if (existe)
        {
            Console.WriteLine($"El numero {numero} se encuentra en el arreglo.");
        }
        else
        {
            Console.WriteLine($"El numero {numero} no se encuentra en el arreglo");
        }
    }

    static void Guiones()
    {
        Console.WriteLine("----------------------------------------------------------------------");
    }

    static int Contar(int[] arrayNum, int numero)
    {
        int contador = 0;
        for(int i = 0;i < arrayNum.Length; i++)
        {
            if (arrayNum[i] == numero)
                contador++;          
        }
        return contador;
    }

    static void MostrarArreglo(int[] arrayNum)
    {
        for(int i = 0;i < arrayNum.Length; i++)
        {
            Console.Write(arrayNum[i]+ "\t");
        }
        Console.WriteLine();
    }
    static void InvertirArreglo(int[] arrayNum)
    {
        int j = arrayNum.Length - 1;
        int[] invertido = new int[arrayNum.Length];
        for (int i = 0; i < arrayNum.Length; i++)
        {
            invertido[i] = arrayNum[j];
            Console.Write(invertido[i] + "\t");
            j--;
        }
        Console.WriteLine();
    }
}
