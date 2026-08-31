namespace TCCpricipal
{
    public partial class CalendarPage : ContentPage
    {
        public CalendarPage()
        {
            Title = "Calendário";
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Calendário", FontSize = 24, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Página de calendário (placeholder).", TextColor = Colors.Gray }
                }
            };
        }
    }
}
