using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ya funciono...");
        Producto producto = new Producto(1,"Jugo",50,10);
        List<Producto> listaProducto = new List<Producto>();
        

        producto.MostrarInfo();

        Console.WriteLine("INSERTA EL ID PARA BUSCAR: ");
        int id = Convert.ToInt32(Console.ReadLine());

        
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
        List<Producto> listaProducto = new List<Producto>();
        public void Agregar(Producto item) 
        {
            listaProducto.Add(item);
        }

        public void Eliminar(int id)
        {
            listaProducto.RemoveAt(id);
        }

        public Producto BuscarId(int id)
        {
            foreach (Producto producto in listaProducto)
            {

            if (producto.Id == id)
                {
                    producto.MostrarInfo();
                    return producto;
                }
            }
            return null;
        }

        public void Listar()
        {
            foreach (var producto in listaProducto)
            {
              producto.MostrarInfo();
            }

        }


    }
}

