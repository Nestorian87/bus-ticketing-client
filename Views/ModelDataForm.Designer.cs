﻿namespace BusTicketingSystem.Views
{
    partial class ModelDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModelDataForm));
            saveButton = new Button();
            label4 = new Label();
            label3 = new Label();
            nameTextBox = new TextBox();
            cancelButton = new Button();
            seatsCountNumericUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)seatsCountNumericUpDown).BeginInit();
            SuspendLayout();
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
            saveButton.Location = new Point(348, 124);
            saveButton.Margin = new Padding(2, 2, 2, 2);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(123, 36);
            saveButton.TabIndex = 4;
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
            label4.Location = new Point(10, 58);
            label4.Margin = new Padding(0);
            label4.Name = "label4";
            label4.Size = new Size(159, 23);
            label4.TabIndex = 9;
            label4.Text = "Кількість місць";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.875F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label3.ForeColor = Color.FromArgb(52, 78, 65);
            label3.Location = new Point(102, 16);
            label3.Margin = new Padding(0);
            label3.Name = "label3";
            label3.Size = new Size(67, 23);
            label3.TabIndex = 7;
            label3.Text = "Назва";
            // 
            // nameTextBox
            // 
            nameTextBox.Anchor = AnchorStyles.None;
            nameTextBox.BackColor = Color.FromArgb(218, 215, 205);
            nameTextBox.BorderStyle = BorderStyle.FixedSingle;
            nameTextBox.Font = new Font("Verdana", 10.125F, FontStyle.Regular, GraphicsUnit.Point, 204);
            nameTextBox.ForeColor = SystemColors.WindowText;
            nameTextBox.Location = new Point(174, 16);
            nameTextBox.Margin = new Padding(2, 2, 2, 2);
            nameTextBox.MaxLength = 30;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(298, 28);
            nameTextBox.TabIndex = 1;
            nameTextBox.WordWrap = false;
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
            cancelButton.Location = new Point(212, 124);
            cancelButton.Margin = new Padding(2, 2, 2, 2);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(123, 36);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Скасувати";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // seatsCountNumericUpDown
            // 
            seatsCountNumericUpDown.Anchor = AnchorStyles.None;
            seatsCountNumericUpDown.BackColor = Color.FromArgb(218, 215, 205);
            seatsCountNumericUpDown.BorderStyle = BorderStyle.FixedSingle;
            seatsCountNumericUpDown.Font = new Font("Verdana", 10.125F);
            seatsCountNumericUpDown.Location = new Point(174, 58);
            seatsCountNumericUpDown.Margin = new Padding(2, 2, 2, 2);
            seatsCountNumericUpDown.Maximum = new decimal(new int[] { 300, 0, 0, 0 });
            seatsCountNumericUpDown.Name = "seatsCountNumericUpDown";
            seatsCountNumericUpDown.Size = new Size(297, 28);
            seatsCountNumericUpDown.TabIndex = 2;
            // 
            // ModelDataForm
            // 
            AcceptButton = saveButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            CancelButton = cancelButton;
            ClientSize = new Size(497, 188);
            Controls.Add(seatsCountNumericUpDown);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTextBox);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 2, 2, 2);
            MinimumSize = new Size(515, 235);
            Name = "ModelDataForm";
            Text = "Модель";
            ((System.ComponentModel.ISupportInitialize)seatsCountNumericUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveButton;
        private Label label4;
        private Label label3;
        private TextBox nameTextBox;
        private Button cancelButton;
        private NumericUpDown seatsCountNumericUpDown;
    }
}