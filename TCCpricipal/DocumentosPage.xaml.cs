namespace TCCpricipal
{
    public partial class DocumentosPage : ContentPage
    {
        public DocumentosPage()
        {
            Title = "Documentos";

            Content = new ScrollView
            {
                Content = new VerticalStackLayout
                {
          
                    Padding = 20,
                    Spacing = 16,
                    Children =
                    {
                        // Cabeçalho
                        new Label { Text = "Organizar Documentos", FontSize = 28, FontAttributes = FontAttributes.Bold, TextColor = Colors.Black },
                        new Label { Text = "Aqui você pode visualizar os documentos que você enviou ou que foram enviados a você", FontSize = 14, TextColor = Colors.Gray },

                        // Linha separadora
                        new BoxView { HeightRequest = 1, BackgroundColor = Color.FromArgb("#DDDDDD") },

                        // Tabs simples (Documentos Enviados / Atestados Recebidos)
                        new Frame
                        {
                            Padding = new Thickness(10),
                            CornerRadius = 8,
                            BackgroundColor = Color.FromArgb("#F0F0F0"),
                            HasShadow = false,
                            Content = new Grid
                            {
                                ColumnDefinitions = new ColumnDefinitionCollection
                                {
                                    new ColumnDefinition { Width = GridLength.Star },
                                    new ColumnDefinition { Width = GridLength.Star }
                                },
                                Children =
                                {
                                    new Button { Text = "📤 Documentos Enviados", BackgroundColor = Colors.White, CornerRadius = 6, HorizontalOptions = LayoutOptions.Fill } ,
                                    new Button { Text = "📥 Atestados Recebidos", BackgroundColor = Color.FromArgb("#D8D8D8"), CornerRadius = 6, HorizontalOptions = LayoutOptions.Fill }
                                }
                            }
                        },

                        // Busca
                        new Grid
                        {
                            ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = GridLength.Star }, new ColumnDefinition { Width = GridLength.Auto } },
                            Children =
                            {
                                new Entry { Placeholder = "Faça sua busca", BackgroundColor = Colors.White, HorizontalOptions = LayoutOptions.FillAndExpand, Margin = new Thickness(0,8,8,0) },
                                new Button { Text = "Buscar", BackgroundColor = Color.FromArgb("#117A4D"), TextColor = Colors.White, CornerRadius = 6, Margin = new Thickness(0,8,0,0) , HeightRequest = 40}
                            }
                        },

                        // Botão central de enviar documento
                        new HorizontalStackLayout
                        {
                            HorizontalOptions = LayoutOptions.Center,
                            Children =
                            {
                                new Button { Text = "+ Enviar Documento", BackgroundColor = Color.FromArgb("#117A4D"), TextColor = Colors.White, CornerRadius = 8, Padding = new Thickness(20,10) }
                            }
                        },

                        // Lista de documentos - exemplo de item sem o frame do ícone
                        new Frame
                        {
                            CornerRadius = 12,
                            HasShadow = true,
                            Padding = new Thickness(18),
                            BackgroundColor = Color.FromArgb("#FAFAFA"),
                            Content = new Grid
                            {
                                ColumnDefinitions = new ColumnDefinitionCollection { new ColumnDefinition { Width = GridLength.Star }, new ColumnDefinition { Width = GridLength.Auto } },
                                Children =
                                {
                                    // Conteúdo principal (título, meta)
                                    new VerticalStackLayout
                                    {
                                        Spacing = 6,
                                        Children =
                                        {
                                            new Label { Text = "Acidente nas Torres Gêmeas", FontSize = 20, FontAttributes = FontAttributes.Bold, TextColor = Colors.Black },
                                            new Label { Text = "11/09/2001 • Enviado para: Celso Portiolli", FontSize = 13, TextColor = Colors.DarkGray },
                                            new Label { Text = "anexo documento", FontSize = 13, TextColor = Colors.Gray }
                                        }
                                    },

                                    // Menu de três pontos (à direita)
                                    new Button { Text = "⋮", BackgroundColor = Colors.Transparent, BorderWidth = 0, FontSize = 20, TextColor = Colors.DarkGray, HorizontalOptions = LayoutOptions.End }
                                }
                            }
                        }
                    }
                }
            };
        }
    }
}
