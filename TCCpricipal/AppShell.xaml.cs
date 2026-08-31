namespace TCCpricipal
{
    public partial class AppShell : Shell
    {
        bool _isFlyoutCollapsed = false;
        bool _loginShown = false;

        public AppShell()
        {
            InitializeComponent();
            // Adia a exibição da tela de login até o Shell estar pronto
            this.Loaded += AppShell_Loaded;
            // Inicializa estado da flyout
            _isFlyoutCollapsed = false;
            // Anexa o handler de clique ao botão da seta (para alternar flyout)
            var btn = this.FindByName<Microsoft.Maui.Controls.Button>("ToggleFlyoutButton");
            if (btn != null)
            {
                btn.Clicked += OnToggleFlyoutButtonClicked;
            }
        }

        private async void AppShell_Loaded(object? sender, EventArgs e)
        {
            if (_loginShown)
                return;
            _loginShown = true;

            // Mostra a MainPage (login) como modal sobre o Shell para que o flyout não apareça
            await this.Navigation.PushModalAsync(new MainPage());
        }

        // Handler chamado quando o botão de alternância é clicado
        private void OnToggleFlyoutButtonClicked(object sender, System.EventArgs e)
        {
            // Valores de largura: expandido e colapsado
            const double expandedWidth = 220;
            const double collapsedWidth = 60;

            var btn = this.FindByName<Microsoft.Maui.Controls.Button>("ToggleFlyoutButton");

            // Atualiza na UI thread para garantir aplicação imediata
            Microsoft.Maui.ApplicationModel.MainThread.BeginInvokeOnMainThread(() =>
            {
                // Alterna largura
                if (_isFlyoutCollapsed)
                {
                    this.FlyoutWidth = expandedWidth;
                    if (btn != null) btn.Text = "«"; // aponta para esquerda quando expandido
                    _isFlyoutCollapsed = false;
                }
                else
                {
                    this.FlyoutWidth = collapsedWidth;
                    if (btn != null) btn.Text = ">"; // aponta para direita quando colapsado
                    _isFlyoutCollapsed = true;
                }
            });
        }
    }
}
