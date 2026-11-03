using PDV;

public static class ProcesarVentaExtention
{
    public static void AgregarProducto(this ProcesarVenta form)
    {
        var p = Products.Instace.LstProduct.Find(x => x.Clave == form.TxtID.Text);
        if (p != null)
        {
            int cant = 0;
            if (form.TxtCant.Text == string.Empty) cant = 1;
            else if (int.TryParse(form.TxtCant.Text, out int c))
                cant = c;
            else return; //Mandar error
            if (form.detalles.Any(x => x.Product.Clave == p.Clave))
            {
                var d = form.detalles.First(x => x.Product.Clave == p.Clave);
                cant += d.Cant; form.detalles.Remove(d);
            }
            cant = Math.Clamp(cant, 0, p.Stock);
            if (cant == 0) return; //Mandar advertencia de que no hay stock
            form.detalles.Add(new(cant, p));
        }
        form.TxtID.Text = string.Empty;
        form.TxtCant.Text = string.Empty;
        form.CalcularTotal();
        form.TxtID.Focus();
    }

    public static void CalcularTotal(this ProcesarVenta form)
    {
        float subtotal = form.detalles.Sum(x => x.Importe);
        float iva = subtotal * 0.16f;
        float total = subtotal + iva;
        form.LblSubtotal.Text = subtotal.ToString("C2");
        form.LblIVA.Text = iva.ToString("C2");
        form.LblTotal.Text = total.ToString("C2");
    }
}