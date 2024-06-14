namespace TrabalhoFormativa.Paginas;

public partial class Homexplorar : ContentPage
{
	public Homexplorar()
	{
		InitializeComponent();
	}

    private void btnEntrar_Clicked(object sender, EventArgs e)
    {
      
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void btnAcessar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new TintaMarromPage());
    }
}