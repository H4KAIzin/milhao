namespace milhao;

public partial class PlayPage : ContentPage
{
	 Gerenciador gerenciador;
	public PlayPage()
	{
		InitializeComponent();

		gerenciador = new Gerenciador(labelpergunta, Button1, Button2, Button3, Button4, Button5);
        gerenciador.ProximaQuestao();
	}




	public void Click1(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(1);
	}

	public void Click2(object sender, EventArgs e)
	{
	 gerenciador.VerificaResposta(2);
	}

	public void Click3(object sender, EventArgs e)
	{
	 gerenciador.VerificaResposta(3);
	}

	public void Click4(object sender, EventArgs e)
	{
	 gerenciador.VerificaResposta(4);
	}

	public void Click5(object sender, EventArgs e)
	{
	 gerenciador.VerificaResposta(5);
	}

}