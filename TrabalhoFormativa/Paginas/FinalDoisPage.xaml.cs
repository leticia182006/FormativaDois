namespace TrabalhoFormativa.Paginas;

public partial class FinalDoisPage : ContentPage
{
	public FinalDoisPage()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new LoginPage());
    }
}