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
    public partial class ModelDataForm : Form, IModelDataView
    {
        public ModelDataForm()
        {
            InitializeComponent();
        }

        public string ModelName
        {
            get => nameTextBox.Text;
            set => nameTextBox.Text = value;
        }

        public int? SeatsCount
        {
            get => string.IsNullOrEmpty(seatsCountNumericUpDown.Text) ?
                null : (int) seatsCountNumericUpDown.Value;
            set => seatsCountNumericUpDown.Text = value?.ToString() ?? "";
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
    }
}
