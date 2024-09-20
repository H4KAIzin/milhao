namespace milhao
{
    public class Gerenciador
    {
    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
      
       public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
      void CriarQuestoes(Label labelPergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            var q1 = new Questao();
            q1.Question = "Quanto é 2+2?";
            q1.Answer01 = "1";
            q1.Answer02 = "2";
            q1.Answer03 = "13";
            q1.Answer04 = "22";
            q1.Answer05 = "4";
            q1.CorrectAnswer = 5;
            q1.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
            listaQuestoes.Add(q1); 
        }

        
         void ProximaQuestao()
        {
            var numRandomico = Random.Shared.Next(0, listaQuestoes.Count);
            while (listaQuestaoRespondida.Contains(numRandomico))
            {
                numRandomico = Random.Shared.Next(0, listaQuestoes.Count);
            }

            listaQuestaoRespondida.Add(numRandomico);
            questaoAtual = listaQuestoes[numRandomico];
            questaoAtual.Desenhar();
        }

        
     async void VerificaCorreto(int resposta)
        {
            if (questaoAtual.VerificaResposta(resposta))
            {
                await Task.Delay(1000);
                ProximaQuestao();
            }
        }
    }

    
    }
    }
