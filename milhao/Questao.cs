namespace milhao;

public class Questao
{

    public int DifficultyLvl;

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

     public Questao(){
        
     }

    public void ConfiguraEstruturaDesenho(Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5)
        {
           
            Labelpergunta = labelpergunta;
            Button1 = button1;
            Button2 = button2;
            Button3 = button3;
            Button4 = button4;
            Button5 = button5;
        }

        
    public void Desenhar()
        {
            
            Labelpergunta.Text = Question;
            Button1.Text = Answer01;
            Button2.Text = Answer02;
            Button3.Text = Answer03;
            Button4.Text = Answer04;
            Button5.Text = Answer05;
        }
        private Button QualButton(int r){
        if(r == 1){
            return Button1;
        }
        else if(r == 2){
            return Button2;
        }
        else if (r == 3){
            return Button3;
        }
        else if (r == 4){
            return Button4;
        }
        else if (r == 5 ){
            return Button5;
        }
        else{
            return null;
        }
    }

    public bool VerificaResposta(int rr){
        if(CorrectAnswer == rr){
    var button = QualButton(rr);
        button.BackgroundColor = Colors.Green;
    return true;
        }
        else{
            var buttonCorreto = QualButton(CorrectAnswer);
                var buttonIncorreto = QualButton(rr);
            buttonCorreto.BackgroundColor = Colors.Green;
                buttonIncorreto.BackgroundColor = Colors.Red;

            return false;
        }
    }
}