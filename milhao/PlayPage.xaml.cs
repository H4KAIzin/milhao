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
	 {
        //     frameGameOver.IsVisible = false;
        // }
        // else
        // {
        //     frameGameOver.IsVisible = true;
        // }
	 }
	}

	void Click2(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(2);
	 {
        //     frameGameOver.IsVisible = false;
        // }
        // else
        // {
        //     frameGameOver.IsVisible = true;
        // }
	}
	}

	void Click3(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(3);
	 {
        //     frameGameOver.IsVisible = false;
        // }
        // else
        // {
        //     frameGameOver.IsVisible = true;
        // }
	}
	}

	void Click4(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(4);
	 {
        //     frameGameOver.IsVisible = false;
        // }
        // else
        // {
        //     frameGameOver.IsVisible = true;
        // }
	}
	}

	void Click5(object sender, EventArgs e)
	{
	 gerenciador.VerificaCorreto(5);
	 {
        //     frameGameOver.IsVisible = false;
        // }
        // else
        // {
        //     frameGameOver.IsVisible = true;
        // }
	}
	}

	void BotaoRecomecar(object s, EventArgs e)
    {
        gerenciador.Initialize();
        frameGameOver.IsVisible = false;
    }

	void OnAjudaPulaClicked(object s, EventArgs e)
    {
        gerenciador.ProximaQuestao();
        (s as Button).IsVisible = false;
    }

    void OnAjudaRetirarCliecked(object s, EventArgs e)
    {
        var ajuda = new RetiraErrada();
        ajuda.ConfiguraEstruturaDesenho(Button1, Button2, Button3, Button4, Button5);
        ajuda.RealizaAjuda(gerenciador.GetQuestaoAtual());
        (s as Button).IsVisible = false;
    }
}