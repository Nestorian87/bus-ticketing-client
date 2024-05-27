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
    public partial class BusDataForm : Form, IBusDataView
    {
        public BusModel? Model { 
            get => modelComboBox.SelectedItem as BusModel;
            set => modelComboBox.SelectedItem = value;
        }
        public string Number {
            get => numberMaskedTextBox.Text.Trim().ToUpper();
            set => numberMaskedTextBox.Text = value;
        }

        public BusDataForm()
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

        public void SetModelBindingSource(BindingSource source)
        {
            busModelBindingSource.DataSource = source;
        }
    }
}
