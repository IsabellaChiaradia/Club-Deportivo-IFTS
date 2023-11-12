namespace ClubDeportivo.Comprobantes
{
    partial class frmFactura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            lblClubDeportivo = new Label();
            lblClubDeportivo2 = new Label();
            lblFactura = new Label();
            lblTituloNombreApe = new Label();
            lblTituloDNI = new Label();
            lblTituloCaracter = new Label();
            lblTituloPago = new Label();
            lblTituloFechaPago = new Label();
            lblTituloDescuento = new Label();
            lblTituloFechaVenc = new Label();
            lblTituloFormaPago = new Label();
            lblTituloMonto = new Label();
            lblNombreApe = new Label();
            lblDNI = new Label();
            lblCaracter = new Label();
            lblPago = new Label();
            lblFechaPago = new Label();
            lblFechaVenc = new Label();
            lblFormaPago = new Label();
            lblDescuento = new Label();
            lblMonto = new Label();
            btnImprimirFactura = new Dashboard_ClubDeportivo.CustomBotonDos();
            btnVolver = new Dashboard_ClubDeportivo.CustomBotonDos();
            SuspendLayout();
            // 
            // lblClubDeportivo
            // 
            lblClubDeportivo.AutoSize = true;
            lblClubDeportivo.Enabled = false;
            lblClubDeportivo.FlatStyle = FlatStyle.Flat;
            lblClubDeportivo.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblClubDeportivo.ForeColor = Color.FromArgb(74, 102, 174);
            lblClubDeportivo.Location = new Point(156, 47);
            lblClubDeportivo.Name = "lblClubDeportivo";
            lblClubDeportivo.Size = new Size(237, 37);
            lblClubDeportivo.TabIndex = 0;
            lblClubDeportivo.Text = "Club deportivo";
            // 
            // lblClubDeportivo2
            // 
            lblClubDeportivo2.AutoSize = true;
            lblClubDeportivo2.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblClubDeportivo2.ForeColor = Color.FromArgb(74, 102, 174);
            lblClubDeportivo2.Location = new Point(156, 79);
            lblClubDeportivo2.Name = "lblClubDeportivo2";
            lblClubDeportivo2.Size = new Size(138, 37);
            lblClubDeportivo2.TabIndex = 1;
            lblClubDeportivo2.Text = "Nombre";
            // 
            // lblFactura
            // 
            lblFactura.AutoSize = true;
            lblFactura.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblFactura.ForeColor = Color.FromArgb(74, 102, 174);
            lblFactura.Location = new Point(31, 128);
            lblFactura.Name = "lblFactura";
            lblFactura.Size = new Size(107, 31);
            lblFactura.TabIndex = 2;
            lblFactura.Text = "Factura";
            // 
            // lblTituloNombreApe
            // 
            lblTituloNombreApe.AutoSize = true;
            lblTituloNombreApe.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloNombreApe.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloNombreApe.Location = new Point(31, 167);
            lblTituloNombreApe.Name = "lblTituloNombreApe";
            lblTituloNombreApe.Size = new Size(164, 22);
            lblTituloNombreApe.TabIndex = 3;
            lblTituloNombreApe.Text = "Nombre y apellido: ";
            // 
            // lblTituloDNI
            // 
            lblTituloDNI.AutoSize = true;
            lblTituloDNI.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloDNI.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloDNI.Location = new Point(31, 191);
            lblTituloDNI.Name = "lblTituloDNI";
            lblTituloDNI.Size = new Size(45, 22);
            lblTituloDNI.TabIndex = 4;
            lblTituloDNI.Text = "DNI:";
            // 
            // lblTituloCaracter
            // 
            lblTituloCaracter.AutoSize = true;
            lblTituloCaracter.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloCaracter.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloCaracter.Location = new Point(31, 215);
            lblTituloCaracter.Name = "lblTituloCaracter";
            lblTituloCaracter.Size = new Size(132, 22);
            lblTituloCaracter.TabIndex = 5;
            lblTituloCaracter.Text = "En caracter de:";
            // 
            // lblTituloPago
            // 
            lblTituloPago.AutoSize = true;
            lblTituloPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloPago.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloPago.Location = new Point(31, 239);
            lblTituloPago.Name = "lblTituloPago";
            lblTituloPago.Size = new Size(294, 22);
            lblTituloPago.TabIndex = 6;
            lblTituloPago.Text = "Pago de actividad o cuota mensual:";
            // 
            // lblTituloFechaPago
            // 
            lblTituloFechaPago.AutoSize = true;
            lblTituloFechaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFechaPago.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloFechaPago.Location = new Point(31, 290);
            lblTituloFechaPago.Name = "lblTituloFechaPago";
            lblTituloFechaPago.Size = new Size(135, 22);
            lblTituloFechaPago.TabIndex = 7;
            lblTituloFechaPago.Text = "Fecha de pago:";
            // 
            // lblTituloDescuento
            // 
            lblTituloDescuento.AutoSize = true;
            lblTituloDescuento.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloDescuento.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloDescuento.Location = new Point(31, 396);
            lblTituloDescuento.Name = "lblTituloDescuento";
            lblTituloDescuento.Size = new Size(101, 22);
            lblTituloDescuento.TabIndex = 8;
            lblTituloDescuento.Text = "Descuento:";
            // 
            // lblTituloFechaVenc
            // 
            lblTituloFechaVenc.AutoSize = true;
            lblTituloFechaVenc.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFechaVenc.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloFechaVenc.Location = new Point(31, 314);
            lblTituloFechaVenc.Name = "lblTituloFechaVenc";
            lblTituloFechaVenc.Size = new Size(190, 22);
            lblTituloFechaVenc.TabIndex = 9;
            lblTituloFechaVenc.Text = "Fecha de vencimiento:";
            // 
            // lblTituloFormaPago
            // 
            lblTituloFormaPago.AutoSize = true;
            lblTituloFormaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloFormaPago.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloFormaPago.Location = new Point(31, 371);
            lblTituloFormaPago.Name = "lblTituloFormaPago";
            lblTituloFormaPago.Size = new Size(136, 22);
            lblTituloFormaPago.TabIndex = 10;
            lblTituloFormaPago.Text = "Forma de pago:";
            // 
            // lblTituloMonto
            // 
            lblTituloMonto.AutoSize = true;
            lblTituloMonto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblTituloMonto.ForeColor = Color.FromArgb(74, 102, 174);
            lblTituloMonto.Location = new Point(276, 425);
            lblTituloMonto.Name = "lblTituloMonto";
            lblTituloMonto.Size = new Size(64, 22);
            lblTituloMonto.TabIndex = 11;
            lblTituloMonto.Text = "Monto:";
            // 
            // lblNombreApe
            // 
            lblNombreApe.AutoSize = true;
            lblNombreApe.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreApe.Location = new Point(194, 167);
            lblNombreApe.Name = "lblNombreApe";
            lblNombreApe.Size = new Size(58, 22);
            lblNombreApe.TabIndex = 12;
            lblNombreApe.Text = "label1";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDNI.Location = new Point(71, 191);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(58, 22);
            lblDNI.TabIndex = 13;
            lblDNI.Text = "label2";
            // 
            // lblCaracter
            // 
            lblCaracter.AutoSize = true;
            lblCaracter.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblCaracter.Location = new Point(163, 215);
            lblCaracter.Name = "lblCaracter";
            lblCaracter.Size = new Size(58, 22);
            lblCaracter.TabIndex = 14;
            lblCaracter.Text = "label3";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblPago.Location = new Point(333, 239);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(58, 22);
            lblPago.TabIndex = 15;
            lblPago.Text = "label4";
            // 
            // lblFechaPago
            // 
            lblFechaPago.AutoSize = true;
            lblFechaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaPago.Location = new Point(169, 290);
            lblFechaPago.Name = "lblFechaPago";
            lblFechaPago.Size = new Size(58, 22);
            lblFechaPago.TabIndex = 16;
            lblFechaPago.Text = "label5";
            // 
            // lblFechaVenc
            // 
            lblFechaVenc.AutoSize = true;
            lblFechaVenc.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFechaVenc.Location = new Point(228, 314);
            lblFechaVenc.Name = "lblFechaVenc";
            lblFechaVenc.Size = new Size(58, 22);
            lblFechaVenc.TabIndex = 17;
            lblFechaVenc.Text = "label6";
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFormaPago.Location = new Point(170, 371);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(58, 22);
            lblFormaPago.TabIndex = 18;
            lblFormaPago.Text = "label7";
            // 
            // lblDescuento
            // 
            lblDescuento.AutoSize = true;
            lblDescuento.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescuento.Location = new Point(131, 396);
            lblDescuento.Name = "lblDescuento";
            lblDescuento.Size = new Size(58, 22);
            lblDescuento.TabIndex = 19;
            lblDescuento.Text = "label8";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Font = new Font("Microsoft Sans Serif", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblMonto.Location = new Point(348, 425);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(58, 22);
            lblMonto.TabIndex = 21;
            lblMonto.Text = "label9";
            // 
            // btnImprimirFactura
            // 
            btnImprimirFactura.BackColor = Color.FromArgb(96, 61, 140);
            btnImprimirFactura.Cursor = Cursors.Hand;
            btnImprimirFactura.FlatAppearance.BorderSize = 0;
            btnImprimirFactura.FlatStyle = FlatStyle.Flat;
            btnImprimirFactura.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnImprimirFactura.ForeColor = Color.White;
            btnImprimirFactura.Location = new Point(276, 477);
            btnImprimirFactura.Margin = new Padding(3, 2, 3, 2);
            btnImprimirFactura.Name = "btnImprimirFactura";
            btnImprimirFactura.Size = new Size(181, 39);
            btnImprimirFactura.TabIndex = 33;
            btnImprimirFactura.Text = "IMPRIMIR";
            btnImprimirFactura.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.FromArgb(96, 61, 140);
            btnVolver.Cursor = Cursors.Hand;
            btnVolver.FlatAppearance.BorderSize = 0;
            btnVolver.FlatStyle = FlatStyle.Flat;
            btnVolver.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(40, 477);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(181, 39);
            btnVolver.TabIndex = 34;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 544);
            Controls.Add(btnVolver);
            Controls.Add(btnImprimirFactura);
            Controls.Add(lblMonto);
            Controls.Add(lblDescuento);
            Controls.Add(lblFormaPago);
            Controls.Add(lblFechaVenc);
            Controls.Add(lblFechaPago);
            Controls.Add(lblPago);
            Controls.Add(lblCaracter);
            Controls.Add(lblDNI);
            Controls.Add(lblNombreApe);
            Controls.Add(lblTituloMonto);
            Controls.Add(lblTituloFormaPago);
            Controls.Add(lblTituloFechaVenc);
            Controls.Add(lblTituloDescuento);
            Controls.Add(lblTituloFechaPago);
            Controls.Add(lblTituloPago);
            Controls.Add(lblTituloCaracter);
            Controls.Add(lblTituloDNI);
            Controls.Add(lblTituloNombreApe);
            Controls.Add(lblFactura);
            Controls.Add(lblClubDeportivo);
            Controls.Add(lblClubDeportivo2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmFactura";
            Load += frmFactura_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblClubDeportivo;
        private Label lblClubDeportivo2;
        private Label lblFactura;
        private Label lblTituloNombreApe;
        private Label lblTituloDNI;
        private Label lblTituloCaracter;
        private Label lblTituloPago;
        private Label lblTituloFechaPago;
        private Label lblTituloDescuento;
        private Label lblTituloFechaVenc;
        private Label lblTituloFormaPago;
        private Label lblTituloMonto;
        private Label lblNombreApe;
        private Label lblDNI;
        private Label lblCaracter;
        private Label lblPago;
        private Label lblFechaPago;
        private Label lblFechaVenc;
        private Label lblFormaPago;
        private Label lblDescuento;
        private Label lblMonto;
        private Dashboard_ClubDeportivo.CustomBotonDos btnImprimirFactura;
        private Dashboard_ClubDeportivo.CustomBotonDos btnVolver;
    }
}