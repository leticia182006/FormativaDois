namespace TrabalhoFormativa.Paginas;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private async void btnAcessar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homexplorar());
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new SobreNos());
    }
}