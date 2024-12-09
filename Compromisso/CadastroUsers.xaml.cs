using Models;

namespace Compromisso;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCadastrarClicked(object sender, EventArgs e) {
		Models.Usuario usuario = new();

		usuario.UsuarioId = count;
		count ++;
		usuario.Nome =  NomeEntry.Text;
		usuario.Senha = SenhaEntry.Text;
		usuario.Cpf = CpfEntry.Text;
		usuario.Email = EmailEntry.Text;
		string senha = SenhaEntry.Text;
        string confirmarSenha = ConfirmarSenhaEntry.Text;

        // Verifica se a senha e a confirmação coincidem
        if (senha == confirmarSenha)
        {
            // Aqui você poderia salvar o cadastro ou realizar outra ação
            ResultadoLabel.Text = "Cadastro realizado com sucesso!";
            ResultadoLabel.TextColor = Colors.Green;

            // Limpa os campos de entrada após o cadastro
            NomeEntry.Text = string.Empty;
            EmailEntry.Text = string.Empty;
            CpfEntry.Text = string.Empty;
            SenhaEntry.Text = string.Empty;
            ConfirmarSenhaEntry.Text = string.Empty;
        }
        else
        {
            ResultadoLabel.Text = "As senhas não coincidem. Tente novamente.";
            ResultadoLabel.TextColor = Colors.Red;
        }
    }

    private async void ButtonCancel_Clicked(object sender, EventArgs e)
    {
			 await Navigation.PopAsync();

    }
}
