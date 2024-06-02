namespace BusTicketingSystem.Views
{
    partial class BusDataForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BusDataForm));
            modelComboBox = new ComboBox();
            busModelBindingSource = new BindingSource(components);
            label3 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            Номер = new Label();
            numberMaskedTextBox = new MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)busModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // modelComboBox
            // 
            modelComboBox.Anchor = AnchorStyles.None;
            modelComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            modelComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            modelComboBox.BackColor = Color.FromArgb(218, 215, 205);
            modelComboBox.DataSource = busModelBindingSource;
            modelComboBox.DisplayMember = "Name";
            modelComboBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            modelComboBox.FormattingEnabled = true;
            modelComboBox.Location = new Point(134, 17);
            modelComboBox.Margin = new Padding(2, 2, 2, 2);
            modelComboBox.MaxLength = 30;
            modelComboBox.Name = "modelComboBox";
            modelComboBox.Size = new Size(302, 28);
            modelComboBox.TabIndex = 30;
            modelComboBox.ValueMember = "Id";
            // 
            // busModelBindingSource
            // 
            busModelBindingSource.DataSource = typeof(Models.BusModel);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(38, 18);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 29;
            label3.Text = "Модель";
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
            cancelButton.Location = new Point(174, 122);
            cancelButton.Margin = new Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 36);
            cancelButton.TabIndex = 32;
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
            saveButton.Location = new Point(311, 122);
            saveButton.Margin = new Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 36);
            saveButton.TabIndex = 31;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // Номер
            // 
            Номер.Anchor = AnchorStyles.None;
            Номер.AutoSize = true;
            Номер.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Номер.ForeColor = Color.FromArgb(52, 78, 65);
            Номер.Location = new Point(38, 70);
            Номер.Margin = new Padding(0);
            Номер.Name = "Номер";
            Номер.Size = new Size(72, 23);
            Номер.TabIndex = 33;
            Номер.Text = "Номер";
            // 
            // numberMaskedTextBox
            // 
            numberMaskedTextBox.Anchor = AnchorStyles.None;
            numberMaskedTextBox.AsciiOnly = true;
            numberMaskedTextBox.BackColor = Color.FromArgb(218, 215, 205);
            numberMaskedTextBox.BorderStyle = BorderStyle.FixedSingle;
            numberMaskedTextBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            numberMaskedTextBox.Location = new Point(134, 70);
            numberMaskedTextBox.Margin = new Padding(2, 2, 2, 2);
            numberMaskedTextBox.Mask = "LL 0000 LL";
            numberMaskedTextBox.Name = "numberMaskedTextBox";
            numberMaskedTextBox.Size = new Size(301, 28);
            numberMaskedTextBox.TabIndex = 35;
            // 
            // BusDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(458, 181);
            Controls.Add(numberMaskedTextBox);
            Controls.Add(Номер);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(modelComboBox);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(476, 228);
            Name = "BusDataForm";
            Text = "Автобус";
            ((System.ComponentModel.ISupportInitialize)busModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox modelComboBox;
        private Label label3;
        private BindingSource busModelBindingSource;
        private Button cancelButton;
        private Button saveButton;
        private Label Номер;
        private MaskedTextBox numberMaskedTextBox;
    }
}