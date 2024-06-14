namespace TrabalhoFormativa.Paginas;

public partial class TintaMarromPage : ContentPage
{
	public TintaMarromPage()
	{
		InitializeComponent();
	} 
    private async void btnEntrar_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }

    private async void btnVoltar_Clicked_1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new HomePage());
    }

    private async void btnTinta_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }
}