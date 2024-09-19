namespace milhao;

public class Questao
{
   
    private int IdPage ;

    private int DifficultyLvl;

     public string? Question;

    public string? Answer01;

    public string? Answer02;

    public string? Answer03;

    public string? Answer04;
    
    public string? Answer05;

    public int  CorrectAnswer;
    private Label Labelpergunta;
    private Button Button1;
    private Button Button2;
    private Button Button3;
    private Button Button4;
    private Button Button5;

     public void ConfiguraEstruturaDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            // Inicializando os componentes da UI
            Labelpergunta = labelpergunta;
            ButtonResposta1 = button1;
            ButtonResposta2 = button2;
            ButtonResposta3 = button3;
            ButtonResposta4 = button4;
            ButtonResposta5 = button5;
        }

        // Método para desenhar as perguntas e respostas
        public void Desenhar()
        {
            // Atribuindo os textos corretos aos componentes da UI
            Labelpergunta.Text = Pergunta;
            ButtonResposta1.Text = Resposta1;
            ButtonResposta2.Text = Resposta2;
            ButtonResposta3.Text = Resposta3;
            ButtonResposta4.Text = Resposta4;
            ButtonResposta5.Text = Resposta5;
        }

        // Método para identificar qual botão corresponde à resposta selecionada
        private Button QualButton(int RespostaSelecionada)
        {
            return RespostaSelecionada switch
            {
                1 => ButtonResposta1,
                2 => ButtonResposta2,
                3 => ButtonResposta3,
                4 => ButtonResposta4,
                5 => ButtonResposta5,
                _ => null,
            };
        }

        // Método para verificar se a resposta está correta
        public bool VerificaResposta(int RespostaSelecionada)
        {
            if (Respostacorreta == RespostaSelecionada)
            {
                // Resposta correta - o botão da resposta correta fica verde
                var Button = QualButton(RespostaSelecionada);
                if (Button != null)
                {
                    Button.BackgroundColor = Colors.Green;
                }
                return true;
            }
            else
            {
                // Resposta incorreta - o botão correto fica amarelo, o incorreto fica vermelho
                var ButtonCorreto = QualButton(Respostacorreta);
                var ButtonIncorreto = QualButton(RespostaSelecionada);

                if (ButtonCorreto != null)
                {
                    ButtonCorreto.BackgroundColor = Colors.Yellow;
                }

                if (ButtonIncorreto != null)
                {
                    ButtonIncorreto.BackgroundColor = Colors.Red;
                }

                return false;
            }
        }

        // Construtor padrão
        public Questao() { }

        // Construtor com parâmetros
        public Questao(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            // Usando 'this' para referenciar as propriedades da instância atual
            this.Labelpergunta = labelpergunta;
            this.ButtonResposta1 = button1;
            this.ButtonResposta2 = button2;
            this.ButtonResposta3 = button3;
            this.ButtonResposta4 = button4;
            this.ButtonResposta5 = button5;
        }
    }