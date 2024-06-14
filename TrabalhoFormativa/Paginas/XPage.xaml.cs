namespace TrabalhoFormativa.Paginas;
public partial class XPage : ContentPage
{
	public XPage()
	{
		InitializeComponent();
	}

    private async void btnVoltar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Homexplorar());
    }

    private async void btnEntrar_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FinalPage());
    }
}