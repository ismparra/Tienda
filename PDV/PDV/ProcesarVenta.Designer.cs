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
            lblFecha = new Label();
            lblHora = new Label();
            label1 = new Label();
            lblNegocio = new Label();
            tmSystemDT = new System.Windows.Forms.Timer(components);
            panel1 = new Panel();
            lblTotal = new Label();
            lblIVA = new Label();
            lblSubtotal = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            dvProducts = new DataGridView();
            panel2 = new Panel();
            label5 = new Label();
            btnBuy = new Button();
            grpHeader.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvProducts).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // grpHeader
            // 
            grpHeader.BackColor = Color.MidnightBlue;
            grpHeader.Controls.Add(lblFecha);
            grpHeader.Controls.Add(lblHora);
            grpHeader.Controls.Add(label1);
            grpHeader.Controls.Add(lblNegocio);
            grpHeader.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpHeader.ForeColor = Color.LightSkyBlue;
            grpHeader.Location = new Point(-1, -17);
            grpHeader.Name = "grpHeader";
            grpHeader.Size = new Size(1199, 110);
            grpHeader.TabIndex = 3;
            grpHeader.TabStop = false;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(698, 35);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(277, 32);
            lblFecha.TabIndex = 3;
            lblFecha.Text = "dddd dd MMMM yyyy";
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Location = new Point(1042, 36);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(108, 32);
            lblHora.TabIndex = 2;
            lblHora.Text = "HH:MM";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 36);
            label1.Name = "label1";
            label1.Size = new Size(123, 32);
            label1.TabIndex = 1;
            label1.Text = "Order: #0";
            // 
            // lblNegocio
            // 
            lblNegocio.AutoSize = true;
            lblNegocio.Font = new Font("Algerian", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNegocio.Location = new Point(58, 36);
            lblNegocio.Name = "lblNegocio";
            lblNegocio.Size = new Size(245, 31);
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
            panel1.Location = new Point(27, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 548);
            panel1.TabIndex = 4;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTotal.ForeColor = Color.Gold;
            lblTotal.Location = new Point(308, 486);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(77, 32);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "0.00$";
            // 
            // lblIVA
            // 
            lblIVA.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblIVA.AutoSize = true;
            lblIVA.ForeColor = Color.LightGreen;
            lblIVA.Location = new Point(828, 503);
            lblIVA.Name = "lblIVA";
            lblIVA.Size = new Size(56, 25);
            lblIVA.TabIndex = 15;
            lblIVA.Text = "0.00$";
            // 
            // lblSubtotal
            // 
            lblSubtotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblSubtotal.AutoSize = true;
            lblSubtotal.ForeColor = Color.WhiteSmoke;
            lblSubtotal.Location = new Point(827, 468);
            lblSubtotal.Name = "lblSubtotal";
            lblSubtotal.Size = new Size(56, 25);
            lblSubtotal.TabIndex = 14;
            lblSubtotal.Text = "0.00$";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Gold;
            label4.Location = new Point(83, 485);
            label4.Name = "label4";
            label4.Size = new Size(235, 32);
            label4.TabIndex = 13;
            label4.Text = "Total en esta venta:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.LightGreen;
            label3.Location = new Point(720, 503);
            label3.Name = "label3";
            label3.Size = new Size(43, 25);
            label3.TabIndex = 12;
            label3.Text = "IVA:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(684, 468);
            label2.Name = "label2";
            label2.Size = new Size(83, 25);
            label2.TabIndex = 10;
            label2.Text = "Subtotal:";
            // 
            // dvProducts
            // 
            dvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvProducts.Location = new Point(0, 97);
            dvProducts.Name = "dvProducts";
            dvProducts.RowHeadersWidth = 62;
            dvProducts.Size = new Size(1029, 350);
            dvProducts.TabIndex = 9;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 117, 24);
            panel2.Controls.Add(label5);
            panel2.Font = new Font("Showcard Gothic", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(0, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1029, 96);
            panel2.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Ravie", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(213, 22);
            label5.Name = "label5";
            label5.Size = new Size(591, 49);
            label5.TabIndex = 0;
            label5.Text = "DETALLES DE LA VENTA";
            // 
            // btnBuy
            // 
            btnBuy.BackColor = Color.FromArgb(56, 176, 0);
            btnBuy.FlatStyle = FlatStyle.Flat;
            btnBuy.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuy.ForeColor = SystemColors.Control;
            btnBuy.Location = new Point(1071, 139);
            btnBuy.Name = "btnBuy";
            btnBuy.Size = new Size(112, 34);
            btnBuy.TabIndex = 5;
            btnBuy.Text = "BUY";
            btnBuy.UseVisualStyleBackColor = false;
            // 
            // ProcesarVenta
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(1197, 674);
            Controls.Add(btnBuy);
            Controls.Add(panel1);
            Controls.Add(grpHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProcesarVenta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesar venta";
            Load += ProcesarVenta_Load;
            grpHeader.ResumeLayout(false);
            grpHeader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dvProducts).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
    }
}
