namespace milhao;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void startou(object sender, EventArgs args)
	{
		Navigation.PushAsync(new PlayPage());
	}	

}

