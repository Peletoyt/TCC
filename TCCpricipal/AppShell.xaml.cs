namespace TCCpricipal
{
    public partial class AppShell : Shell
    {
        bool _loginShown = false;

        public AppShell()
        {
            InitializeComponent();
            // Adia a exibição da tela de login até o Shell estar pronto
            this.Loaded += AppShell_Loaded;
        }

        private async void AppShell_Loaded(object? sender, EventArgs e)
        {
            if (_loginShown)
                return;
            _loginShown = true;

            // Mostra a MainPage (login) como modal sobre o Shell para que o flyout não apareça
            await this.Navigation.PushModalAsync(new MainPage());
        }
    }
}
