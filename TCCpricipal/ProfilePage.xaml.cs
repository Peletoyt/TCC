namespace TCCpricipal
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            Title = "Profile";
            Content = new VerticalStackLayout
            {
                Padding = 20,
                Children =
                {
                    new Label { Text = "Profile", FontSize = 24, FontAttributes = FontAttributes.Bold },
                    new Label { Text = "Página de perfil (placeholder).", TextColor = Colors.Gray }
                }
            };
        }
    }
}
