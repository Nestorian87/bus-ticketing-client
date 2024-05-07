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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            logoutButton = new Button();
            myTicketsButton = new Button();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            fromComboBox = new ComboBox();
            searchPanel = new Panel();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            StartStopDepartureTime = new DataGridViewTextBoxColumn();
            endStopArrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rideTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tripBindingSource = new BindingSource(components);
            panel2 = new Panel();
            searchTripsButton = new Button();
            datePicker = new DateTimePicker();
            label5 = new Label();
            toComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tripBindingSource).BeginInit();
            panel2.SuspendLayout();
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
            fromComboBox.Anchor = AnchorStyles.None;
            fromComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            fromComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            fromComboBox.BackColor = Color.FromArgb(218, 215, 205);
            fromComboBox.DisplayMember = "Id";
            fromComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            fromComboBox.FormattingEnabled = true;
            fromComboBox.Location = new Point(30, 88);
            fromComboBox.MaxLength = 20;
            fromComboBox.Name = "fromComboBox";
            fromComboBox.RightToLeft = RightToLeft.No;
            fromComboBox.Size = new Size(309, 53);
            fromComboBox.TabIndex = 1;
            fromComboBox.ValueMember = "Id";
            fromComboBox.Enter += сomboBox_Enter;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.FromArgb(218, 215, 205);
            searchPanel.Controls.Add(dataGridView1);
            searchPanel.Controls.Add(panel2);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(411, 0);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(1361, 952);
            searchPanel.TabIndex = 2;
            searchPanel.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.FromArgb(218, 215, 205);
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, availableSeatsDataGridViewTextBoxColumn, StartStopDepartureTime, endStopArrivalTimeDataGridViewTextBoxColumn, rideTimeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            dataGridView1.DataSource = tripBindingSource;
            dataGridView1.GridColor = Color.FromArgb(218, 215, 205);
            dataGridView1.Location = new Point(0, 178);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.RowHeadersWidth = 100;
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1361, 774);
            dataGridView1.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Рейс";
            idDataGridViewTextBoxColumn.MinimumWidth = 10;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 110;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Маршрут";
            titleDataGridViewTextBoxColumn.MinimumWidth = 10;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 162;
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            availableSeatsDataGridViewTextBoxColumn.HeaderText = "Місця";
            availableSeatsDataGridViewTextBoxColumn.MinimumWidth = 10;
            availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            availableSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            availableSeatsDataGridViewTextBoxColumn.Width = 124;
            // 
            // StartStopDepartureTime
            // 
            StartStopDepartureTime.DataPropertyName = "StartStopDepartureTime";
            StartStopDepartureTime.HeaderText = "Відправлення";
            StartStopDepartureTime.MinimumWidth = 10;
            StartStopDepartureTime.Name = "StartStopDepartureTime";
            StartStopDepartureTime.ReadOnly = true;
            StartStopDepartureTime.Width = 211;
            // 
            // endStopArrivalTimeDataGridViewTextBoxColumn
            // 
            endStopArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "EndStopArrivalTime";
            endStopArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Прибуття";
            endStopArrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            endStopArrivalTimeDataGridViewTextBoxColumn.Name = "endStopArrivalTimeDataGridViewTextBoxColumn";
            endStopArrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            endStopArrivalTimeDataGridViewTextBoxColumn.Width = 162;
            // 
            // rideTimeDataGridViewTextBoxColumn
            // 
            rideTimeDataGridViewTextBoxColumn.DataPropertyName = "RideTime";
            rideTimeDataGridViewTextBoxColumn.HeaderText = "Час в дорозі";
            rideTimeDataGridViewTextBoxColumn.MinimumWidth = 10;
            rideTimeDataGridViewTextBoxColumn.Name = "rideTimeDataGridViewTextBoxColumn";
            rideTimeDataGridViewTextBoxColumn.ReadOnly = true;
            rideTimeDataGridViewTextBoxColumn.Width = 197;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            priceDataGridViewTextBoxColumn.MinimumWidth = 10;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 109;
            // 
            // tripBindingSource
            // 
            tripBindingSource.DataSource = typeof(Models.Trip);
            // 
            // panel2
            // 
            panel2.Controls.Add(searchTripsButton);
            panel2.Controls.Add(datePicker);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(toComboBox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(fromComboBox);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 40, 0, 0);
            panel2.Size = new Size(1361, 178);
            panel2.TabIndex = 9;
            // 
            // searchTripsButton
            // 
            searchTripsButton.Anchor = AnchorStyles.None;
            searchTripsButton.BackColor = Color.FromArgb(58, 90, 64);
            searchTripsButton.FlatAppearance.BorderSize = 0;
            searchTripsButton.FlatStyle = FlatStyle.Flat;
            searchTripsButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            searchTripsButton.ForeColor = Color.White;
            searchTripsButton.Location = new Point(1087, 84);
            searchTripsButton.Name = "searchTripsButton";
            searchTripsButton.Size = new Size(251, 70);
            searchTripsButton.TabIndex = 14;
            searchTripsButton.Text = "Пошук";
            searchTripsButton.UseVisualStyleBackColor = false;
            searchTripsButton.Click += searchTripsButton_Click;
            // 
            // datePicker
            // 
            datePicker.Anchor = AnchorStyles.None;
            datePicker.CalendarMonthBackground = Color.FromArgb(218, 215, 205);
            datePicker.Font = new Font("Segoe UI", 12F);
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Location = new Point(722, 93);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(316, 50);
            datePicker.TabIndex = 13;
            datePicker.Value = new DateTime(2024, 5, 5, 19, 31, 27, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(715, 34);
            label5.Name = "label5";
            label5.Size = new Size(87, 45);
            label5.TabIndex = 12;
            label5.Text = "Дата";
            // 
            // toComboBox
            // 
            toComboBox.Anchor = AnchorStyles.None;
            toComboBox.AutoCompleteMode = AutoCompleteMode.Append;
            toComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            toComboBox.BackColor = Color.FromArgb(218, 215, 205);
            toComboBox.DisplayMember = "Id";
            toComboBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            toComboBox.FormattingEnabled = true;
            toComboBox.Location = new Point(384, 90);
            toComboBox.MaxLength = 20;
            toComboBox.Name = "toComboBox";
            toComboBox.RightToLeft = RightToLeft.No;
            toComboBox.Size = new Size(309, 53);
            toComboBox.TabIndex = 10;
            toComboBox.ValueMember = "Id";
            toComboBox.Enter += сomboBox_Enter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(377, 36);
            label4.Name = "label4";
            label4.Size = new Size(91, 45);
            label4.TabIndex = 11;
            label4.Text = "Куди";
            // 
            // label3
            // 
            label3.BackColor = Color.Black;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Dock = DockStyle.Bottom;
            label3.FlatStyle = FlatStyle.Flat;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(0, 177);
            label3.Name = "label3";
            label3.Size = new Size(1361, 1);
            label3.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(23, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 45);
            label2.TabIndex = 8;
            label2.Text = "Звідки";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            ClientSize = new Size(1772, 952);
            Controls.Add(searchPanel);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1798, 800);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каса автовокзалу";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)tripBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Panel searchPanel;
        private Label label2;
        private Panel panel2;
        private Label label3;
        private ComboBox toComboBox;
        private Label label4;
        private DateTimePicker datePicker;
        private Label label5;
        private DataGridView dataGridView1;
        private BindingSource tripBindingSource;
        private DataGridViewTextBoxColumn startStopArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn StartStopDepartureTime;
        private DataGridViewTextBoxColumn endStopArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rideTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private Button searchTripsButton;
    }
}
