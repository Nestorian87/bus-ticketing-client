using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem.Views
{
    public partial class RouteStopDataForm : Form, IRouteStopDataView
    {

        public Stop? Stop
        {
            get => stopComboBox.SelectedItem as Stop;
            set => stopComboBox.SelectedItem = value;
        }
        public int? RideHoursFromPreviousStop
        {
            get => string.IsNullOrEmpty(rideTimeHoursNumericUpDown.Text) ?
                   null : (int)rideTimeHoursNumericUpDown.Value;
            set => rideTimeHoursNumericUpDown.Text = value?.ToString() ?? "";
        }
        public int? RideMinutesFromPreviousStop
        {
            get => string.IsNullOrEmpty(rideTimeMinutesNumericUpDown.Text) ?
                   null : (int)rideTimeMinutesNumericUpDown.Value;
            set => rideTimeMinutesNumericUpDown.Text = value?.ToString() ?? "";
        }
        public int? StopTimeMinutes
        {
            get => string.IsNullOrEmpty(stopMinutesNumericUpDown.Text) ?
                   null : (int)stopMinutesNumericUpDown.Value;
            set => stopMinutesNumericUpDown.Text = value?.ToString() ?? "";
        }

        public RouteStopDataForm()
        {
            InitializeComponent();
        }

        public event EventHandler? SaveClicked;

        public void CloseView() => Close();

        public void ShowView() => ShowDialog();

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveClicked?.Invoke(this, EventArgs.Empty);
        }

        private void cancelButton_Click(object sender, EventArgs e) => CloseView();

        public void ShowError(string error)
        {
            MessageBox.Show(
                text: error,
                caption: "Сталася помилка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }

        public void SetStopsBindingSource(BindingSource bindingSource)
        {
            stopDataBindingSource.DataSource = bindingSource;
        }

        public bool ShowConfirmationWithWarning(string message)
        {
            DialogResult result = MessageBox.Show(
                message,
                "Попередження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            return result == DialogResult.Yes;
        }
    }
}
