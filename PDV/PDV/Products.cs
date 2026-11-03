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
    public Product(string c, string n, float p, int s)
    {
        Clave = c;
        Nombre = n;
        Precio = p;
        Stock = s;
    }
}

public class DetalleVenta
{
    public int Cant { get; set; }
    public Product Product;
    public string Nombre => Product.Nombre;
    public float Precio => Product.Precio;
    public float Importe => Cant * Product.Precio;
    public DetalleVenta(int c, Product p)
    {
        Cant = c;
        Product = p;
    }
}