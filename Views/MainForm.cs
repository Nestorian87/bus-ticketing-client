using BusTicketingSystem.Models;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using System.Data;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class MainForm : Form, IMainView, ISearchView, ITicketsView, IModelsView
    {

        private ApplicationContext context;

        public MainForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
            HideTabs();
        }

        public Stop? FromStop
        {
            get => fromComboBox.SelectedItem as Stop;
            set
            {
                fromComboBox.SelectedItem = value;
            }
        }

        public Stop? ToStop
        {
            get => toComboBox.SelectedItem as Stop;
            set => toComboBox.SelectedItem = value;
        }

        public DateTime SearchDate
        {
            get => datePicker.Value.Date;
            set => datePicker.Value = value;
        }

        public DateTime MinSearchDate
        {
            set => datePicker.MinDate = value;
        }

        public List<Stop> Stops
        {
            set
            {
                BindStopComboBox(fromComboBox, value);
                BindStopComboBox(toComboBox, value);
            }
        }

        public Trip? SelectedTrip
        {
            get
            {
                var selectedRows = tripsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Trip;
            }
        }

        public bool IsTripsNotFoundTextVisible { set => tripsNotFoundLabel.Visible = value; }

        public Ticket? SelectedTicket
        {
            get
            {
                var selectedRows = boughtTicketsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Ticket;
            }
        }

        public BusModel? SelectedModel
        {
            get
            {
                var selectedRows = modelsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as BusModel;
            }
        }

        public event EventHandler? LogoutClicked;
        public event EventHandler? TripsSearchClicked;
        public event EventHandler? BuyTicketClicked;
        public event EventHandler? SearchTripsClicked;
        public event EventHandler? MyTicketsClicked;
        public event EventHandler? SaveTicketClicked;
        public event EventHandler? ReturnTicketClicked;
        public event EventHandler? AddModelClicked;
        public event EventHandler? EditModelClicked;
        public event EventHandler? DeleteModelClicked;
        public event EventHandler? ModelsClicked;

        public void SetTripBindingSource(BindingSource source)
        {
            tripBindingSource.DataSource = source;
        }


        private void BindStopComboBox(ComboBox comboBox, List<Stop> stops)
        {
            comboBox.DataSource = new List<Stop>(stops);
            comboBox.ValueMember = "Id";
            comboBox.DisplayMember = "Name";
        }

        void ISearchView.ShowView() => tabControl.SelectedTab = searchTabPage;

        void ISearchView.CloseView() { }

        void ITicketsView.ShowView() => tabControl.SelectedTab = myTicketsTabPage;

        void ITicketsView.CloseView() { }

        void IModelsView.ShowView() => tabControl.SelectedTab = modelsTabPage;

        void IModelsView.CloseView() { }

        private void buyButton_Click(object sender, EventArgs e)
        {
            BuyTicketClicked?.Invoke(this, EventArgs.Empty);
        }

        private void searchTripsButton_Click(object sender, EventArgs e)
        {
            TripsSearchClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(
                text: error,
                caption: "Сталася помилка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void сomboBox_Enter(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (!comboBox.DroppedDown)
            {
                comboBox.DroppedDown = true;
            }
        }

        public void ShowView()
        {
            bool isRunning = context.MainForm != null;
            context.MainForm = this;
            if (isRunning)
            {
                Show();
            }
            else
            {
                Application.Run(context);
            }
        }

        public void CloseView() => Hide();

        public bool ShowBuyingConfirmation(string message)
        {
            DialogResult result = MessageBox.Show(
                message,
                "Підтвердження дії",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        private void HideTabs()
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        public void SetTicketBindingSource(BindingSource source)
        {
            ticketBindingSource.DataSource = source;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchTripsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void myTicketsButton_Click(object sender, EventArgs e)
        {
            MyTicketsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void returnTicketButton_Click(object sender, EventArgs e)
        {
            ReturnTicketClicked?.Invoke(this, EventArgs.Empty);
        }

        private void saveTicketButton_Click(object sender, EventArgs e)
        {
            SaveTicketClicked?.Invoke(this, EventArgs.Empty);
        }

        public bool ShowConfirmation(string message)
        {
            DialogResult result = MessageBox.Show(
                message,
                "Підтвердження дії",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }

        public string RequestTicketSavingPath()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Файл pdf|*.pdf";
            dialog.Title = "Завантаження квитка";
            dialog.FileName = "Квиток";
            dialog.ShowDialog();
            return dialog.FileName;
        }

        public void ChangeAdminControlsVisibility(bool isVisible)
        {
            menuStrip.Visible = isVisible;
        }

        public void SetModelsBindingSource(BindingSource source)
        {
            busModelBindingSource.DataSource = source;
        }

        private void modelsMenuItem_Click(object sender, EventArgs e)
        {
            ModelsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addModelButton_Click(object sender, EventArgs e)
        {
            AddModelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editModelButton_Click(object sender, EventArgs e)
        {
            EditModelClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteModelButton_Click(object sender, EventArgs e)
        {
            DeleteModelClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
