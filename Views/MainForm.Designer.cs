namespace BusTicketingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            logoutButton = new Button();
            myTicketsButton = new Button();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            fromComboBox = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(58, 90, 64);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(logoutButton);
            panel1.Controls.Add(myTicketsButton);
            panel1.Controls.Add(searchButton);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(411, 952);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(0, 871);
            label1.Name = "label1";
            label1.Size = new Size(412, 2);
            label1.TabIndex = 4;
            // 
            // logoutButton
            // 
            logoutButton.BackgroundImageLayout = ImageLayout.Zoom;
            logoutButton.Dock = DockStyle.Bottom;
            logoutButton.FlatAppearance.BorderSize = 0;
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            logoutButton.ForeColor = Color.White;
            logoutButton.Image = Properties.Resources.sign_out;
            logoutButton.ImageAlign = ContentAlignment.MiddleRight;
            logoutButton.Location = new Point(0, 873);
            logoutButton.Margin = new Padding(3, 0, 3, 3);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(411, 79);
            logoutButton.TabIndex = 3;
            logoutButton.Text = " Вийти";
            logoutButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            logoutButton.UseVisualStyleBackColor = true;
            logoutButton.Click += logoutButton_Click;
            // 
            // myTicketsButton
            // 
            myTicketsButton.BackgroundImageLayout = ImageLayout.Zoom;
            myTicketsButton.FlatAppearance.BorderSize = 0;
            myTicketsButton.FlatStyle = FlatStyle.Flat;
            myTicketsButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            myTicketsButton.ForeColor = Color.White;
            myTicketsButton.Image = Properties.Resources.ticket;
            myTicketsButton.ImageAlign = ContentAlignment.MiddleLeft;
            myTicketsButton.Location = new Point(1, 363);
            myTicketsButton.Name = "myTicketsButton";
            myTicketsButton.Padding = new Padding(40, 0, 0, 0);
            myTicketsButton.Size = new Size(410, 79);
            myTicketsButton.TabIndex = 2;
            myTicketsButton.Text = " Мої квитки";
            myTicketsButton.TextAlign = ContentAlignment.MiddleLeft;
            myTicketsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            myTicketsButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.BackgroundImageLayout = ImageLayout.Zoom;
            searchButton.FlatAppearance.BorderSize = 0;
            searchButton.FlatStyle = FlatStyle.Flat;
            searchButton.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            searchButton.ForeColor = Color.White;
            searchButton.Image = Properties.Resources.search;
            searchButton.ImageAlign = ContentAlignment.MiddleLeft;
            searchButton.Location = new Point(0, 278);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(50, 0, 0, 0);
            searchButton.Size = new Size(408, 79);
            searchButton.TabIndex = 0;
            searchButton.Text = "  Пошук";
            searchButton.TextAlign = ContentAlignment.MiddleLeft;
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bus;
            pictureBox1.Location = new Point(124, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(163, 155);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // fromComboBox
            // 
            fromComboBox.BackColor = Color.FromArgb(218, 215, 205);
            fromComboBox.Font = new Font("Segoe UI", 12F);
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Location = new Point(468, 72);
            fromComboBox.MaxLength = 20;
            fromComboBox.Name = "fromComboBox";
            fromComboBox.Size = new Size(418, 53);
            fromComboBox.TabIndex = 1;
            fromComboBox.Enter += сomboBox_Enter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            ClientSize = new Size(1484, 952);
            Controls.Add(fromComboBox);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1510, 800);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каса автовокзалу";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button searchButton;
        private Button myTicketsButton;
        private Button logoutButton;
        private Label label1;
        private ComboBox fromComboBox;
    }
}
