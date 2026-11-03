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
            btnMinimizar = new Button();
            btnExit = new Button();
            lblFecha = new Label();
            lblHora = new Label();
            lblOrden = new Label();
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
            txtID = new TextBox();
            txtCant = new TextBox();
            label6 = new Label();
            label7 = new Label();
            button1 = new Button();
            grpHeader.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProducts).BeginInit();
            SuspendLayout();
            // 
            // grpHeader
            // 
            grpHeader.BackColor = Color.FromArgb(30, 41, 59);
            grpHeader.Controls.Add(btnMinimizar);
            grpHeader.Controls.Add(btnExit);
            grpHeader.Controls.Add(lblFecha);
            grpHeader.Controls.Add(lblHora);
            grpHeader.Controls.Add(lblOrden);
            grpHeader.Controls.Add(lblNegocio);
            grpHeader.Dock = DockStyle.Top;
            grpHeader.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpHeader.ForeColor = Color.LightSkyBlue;
            grpHeader.Location = new Point(0, 0);
            grpHeader.Margin = new Padding(1);
            grpHeader.Name = "grpHeader";
            grpHeader.Padding = new Padding(1);
            grpHeader.Size = new Size(1124, 66);
            grpHeader.TabIndex = 3;
            grpHeader.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.BackColor = Color.FromArgb(51, 65, 85);
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnMinimizar.ForeColor = Color.Azure;
            btnMinimizar.Location = new Point(1045, 17);
            btnMinimizar.Margin = new Padding(1);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(31, 25);
            btnMinimizar.TabIndex = 12;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnExit
            // 
            btnExit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnExit.BackColor = Color.FromArgb(239, 68, 68);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Azure;
            btnExit.Location = new Point(1080, 17);
            btnExit.Margin = new Padding(1);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(31, 25);
            btnExit.TabIndex = 11;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(148, 163, 184);
            lblFecha.Location = new Point(482, 25);
            lblFecha.Margin = new Padding(1, 0, 1, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(182, 21);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "dddd dd MMMM yyyy";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.ForeColor = Color.FromArgb(148, 163, 184);
            lblHora.Location = new Point(721, 25);
            lblHora.Margin = new Padding(1, 0, 1, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(73, 21);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:MM";
            // 
            // lblOrden
            // 
            lblOrden.AutoSize = true;
            lblOrden.ForeColor = Color.FromArgb(148, 163, 184);
            lblOrden.Location = new Point(308, 25);
            lblOrden.Margin = new Padding(1, 0, 1, 0);
            lblOrden.Name = "lblOrden";
            lblOrden.Size = new Size(84, 21);
            lblOrden.TabIndex = 1;
            lblOrden.Text = "Order: #0";
            // 
            // lblNegocio
            // 
            lblNegocio.AutoSize = true;
            lblNegocio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNegocio.ForeColor = Color.White;
            lblNegocio.Location = new Point(41, 25);
            lblNegocio.Margin = new Padding(1, 0, 1, 0);
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
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblIVA);
            panel1.Controls.Add(lblSubtotal);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dvProducts);
            panel1.Location = new Point(13, 167);
            panel1.Margin = new Padding(1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1156, 347);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(51, 65, 85);
            panel2.Controls.Add(label5);
            panel2.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1156, 58);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(402, 13);
            label5.Margin = new Padding(1, 0, 1, 0);
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
            lblTotal.ForeColor = Color.FromArgb(52, 211, 153);
            lblTotal.Location = new Point(379, 291);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 21);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "0.00$";
            // 
            // lblIVA
            // 
            lblIVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIVA.AutoSize = true;
            lblIVA.ForeColor = Color.FromArgb(148, 163, 184);
            lblIVA.Location = new Point(1056, 301);
            lblIVA.Margin = new Padding(1, 0, 1, 0);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(34, 15);
            lblIVA.TabIndex = 15;
            lblIVA.Text = "0.00$";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtotal.Location = new Point(1056, 281);
            lblSubtotal.Margin = new Padding(1, 0, 1, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(34, 15);
            lblSubtotal.TabIndex = 14;
            lblSubtotal.Text = "0.00$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 211, 153);
            label4.Location = new Point(57, 291);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(157, 21);
            label4.TabIndex = 13;
            label4.Text = "Total en esta venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(855, 301);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 12;
            label3.Text = "IVA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(827, 281);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 10;
            label2.Text = "Subtotal:";
            // 
            // dvProducts
            // 
            dvProducts.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dvProducts.BackgroundColor = Color.FromArgb(30, 41, 59);
            dvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProducts.Location = new Point(0, 59);
            dvProducts.Margin = new Padding(1);
            dvProducts.Name = "dvProducts";
            dvProducts.RowHeadersWidth = 62;
            dvProducts.Size = new Size(1156, 210);
            dvProducts.TabIndex = 9;
            dvProducts.CellMouseClick += dvProducts_CellMouseClick;
            // 
            // btnBuy
            // 
            btnBuy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnBuy.BackColor = Color.FromArgb(16, 185, 129);
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = SystemColors.Control;
            btnBuy.Location = new Point(1033, 89);
            btnBuy.Margin = new Padding(1);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(78, 20);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(30, 41, 59);
            txtID.BorderStyle = BorderStyle.None;
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(64, 95);
            txtID.Margin = new Padding(1);
            txtID.Name = "txtID";
            txtID.Size = new Size(160, 16);
            txtID.TabIndex = 6;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // txtCant
            // 
            txtCant.BackColor = Color.FromArgb(30, 41, 59);
            txtCant.BorderStyle = BorderStyle.None;
            txtCant.ForeColor = Color.White;
            txtCant.Location = new Point(307, 95);
            txtCant.Margin = new Padding(1);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(160, 16);
            txtCant.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(226, 232, 240);
            label6.Location = new Point(40, 95);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(18, 15);
            label6.TabIndex = 8;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(226, 232, 240);
            label7.Location = new Point(245, 94);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 9;
            label7.Text = "Cantidad";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(37, 99, 235);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(480, 92);
            button1.Margin = new Padding(1);
            button1.Name = "button1";
            button1.Size = new Size(78, 20);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAdd_Click;
            // 
            // ProcesarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1124, 473);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnBuy);
            Controls.Add(txtCant);
            Controls.Add(txtID);
            Controls.Add(panel1);
            Controls.Add(grpHeader);
            ForeColor = Color.FromArgb(15, 23, 42);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(1);
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
            PerformLayout();
        }

        #endregion
        private GroupBox grpHeader;
        private Label lblNegocio;
        private Label lblOrden;
        private System.Windows.Forms.Timer tmSystemDT;
        private Label lblHora;
        private Label lblFecha;
        private Panel panel1;
        public Label lblTotal;
        private Label lblIVA;
        private Label lblSubtotal;
        private Label label4;
        private Label label3;
        private Label label2;
        private DataGridView dvProducts;
        private Panel panel2;
        private Label label5;
        private Button btnBuy;
        private TextBox txtID;
        private TextBox txtCant;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnExit;
        private Button btnMinimizar;
    }
}
