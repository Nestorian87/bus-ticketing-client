using BusTicketingSystem.View;

namespace BusTicketingSystem
{
    public partial class MainForm : Form, IMainView
    {

        private ApplicationContext context;

        public MainForm(ApplicationContext context)
        {
            InitializeComponent();
            this.context = context;
        }

        public event EventHandler? LogoutClicked;

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

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LogoutClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ñomboBox_Enter(object sender, EventArgs e)
        {
            ((ComboBox) sender).DroppedDown = true;
        }
    }
}
