using BusTicketingSystem.Models;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;
using System.Data;
using System.Windows.Forms;

namespace BusTicketingSystem
{
    public partial class MainForm : Form, IMainView, ISearchView
    {

        private ApplicationContext context;

        public MainForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
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

        public event EventHandler? LogoutClicked;
        public event EventHandler? TripsSearchClicked;
        public event EventHandler? BuyTicketClicked;

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

        void ISearchView.ShowView() => searchPanel.Visible = true;

        void ISearchView.CloseView() => searchPanel.Visible = false;

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

        public void CloseView() => Close();

        public bool ShowBuyingConfirmation(string message)
        {
            DialogResult result = MessageBox.Show(
                message,
                "Підтвердження купівлі",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            return result == DialogResult.Yes;
        }
    }
}
