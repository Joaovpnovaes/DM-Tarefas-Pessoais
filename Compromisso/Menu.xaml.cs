namespace Compromisso;

public partial class Menu : ContentPage
{
	public Menu()
	{
		InitializeComponent();

	}
	private async void ABRIR_GERENCIAMENTO_CONTAS(object sender, EventArgs e)
{
    // Navega para a página de Gerenciamento de Contas
    await Navigation.PushAsync(new Compromisso.GerenciamentoC());
}

 private async void ABRIR_MENU(object sender, EventArgs e)
{
    // Navega para a página de menu
    await Navigation.PushAsync(new Compromisso.Menu());
}

 private async void ABRIR_TRANSACOES(object sender, EventArgs e)
{
    // Navega para a página de Transações
    await Navigation.PushAsync(new Compromisso.Transacoes());
}

}  
	



