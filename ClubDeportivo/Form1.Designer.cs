namespace ClubDeportivo
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            lblSingin = new Label();
            linklblRecuperar = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.BackColor = Color.FromArgb(85, 96, 165);
            pictureBox2.Location = new Point(327, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(380, 490);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-3, -26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 490);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(85, 96, 165);
            txtUser.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(410, 189);
            txtUser.Multiline = true;
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(232, 40);
            txtUser.TabIndex = 5;
            txtUser.Text = "Usuario";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(85, 96, 165);
            txtPassword.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(410, 263);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(232, 40);
            txtPassword.TabIndex = 6;
            txtPassword.Text = "Contraseña";
            // 
            // lblSingin
            // 
            lblSingin.AutoSize = true;
            lblSingin.BackColor = Color.FromArgb(85, 96, 165);
            lblSingin.Font = new Font("Segoe UI Black", 36F, FontStyle.Regular, GraphicsUnit.Point);
            lblSingin.ForeColor = Color.White;
            lblSingin.Location = new Point(429, 89);
            lblSingin.Name = "lblSingin";
            lblSingin.Size = new Size(189, 65);
            lblSingin.TabIndex = 7;
            lblSingin.Text = "Sing in";
            // 
            // linklblRecuperar
            // 
            linklblRecuperar.ActiveLinkColor = Color.Red;
            linklblRecuperar.AutoSize = true;
            linklblRecuperar.BackColor = Color.FromArgb(85, 96, 165);
            linklblRecuperar.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            linklblRecuperar.ForeColor = Color.White;
            linklblRecuperar.LinkBehavior = LinkBehavior.HoverUnderline;
            linklblRecuperar.LinkColor = Color.Wheat;
            linklblRecuperar.Location = new Point(451, 329);
            linklblRecuperar.Name = "linklblRecuperar";
            linklblRecuperar.Size = new Size(141, 19);
            linklblRecuperar.TabIndex = 8;
            linklblRecuperar.TabStop = true;
            linklblRecuperar.Text = "Recuperar contraseña";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 450);
            Controls.Add(linklblRecuperar);
            Controls.Add(lblSingin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Label lblSingin;
        private LinkLabel linklblRecuperar;
    }
}