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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            logoutButton = new Button();
            myTicketsButton = new Button();
            searchButton = new Button();
            pictureBox1 = new PictureBox();
            fromComboBox = new ComboBox();
            searchPanel = new Panel();
            buyButton = new Button();
            panel3 = new Panel();
            tripsNotFoundLabel = new Label();
            tripsDataGridView = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            titleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            availableSeatsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startStopDepartureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
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
            tabControl = new TabControl();
            searchTabPage = new TabPage();
            myTicketsTabPage = new TabPage();
            returnTicketButton = new Button();
            saveTicketButton = new Button();
            boughtTicketsDataGridView = new DataGridView();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tripNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fromDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            toDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            departureTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            arrivalTimeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ticketBindingSource = new BindingSource(components);
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            searchPanel.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tripsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tripBindingSource).BeginInit();
            panel2.SuspendLayout();
            tabControl.SuspendLayout();
            searchTabPage.SuspendLayout();
            myTicketsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)boughtTicketsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).BeginInit();
            panel4.SuspendLayout();
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
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(253, 659);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Location = new Point(0, 608);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 1);
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
            logoutButton.Location = new Point(0, 610);
            logoutButton.Margin = new Padding(2, 0, 2, 2);
            logoutButton.Name = "logoutButton";
            logoutButton.Size = new Size(253, 49);
            logoutButton.TabIndex = 3;
            logoutButton.TabStop = false;
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
            myTicketsButton.Location = new Point(2, 239);
            myTicketsButton.Margin = new Padding(2);
            myTicketsButton.Name = "myTicketsButton";
            myTicketsButton.Padding = new Padding(25, 0, 0, 0);
            myTicketsButton.Size = new Size(249, 73);
            myTicketsButton.TabIndex = 2;
            myTicketsButton.TabStop = false;
            myTicketsButton.Text = " Мої квитки";
            myTicketsButton.TextAlign = ContentAlignment.MiddleLeft;
            myTicketsButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            myTicketsButton.UseVisualStyleBackColor = true;
            myTicketsButton.Click += myTicketsButton_Click;
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
            searchButton.Location = new Point(0, 174);
            searchButton.Margin = new Padding(2);
            searchButton.Name = "searchButton";
            searchButton.Padding = new Padding(31, 0, 0, 0);
            searchButton.Size = new Size(251, 61);
            searchButton.TabIndex = 0;
            searchButton.TabStop = false;
            searchButton.Text = "  Пошук";
            searchButton.TextAlign = ContentAlignment.MiddleLeft;
            searchButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bus;
            pictureBox1.Location = new Point(76, 36);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 97);
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
            fromComboBox.Location = new Point(65, 55);
            fromComboBox.Margin = new Padding(2);
            fromComboBox.MaxLength = 20;
            fromComboBox.Name = "fromComboBox";
            fromComboBox.RightToLeft = RightToLeft.No;
            fromComboBox.Size = new Size(192, 36);
            fromComboBox.TabIndex = 1;
            fromComboBox.ValueMember = "Id";
            fromComboBox.Enter += сomboBox_Enter;
            // 
            // searchPanel
            // 
            searchPanel.BackColor = Color.FromArgb(218, 215, 205);
            searchPanel.Controls.Add(buyButton);
            searchPanel.Controls.Add(panel3);
            searchPanel.Controls.Add(panel2);
            searchPanel.Dock = DockStyle.Fill;
            searchPanel.Location = new Point(2, 2);
            searchPanel.Margin = new Padding(2);
            searchPanel.Name = "searchPanel";
            searchPanel.Padding = new Padding(2, 0, 0, 0);
            searchPanel.Size = new Size(932, 625);
            searchPanel.TabIndex = 2;
            // 
            // buyButton
            // 
            buyButton.Anchor = AnchorStyles.Bottom;
            buyButton.BackColor = Color.FromArgb(58, 90, 64);
            buyButton.FlatAppearance.BorderSize = 0;
            buyButton.FlatStyle = FlatStyle.Flat;
            buyButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buyButton.ForeColor = Color.White;
            buyButton.Location = new Point(718, 567);
            buyButton.Margin = new Padding(2);
            buyButton.Name = "buyButton";
            buyButton.Size = new Size(154, 44);
            buyButton.TabIndex = 15;
            buyButton.Text = "Купити";
            buyButton.UseVisualStyleBackColor = false;
            buyButton.Click += buyButton_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel3.BackColor = Color.FromArgb(218, 215, 205);
            panel3.Controls.Add(tripsNotFoundLabel);
            panel3.Controls.Add(tripsDataGridView);
            panel3.Location = new Point(-56, 111);
            panel3.Margin = new Padding(2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 438);
            panel3.TabIndex = 11;
            // 
            // tripsNotFoundLabel
            // 
            tripsNotFoundLabel.Anchor = AnchorStyles.None;
            tripsNotFoundLabel.AutoSize = true;
            tripsNotFoundLabel.Font = new Font("Segoe UI Semibold", 15F, FontStyle.Bold);
            tripsNotFoundLabel.Location = new Point(405, 202);
            tripsNotFoundLabel.Margin = new Padding(2, 0, 2, 0);
            tripsNotFoundLabel.Name = "tripsNotFoundLabel";
            tripsNotFoundLabel.Size = new Size(245, 40);
            tripsNotFoundLabel.TabIndex = 11;
            tripsNotFoundLabel.Text = "Рейсів не знайдено";
            tripsNotFoundLabel.UseCompatibleTextRendering = true;
            tripsNotFoundLabel.Visible = false;
            // 
            // tripsDataGridView
            // 
            tripsDataGridView.AllowUserToAddRows = false;
            tripsDataGridView.AllowUserToDeleteRows = false;
            tripsDataGridView.AutoGenerateColumns = false;
            tripsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            tripsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tripsDataGridView.BackgroundColor = Color.FromArgb(218, 215, 205);
            tripsDataGridView.BorderStyle = BorderStyle.None;
            tripsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            tripsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            tripsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tripsDataGridView.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, titleDataGridViewTextBoxColumn, availableSeatsDataGridViewTextBoxColumn, startStopDepartureTimeDataGridViewTextBoxColumn, endStopArrivalTimeDataGridViewTextBoxColumn, rideTimeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            tripsDataGridView.DataSource = tripBindingSource;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tripsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            tripsDataGridView.Dock = DockStyle.Fill;
            tripsDataGridView.GridColor = Color.FromArgb(218, 215, 205);
            tripsDataGridView.Location = new Point(0, 0);
            tripsDataGridView.Margin = new Padding(2);
            tripsDataGridView.MultiSelect = false;
            tripsDataGridView.Name = "tripsDataGridView";
            tripsDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            tripsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            tripsDataGridView.RowHeadersWidth = 100;
            tripsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle5.Padding = new Padding(5);
            tripsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            tripsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tripsDataGridView.Size = new Size(1048, 438);
            tripsDataGridView.TabIndex = 10;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Рейс";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            idDataGridViewTextBoxColumn.Width = 84;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            titleDataGridViewTextBoxColumn.HeaderText = "Маршрут";
            titleDataGridViewTextBoxColumn.MinimumWidth = 6;
            titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            titleDataGridViewTextBoxColumn.ReadOnly = true;
            titleDataGridViewTextBoxColumn.Width = 129;
            // 
            // availableSeatsDataGridViewTextBoxColumn
            // 
            availableSeatsDataGridViewTextBoxColumn.DataPropertyName = "AvailableSeats";
            availableSeatsDataGridViewTextBoxColumn.HeaderText = "Місця";
            availableSeatsDataGridViewTextBoxColumn.MinimumWidth = 6;
            availableSeatsDataGridViewTextBoxColumn.Name = "availableSeatsDataGridViewTextBoxColumn";
            availableSeatsDataGridViewTextBoxColumn.ReadOnly = true;
            availableSeatsDataGridViewTextBoxColumn.Width = 96;
            // 
            // startStopDepartureTimeDataGridViewTextBoxColumn
            // 
            startStopDepartureTimeDataGridViewTextBoxColumn.DataPropertyName = "StartStopDepartureTime";
            startStopDepartureTimeDataGridViewTextBoxColumn.HeaderText = "Відправлення";
            startStopDepartureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            startStopDepartureTimeDataGridViewTextBoxColumn.Name = "startStopDepartureTimeDataGridViewTextBoxColumn";
            startStopDepartureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            startStopDepartureTimeDataGridViewTextBoxColumn.Width = 172;
            // 
            // endStopArrivalTimeDataGridViewTextBoxColumn
            // 
            endStopArrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "EndStopArrivalTime";
            endStopArrivalTimeDataGridViewTextBoxColumn.HeaderText = "Прибуття";
            endStopArrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            endStopArrivalTimeDataGridViewTextBoxColumn.Name = "endStopArrivalTimeDataGridViewTextBoxColumn";
            endStopArrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            endStopArrivalTimeDataGridViewTextBoxColumn.Width = 131;
            // 
            // rideTimeDataGridViewTextBoxColumn
            // 
            rideTimeDataGridViewTextBoxColumn.DataPropertyName = "RideTime";
            rideTimeDataGridViewTextBoxColumn.HeaderText = "В дорозі";
            rideTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            rideTimeDataGridViewTextBoxColumn.Name = "rideTimeDataGridViewTextBoxColumn";
            rideTimeDataGridViewTextBoxColumn.ReadOnly = true;
            rideTimeDataGridViewTextBoxColumn.Width = 121;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            priceDataGridViewTextBoxColumn.HeaderText = "Ціна";
            priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            priceDataGridViewTextBoxColumn.Width = 84;
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
            panel2.Location = new Point(2, 0);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(0, 25, 0, 0);
            panel2.Size = new Size(930, 111);
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
            searchTripsButton.Location = new Point(715, 52);
            searchTripsButton.Margin = new Padding(2);
            searchTripsButton.Name = "searchTripsButton";
            searchTripsButton.Size = new Size(154, 44);
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
            datePicker.Location = new Point(491, 58);
            datePicker.Margin = new Padding(2);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(196, 34);
            datePicker.TabIndex = 13;
            datePicker.Value = new DateTime(2024, 5, 5, 19, 31, 27, 0);
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label5.Location = new Point(486, 21);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
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
            toComboBox.Location = new Point(283, 56);
            toComboBox.Margin = new Padding(2);
            toComboBox.MaxLength = 20;
            toComboBox.Name = "toComboBox";
            toComboBox.RightToLeft = RightToLeft.No;
            toComboBox.Size = new Size(192, 36);
            toComboBox.TabIndex = 10;
            toComboBox.ValueMember = "Id";
            toComboBox.Enter += сomboBox_Enter;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label4.Location = new Point(278, 22);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 28);
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
            label3.Location = new Point(0, 110);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(930, 1);
            label3.TabIndex = 9;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(61, 21);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 28);
            label2.TabIndex = 8;
            label2.Text = "Звідки";
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.Controls.Add(searchTabPage);
            tabControl.Controls.Add(myTicketsTabPage);
            tabControl.Location = new Point(246, -6);
            tabControl.Margin = new Padding(0);
            tabControl.Name = "tabControl";
            tabControl.Padding = new Point(0, 0);
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(944, 665);
            tabControl.TabIndex = 15;
            tabControl.TabStop = false;
            // 
            // searchTabPage
            // 
            searchTabPage.Controls.Add(searchPanel);
            searchTabPage.Location = new Point(4, 32);
            searchTabPage.Margin = new Padding(2);
            searchTabPage.Name = "searchTabPage";
            searchTabPage.Padding = new Padding(2);
            searchTabPage.Size = new Size(936, 629);
            searchTabPage.TabIndex = 0;
            searchTabPage.Text = "tabPage1";
            searchTabPage.UseVisualStyleBackColor = true;
            // 
            // myTicketsTabPage
            // 
            myTicketsTabPage.BackColor = Color.FromArgb(218, 215, 205);
            myTicketsTabPage.Controls.Add(returnTicketButton);
            myTicketsTabPage.Controls.Add(saveTicketButton);
            myTicketsTabPage.Controls.Add(boughtTicketsDataGridView);
            myTicketsTabPage.Location = new Point(4, 32);
            myTicketsTabPage.Margin = new Padding(2);
            myTicketsTabPage.Name = "myTicketsTabPage";
            myTicketsTabPage.Padding = new Padding(2);
            myTicketsTabPage.Size = new Size(936, 629);
            myTicketsTabPage.TabIndex = 1;
            myTicketsTabPage.Text = "tabPage2";
            // 
            // returnTicketButton
            // 
            returnTicketButton.Anchor = AnchorStyles.Bottom;
            returnTicketButton.BackColor = Color.FromArgb(255, 41, 46);
            returnTicketButton.FlatAppearance.BorderSize = 0;
            returnTicketButton.FlatStyle = FlatStyle.Flat;
            returnTicketButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            returnTicketButton.ForeColor = Color.White;
            returnTicketButton.Location = new Point(567, 578);
            returnTicketButton.Margin = new Padding(2);
            returnTicketButton.Name = "returnTicketButton";
            returnTicketButton.Size = new Size(154, 44);
            returnTicketButton.TabIndex = 17;
            returnTicketButton.Text = "Повернути";
            returnTicketButton.UseVisualStyleBackColor = false;
            returnTicketButton.Click += returnTicketButton_Click;
            // 
            // saveTicketButton
            // 
            saveTicketButton.Anchor = AnchorStyles.Bottom;
            saveTicketButton.BackColor = Color.FromArgb(58, 90, 64);
            saveTicketButton.FlatAppearance.BorderSize = 0;
            saveTicketButton.FlatStyle = FlatStyle.Flat;
            saveTicketButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            saveTicketButton.ForeColor = Color.White;
            saveTicketButton.Location = new Point(745, 578);
            saveTicketButton.Margin = new Padding(2);
            saveTicketButton.Name = "saveTicketButton";
            saveTicketButton.Size = new Size(178, 44);
            saveTicketButton.TabIndex = 16;
            saveTicketButton.Text = "Завантажити";
            saveTicketButton.UseVisualStyleBackColor = false;
            saveTicketButton.Click += saveTicketButton_Click;
            // 
            // boughtTicketsDataGridView
            // 
            boughtTicketsDataGridView.AllowUserToAddRows = false;
            boughtTicketsDataGridView.AllowUserToDeleteRows = false;
            boughtTicketsDataGridView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            boughtTicketsDataGridView.AutoGenerateColumns = false;
            boughtTicketsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            boughtTicketsDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            boughtTicketsDataGridView.BackgroundColor = Color.FromArgb(218, 215, 205);
            boughtTicketsDataGridView.BorderStyle = BorderStyle.None;
            boughtTicketsDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            boughtTicketsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            boughtTicketsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            boughtTicketsDataGridView.Columns.AddRange(new DataGridViewColumn[] { dateDataGridViewTextBoxColumn, tripNumberDataGridViewTextBoxColumn, fromDataGridViewTextBoxColumn, toDataGridViewTextBoxColumn, departureTimeDataGridViewTextBoxColumn, arrivalTimeDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn1 });
            boughtTicketsDataGridView.DataSource = ticketBindingSource;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.White;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            boughtTicketsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            boughtTicketsDataGridView.GridColor = Color.FromArgb(218, 215, 205);
            boughtTicketsDataGridView.Location = new Point(-21, 20);
            boughtTicketsDataGridView.Margin = new Padding(2);
            boughtTicketsDataGridView.MultiSelect = false;
            boughtTicketsDataGridView.Name = "boughtTicketsDataGridView";
            boughtTicketsDataGridView.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            boughtTicketsDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            boughtTicketsDataGridView.RowHeadersWidth = 100;
            boughtTicketsDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle10.Padding = new Padding(5);
            boughtTicketsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle10;
            boughtTicketsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            boughtTicketsDataGridView.Size = new Size(955, 554);
            boughtTicketsDataGridView.TabIndex = 11;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Дата поїздки";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 164;
            // 
            // tripNumberDataGridViewTextBoxColumn
            // 
            tripNumberDataGridViewTextBoxColumn.DataPropertyName = "TripNumber";
            tripNumberDataGridViewTextBoxColumn.HeaderText = "Рейс";
            tripNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            tripNumberDataGridViewTextBoxColumn.Name = "tripNumberDataGridViewTextBoxColumn";
            tripNumberDataGridViewTextBoxColumn.ReadOnly = true;
            tripNumberDataGridViewTextBoxColumn.Width = 84;
            // 
            // fromDataGridViewTextBoxColumn
            // 
            fromDataGridViewTextBoxColumn.DataPropertyName = "From";
            fromDataGridViewTextBoxColumn.HeaderText = "Звідки";
            fromDataGridViewTextBoxColumn.MinimumWidth = 6;
            fromDataGridViewTextBoxColumn.Name = "fromDataGridViewTextBoxColumn";
            fromDataGridViewTextBoxColumn.ReadOnly = true;
            fromDataGridViewTextBoxColumn.Width = 103;
            // 
            // toDataGridViewTextBoxColumn
            // 
            toDataGridViewTextBoxColumn.DataPropertyName = "To";
            toDataGridViewTextBoxColumn.HeaderText = "Куди";
            toDataGridViewTextBoxColumn.MinimumWidth = 6;
            toDataGridViewTextBoxColumn.Name = "toDataGridViewTextBoxColumn";
            toDataGridViewTextBoxColumn.ReadOnly = true;
            toDataGridViewTextBoxColumn.Width = 85;
            // 
            // departureTimeDataGridViewTextBoxColumn
            // 
            departureTimeDataGridViewTextBoxColumn.DataPropertyName = "DepartureTime";
            departureTimeDataGridViewTextBoxColumn.HeaderText = "Відправлення";
            departureTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            departureTimeDataGridViewTextBoxColumn.Name = "departureTimeDataGridViewTextBoxColumn";
            departureTimeDataGridViewTextBoxColumn.ReadOnly = true;
            departureTimeDataGridViewTextBoxColumn.Width = 172;
            // 
            // arrivalTimeDataGridViewTextBoxColumn
            // 
            arrivalTimeDataGridViewTextBoxColumn.DataPropertyName = "ArrivalTime";
            arrivalTimeDataGridViewTextBoxColumn.HeaderText = "Прибуття";
            arrivalTimeDataGridViewTextBoxColumn.MinimumWidth = 6;
            arrivalTimeDataGridViewTextBoxColumn.Name = "arrivalTimeDataGridViewTextBoxColumn";
            arrivalTimeDataGridViewTextBoxColumn.ReadOnly = true;
            arrivalTimeDataGridViewTextBoxColumn.Width = 131;
            // 
            // priceDataGridViewTextBoxColumn1
            // 
            priceDataGridViewTextBoxColumn1.DataPropertyName = "Price";
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            priceDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle7;
            priceDataGridViewTextBoxColumn1.HeaderText = "Ціна";
            priceDataGridViewTextBoxColumn1.MinimumWidth = 6;
            priceDataGridViewTextBoxColumn1.Name = "priceDataGridViewTextBoxColumn1";
            priceDataGridViewTextBoxColumn1.ReadOnly = true;
            priceDataGridViewTextBoxColumn1.Width = 84;
            // 
            // ticketBindingSource
            // 
            ticketBindingSource.DataSource = typeof(Models.Ticket);
            // 
            // panel4
            // 
            panel4.Controls.Add(tabControl);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1184, 659);
            panel4.TabIndex = 16;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(218, 215, 205);
            ClientSize = new Size(1184, 659);
            Controls.Add(panel1);
            Controls.Add(panel4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            MinimumSize = new Size(1187, 518);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Каса автовокзалу";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            searchPanel.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tripsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tripBindingSource).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabControl.ResumeLayout(false);
            searchTabPage.ResumeLayout(false);
            myTicketsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)boughtTicketsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ticketBindingSource).EndInit();
            panel4.ResumeLayout(false);
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
        private DataGridView tripsDataGridView;
        private DataGridViewTextBoxColumn startStopArrivalTimeDataGridViewTextBoxColumn;
        private Button searchTripsButton;
        private Panel panel3;
        private Button buyButton;
        private Label tripsNotFoundLabel;
        private TabControl tabControl;
        private TabPage searchTabPage;
        private TabPage myTicketsTabPage;
        private Panel panel4;
        private DataGridView ticketsDataGridView;
        private DataGridView boughtTicketsDataGridView;
        private BindingSource ticketBindingSource;
        private BindingSource tripBindingSource;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn availableSeatsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startStopDepartureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endStopArrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rideTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn tripNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fromDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn toDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn departureTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn arrivalTimeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn1;
        private Button returnTicketButton;
        private Button saveTicketButton;
    }
}
