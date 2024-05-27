namespace BusTicketingSystem.Views
{
    partial class RouteDataForm
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
            priceNumericUpDown = new NumericUpDown();
            cancelButton = new Button();
            saveButton = new Button();
            label4 = new Label();
            label3 = new Label();
            titleTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).BeginInit();
            SuspendLayout();
            // 
            // priceNumericUpDown
            // 
            priceNumericUpDown.Anchor = AnchorStyles.None;
            priceNumericUpDown.BackColor = Color.FromArgb(218, 215, 205);
            priceNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            priceNumericUpDown.Font = new Font("Verdana", 10.125F);
            priceNumericUpDown.Location = new Point(272, 89);
            priceNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            priceNumericUpDown.Name = "priceNumericUpDown";
            priceNumericUpDown.Size = new Size(483, 40);
            priceNumericUpDown.TabIndex = 18;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelButton.BackColor = Color.FromArgb(88, 129, 87);
            cancelButton.Cursor = Cursors.Hand;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            cancelButton.ForeColor = Color.White;
            cancelButton.Location = new Point(335, 190);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 57);
            cancelButton.TabIndex = 17;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // saveButton
            // 
            saveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveButton.BackColor = Color.FromArgb(88, 129, 87);
            saveButton.Cursor = Cursors.Hand;
            saveButton.FlatAppearance.BorderSize = 0;
            saveButton.FlatStyle = FlatStyle.Flat;
            saveButton.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveButton.ForeColor = Color.White;
            saveButton.Location = new Point(555, 190);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 57);
            saveButton.TabIndex = 16;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(52, 78, 65);
            label4.Location = new Point(188, 89);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(81, 35);
            label4.TabIndex = 15;
            label4.Text = "Ціна";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(121, 22);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(148, 35);
            label3.TabIndex = 14;
            label3.Text = "Маршрут";
            // 
            // titleTextBox
            // 
            titleTextBox.Anchor = AnchorStyles.None;
            titleTextBox.BackColor = Color.FromArgb(218, 215, 205);
            titleTextBox.BorderStyle = BorderStyle.FixedSingle;
            titleTextBox.Enabled = false;
            titleTextBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            titleTextBox.ForeColor = SystemColors.WindowText;
            titleTextBox.Location = new Point(272, 22);
            titleTextBox.MaxLength = 20;
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(483, 40);
            titleTextBox.TabIndex = 13;
            titleTextBox.WordWrap = false;
            // 
            // RouteDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(783, 259);
            Controls.Add(priceNumericUpDown);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(titleTextBox);
            MinimumSize = new Size(809, 330);
            Name = "RouteDataForm";
            Text = "Маршрут";
            ((System.ComponentModel.ISupportInitialize)priceNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown priceNumericUpDown;
        private Button cancelButton;
        private Button saveButton;
        private Label label4;
        private Label label3;
        private TextBox titleTextBox;
    }
}