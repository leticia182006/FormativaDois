namespace TrabalhoFormativa.Paginas;

public partial class FinalPage : ContentPage
{
	public FinalPage()
	{
		InitializeComponent();
	}

    private async void btnSim_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalDoisPage());
    }

    private async void btnNao_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homexplorar());
    }

    private async void btnX_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new XPage());
    }

    private async void btnInstagram_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new InstagramPage());
    }

    private async void btnWhats_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new WhatsPage());
    }
}