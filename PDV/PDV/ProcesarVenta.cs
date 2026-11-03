using System.ComponentModel;
namespace PDV
{
    public partial class ProcesarVenta : Form
    {

        public TextBox TxtCant => this.txtCant;
        public TextBox TxtID => this.txtID;
        public Label LblSubtotal => this.lblSubtotal;
        public Label LblIVA => this.lblIVA;
        public Label LblTotal => this.lblTotal;

        public BindingList<DetalleVenta> detalles { get; private set; } = new();
        public ProcesarVenta()
        {
            InitializeComponent();
            Conection.CargarProductos();
            int orden = Conection.ObtenerSiguienteVenta();
            lblOrden.Text = "Order: #" + (orden < 10 && orden > 0 ? "0" + orden : orden.ToString());
            dvProducts.DataSource = detalles;
            Products.Instace.LstProduct.Add(new("7508310245041", "Hojas", 22, 10));
            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn();
            btnEliminar.Name = "Eliminar";
            btnEliminar.HeaderText = "";
            btnEliminar.Text = "🗑";
            btnEliminar.UseColumnTextForButtonValue = true;
            btnEliminar.DefaultCellStyle.BackColor = Color.Firebrick;
            dvProducts.Columns.Add(btnEliminar);
            dvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public void ActualizarFechaHora()
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }
        #region Events
        private void ProcesarVenta_Load(object sender, EventArgs e)
        {
            ActualizarFechaHora();
            tmSystemDT.Interval = (60 - DateTime.Now.Second) * 1000;
            tmSystemDT.Start();
            dvProducts.AutoGenerateColumns = true;
        }
        //Timer
        private void tmSystemDT_Tick(object sender, EventArgs e) =>
            ActualizarFechaHora();
        private void btnBuy_Click(object sender, EventArgs e)
        {
            //Llamar al metodo que se encarga de la base de datos
        }
        private void btnAdd_Click(object sender, EventArgs e) =>
            this.AgregarProducto();
        private void btnExit_Click(object sender, EventArgs e) =>
            Environment.Exit(0);
        private void btnMinimizar_Click(object sender, EventArgs e) =>
            this.WindowState = FormWindowState.Minimized;
        private void dvProducts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (dvProducts.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                DetalleVenta producto = (DetalleVenta)dvProducts.Rows[e.RowIndex].DataBoundItem!;
                producto.Cant--;
                if (producto.Cant <= 0)
                {
                    dvProducts.Rows.RemoveAt(e.RowIndex);
                }
                dvProducts.Refresh();
                this.CalcularTotal();
            }
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.AgregarProducto();
        }
        #endregion
    }
}