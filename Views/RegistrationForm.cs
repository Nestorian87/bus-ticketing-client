using BusTicketingSystem.Presenter;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.View;
using Microsoft.EntityFrameworkCore;

namespace BusTicketingSystem.Views
{
    public partial class RegistrationForm : Form, IRegistrationView
    {

        private ApplicationContext context;

        public event EventHandler? BackArrowClicked;
        public event EventHandler? RegisterClicked;

        public RegistrationForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        string IRegistrationView.Name => nameTextBox.Text;

        public string Surname => surnameTextBox.Text;

        public string Username => usernameTextBox.Text;

        public string Password => passwordTextBox.Text;

        public void ShowError(string error)
        {
            MessageBox.Show(
                text: error,
                caption: "Сталася помилка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }

        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterClicked?.Invoke(this, EventArgs.Empty);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            BackArrowClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
