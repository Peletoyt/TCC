namespace TCCpricipal
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }



        private async void OnLoginClicked(object? sender, EventArgs e)
        {
            // mostra um pop-up informando que o login foi feito
            await DisplayAlert("Sucesso", "login feito", "OK");

            // opcional: também atualiza o StatusLabel se existir
            var statusLabel = this.FindByName<Label>("StatusLabel");
            if (statusLabel != null)
            {
                statusLabel.Text = "login feito";
                statusLabel.IsVisible = true;
            }

            // Navega para a página de resultados dentro do Shell e fecha o modal de login
            if (Shell.Current != null)
            {
                await Shell.Current.GoToAsync("//TelaDeResultados");
            }

            // Fecha o modal (a MainPage foi apresentada como modal sobre o Shell)
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }
    }
}
