using BusTicketingSystem.Models;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using System.Data;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class MainForm : 
        Form,
        IMainView, 
        ISearchView, 
        ITicketsView, 
        IModelsView, 
        IRoutesView, 
        IBusesView, 
        IStopsView
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

        public Route? SelectedRoute
        {
            get
            {
                var selectedRows = routesDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Route;
            }
        }

        public RouteStop? SelectedRouteStop
        {
            get
            {
                var selectedRows = routeStopsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as RouteStop;
            }
        }

        public Trip? SelectedRouteTrip
        {
            get
            {
                var selectedRows = routeTripsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Trip;
            }
        }

        public Bus? SelectedBus
        {
            get
            {
                var selectedRows = busesDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Bus;
            }
        }

        public Stop? SelectedStop
        {
            get
            {
                var selectedRows = stopsDataGridView.SelectedRows;
                if (selectedRows == null || selectedRows.Count == 0)
                {
                    return null;
                }
                return selectedRows[0].DataBoundItem as Stop;
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
        public event EventHandler? AddRouteClicked;
        public event EventHandler? EditRouteClicked;
        public event EventHandler? DeleteRouteClicked;
        public event EventHandler? AddRouteStopClicked;
        public event EventHandler? EditRouteStopClicked;
        public event EventHandler? DeleteRouteStopClicked;
        public event EventHandler? MoveRouteStopBeforeClicked;
        public event EventHandler? MoveRouteStopAfterClicked;
        public event EventHandler? AddRouteTripClicked;
        public event EventHandler? EditRouteTripClicked;
        public event EventHandler? DeleteRouteTripClicked;
        public event EventHandler? RoutesClicked;
        public event EventHandler? RouteSelectionChanged;
        public event EventHandler? AddBusClicked;
        public event EventHandler? EditBusClicked;
        public event EventHandler? DeleteBusClicked;
        public event EventHandler? BusesClicked;
        public event EventHandler? AddStopClicked;
        public event EventHandler? EditStopClicked;
        public event EventHandler? DeleteStopClicked;
        public event EventHandler? StopsClicked;

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

        void IRoutesView.ShowView() => tabControl.SelectedTab = routesTabPage;
        void IRoutesView.CloseView() { }

        void IBusesView.ShowView() => tabControl.SelectedTab = busesTabPage;
        void IBusesView.CloseView() { }

        void IStopsView.ShowView() => tabControl.SelectedTab = stopsTabPage;
        void IStopsView.CloseView() { }

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

        private void routesMenuItem_Click(object sender, EventArgs e)
        {
            RoutesClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetRouteBindingSource(BindingSource source)
        {
            routeBindingSource.DataSource = source;
        }

        public void SetRouteStopBindingSource(BindingSource source)
        {
            routeStopBindingSource.DataSource = source;
        }

        public void SetRouteTripBindingSource(BindingSource source)
        {
            routeTripBindingSource.DataSource = source;
        }

        private void routesDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            RouteSelectionChanged?.Invoke(this, EventArgs.Empty);
        }

        private void AddRouteButton_Click(object sender, EventArgs e)
        {
            AddRouteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editRouteButton_Click(object sender, EventArgs e)
        {
            EditRouteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteRouteButton_Click(object sender, EventArgs e)
        {
            DeleteRouteClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addRouteStopButton_Click(object sender, EventArgs e)
        {
            AddRouteStopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editRouteStopButton_Click(object sender, EventArgs e)
        {
            EditRouteStopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteRouteStopButton_Click(object sender, EventArgs e)
        {
            DeleteRouteStopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void moveRouteStopToBottomButton_Click(object sender, EventArgs e)
        {
            MoveRouteStopAfterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void moveRouteStopBeforeButton_Click(object sender, EventArgs e)
        {
            MoveRouteStopBeforeClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetSelectedRouteStopIndex(int index)
        {
            if (index >= 0 && index < routeStopsDataGridView.Rows.Count)
            {
                routeStopsDataGridView.Rows[index].Cells[1].Selected = true;
            }
        }

        private void AddTripButton_Click(object sender, EventArgs e)
        {
            AddRouteTripClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editTripButton_Click(object sender, EventArgs e)
        {
            EditRouteTripClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteTripButton_Click(object sender, EventArgs e)
        {
            DeleteRouteTripClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetBusBindingSource(BindingSource source)
        {
            busBindingSource.DataSource = source;
        }

        private void addBusButton_Click(object sender, EventArgs e)
        {
            AddBusClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editBusButton_Click(object sender, EventArgs e)
        {
            EditBusClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteBusButton_Click(object sender, EventArgs e)
        {
            DeleteBusClicked?.Invoke(this, EventArgs.Empty);
        }

        private void busesMenuItem_Click(object sender, EventArgs e)
        {
            BusesClicked?.Invoke(this, EventArgs.Empty);
        }

        private void stopsMenuItem_Click(object sender, EventArgs e)
        {
            StopsClicked?.Invoke(this, EventArgs.Empty);
        }

        private void addStopButton_Click(object sender, EventArgs e)
        {
            AddStopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editStopButton_Click(object sender, EventArgs e)
        {
            EditStopClicked?.Invoke(this, EventArgs.Empty);
        }

        private void deleteStopButton_Click(object sender, EventArgs e)
        {
            DeleteStopClicked?.Invoke(this, EventArgs.Empty);
        }

        public void SetStopBindingSource(BindingSource source)
        {
            stopBindingSource.DataSource = source;
        }
    }
}
