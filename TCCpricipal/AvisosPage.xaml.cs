namespace TCCpricipal
{
    public partial class AvisosPage : ContentPage
    {
        public AvisosPage()
        {
            Title = "Avisos";
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Avisos", FontSize = 24, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Página de avisos (placeholder).", TextColor = Colors.Gray }
                }
            };
        }
    }
}
