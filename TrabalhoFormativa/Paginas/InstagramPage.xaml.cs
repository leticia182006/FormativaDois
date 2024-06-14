namespace TrabalhoFormativa.Paginas;

public partial class InstagramPage : ContentPage
{
	public InstagramPage()
	{
		InitializeComponent();
	}

    private async void btnCadastrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homexplorar());
    }

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }
}