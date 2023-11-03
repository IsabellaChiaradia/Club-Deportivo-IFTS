namespace Dashboard_ClubDeportivo.Pages
{
    partial class PagoMensualCuota
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PagoMensualCuota));
            lblPMC = new Label();
            txtMontoPMC = new TextBox();
            picMontoPMC = new PictureBox();
            txtDocumentoPMC = new TextBox();
            picDocPMC = new PictureBox();
            lblFormaPago = new Label();
            cbxEfectivo = new CheckBox();
            cbxTarjeta = new CheckBox();
            picCantCuotas = new PictureBox();
            cboCuotas = new ComboBox();
            pictureBox2 = new PictureBox();
            dtpPMC = new DateTimePicker();
            lblTotal = new Label();
            dataGridView1 = new DataGridView();
            btnPagar = new CustomBotonDos();
            btnPrint = new CustomBotonDos();
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDocPMC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblPMC
            // 
            lblPMC.AutoSize = true;
            lblPMC.Font = new Font("Microsoft Sans Serif", 16.1999989F, FontStyle.Bold, GraphicsUnit.Point);
            lblPMC.ForeColor = Color.White;
            lblPMC.Location = new Point(32, 26);
            lblPMC.Name = "lblPMC";
            lblPMC.Size = new Size(229, 26);
            lblPMC.TabIndex = 0;
            lblPMC.Text = "Pago mensual cuota";
            // 
            // txtMontoPMC
            // 
            txtMontoPMC.BackColor = Color.FromArgb(74, 102, 174);
            txtMontoPMC.BorderStyle = BorderStyle.None;
            txtMontoPMC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtMontoPMC.ForeColor = Color.White;
            txtMontoPMC.Location = new Point(50, 153);
            txtMontoPMC.Margin = new Padding(3, 2, 3, 2);
            txtMontoPMC.Multiline = true;
            txtMontoPMC.Name = "txtMontoPMC";
            txtMontoPMC.Size = new Size(214, 22);
            txtMontoPMC.TabIndex = 13;
            txtMontoPMC.Text = "Monto";
            txtMontoPMC.Enter += txtMontoPMC_Enter;
            txtMontoPMC.Leave += txtMontoPMC_Leave;
            // 
            // picMontoPMC
            // 
            picMontoPMC.Image = (Image)resources.GetObject("picMontoPMC.Image");
            picMontoPMC.Location = new Point(6, 143);
            picMontoPMC.Margin = new Padding(3, 2, 3, 2);
            picMontoPMC.Name = "picMontoPMC";
            picMontoPMC.Size = new Size(304, 43);
            picMontoPMC.SizeMode = PictureBoxSizeMode.Zoom;
            picMontoPMC.TabIndex = 11;
            picMontoPMC.TabStop = false;
            // 
            // txtDocumentoPMC
            // 
            txtDocumentoPMC.BackColor = Color.FromArgb(74, 102, 174);
            txtDocumentoPMC.BorderStyle = BorderStyle.None;
            txtDocumentoPMC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDocumentoPMC.ForeColor = Color.White;
            txtDocumentoPMC.Location = new Point(50, 86);
            txtDocumentoPMC.Margin = new Padding(3, 2, 3, 2);
            txtDocumentoPMC.Multiline = true;
            txtDocumentoPMC.Name = "txtDocumentoPMC";
            txtDocumentoPMC.Size = new Size(214, 22);
            txtDocumentoPMC.TabIndex = 12;
            txtDocumentoPMC.Text = "Documento";
            txtDocumentoPMC.Enter += txtDocumentoPMC_Enter;
            txtDocumentoPMC.Leave += txtDocumentoPMC_Leave;
            // 
            // picDocPMC
            // 
            picDocPMC.Image = (Image)resources.GetObject("picDocPMC.Image");
            picDocPMC.Location = new Point(6, 76);
            picDocPMC.Margin = new Padding(3, 2, 3, 2);
            picDocPMC.Name = "picDocPMC";
            picDocPMC.Size = new Size(304, 43);
            picDocPMC.SizeMode = PictureBoxSizeMode.Zoom;
            picDocPMC.TabIndex = 10;
            picDocPMC.TabStop = false;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormaPago.ForeColor = Color.White;
            lblFormaPago.Location = new Point(44, 251);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(130, 20);
            lblFormaPago.TabIndex = 14;
            lblFormaPago.Text = "Forma de pago";
            // 
            // cbxEfectivo
            // 
            cbxEfectivo.AutoSize = true;
            cbxEfectivo.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxEfectivo.ForeColor = Color.White;
            cbxEfectivo.Location = new Point(49, 293);
            cbxEfectivo.Margin = new Padding(3, 2, 3, 2);
            cbxEfectivo.Name = "cbxEfectivo";
            cbxEfectivo.Size = new Size(85, 24);
            cbxEfectivo.TabIndex = 23;
            cbxEfectivo.Text = "Efectivo";
            cbxEfectivo.UseVisualStyleBackColor = true;
            cbxEfectivo.CheckedChanged += cbxEfectivo_CheckedChanged;
            // 
            // cbxTarjeta
            // 
            cbxTarjeta.AutoSize = true;
            cbxTarjeta.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbxTarjeta.ForeColor = Color.White;
            cbxTarjeta.Location = new Point(49, 338);
            cbxTarjeta.Margin = new Padding(3, 2, 3, 2);
            cbxTarjeta.Name = "cbxTarjeta";
            cbxTarjeta.Size = new Size(151, 24);
            cbxTarjeta.TabIndex = 24;
            cbxTarjeta.Text = "Tarjeta de crédito";
            cbxTarjeta.UseVisualStyleBackColor = true;
            cbxTarjeta.CheckedChanged += cbxTarjeta_CheckedChanged;
            cbxTarjeta.CheckStateChanged += cbxTarjeta_CheckStateChanged;
            // 
            // picCantCuotas
            // 
            picCantCuotas.BackgroundImage = (Image)resources.GetObject("picCantCuotas.BackgroundImage");
            picCantCuotas.BackgroundImageLayout = ImageLayout.Stretch;
            picCantCuotas.Location = new Point(44, 391);
            picCantCuotas.Name = "picCantCuotas";
            picCantCuotas.Size = new Size(247, 43);
            picCantCuotas.TabIndex = 25;
            picCantCuotas.TabStop = false;
            // 
            // cboCuotas
            // 
            cboCuotas.Cursor = Cursors.Hand;
            cboCuotas.Enabled = false;
            cboCuotas.FlatStyle = FlatStyle.Popup;
            cboCuotas.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cboCuotas.ForeColor = Color.FromArgb(74, 102, 174);
            cboCuotas.FormattingEnabled = true;
            cboCuotas.Items.AddRange(new object[] { "3 cuotas", "6 cuotas" });
            cboCuotas.Location = new Point(58, 399);
            cboCuotas.Name = "cboCuotas";
            cboCuotas.Size = new Size(217, 28);
            cboCuotas.TabIndex = 26;
            cboCuotas.Text = "  Cantidad de cuotas";
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(362, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(247, 43);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // dtpPMC
            // 
            dtpPMC.CalendarForeColor = Color.Black;
            dtpPMC.CalendarTitleForeColor = Color.FromArgb(74, 102, 174);
            dtpPMC.Cursor = Cursors.Hand;
            dtpPMC.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpPMC.Format = DateTimePickerFormat.Short;
            dtpPMC.Location = new Point(379, 86);
            dtpPMC.MaxDate = new DateTime(2025, 12, 31, 0, 0, 0, 0);
            dtpPMC.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            dtpPMC.Name = "dtpPMC";
            dtpPMC.Size = new Size(215, 26);
            dtpPMC.TabIndex = 28;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotal.ForeColor = Color.White;
            lblTotal.Location = new Point(362, 157);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(157, 20);
            lblTotal.TabIndex = 29;
            lblTotal.Text = "Total con descuento:";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(362, 189);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(408, 174);
            dataGridView1.TabIndex = 30;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.FromArgb(96, 61, 140);
            btnPagar.Cursor = Cursors.Hand;
            btnPagar.FlatAppearance.BorderSize = 0;
            btnPagar.FlatStyle = FlatStyle.Flat;
            btnPagar.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(362, 395);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(181, 39);
            btnPagar.TabIndex = 31;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnPrint
            // 
            btnPrint.BackColor = Color.FromArgb(96, 61, 140);
            btnPrint.Cursor = Cursors.Hand;
            btnPrint.FlatAppearance.BorderSize = 0;
            btnPrint.FlatStyle = FlatStyle.Flat;
            btnPrint.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPrint.ForeColor = Color.White;
            btnPrint.Location = new Point(589, 395);
            btnPrint.Margin = new Padding(3, 2, 3, 2);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(181, 39);
            btnPrint.TabIndex = 32;
            btnPrint.Text = "IMPRIMIR";
            btnPrint.UseVisualStyleBackColor = false;
            // 
            // PagoMensualCuota
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 102, 174);
            Controls.Add(btnPrint);
            Controls.Add(btnPagar);
            Controls.Add(dataGridView1);
            Controls.Add(lblTotal);
            Controls.Add(dtpPMC);
            Controls.Add(pictureBox2);
            Controls.Add(cboCuotas);
            Controls.Add(picCantCuotas);
            Controls.Add(cbxTarjeta);
            Controls.Add(cbxEfectivo);
            Controls.Add(lblFormaPago);
            Controls.Add(txtMontoPMC);
            Controls.Add(picMontoPMC);
            Controls.Add(txtDocumentoPMC);
            Controls.Add(picDocPMC);
            Controls.Add(lblPMC);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PagoMensualCuota";
            Size = new Size(789, 513);
            ((System.ComponentModel.ISupportInitialize)picMontoPMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDocPMC).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCantCuotas).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMontoPMC;
        private PictureBox picMontoPMC;
        private TextBox txtDocumentoPMC;
        private PictureBox picDocPMC;
        private Label lblFormaPago;
        private CheckBox cbxEfectivo;
        private CheckBox cbxTarjeta;
        private Label lblPMC;
        private PictureBox pictureBox1;
        private PictureBox picCantCuotas;
        private ComboBox cboCuotas;
        private PictureBox pictureBox2;
        private DateTimePicker dtpPMC;
        private Label lblTotal;
        private DataGridView dataGridView1;
        private CustomBotonDos btnPagar;
        private CustomBotonDos btnPrint;
    }
}
