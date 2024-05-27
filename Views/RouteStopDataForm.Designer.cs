namespace BusTicketingSystem.Views
{
    partial class RouteStopDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouteStopDataForm));
            cancelButton = new Button();
            saveButton = new Button();
            label3 = new Label();
            stopComboBox = new ComboBox();
            stopDataBindingSource = new BindingSource(components);
            label1 = new Label();
            rideTimeHoursNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label4 = new Label();
            rideTimeMinutesNumericUpDown = new NumericUpDown();
            label5 = new Label();
            stopMinutesNumericUpDown = new NumericUpDown();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)stopDataBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rideTimeHoursNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rideTimeMinutesNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stopMinutesNumericUpDown).BeginInit();
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
            cancelButton.Location = new Point(339, 381);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(200, 57);
            cancelButton.TabIndex = 5;
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
            saveButton.Location = new Point(562, 381);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(200, 57);
            saveButton.TabIndex = 6;
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
            label3.Location = new Point(123, 63);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(139, 35);
            label3.TabIndex = 15;
            label3.Text = "Зупинка";
            // 
            // stopComboBox
            // 
            stopComboBox.Anchor = AnchorStyles.None;
            stopComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            stopComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            stopComboBox.BackColor = Color.FromArgb(218, 215, 205);
            stopComboBox.DataSource = stopDataBindingSource;
            stopComboBox.DisplayMember = "Name";
            stopComboBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            stopComboBox.FormattingEnabled = true;
            stopComboBox.Location = new Point(279, 62);
            stopComboBox.Name = "stopComboBox";
            stopComboBox.Size = new Size(380, 40);
            stopComboBox.TabIndex = 1;
            stopComboBox.ValueMember = "Id";
            // 
            // stopDataBindingSource
            // 
            stopDataBindingSource.DataSource = typeof(Models.Stop);
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.FromArgb(52, 78, 65);
            label1.Location = new Point(26, 122);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(236, 140);
            label1.TabIndex = 17;
            label1.Text = "Час від \r\nпопередньої зупинки";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rideTimeHoursNumericUpDown
            // 
            rideTimeHoursNumericUpDown.Anchor = AnchorStyles.None;
            rideTimeHoursNumericUpDown.BackColor = Color.FromArgb(218, 215, 205);
            rideTimeHoursNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            rideTimeHoursNumericUpDown.Font = new Font("Verdana", 10.125F);
            rideTimeHoursNumericUpDown.Location = new Point(279, 145);
            rideTimeHoursNumericUpDown.Maximum = new decimal(new int[] { 30, 0, 0, 0 });
            rideTimeHoursNumericUpDown.Name = "rideTimeHoursNumericUpDown";
            rideTimeHoursNumericUpDown.Size = new Size(380, 40);
            rideTimeHoursNumericUpDown.TabIndex = 2;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.FromArgb(52, 78, 65);
            label2.Location = new Point(697, 150);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(65, 35);
            label2.TabIndex = 19;
            label2.Text = "год";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.ForeColor = Color.FromArgb(52, 78, 65);
            label4.Location = new Point(697, 201);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(49, 35);
            label4.TabIndex = 21;
            label4.Text = "хв";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rideTimeMinutesNumericUpDown
            // 
            rideTimeMinutesNumericUpDown.Anchor = AnchorStyles.None;
            rideTimeMinutesNumericUpDown.BackColor = Color.FromArgb(218, 215, 205);
            rideTimeMinutesNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            rideTimeMinutesNumericUpDown.Font = new Font("Verdana", 10.125F);
            rideTimeMinutesNumericUpDown.Location = new Point(279, 201);
            rideTimeMinutesNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            rideTimeMinutesNumericUpDown.Name = "rideTimeMinutesNumericUpDown";
            rideTimeMinutesNumericUpDown.Size = new Size(380, 40);
            rideTimeMinutesNumericUpDown.TabIndex = 3;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.ForeColor = Color.FromArgb(52, 78, 65);
            label5.Location = new Point(61, 292);
            label5.Margin = new Padding(0);
            label5.Name = "label5";
            label5.Size = new Size(201, 35);
            label5.TabIndex = 22;
            label5.Text = "Час зупинки";
            // 
            // stopMinutesNumericUpDown
            // 
            stopMinutesNumericUpDown.Anchor = AnchorStyles.None;
            stopMinutesNumericUpDown.BackColor = Color.FromArgb(218, 215, 205);
            stopMinutesNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            stopMinutesNumericUpDown.Font = new Font("Verdana", 10.125F);
            stopMinutesNumericUpDown.Location = new Point(279, 287);
            stopMinutesNumericUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            stopMinutesNumericUpDown.Name = "stopMinutesNumericUpDown";
            stopMinutesNumericUpDown.Size = new Size(380, 40);
            stopMinutesNumericUpDown.TabIndex = 4;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label6.ForeColor = Color.FromArgb(52, 78, 65);
            label6.Location = new Point(697, 287);
            label6.Margin = new Padding(0);
            label6.Name = "label6";
            label6.Size = new Size(49, 35);
            label6.TabIndex = 24;
            label6.Text = "хв";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RouteStopDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(stopMinutesNumericUpDown);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(rideTimeMinutesNumericUpDown);
            Controls.Add(label2);
            Controls.Add(rideTimeHoursNumericUpDown);
            Controls.Add(label1);
            Controls.Add(stopComboBox);
            Controls.Add(label3);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(826, 521);
            Name = "RouteStopDataForm";
            Text = "Зупинка маршруту";
            ((System.ComponentModel.ISupportInitialize)stopDataBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)rideTimeHoursNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)rideTimeMinutesNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)stopMinutesNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cancelButton;
        private Button saveButton;
        private Label label3;
        private ComboBox stopComboBox;
        private BindingSource stopDataBindingSource;
        private Label label1;
        private NumericUpDown rideTimeHoursNumericUpDown;
        private Label label2;
        private Label label4;
        private NumericUpDown rideTimeMinutesNumericUpDown;
        private Label label5;
        private NumericUpDown stopMinutesNumericUpDown;
        private Label label6;
    }
}