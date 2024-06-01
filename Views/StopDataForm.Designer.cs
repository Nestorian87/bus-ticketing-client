namespace BusTicketingSystem.Views
{
    partial class StopDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StopDataForm));
            cancelButton = new Button();
            saveButton = new Button();
            label3 = new Label();
            nameTextBox = new TextBox();
            label1 = new Label();
            addressTextBox = new TextBox();
            SuspendLayout();
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
            cancelButton.Location = new Point(150, 111);
            cancelButton.Margin = new Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 36);
            cancelButton.TabIndex = 3;
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
            saveButton.Location = new Point(285, 111);
            saveButton.Margin = new Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 36);
            saveButton.TabIndex = 4;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(23, 16);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 13;
            label3.Text = "Назва";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.BackColor = Color.FromArgb(218, 215, 205);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.ForeColor = SystemColors.WindowText;
            nameTextBox.Location = new Point(94, 15);
            nameTextBox.Margin = new Padding(2, 2, 2, 2);
            nameTextBox.MaxLength = 30;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(315, 28);
            nameTextBox.TabIndex = 1;
            nameTextBox.WordWrap = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 78, 65);
            label1.Location = new Point(12, 60);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(79, 23);
            label1.TabIndex = 17;
            label1.Text = "Адреса";
            // 
            // addressTextBox
            // 
            addressTextBox.Anchor = AnchorStyles.None;
            addressTextBox.BackColor = Color.FromArgb(218, 215, 205);
            addressTextBox.BorderStyle = BorderStyle.FixedSingle;
            addressTextBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            addressTextBox.ForeColor = SystemColors.WindowText;
            addressTextBox.Location = new Point(94, 57);
            addressTextBox.Margin = new Padding(2, 2, 2, 2);
            addressTextBox.MaxLength = 70;
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(315, 28);
            addressTextBox.TabIndex = 2;
            addressTextBox.WordWrap = false;
            // 
            // StopDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(425, 169);
            Controls.Add(label1);
            Controls.Add(addressTextBox);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(443, 216);
            Name = "StopDataForm";
            Text = "Зупинка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private Label label3;
        private TextBox nameTextBox;
        private Label label1;
        private TextBox addressTextBox;
    }
}