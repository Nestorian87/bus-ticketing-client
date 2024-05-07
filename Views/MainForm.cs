using BusTicketingSystem.Models;
using BusTicketingSystem.View;
using BusTicketingSystem.Views;

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

        public Stop? FromStop => fromComboBox.SelectedItem as Stop;

        public Stop? ToStop => toComboBox.SelectedItem as Stop;

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



        public event EventHandler? LogoutClicked;
        public event EventHandler? TripsSearchClicked;

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

        private void searchTripsButton_Click(object sender, EventArgs e)
        {
            TripsSearchClicked?.Invoke(this, EventArgs.Empty);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(
                text: error,
                caption: "Ñòàëàñÿ ïîìèëêà",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ñomboBox_Enter(object sender, EventArgs e)
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
    }
}
