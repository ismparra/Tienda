namespace PDV
{
    public partial class ProcesarVenta : Form
    {
        public ProcesarVenta() => InitializeComponent();
        public void ActualizarFechaHora()
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm");
            lblFecha.Text = DateTime.Now.ToString("dddd dd MMMM yyyy");
        }
        private void ProcesarVenta_Load(object sender, EventArgs e)
        {
            ActualizarFechaHora();
            tmSystemDT.Interval = (60 - DateTime.Now.Second) * 1000;
            tmSystemDT.Start();
        }

        #region Events
        //Timer
        private void tmSystemDT_Tick(object sender, EventArgs e) =>
            ActualizarFechaHora();
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
