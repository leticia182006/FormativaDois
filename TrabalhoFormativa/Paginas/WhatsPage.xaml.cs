namespace TrabalhoFormativa.Paginas;
public partial class WhatsPage : ContentPage
{
	public WhatsPage()
	{
		InitializeComponent();
	}

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homexplorar());
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }
}