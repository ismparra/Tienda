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
            grpHeader.Controls.Add(label1);
            grpHeader.Controls.Add(lblNegocio);
            grpHeader.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpHeader.ForeColor = Color.LightSkyBlue;
            grpHeader.Location = new Point(-1, -14);
            grpHeader.Margin = new Padding(2, 2, 2, 2);
            grpHeader.Name = "grpHeader";
            grpHeader.Padding = new Padding(2, 2, 2, 2);
            grpHeader.Size = new Size(1186, 88);
            grpHeader.TabIndex = 3;
            grpHeader.TabStop = false;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.FromArgb(51, 65, 85);
            btnMinimizar.FlatStyle = FlatStyle.Popup;
            btnMinimizar.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold);
            btnMinimizar.ForeColor = Color.Azure;
            btnMinimizar.Location = new Point(1094, 23);
            btnMinimizar.Margin = new Padding(2, 2, 2, 2);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 33);
            btnMinimizar.TabIndex = 12;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(239, 68, 68);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Azure;
            btnExit.Location = new Point(1134, 23);
            btnExit.Margin = new Padding(2, 2, 2, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(35, 33);
            btnExit.TabIndex = 11;
            btnExit.Text = "X";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = Color.FromArgb(148, 163, 184);
            lblFecha.Location = new Point(550, 33);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(232, 28);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "dddd dd MMMM yyyy";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.ForeColor = Color.FromArgb(148, 163, 184);
            lblHora.Location = new Point(824, 33);
            lblHora.Margin = new Padding(2, 0, 2, 0);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(90, 28);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:MM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(148, 163, 184);
            label1.Location = new Point(352, 33);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(105, 28);
            label1.TabIndex = 1;
            label1.Text = "Order: #0";
            // 
            // lblNegocio
            // 
            lblNegocio.AutoSize = true;
            lblNegocio.Font = new Font("Algerian", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNegocio.ForeColor = Color.White;
            lblNegocio.Location = new Point(46, 34);
            lblNegocio.Margin = new Padding(2, 0, 2, 0);
            lblNegocio.Name = "lblNegocio";
            lblNegocio.Size = new Size(212, 26);
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
            panel1.Location = new Point(14, 222);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1146, 463);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(51, 65, 85);
            panel2.Controls.Add(label5);
            panel2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 2);
            panel2.Margin = new Padding(2, 2, 2, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1146, 77);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(350, 18);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(493, 40);
            label5.TabIndex = 0;
            label5.Text = "DETALLES DE LA VENTA";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.FromArgb(52, 211, 153);
            lblTotal.Location = new Point(270, 388);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(65, 28);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "0.00$";
            // 
            // lblIVA
            // 
            lblIVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIVA.AutoSize = true;
            lblIVA.ForeColor = Color.FromArgb(148, 163, 184);
            lblIVA.Location = new Point(1030, 402);
            lblIVA.Margin = new Padding(2, 0, 2, 0);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(44, 20);
            lblIVA.TabIndex = 15;
            lblIVA.Text = "0.00$";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.ForeColor = Color.FromArgb(148, 163, 184);
            lblSubtotal.Location = new Point(1030, 374);
            lblSubtotal.Margin = new Padding(2, 0, 2, 0);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(44, 20);
            lblSubtotal.TabIndex = 14;
            lblSubtotal.Text = "0.00$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(52, 211, 153);
            label4.Location = new Point(66, 388);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(197, 28);
            label4.TabIndex = 13;
            label4.Text = "Total en esta venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(148, 163, 184);
            label3.Location = new Point(978, 402);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 12;
            label3.Text = "IVA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(148, 163, 184);
            label2.Location = new Point(946, 374);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 10;
            label2.Text = "Subtotal:";
            // 
            // dvProducts
            // 
            dvProducts.BackgroundColor = Color.FromArgb(30, 41, 59);
            dvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProducts.Location = new Point(0, 78);
            dvProducts.Margin = new Padding(2, 2, 2, 2);
            dvProducts.Name = "dvProducts";
            dvProducts.RowHeadersWidth = 62;
            dvProducts.Size = new Size(1146, 280);
            dvProducts.TabIndex = 9;
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(16, 185, 129);
            btnBuy.FlatAppearance.BorderSize = 0;
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = SystemColors.Control;
            btnBuy.Location = new Point(1044, 126);
            btnBuy.Margin = new Padding(2, 2, 2, 2);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(90, 27);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            btnBuy.Click += btnBuy_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(30, 41, 59);
            txtID.BorderStyle = BorderStyle.None;
            txtID.Location = new Point(74, 126);
            txtID.Margin = new Padding(2, 2, 2, 2);
            txtID.Name = "txtID";
            txtID.Size = new Size(183, 20);
            txtID.TabIndex = 6;
            // 
            // txtCant
            // 
            txtCant.BackColor = Color.FromArgb(30, 41, 59);
            txtCant.BorderStyle = BorderStyle.None;
            txtCant.Location = new Point(351, 126);
            txtCant.Margin = new Padding(2, 2, 2, 2);
            txtCant.Name = "txtCant";
            txtCant.Size = new Size(183, 20);
            txtCant.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(226, 232, 240);
            label6.Location = new Point(46, 129);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(24, 20);
            label6.TabIndex = 8;
            label6.Text = "ID";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(226, 232, 240);
            label7.Location = new Point(280, 130);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
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
            button1.Location = new Point(549, 123);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 10;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnAdd_Click;
            // 
            // ProcesarVenta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(15, 23, 42);
            ClientSize = new Size(1178, 710);
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
            Margin = new Padding(2, 2, 2, 2);
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
        private TextBox txtID;
        private TextBox txtCant;
        private Label label6;
        private Label label7;
        private Button button1;
        private Button btnExit;
        private Button btnMinimizar;
    }
}
