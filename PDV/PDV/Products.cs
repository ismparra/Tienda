using System.ComponentModel;

public class Products
{
    public static Products Instace { get; private set; } = new();
    public List<Product> LstProduct { get; private set; } = new();
}

public class Product
{
    public string Clave { get; private set; }
    public string Nombre { get; private set; }
    public float Precio { get; private set; }
    public int Stock { get; private set; }
    public Product(string c, string n, float p)
    {
        Clave = c;
        Nombre = n;
        Precio = p;
    }
}

public class DetalleVenta
{
    public int Cant;
    public Product Product;
    public DetalleVenta(int c, Product p)
    {
        Cant = c;
        Product = p;
    }
}