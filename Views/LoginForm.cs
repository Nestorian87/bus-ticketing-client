using BusTicketingSystem.Presenter;
using BusTicketingSystem.View;

namespace BusTicketingSystem
{
    public partial class LoginForm : Form, ILoginView
    {

        private ApplicationContext context;

        public LoginForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        public string Username => loginTextBox.Text;

        public string Password => passwordTextBox.Text;

        public event EventHandler? LoginClicked;
        public event EventHandler? RegistrationClicked;

        public void ShowError(string error)
        {
            MessageBox.Show(
                text: error, 
                caption: "Сталася помилка",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error
            );
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            LoginClicked?.Invoke(this, EventArgs.Empty);
        }

        private void registrationLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationClicked?.Invoke(this, EventArgs.Empty);
        }

        public new void Show()
        {
            bool isRunning = context.MainForm != null;
            context.MainForm = this;
            if (isRunning)
            {
                base.Show();
            }
            else
            {
                Application.Run(context);
            }
        }
    }
}
