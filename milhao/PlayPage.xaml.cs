namespace milhao;

public partial class PlayPage
{
	Gerenciador gerenciador;
	public PlayPage()
	{
		InitializeComponent();

		gerenciador = new Gerenciador(labelpergunta, Button1, Button2, Button3, Button4, Button5);
        gerenciador.ProximaQuestao();
	}

	void Click1(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(1);
	}

	void Click2(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(2);
	}

	void Click3(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(3);
	}

	void Click4(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(4);
	}

	void Click5(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(5);
	}

}