using BusTicketingSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem.Views
{
    public partial class RouteTripDataForm : Form, IRouteTripDataView
    {
        public Bus? Bus
        {
            get => busComboBox.SelectedItem as Bus;
            set => busComboBox.SelectedItem = value;
        }

        public TimeOnly StartTime {
            get => TimeOnly.FromDateTime(startTimePicker.Value);
            set => startTimePicker.Value = DateTime.Today + value.ToTimeSpan();
        }

        public List<DayOfWeek> ActiveDaysOfWeek
        {
            get
            {
                return daysOfWeekCheckedListBox.CheckedIndices
                    .Cast<int>()
                    .Select(index => (DayOfWeek)((index + 1) % 7))
                    .ToList();
            }
            set
            {
                for (int i = 0; i < daysOfWeekCheckedListBox.Items.Count; i++)
                {
                    daysOfWeekCheckedListBox.SetItemChecked(i, value.Contains((DayOfWeek)((i + 1) % 7)));
                }
            }
        }


        public RouteTripDataForm()
        {
            InitializeComponent();
            InitDaysOfWeek();
        }

        private void InitDaysOfWeek()
        {
            var cultureInfo = new CultureInfo("uk-UA");
            var dateTimeFormat = cultureInfo.DateTimeFormat;

            for (int i = 1; i <= 7; i++)
            {
                DayOfWeek day = (DayOfWeek)(i % 7);
                daysOfWeekCheckedListBox.Items.Add(dateTimeFormat.GetDayName(day));
            }
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

        public void SetBusesBindingSource(BindingSource bindingSource)
        {
            tripBusBindingSource.DataSource = bindingSource;
        }
    }
}
