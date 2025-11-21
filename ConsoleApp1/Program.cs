
class Program
{
    static void Main()
    {
        Carro carro = new Carro("ferrari", 300);

        carro.Estado();
    }
}
class Carro
{
    string Marca { get; set; }
    int Velocidad { get; set; }

    public Carro(string marca, int velocidad)
    {
        Marca = marca;
        Velocidad = velocidad;
    }

    public void Estado()
    {
        Console.WriteLine("El carro: " + Marca + " esta encendido y corre a: " + Velocidad);
    }
}