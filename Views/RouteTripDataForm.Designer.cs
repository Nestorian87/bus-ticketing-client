namespace BusTicketingSystem.Views
{
    partial class RouteTripDataForm
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
            label5 = new Label();
            label1 = new Label();
            busComboBox = new ComboBox();
            tripBusBindingSource = new BindingSource(components);
            label3 = new Label();
            cancelButton = new Button();
            saveButton = new Button();
            startTimePicker = new DateTimePicker();
            daysOfWeekCheckedListBox = new CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)tripBusBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(52, 78, 65);
            label5.Location = new Point(98, 246);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(165, 35);
            label5.TabIndex = 34;
            label5.Text = "Дні тижня";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 78, 65);
            label1.Location = new Point(2, 162);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(280, 35);
            label1.TabIndex = 29;
            label1.Text = "Час відправлення";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // busComboBox
            // 
            busComboBox.Anchor = AnchorStyles.None;
            busComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            busComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            busComboBox.BackColor = Color.FromArgb(218, 215, 205);
            busComboBox.DataSource = tripBusBindingSource;
            busComboBox.DisplayMember = "Info";
            busComboBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            busComboBox.FormattingEnabled = true;
            busComboBox.Location = new Point(285, 74);
            busComboBox.Name = "busComboBox";
            busComboBox.Size = new Size(483, 40);
            busComboBox.TabIndex = 28;
            busComboBox.ValueMember = "Id";
            // 
            // tripBusBindingSource
            // 
            tripBusBindingSource.DataSource = typeof(Models.Bus);
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(129, 75);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(134, 35);
            label3.TabIndex = 27;
            label3.Text = "Автобус";
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
            cancelButton.Location = new Point(345, 608);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 57);
            cancelButton.TabIndex = 26;
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
            saveButton.Location = new Point(568, 608);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 57);
            saveButton.TabIndex = 25;
            saveButton.Text = "Зберегти";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Click += saveButton_Click;
            // 
            // startTimePicker
            // 
            startTimePicker.Anchor = AnchorStyles.None;
            startTimePicker.CalendarMonthBackground = Color.White;
            startTimePicker.CustomFormat = "HH:mm";
            startTimePicker.Font = new Font("Verdana", 10F);
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.Location = new Point(285, 162);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(483, 40);
            startTimePicker.TabIndex = 37;
            // 
            // daysOfWeekCheckedListBox
            // 
            daysOfWeekCheckedListBox.Anchor = AnchorStyles.None;
            daysOfWeekCheckedListBox.BackColor = Color.FromArgb(218, 215, 205);
            daysOfWeekCheckedListBox.BorderStyle = BorderStyle.None;
            daysOfWeekCheckedListBox.CheckOnClick = true;
            daysOfWeekCheckedListBox.Font = new Font("Verdana", 10F);
            daysOfWeekCheckedListBox.FormattingEnabled = true;
            daysOfWeekCheckedListBox.Location = new Point(285, 246);
            daysOfWeekCheckedListBox.Name = "daysOfWeekCheckedListBox";
            daysOfWeekCheckedListBox.Size = new Size(483, 333);
            daysOfWeekCheckedListBox.TabIndex = 38;
            // 
            // RouteTripDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(800, 702);
            Controls.Add(daysOfWeekCheckedListBox);
            Controls.Add(startTimePicker);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(busComboBox);
            Controls.Add(label3);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            MinimumSize = new Size(826, 773);
            Name = "RouteTripDataForm";
            Text = "Рейс";
            ((System.ComponentModel.ISupportInitialize)tripBusBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label1;
        private ComboBox busComboBox;
        private Label label3;
        private Button cancelButton;
        private Button saveButton;
        private BindingSource tripBusBindingSource;
        private DateTimePicker startTimePicker;
        private CheckedListBox daysOfWeekCheckedListBox;
    }
}