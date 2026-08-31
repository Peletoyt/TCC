namespace TCCpricipal
{
    public partial class DocumentosPage : ContentPage
    {
        public DocumentosPage()
        {
            Title = "Documentos";
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Documentos", FontSize = 24, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Página de documentos (placeholder).", TextColor = Colors.Gray }
                }
            };
        }
    }
}
