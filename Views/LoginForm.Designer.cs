namespace BusTicketingSystem
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            panel2 = new Panel();
            registrationLabel = new LinkLabel();
            loginButton = new Button();
            label4 = new Label();
            passwordTextBox = new TextBox();
            label3 = new Label();
            loginTextBox = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 90, 64);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 671);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(31, 115);
            panel3.Name = "panel3";
            panel3.Size = new Size(403, 440);
            panel3.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.bus;
            pictureBox1.Location = new Point(62, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(279, 238);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(41, 288);
            label2.Name = "label2";
            label2.Size = new Size(320, 130);
            label2.TabIndex = 1;
            label2.Text = "Каса\r\nавтовокзалу";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(registrationLabel);
            panel2.Controls.Add(loginButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(loginTextBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(480, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(649, 573);
            panel2.TabIndex = 2;
            // 
            // registrationLabel
            // 
            registrationLabel.ActiveLinkColor = Color.FromArgb(163, 177, 138);
            registrationLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registrationLabel.AutoSize = true;
            registrationLabel.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            registrationLabel.LinkBehavior = LinkBehavior.HoverUnderline;
            registrationLabel.LinkColor = Color.FromArgb(88, 129, 87);
            registrationLabel.Location = new Point(222, 499);
            registrationLabel.Name = "registrationLabel";
            registrationLabel.Size = new Size(204, 47);
            registrationLabel.TabIndex = 6;
            registrationLabel.TabStop = true;
            registrationLabel.Text = "Реєстрація";
            registrationLabel.LinkClicked += registrationLabel_LinkClicked;
            // 
            // loginButton
            // 
            loginButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginButton.BackColor = Color.FromArgb(88, 129, 87);
            loginButton.Cursor = Cursors.Hand;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(104, 389);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(450, 79);
            loginButton.TabIndex = 5;
            loginButton.Text = "Увійти";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += loginButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.125F);
            label4.ForeColor = Color.FromArgb(52, 78, 65);
            label4.Location = new Point(79, 241);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(150, 42);
            label4.TabIndex = 4;
            label4.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(218, 215, 205);
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Verdana", 13F);
            passwordTextBox.ForeColor = SystemColors.WindowText;
            passwordTextBox.Location = new Point(87, 298);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(483, 50);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.WordWrap = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.125F);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(81, 122);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(326, 42);
            label3.TabIndex = 2;
            label3.Text = "Ім'я користувача";
            // 
            // loginTextBox
            // 
            loginTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            loginTextBox.BackColor = Color.FromArgb(218, 215, 205);
            loginTextBox.BorderStyle = BorderStyle.FixedSingle;
            loginTextBox.Font = new Font("Verdana", 13F);
            loginTextBox.ForeColor = SystemColors.WindowText;
            loginTextBox.Location = new Point(87, 179);
            loginTextBox.MaxLength = 20;
            loginTextBox.Name = "loginTextBox";
            loginTextBox.Size = new Size(483, 50);
            loginTextBox.TabIndex = 1;
            loginTextBox.WordWrap = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(256, 25);
            label1.Name = "label1";
            label1.Size = new Size(136, 68);
            label1.TabIndex = 7;
            label1.Text = "Вхід";
            // 
            // LoginForm
            // 
            AcceptButton = loginButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            ClientSize = new Size(1129, 671);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1155, 742);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Вхід";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox loginTextBox;
        private Label label3;
        private Label label4;
        private TextBox passwordTextBox;
        private Button loginButton;
        private LinkLabel registrationLabel;
        private Panel panel3;
    }
}