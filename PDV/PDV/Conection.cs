using MySql.Data.MySqlClient;
public class Conection
{
    private static readonly string connectionString =
       "Server=localhost;Database=PDV_BD;Uid=root;Pwd=;";
    public static MySqlConnection GetConnection()
    {
        return new MySqlConnection(connectionString);
    }
    public static void CargarProductos()
    {
        Products.Instace.LstProduct.Clear();

        using MySqlConnection conn = Conection.GetConnection();

        conn.Open();

        string sql = "SELECT clave, nombre, precio, stock FROM productos";

        using MySqlCommand cmd = new(sql, conn);
        using MySqlDataReader reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Product producto = new(
                reader.GetString("clave"),
                reader.GetString("nombre"),
                reader.GetFloat("precio"),
                reader.GetInt32("stock")
            );

            Products.Instace.LstProduct.Add(producto);
        }
    }
    public static int ObtenerSiguienteVenta()
    {
        using MySqlConnection conn = Conection.GetConnection();

        conn.Open();

        string sql = "SELECT IFNULL(MAX(id_venta),0) + 1 FROM ventas";

        using MySqlCommand cmd = new(sql, conn);

        return Convert.ToInt32(cmd.ExecuteScalar());
    }
}