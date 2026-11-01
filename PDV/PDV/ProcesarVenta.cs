using System.ComponentModel;
namespace PDV
{
    public partial class ProcesarVenta : Form
    {
        BindingList<DetalleVenta> detalles = new();
        public ProcesarVenta()
        {
            InitializeComponent();
            dvProducts.DataSource = detalles;
            Products.Instace.LstProduct.Add(new("7508310245041", "Hojas", 22));
        }
        public void ActualizarFechaHora()
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }
        public void AgregarProducto()
        {
            var p = Products.Instace.LstProduct.Find(x => x.Clave == txtID.Text);
            if (p != null)
            {
                int cant = 0;
                if (txtCant.Text == string.Empty) cant = 1;
                else if (int.TryParse(txtCant.Text, out int c))
                    cant = c;
                else return; //Mandar error
                detalles.Add(new(cant, p));
            }
            txtID.Text = string.Empty;
            txtID.Focus();
        }
        #region Events
        private void ProcesarVenta_Load(object sender, EventArgs e)
        {
            ActualizarFechaHora();
            tmSystemDT.Interval = (60 - DateTime.Now.Second) * 1000;
            tmSystemDT.Start();
        }
        //Timer
        private void tmSystemDT_Tick(object sender, EventArgs e) =>
            ActualizarFechaHora();
        private void btnBuy_Click(object sender, EventArgs e)
        {

        }
        private void btnAdd_Click(object sender, EventArgs e) =>
            AgregarProducto();
        #endregion

        private void btnBuy_Click(object sender, EventArgs e)
        {

        }

        private void lblFecha_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
