using BusTicketingSystem.Managers;
using BusTicketingSystem.Models;
using BusTicketingSystem.Repositories;
using BusTicketingSystem.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusTicketingSystem.Presenters
{
    public class TicketsPresenter : IPresenter
    {
        private ITicketsView view;
        private ITicketRepository ticketRepository;
        private BindingSource ticketBindingSource = new BindingSource();

        public TicketsPresenter(ITicketsView view, ITicketRepository ticketRepository)
        {
            this.view = view;
            this.ticketRepository = ticketRepository;

            view.SetTicketBindingSource(ticketBindingSource);

            view.ReturnTicketClicked += (_, _) => ReturnTicket();
            view.SaveTicketClicked += (_, _) => SaveTicket();
        }

        public void Run()
        {
            ShowTickets();
            view.ShowView();
        }

        private void ShowTickets()
        {
            List<Ticket> tickets = ticketRepository.GetActiveTickets();
            ticketBindingSource.DataSource = tickets;
            view.IsNoBoughtTicketsTextVisible = tickets.Count == 0;
        }

        private void ReturnTicket()
        {
            Ticket? selectedTicket = view.SelectedTicket;

            if (selectedTicket == null)
            {
                view.ShowError("Для повернення оберіть квиток");
                return;
            }

            string confirmationMessage = $"Ви точно хочете повернути квиток {selectedTicket.StartStop.Stop.Name} – {selectedTicket.EndStop.Stop.Name} на {selectedTicket.Date.ToLongDateString()} {selectedTicket.DepartureTime.ToShortTimeString()}?";
            if (view.ShowConfirmation(confirmationMessage))
            {
                ticketRepository.ReturnTicket(selectedTicket.Id);
                ShowTickets();
            }
        }

        private void SaveTicket()
        {
            Ticket? selectedTicket = view.SelectedTicket;

            if (selectedTicket == null)
            {
                view.ShowError("Для завантаження оберіть квиток");
                return;
            }

            string path = view.RequestTicketSavingPath();
            if (path == "")
            {
                return;
            }
            PdfTicketManager.GeneratePdf(selectedTicket, path);
            OpenFile(path);
        }

        private void OpenFile(string path)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true
                }
            };
            process.Start();
        }
    }
}
