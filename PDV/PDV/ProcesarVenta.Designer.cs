namespace PDV
{
    partial class ProcesarVenta
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            grpHeader = new GroupBox();
            button1 = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            label1 = new Label();
            lblNegocio = new Label();
            tmSystemDT = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            panel2 = new Panel();
            label5 = new Label();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubtotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dvProducts = new DataGridView();
            btnBuy = new Button();
            grpHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProducts).BeginInit();
            SuspendLayout();
            // 
            // grpHeader
            // 
            grpHeader.BackColor = Color.MidnightBlue;
            grpHeader.Controls.Add(button1);
            grpHeader.Controls.Add(lblFecha);
            grpHeader.Controls.Add(lblHora);
            grpHeader.Controls.Add(label1);
            grpHeader.Controls.Add(lblNegocio);
            grpHeader.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpHeader.ForeColor = Color.LightSkyBlue;
            grpHeader.Location = new Point(-1, -10);
            grpHeader.Margin = new Padding(2);
            grpHeader.Name = "grpHeader";
            grpHeader.Padding = new Padding(2);
            grpHeader.Size = new Size(839, 66);
            grpHeader.TabIndex = 3;
            grpHeader.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI Black", 8F, FontStyle.Bold);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(807, 12);
            button1.Name = "button1";
            button1.Size = new Size(32, 21);
            button1.TabIndex = 4;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(489, 21);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(182, 21);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "dddd dd MMMM yyyy";
            lblFecha.Click += lblFecha_Click;
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(729, 22);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(73, 21);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:MM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(381, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 1;
            label1.Text = "Order: #0";
            // 
            // lblNegocio
            // 
            lblNegocio.AutoSize = true;
            lblNegocio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNegocio.Location = new Point(41, 22);
            lblNegocio.Margin = new Padding(2, 0, 2, 0);
            lblNegocio.Name = "lblNegocio";
            lblNegocio.Size = new Size(147, 24);
            lblNegocio.TabIndex = 0;
            lblNegocio.Text = "La Pelon Store\r\n";
            // 
            // tmSystemDT
            // 
            tmSystemDT.Tick += tmSystemDT_Tick;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIVA);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dvProducts);
            panel1.Location = new Point(19, 68);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 329);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 117, 24);
            panel2.Controls.Add(label5);
            panel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(720, 58);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(149, 13);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(294, 29);
            label5.TabIndex = 0;
            label5.Text = "DETALLES DE LA VENTA";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Gold;
            lblTotal.Location = new Point(216, 292);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 21);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "0.00$";
            // 
            // lblIVA
            // 
            lblIVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIVA.AutoSize = true;
            lblIVA.ForeColor = Color.LightGreen;
            lblIVA.Location = new Point(580, 302);
            lblIVA.Margin = new Padding(2, 0, 2, 0);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(34, 15);
            lblIVA.TabIndex = 15;
            lblIVA.Text = "0.00$";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.ForeColor = Color.WhiteSmoke;
            lblSubtotal.Location = new Point(579, 281);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(34, 15);
            lblSubtotal.TabIndex = 14;
            lblSubtotal.Text = "0.00$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(58, 291);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 13;
            label4.Text = "Total en esta venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(504, 302);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "IVA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(479, 281);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Subtotal:";
            // 
            // dvProducts
            // 
            dvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProducts.Location = new Point(0, 58);
            dvProducts.Margin = new Padding(2);
            dvProducts.Name = "dvProducts";
            dvProducts.RowHeadersWidth = 62;
            dvProducts.Size = new Size(720, 210);
            dvProducts.TabIndex = 9;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(56, 176, 0);
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = SystemColors.Control;
            btnBuy.Location = new Point(750, 83);
            btnBuy.Margin = new Padding(2);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(78, 45);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // ProcesarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(838, 404);
            Controls.Add(btnBuy);
            Controls.Add(panel1);
            Controls.Add(grpHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "ProcesarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesar venta";
            Load += ProcesarVenta_Load;
            grpHeader.ResumeLayout(false);
            grpHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox grpHeader;
        private Label lblNegocio;
        private Label label1;
        private System.Windows.Forms.Timer tmSystemDT;
        private Label lblHora;
        private Label lblFecha;
        private Panel panel1;
        private Label lblTotal;
        private Label lblIVA;
        private Label lblSubtotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dvProducts;
        private Panel panel2;
        private Label label5;
        private Button btnBuy;
        private Button button1;
    }
}
