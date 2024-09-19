namespace Milhao
{
    public class Gerenciador
    {
    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestoesRespondidas = new List<int>();
    Questao QuestaoAtual;
      void CriarQuestoes(Label labelPergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
            var q1 = new Questao();
            q1.Pergunta = "Quanto é 2+2?";
            q1.Resposta01 = "1";
            q1.Resposta02 = "2";
            q1.Resposta03 = "13";
            q1.Resposta04 = "22";
            q1.Resposta05 = "4";
            q1.RespostaCorreta = 5;
            q1.ConfigurarDesenho(labelPergunta, button1, button2, button3, button4, button5);
            listaQuestoes.Add(q1); 
        }

        
        public void ProximaQuestao()
        {
            var numRandomico = Random.Shared.Next(0, listaQuestoes.Count);
            while (listaQuestoesRespondidas.Contains(numRandomico))
            {
                numRandomico = Random.Shared.Next(0, listaQuestoes.Count);
            }

            listaQuestoesRespondidas.Add(numRandomico);
            QuestaoAtual = listaQuestoes[numRandomico];
            QuestaoAtual.Desenha();
        }

        
        public async void VerificaCorreto(int resposta)
        {
            if (QuestaoAtual.VerificaCorreto(resposta))
            {
                await Task.Delay(1000);
                ProximaQuestao();
            }
        }
    }

    
    }
