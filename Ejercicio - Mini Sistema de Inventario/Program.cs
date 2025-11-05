class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ya funciono...");
    }
}

class Producto
{
    int Id;
    string Nombre;
    decimal Precio;
    int Cantidad;

    public Producto(int id, string nombre, decimal precio, int cantidad)
    {
        Id = id;
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Datos del producto: Id: {Id}, Nombre: {Nombre}, Precio: {Precio}, Cantidad: {Cantidad}");
    }

     interface IGestion<T>
    {
        void Agregar(T item);
        void Eliminar(int id);
        T BuscarId(int id);
        void Listar();
    }

    class Inventario : IGestion<Producto>
    {

    }
}

