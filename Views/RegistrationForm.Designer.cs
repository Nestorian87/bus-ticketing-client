namespace BusTicketingSystem.Views
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            panel1 = new Panel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            backButton = new Button();
            panel2 = new Panel();
            label6 = new Label();
            nameTextBox = new TextBox();
            label5 = new Label();
            usernameTextBox = new TextBox();
            registerButton = new Button();
            label4 = new Label();
            passwordTextBox = new TextBox();
            label3 = new Label();
            surnameTextBox = new TextBox();
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
            panel1.Controls.Add(backButton);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 790);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(38, 148);
            panel3.Name = "panel3";
            panel3.Size = new Size(388, 495);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.bus;
            pictureBox1.Location = new Point(59, 70);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(270, 238);
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
            label2.Location = new Point(34, 339);
            label2.Name = "label2";
            label2.Size = new Size(320, 130);
            label2.TabIndex = 1;
            label2.Text = "Каса\r\nавтовокзалу";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            backButton.BackColor = Color.Transparent;
            backButton.BackgroundImage = Properties.Resources.back_button;
            backButton.BackgroundImageLayout = ImageLayout.Zoom;
            backButton.Cursor = Cursors.Hand;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Location = new Point(22, 22);
            backButton.Name = "backButton";
            backButton.Size = new Size(75, 83);
            backButton.TabIndex = 1;
            backButton.TabStop = false;
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(nameTextBox);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(usernameTextBox);
            panel2.Controls.Add(registerButton);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(passwordTextBox);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(surnameTextBox);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(471, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(646, 778);
            panel2.TabIndex = 1;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 13.125F);
            label6.ForeColor = Color.FromArgb(52, 78, 65);
            label6.Location = new Point(44, 138);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(87, 42);
            label6.TabIndex = 0;
            label6.Text = "Ім'я";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nameTextBox.BackColor = Color.FromArgb(218, 215, 205);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Verdana", 13F);
            nameTextBox.ForeColor = SystemColors.WindowText;
            nameTextBox.Location = new Point(51, 190);
            nameTextBox.MaxLength = 20;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(551, 50);
            nameTextBox.TabIndex = 0;
            nameTextBox.WordWrap = false;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 13.125F);
            label5.ForeColor = Color.FromArgb(52, 78, 65);
            label5.Location = new Point(44, 369);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(326, 42);
            label5.TabIndex = 1;
            label5.Text = "Ім'я користувача";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            usernameTextBox.BackColor = Color.FromArgb(218, 215, 205);
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Font = new Font("Verdana", 13F);
            usernameTextBox.ForeColor = SystemColors.WindowText;
            usernameTextBox.Location = new Point(51, 419);
            usernameTextBox.MaxLength = 20;
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(551, 50);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.WordWrap = false;
            // 
            // registerButton
            // 
            registerButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            registerButton.BackColor = Color.FromArgb(88, 129, 87);
            registerButton.Cursor = Cursors.Hand;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            registerButton.ForeColor = Color.White;
            registerButton.Location = new Point(49, 627);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(551, 86);
            registerButton.TabIndex = 4;
            registerButton.Text = "Створити акаунт";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 13.125F);
            label4.ForeColor = Color.FromArgb(52, 78, 65);
            label4.Location = new Point(41, 483);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(150, 42);
            label4.TabIndex = 5;
            label4.Text = "Пароль";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.FromArgb(218, 215, 205);
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Font = new Font("Verdana", 13F);
            passwordTextBox.ForeColor = SystemColors.WindowText;
            passwordTextBox.Location = new Point(49, 533);
            passwordTextBox.MaxLength = 20;
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(551, 50);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.WordWrap = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 13.125F);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(41, 254);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(188, 42);
            label3.TabIndex = 6;
            label3.Text = "Прізвище";
            // 
            // surnameTextBox
            // 
            surnameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            surnameTextBox.BackColor = Color.FromArgb(218, 215, 205);
            surnameTextBox.BorderStyle = BorderStyle.FixedSingle;
            surnameTextBox.Font = new Font("Verdana", 13F);
            surnameTextBox.ForeColor = SystemColors.WindowText;
            surnameTextBox.Location = new Point(48, 304);
            surnameTextBox.MaxLength = 20;
            surnameTextBox.Name = "surnameTextBox";
            surnameTextBox.Size = new Size(551, 50);
            surnameTextBox.TabIndex = 1;
            surnameTextBox.WordWrap = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label1.Location = new Point(177, 49);
            label1.Name = "label1";
            label1.Size = new Size(292, 68);
            label1.TabIndex = 7;
            label1.Text = "Реєстрація";
            // 
            // RegistrationForm
            // 
            AcceptButton = registerButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            ClientSize = new Size(1129, 790);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1155, 861);
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Реєстрація";
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
        private Panel panel2;
        private Button registerButton;
        private Label label4;
        private TextBox passwordTextBox;
        private Label label3;
        private TextBox surnameTextBox;
        private Label label1;
        private Label label5;
        private TextBox usernameTextBox;
        private Label label6;
        private TextBox nameTextBox;
        private Button backButton;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
    }
}