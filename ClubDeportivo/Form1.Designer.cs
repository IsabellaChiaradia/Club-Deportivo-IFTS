namespace Dashboard_ClubDeportivo
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pnlControlPanel = new Panel();
            btnClose2 = new Button();
            btnClose = new Button();
            panel1 = new Panel();
            btnExtra = new Boton();
            btnActividades = new Boton();
            btnPlantel = new Boton();
            btnPagosFactura = new Boton();
            btnGestion = new Boton();
            panel2 = new Panel();
            lblNombreUser = new Label();
            label2 = new Label();
            label1 = new Label();
            customPanel1 = new CustomPanel();
            pnlControlPanel.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlControlPanel
            // 
            pnlControlPanel.Controls.Add(btnClose2);
            pnlControlPanel.Controls.Add(btnClose);
            pnlControlPanel.Location = new Point(907, 13);
            pnlControlPanel.Name = "pnlControlPanel";
            pnlControlPanel.Size = new Size(184, 35);
            pnlControlPanel.TabIndex = 0;
            // 
            // btnClose2
            // 
            btnClose2.BackColor = Color.Transparent;
            btnClose2.BackgroundImage = (Image)resources.GetObject("btnClose2.BackgroundImage");
            btnClose2.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose2.Cursor = Cursors.Hand;
            btnClose2.FlatAppearance.BorderSize = 0;
            btnClose2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose2.FlatStyle = FlatStyle.Flat;
            btnClose2.Location = new Point(133, 1);
            btnClose2.Name = "btnClose2";
            btnClose2.Size = new Size(25, 31);
            btnClose2.TabIndex = 2;
            btnClose2.UseVisualStyleBackColor = false;
            btnClose2.Click += btnClose2_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Zoom;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnClose.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Location = new Point(77, 1);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(26, 31);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnExtra);
            panel1.Controls.Add(btnActividades);
            panel1.Controls.Add(btnPlantel);
            panel1.Controls.Add(btnPagosFactura);
            panel1.Controls.Add(btnGestion);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(408, 808);
            panel1.TabIndex = 1;
            // 
            // btnExtra
            // 
            btnExtra.BackColor = Color.FromArgb(74, 102, 174);
            btnExtra.BackgroundImageLayout = ImageLayout.None;
            btnExtra.Cursor = Cursors.Hand;
            btnExtra.FlatAppearance.BorderSize = 0;
            btnExtra.FlatStyle = FlatStyle.Flat;
            btnExtra.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnExtra.ForeColor = Color.White;
            btnExtra.Location = new Point(110, 668);
            btnExtra.Margin = new Padding(3, 4, 3, 4);
            btnExtra.Name = "btnExtra";
            btnExtra.Padding = new Padding(34, 0, 0, 0);
            btnExtra.Size = new Size(298, 83);
            btnExtra.TabIndex = 6;
            btnExtra.Text = "Algo más que agregar";
            btnExtra.TextAlign = ContentAlignment.MiddleLeft;
            btnExtra.UseVisualStyleBackColor = false;
            // 
            // btnActividades
            // 
            btnActividades.BackColor = Color.FromArgb(74, 102, 174);
            btnActividades.BackgroundImageLayout = ImageLayout.None;
            btnActividades.Cursor = Cursors.Hand;
            btnActividades.FlatAppearance.BorderSize = 0;
            btnActividades.FlatStyle = FlatStyle.Flat;
            btnActividades.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnActividades.ForeColor = Color.White;
            btnActividades.Location = new Point(110, 556);
            btnActividades.Margin = new Padding(3, 4, 3, 4);
            btnActividades.Name = "btnActividades";
            btnActividades.Padding = new Padding(34, 0, 0, 0);
            btnActividades.Size = new Size(298, 83);
            btnActividades.TabIndex = 5;
            btnActividades.Text = "Lista de actividades";
            btnActividades.TextAlign = ContentAlignment.MiddleLeft;
            btnActividades.UseVisualStyleBackColor = false;
            // 
            // btnPlantel
            // 
            btnPlantel.BackColor = Color.FromArgb(74, 102, 174);
            btnPlantel.BackgroundImageLayout = ImageLayout.None;
            btnPlantel.Cursor = Cursors.Hand;
            btnPlantel.FlatAppearance.BorderSize = 0;
            btnPlantel.FlatStyle = FlatStyle.Flat;
            btnPlantel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPlantel.ForeColor = Color.White;
            btnPlantel.Location = new Point(110, 444);
            btnPlantel.Margin = new Padding(3, 4, 3, 4);
            btnPlantel.Name = "btnPlantel";
            btnPlantel.Padding = new Padding(34, 0, 0, 0);
            btnPlantel.Size = new Size(298, 83);
            btnPlantel.TabIndex = 4;
            btnPlantel.Text = "Plantel docente";
            btnPlantel.TextAlign = ContentAlignment.MiddleLeft;
            btnPlantel.UseVisualStyleBackColor = false;
            // 
            // btnPagosFactura
            // 
            btnPagosFactura.BackColor = Color.FromArgb(74, 102, 174);
            btnPagosFactura.BackgroundImageLayout = ImageLayout.None;
            btnPagosFactura.Cursor = Cursors.Hand;
            btnPagosFactura.FlatAppearance.BorderSize = 0;
            btnPagosFactura.FlatStyle = FlatStyle.Flat;
            btnPagosFactura.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPagosFactura.ForeColor = Color.White;
            btnPagosFactura.Location = new Point(110, 332);
            btnPagosFactura.Margin = new Padding(3, 4, 3, 4);
            btnPagosFactura.Name = "btnPagosFactura";
            btnPagosFactura.Padding = new Padding(34, 0, 0, 0);
            btnPagosFactura.Size = new Size(298, 83);
            btnPagosFactura.TabIndex = 3;
            btnPagosFactura.Text = "Pagos y facturación";
            btnPagosFactura.TextAlign = ContentAlignment.MiddleLeft;
            btnPagosFactura.UseVisualStyleBackColor = false;
            // 
            // btnGestion
            // 
            btnGestion.BackColor = Color.FromArgb(74, 102, 174);
            btnGestion.BackgroundImageLayout = ImageLayout.None;
            btnGestion.Cursor = Cursors.Hand;
            btnGestion.FlatAppearance.BorderSize = 0;
            btnGestion.FlatStyle = FlatStyle.Flat;
            btnGestion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnGestion.ForeColor = Color.White;
            btnGestion.Location = new Point(110, 220);
            btnGestion.Margin = new Padding(3, 4, 3, 4);
            btnGestion.Name = "btnGestion";
            btnGestion.Padding = new Padding(34, 0, 0, 0);
            btnGestion.Size = new Size(298, 83);
            btnGestion.TabIndex = 2;
            btnGestion.Text = "Gestión de miembros";
            btnGestion.TextAlign = ContentAlignment.MiddleLeft;
            btnGestion.UseVisualStyleBackColor = false;
            btnGestion.Click += btnGestion_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(lblNombreUser);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(431, 79);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(656, 103);
            panel2.TabIndex = 2;
            // 
            // lblNombreUser
            // 
            lblNombreUser.AutoSize = true;
            lblNombreUser.Font = new Font("AvenirNext LT Pro Regular", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            lblNombreUser.ForeColor = SystemColors.ButtonHighlight;
            lblNombreUser.Location = new Point(161, 71);
            lblNombreUser.Name = "lblNombreUser";
            lblNombreUser.Size = new Size(221, 24);
            lblNombreUser.TabIndex = 2;
            lblNombreUser.Text = "NOMBRE DE USUARIO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("AvenirNext LT Pro Regular", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(46, 71);
            label2.Name = "label2";
            label2.Size = new Size(120, 24);
            label2.TabIndex = 1;
            label2.Text = "Bienvenido:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("AvenirNext LT Pro Bold", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(42, 11);
            label1.Name = "label1";
            label1.Size = new Size(371, 36);
            label1.TabIndex = 0;
            label1.Text = "Panel de control general";
            // 
            // customPanel1
            // 
            customPanel1.Location = new Point(477, 220);
            customPanel1.Margin = new Padding(3, 4, 3, 4);
            customPanel1.Name = "customPanel1";
            customPanel1.Size = new Size(574, 512);
            customPanel1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1107, 804);
            Controls.Add(customPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pnlControlPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            pnlControlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlControlPanel;
        private Button btnClose;
        private Button btnClose2;
        private Panel panel1;
        private Boton btnGestion;
        private Boton btnExtra;
        private Boton btnActividades;
        private Boton btnPlantel;
        private Boton btnPagosFactura;
        private Panel panel2;
        private Label label2;
        private Label label1;
        private Label lblNombreUser;
        private CustomPanel customPanel1;
    }
}