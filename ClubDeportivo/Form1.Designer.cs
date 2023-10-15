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
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            lblSingin = new Label();
            linklblRecuperar = new LinkLabel();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.AccessibleRole = AccessibleRole.None;
            pictureBox2.BackColor = Color.FromArgb(85, 96, 165);
            pictureBox2.Location = new Point(325, -1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(380, 525);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(-5, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(340, 525);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox3.Location = new Point(410, 232);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(243, 40);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox4.Location = new Point(410, 312);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(243, 40);
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // lblSingin
            // 
            lblSingin.AutoSize = true;
            lblSingin.BackColor = Color.FromArgb(85, 96, 165);
            lblSingin.Font = new Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lblSingin.ForeColor = Color.White;
            lblSingin.Location = new Point(451, 146);
            lblSingin.Name = "lblSingin";
            lblSingin.Size = new Size(151, 54);
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
            linklblRecuperar.Location = new Point(451, 378);
            linklblRecuperar.Name = "linklblRecuperar";
            linklblRecuperar.Size = new Size(141, 19);
            linklblRecuperar.TabIndex = 8;
            linklblRecuperar.TabStop = true;
            linklblRecuperar.Text = "Recuperar contraseña";
            // 
            // txtUser
            // 
            txtUser.BackColor = Color.FromArgb(85, 96, 165);
            txtUser.BorderStyle = BorderStyle.None;
            txtUser.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUser.ForeColor = Color.White;
            txtUser.Location = new Point(424, 241);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(220, 22);
            txtUser.TabIndex = 11;
            txtUser.Text = "Usuario";
            txtUser.Enter += txtUser_Enter;
            txtUser.Leave += txtUser_Leave;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(85, 96, 165);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(423, 321);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(221, 22);
            txtPassword.TabIndex = 12;
            txtPassword.Text = "Contraseña";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(85, 96, 165);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderColor = Color.FromArgb(85, 96, 165);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(645, 12);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(47, 47);
            btnClose.TabIndex = 13;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(704, 522);
            Controls.Add(btnClose);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(linklblRecuperar);
            Controls.Add(lblSingin);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label lblSingin;
        private LinkLabel linklblRecuperar;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnClose;
    }
}