using MySql.Data.MySqlClient;
using System.Data;

public class Conection
{
    private static readonly string connectionString =
       "Server=localhost;Database=PDV_BD;Uid=root;Pwd=root;";
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

    public static int RegistrarVenta(IEnumerable<DetalleVenta> detalles)
    {
        ArgumentNullException.ThrowIfNull(detalles);

        List<DetalleVenta> lineas = detalles.ToList();
        if (lineas.Count == 0)
            throw new InvalidOperationException("La venta debe contener al menos un producto.");

        decimal subtotal = lineas.Sum(detalle => (decimal)detalle.Importe);
        decimal iva = subtotal * 0.16m;
        decimal total = subtotal + iva;

        using MySqlConnection conn = GetConnection();
        conn.Open();

        using MySqlTransaction transaction = conn.BeginTransaction(IsolationLevel.ReadCommitted);
        try
        {
            const string ventaSql = """
                INSERT INTO ventas (subtotal, iva, total)
                VALUES (@subtotal, @iva, @total);
                SELECT LAST_INSERT_ID();
                """;

            using MySqlCommand ventaCommand = new(ventaSql, conn, transaction);
            ventaCommand.Parameters.Add("@subtotal", MySqlDbType.Decimal).Value = subtotal;
            ventaCommand.Parameters.Add("@iva", MySqlDbType.Decimal).Value = iva;
            ventaCommand.Parameters.Add("@total", MySqlDbType.Decimal).Value = total;
            int idVenta = Convert.ToInt32(ventaCommand.ExecuteScalar());

            const string stockSql = """
                UPDATE productos
                SET stock = stock - @cantidad
                WHERE clave = @clave AND stock >= @cantidad;
                """;

            const string detalleSql = """
                INSERT INTO detalles_venta
                    (id_venta, clave, precio_unitario, cantidad, importe)
                VALUES
                    (@idVenta, @clave, @precioUnitario, @cantidad, @importe);
                """;

            foreach (DetalleVenta detalle in lineas)
            {
                if (detalle.Cant <= 0)
                    throw new InvalidOperationException("La cantidad de cada producto debe ser mayor que cero.");

                using MySqlCommand stockCommand = new(stockSql, conn, transaction);
                stockCommand.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = detalle.Product.Clave;
                stockCommand.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle.Cant;

                if (stockCommand.ExecuteNonQuery() != 1)
                    throw new InvalidOperationException($"No hay stock suficiente para el producto {detalle.Product.Clave}.");

                using MySqlCommand detalleCommand = new(detalleSql, conn, transaction);
                detalleCommand.Parameters.Add("@idVenta", MySqlDbType.Int32).Value = idVenta;
                detalleCommand.Parameters.Add("@clave", MySqlDbType.VarChar, 50).Value = detalle.Product.Clave;
                detalleCommand.Parameters.Add("@precioUnitario", MySqlDbType.Decimal).Value = (decimal)detalle.Precio;
                detalleCommand.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle.Cant;
                detalleCommand.Parameters.Add("@importe", MySqlDbType.Decimal).Value = (decimal)detalle.Importe;
                detalleCommand.ExecuteNonQuery();
            }

            transaction.Commit();
            return idVenta;
        }
        catch
        {
            transaction.Rollback();
            throw;
        }
    }
}