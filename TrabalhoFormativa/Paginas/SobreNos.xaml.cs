namespace TrabalhoFormativa.Paginas;
public partial class SobreNos : ContentPage
{
	public SobreNos()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}