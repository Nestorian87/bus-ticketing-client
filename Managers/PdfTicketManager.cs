using BusTicketingSystem.Models;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace BusTicketingSystem.Managers
{
    public static class PdfTicketManager
    {


        public static void GeneratePdf(Ticket ticket, string savePath)
        {
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A5);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);
                    page.DefaultTextStyle(x => x.FontSize(14).FontColor(Colors.Black).FontFamily("Times New Roman"));

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Row(row =>
                        {
                            row.RelativeItem().Column(column =>
                            {
                                column.Spacing(5);

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Пасажир:").Bold();
                                    row.RelativeItem().Text($"{ticket.User.Name} {ticket.User.Surname}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Ціна:").Bold();
                                    row.RelativeItem().Text($"{ticket.Price:F0} грн");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Звідки:").Bold();
                                    row.RelativeItem().Text($"{ticket.StartStop.Stop.Description}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Дата відправлення:").Bold();
                                    row.RelativeItem().Text($"{ticket.Date:dd.MM.yyyy}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Час відправлення:").Bold();
                                    row.RelativeItem().Text($"{ticket.DepartureTime:HH:mm}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Куди:").Bold();
                                    row.RelativeItem().Text($"{ticket.EndStop.Stop.Description}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Номер квитка:").Bold();
                                    row.RelativeItem().Text($"{ticket.Id}");
                                });

                                column.Item().Row(row => {
                                    row.RelativeItem().Text("Номер рейсу:").Bold();
                                    row.RelativeItem().Text($"{ticket.TripNumber}");
                                });
                            });
                        });

                });
            }).GeneratePdf(savePath);
        }
    }
}
