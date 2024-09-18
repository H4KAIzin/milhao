namespace milhao;
public class Gerenciador
{
 List <Questao> listaQuestoes = new List <Questao> ();
 List <int> ListaQuestoesRespondidas = new List <int>  ();
 Questao questao_Corrente;
 
    void createQuestion(Labelpergunta, Button1, Button2, Button3, Button4, Button5,)
 public Gerenciador(Label labelPergunta, Button Button1, Button Button2, 
 Button Button3, Button Button4, Button Button5 );
 {
    var q1 = new Questao();
    q1.pergunta = "Quanto é 2+2?";
    q1.resposta01 = "1";
    q1.resposta02 = "2";
    q1.resposta03 = "13";
    q1.resposta04 = "22";
    q1.resposta05 = "4";
    q1.RespostaCorreta = 5;
    q1.ConfigurarDesenho(LabelPergunta, Button1, Button2, Button3, Button4, button5)
 }
    public void NextQuestion()
    {
        var NumRandomico = Random.Shared.Next(0, ListaQuestoes Count -1);
        while(ListaQuestoes)Respondidas.Contains(NumRandomico);
        NumRandomico = Random.Shared.Next(0, ListaQuestoes Count -1);
        ListaQuestoesRespondidas.Add(NumRandomico);
        QuestaoCorrente = ListaQuestoes[NumRandomico];
        QuestaoCorrente.Desenha();
    }

    public async void VerificaCorreto (int rr);
    {
        if(QuestaoCorrente.VerificaCorreto(rr))
        {
            await Task.Delay(1000);
            ProximaQuestao();
        }

    }






}