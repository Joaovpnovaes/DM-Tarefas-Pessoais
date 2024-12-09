namespace Compromisso;

public partial class LOGIN : ContentPage
{
	public LOGIN()
	{
		InitializeComponent();
		this.Title = "";
		 NavigationPage.SetHasNavigationBar(this, false);
	}


 private async void LOGAR_SISTEMA(object sender, EventArgs e)
    {

		//faz login
		await Navigation.PushAsync(new Compromisso.MainPage());
    


    }
 private async void ABRIR_MENU(object sender, EventArgs e)
{
    // Navega para a página de menu
    await Navigation.PushAsync(new Compromisso.Menu());
}
}