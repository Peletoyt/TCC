namespace TCCpricipal
{
    public partial class NovoUsuarioPage : ContentPage
    {
        public NovoUsuarioPage()
        {
            Title = "Novo Usuário";
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Novo Usuário", FontSize = 24, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Página de criação de usuário (placeholder).", TextColor = Colors.Gray }
                }
            };
        }
    }
}
