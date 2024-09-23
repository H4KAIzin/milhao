namespace milhao;

public class Gerenciador
{
    List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
      
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }
    
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

        var q2 = new Questao();
        q2.Question = "Qual é a capital da França?";
        q2.Answer01 = "Londres";
        q2.Answer02 = "Roma";
        q2.Answer03 = "Berlim";
        q2.Answer04 = "Paris";
        q2.Answer05 = "Madri";
        q2.CorrectAnswer = 4;
        q2.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q2);

        var q3 = new Questao();
        q3.Question = "Quem descobriu o Brasil?";
        q3.Answer01 = "Cristóvão Colombo";
        q3.Answer02 = "Pedro Álvares Cabral";
        q3.Answer03 = "Vasco da Gama";
        q3.Answer04 = "Américo Vespúcio";
        q3.Answer05 = "Fernando de Noronha";
        q3.CorrectAnswer = 2;
        q3.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Question = "Qual é o maior planeta do Sistema Solar?";
        q4.Answer01 = "Marte";
        q4.Answer02 = "Júpiter";
        q4.Answer03 = "Saturno";
        q4.Answer04 = "Vênus";
        q4.Answer05 = "Terra";
        q4.CorrectAnswer = 2;
        q4.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Question = "Quantos continentes existem no planeta Terra?";
        q5.Answer01 = "5";
        q5.Answer02 = "6";
        q5.Answer03 = "7";
        q5.Answer04 = "8";
        q5.Answer05 = "9";
        q5.CorrectAnswer = 3;
        q5.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Question = "Qual é o elemento químico representado pelo símbolo 'O'?";
        q6.Answer01 = "Ouro";
        q6.Answer02 = "Osmio";
        q6.Answer03 = "Oxigênio";
        q6.Answer04 = "Ósmio";
        q6.Answer05 = "Óxido";
        q6.CorrectAnswer = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Question = "Qual é o número atômico do hidrogênio?";
        q7.Answer01 = "1";
        q7.Answer02 = "2";
        q7.Answer03 = "8";
        q7.Answer04 = "10";
        q7.Answer05 = "12";
        q7.CorrectAnswer = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Question = "Quem escreveu 'Dom Quixote'?";
        q8.Answer01 = "William Shakespeare";
        q8.Answer02 = "Miguel de Cervantes";
        q8.Answer03 = "Jorge Luis Borges";
        q8.Answer04 = "Gabriel García Márquez";
        q8.Answer05 = "Fernando Pessoa";
        q8.CorrectAnswer = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Question = "Qual é o país mais populoso do mundo?";
        q9.Answer01 = "Índia";
        q9.Answer02 = "China";
        q9.Answer03 = "Estados Unidos";
        q9.Answer04 = "Indonésia";
        q9.Answer05 = "Brasil";
        q9.CorrectAnswer = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Question = "Quem pintou 'A Última Ceia'?";
        q10.Answer01 = "Michelangelo";
        q10.Answer02 = "Vincent van Gogh";
        q10.Answer03 = "Leonardo da Vinci";
        q10.Answer04 = "Claude Monet";
        q10.Answer05 = "Pablo Picasso";
        q10.CorrectAnswer = 3;
        q10.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q10);

        var q11 = new Questao();
        q11.Question = "Em que ano ocorreu a Revolução Francesa?";
        q11.Answer01 = "1789";
        q11.Answer02 = "1776";
        q11.Answer03 = "1804";
        q11.Answer04 = "1815";
        q11.Answer05 = "1848";
        q11.CorrectAnswer = 1;
        q11.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q11);

        var q12 = new Questao();
        q12.Question = "Qual é o maior oceano do planeta Terra?";
        q12.Answer01 = "Oceano Atlântico";
        q12.Answer02 = "Oceano Índico";
        q12.Answer03 = "Oceano Pacífico";
        q12.Answer04 = "Oceano Ártico";
        q12.Answer05 = "Oceano Antártico";
        q12.CorrectAnswer = 3;
        q12.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q12);

        var q13 = new Questao();
        q13.Question = "Qual é o valor de pi (π) arredondado a duas casas decimais?";
        q13.Answer01 = "3.14";
        q13.Answer02 = "2.71";
        q13.Answer03 = "1.61";
        q13.Answer04 = "3.67";
        q13.Answer05 = "2.99";
        q13.CorrectAnswer = 1;
        q13.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q13);

        var q14 = new Questao();
        q14.Question = "Qual é o maior país em extensão territorial?";
        q14.Answer01 = "China";
        q14.Answer02 = "Canadá";
        q14.Answer03 = "Estados Unidos";
        q14.Answer04 = "Rússia";
        q14.Answer05 = "Brasil";
        q14.CorrectAnswer = 4;
        q14.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q14);

        var q15 = new Questao();
        q15.Question = "Quem foi o primeiro homem a pisar na Lua?";
        q15.Answer01 = "Yuri Gagarin";
        q15.Answer02 = "Buzz Aldrin";
        q15.Answer03 = "Neil Armstrong";
        q15.Answer04 = "John Glenn";
        q15.Answer05 = "Alan Shepard";
        q15.CorrectAnswer = 3;
        q15.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q15);

        var q16 = new Questao();
        q16.Question = "Qual é a capital do Japão?";
        q16.Answer01 = "Seul";
        q16.Answer02 = "Pequim";
        q16.Answer03 = "Tóquio";
        q16.Answer04 = "Xangai";
        q16.Answer05 = "Kyoto";
        q16.CorrectAnswer = 3;
        q16.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q16);

        var q17 = new Questao();
        q17.Question = "Qual é o continente mais populoso?";
        q17.Answer01 = "África";
        q17.Answer02 = "Europa";
        q17.Answer03 = "América do Norte";
        q17.Answer04 = "Ásia";
        q17.Answer05 = "América do Sul";
        q17.CorrectAnswer = 4;
        q17.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q17);

        var q18 = new Questao();
        q18.Question = "Quantos ossos tem o corpo humano adulto?";
        q18.Answer01 = "206";
        q18.Answer02 = "208";
        q18.Answer03 = "210";
        q18.Answer04 = "212";
        q18.Answer05 = "214";
        q18.CorrectAnswer = 1;
        q18.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q18);

        var q19 = new Questao();
        q19.Question = "Quem inventou a lâmpada elétrica?";
        q19.Answer01 = "Alexander Graham Bell";
        q19.Answer02 = "Thomas Edison";
        q19.Answer03 = "Nikola Tesla";
        q19.Answer04 = "Benjamin Franklin";
        q19.Answer05 = "James Watt";
        q19.CorrectAnswer = 2;
        q19.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q19);

        var q20 = new Questao();
        q20.Question = "Qual é o menor país do mundo?";
        q20.Answer01 = "Vaticano";
        q20.Answer02 = "Mônaco";
        q20.Answer03 = "San Marino";
        q20.Answer04 = "Liechtenstein";
        q20.Answer05 = "Malta";
        q20.CorrectAnswer = 1;
        q20.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q20);

        // Continuando a mesma estrutura para os demais:
        var q21 = new Questao();
        q21.Question = "Qual é o maior deserto do mundo?";
        q21.Answer01 = "Saara";
        q21.Answer02 = "Gobi";
        q21.Answer03 = "Deserto da Arábia";
        q21.Answer04 = "Antártida";
        q21.Answer05 = "Kalahari";
        q21.CorrectAnswer = 4;
        q21.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q21);

        var q22 = new Questao();
        q22.Question = "Em que ano o Titanic afundou?";
        q22.Answer01 = "1905";
        q22.Answer02 = "1912";
        q22.Answer03 = "1915";
        q22.Answer04 = "1921";
        q22.Answer05 = "1919";
        q22.CorrectAnswer = 2;
        q22.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q22);

        var q23 = new Questao();
        q23.Question = "Qual é a fórmula química da água?";
        q23.Answer01 = "CO2";
        q23.Answer02 = "H2SO4";
        q23.Answer03 = "H2O";
        q23.Answer04 = "NaCl";
        q23.Answer05 = "O2";
        q23.CorrectAnswer = 3;
        q23.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q23);

        var q24 = new Questao();
        q24.Question = "Em que ano começou a Segunda Guerra Mundial?";
        q24.Answer01 = "1937";
        q24.Answer02 = "1939";
        q24.Answer03 = "1941";
        q24.Answer04 = "1945";
        q24.Answer05 = "1948";
        q24.CorrectAnswer = 2;
        q24.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q24);

        var q25 = new Questao();
        q25.Question = "Quem foi o primeiro presidente dos Estados Unidos?";
        q25.Answer01 = "Thomas Jefferson";
        q25.Answer02 = "Abraham Lincoln";
        q25.Answer03 = "George Washington";
        q25.Answer04 = "Theodore Roosevelt";
        q25.Answer05 = "John Adams";
        q25.CorrectAnswer = 3;
        q25.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q25);

        var q26 = new Questao();
        q26.Question = "Quantos lados tem um hexágono?";
        q26.Answer01 = "4";
        q26.Answer02 = "5";
        q26.Answer03 = "6";
        q26.Answer04 = "7";
        q26.Answer05 = "8";
        q26.CorrectAnswer = 3;
        q26.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q26);

        var q27 = new Questao();
        q27.Question = "Quem pintou 'Guernica'?";
        q27.Answer01 = "Salvador Dalí";
        q27.Answer02 = "Claude Monet";
        q27.Answer03 = "Vincent van Gogh";
        q27.Answer04 = "Pablo Picasso";
        q27.Answer05 = "Joan Miró";
        q27.CorrectAnswer = 4;
        q27.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q27);

        var q28 = new Questao();
        q28.Question = "Qual é a capital da Austrália?";
        q28.Answer01 = "Sydney";
        q28.Answer02 = "Melbourne";
        q28.Answer03 = "Brisbane";
        q28.Answer04 = "Canberra";
        q28.Answer05 = "Adelaide";
        q28.CorrectAnswer = 4;
        q28.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q28);

        var q29 = new Questao();
        q29.Question = "Qual o planeta mais próximo do Sol?";
        q29.Answer01 = "Vênus";
        q29.Answer02 = "Marte";
        q29.Answer03 = "Mercúrio";
        q29.Answer04 = "Terra";
        q29.Answer05 = "Júpiter";
        q29.CorrectAnswer = 3;
        q29.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q29);

        var q30 = new Questao();
        q30.Question = "Qual é o maior animal terrestre?";
        q30.Answer01 = "Elefante";
        q30.Answer02 = "Girafa";
        q30.Answer03 = "Rinoceronte";
        q30.Answer04 = "Hipopótamo";
        q30.Answer05 = "Baleia";
        q30.CorrectAnswer = 1;
        q30.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q30);

        var q31 = new Questao();
        q31.Question = "Qual foi o primeiro satélite artificial lançado pela humanidade?";
        q31.Answer01 = "Apollo 11";
        q31.Answer02 = "Sputnik 1";
        q31.Answer03 = "Voyager 1";
        q31.Answer04 = "Hubble";
        q31.Answer05 = "Skylab";
        q31.CorrectAnswer = 2;
        q31.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q31);

        var q32 = new Questao();
        q32.Question = "Quem foi o criador do personagem 'Sherlock Holmes'?";
        q32.Answer01 = "Agatha Christie";
        q32.Answer02 = "Arthur Conan Doyle";
        q32.Answer03 = "Edgar Allan Poe";
        q32.Answer04 = "H.G. Wells";
        q32.Answer05 = "Mark Twain";
        q32.CorrectAnswer = 2;
        q32.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q32);

        var q33 = new Questao();
        q33.Question = "Quantos segundos há em uma hora?";
        q33.Answer01 = "3.600";
        q33.Answer02 = "6.000";
        q33.Answer03 = "10.000";
        q33.Answer04 = "2.400";
        q33.Answer05 = "3.000";
        q33.CorrectAnswer = 1;
        q33.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q33);

        var q34 = new Questao();
        q34.Question = "Qual é a moeda oficial do Japão?";
        q34.Answer01 = "Dólar";
        q34.Answer02 = "Iene";
        q34.Answer03 = "Euro";
        q34.Answer04 = "Won";
        q34.Answer05 = "Yuan";
        q34.CorrectAnswer = 2;
        q34.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q34);

        var q35 = new Questao();
        q35.Question = "Quem escreveu 'Romeu e Julieta'?";
        q35.Answer01 = "Charles Dickens";
        q35.Answer02 = "William Shakespeare";
        q35.Answer03 = "Oscar Wilde";
        q35.Answer04 = "Jane Austen";
        q35.Answer05 = "George Orwell";
        q35.CorrectAnswer = 2;
        q35.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q35);

        var q36 = new Questao();
        q36.Question = "Qual é o maior órgão do corpo humano?";
        q36.Answer01 = "Coração";
        q36.Answer02 = "Cérebro";
        q36.Answer03 = "Fígado";
        q36.Answer04 = "Pele";
        q36.Answer05 = "Pulmão";
        q36.CorrectAnswer = 4;
        q36.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q36);

        var q37 = new Questao();
        q37.Question = "Quantos planetas compõem o Sistema Solar?";
        q37.Answer01 = "7";
        q37.Answer02 = "8";
        q37.Answer03 = "9";
        q37.Answer04 = "10";
        q37.Answer05 = "11";
        q37.CorrectAnswer = 2;
        q37.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q37);

        var q38 = new Questao();
        q38.Question = "Qual é a capital da Alemanha?";
        q38.Answer01 = "Berlim";
        q38.Answer02 = "Hamburgo";
        q38.Answer03 = "Munique";
        q38.Answer04 = "Colônia";
        q38.Answer05 = "Frankfurt";
        q38.CorrectAnswer = 1;
        q38.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q38);

        var q39 = new Questao();
        q39.Question = "Qual a distância aproximada entre a Terra e a Lua?";
        q39.Answer01 = "384.000 km";
        q39.Answer02 = "150.000 km";
        q39.Answer03 = "1.000.000 km";
        q39.Answer04 = "500.000 km";
        q39.Answer05 = "700.000 km";
        q39.CorrectAnswer = 1;
        q39.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q39);

        var q40 = new Questao();
        q40.Question = "Qual é o oceano entre a África e a América do Sul?";
        q40.Answer01 = "Oceano Índico";
        q40.Answer02 = "Oceano Pacífico";
        q40.Answer03 = "Oceano Atlântico";
        q40.Answer04 = "Oceano Ártico";
        q40.Answer05 = "Oceano Antártico";
        q40.CorrectAnswer = 3;
        q40.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q40);

        var q41 = new Questao();
        q41.Question = "Quem é conhecido como o 'Pai da Aviação'?";
        q41.Answer01 = "Wright Brothers";
        q41.Answer02 = "Albert Einstein";
        q41.Answer03 = "Santos Dumont";
        q41.Answer04 = "Thomas Edison";
        q41.Answer05 = "Nikola Tesla";
        q41.CorrectAnswer = 3;
        q41.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q41);

        var q42 = new Questao();
        q42.Question = "Qual é o menor país do mundo?";
        q42.Answer01 = "Mônaco";
        q42.Answer02 = "Vaticano";
        q42.Answer03 = "Luxemburgo";
        q42.Answer04 = "Malta";
        q42.Answer05 = "Andorra";
        q42.CorrectAnswer = 2;
        q42.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q42);

        var q43 = new Questao();
        q43.Question = "Quantos anéis tem o planeta Saturno?";
        q43.Answer01 = "4";
        q43.Answer02 = "5";
        q43.Answer03 = "6";
        q43.Answer04 = "7";
        q43.Answer05 = "8";
        q43.CorrectAnswer = 4;
        q43.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q43);

        var q44 = new Questao();
        q44.Question = "Qual é o maior oceano do mundo?";
        q44.Answer01 = "Oceano Atlântico";
        q44.Answer02 = "Oceano Índico";
        q44.Answer03 = "Oceano Pacífico";
        q44.Answer04 = "Oceano Ártico";
        q44.Answer05 = "Oceano Antártico";
        q44.CorrectAnswer = 3;
        q44.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q44);

        var q45 = new Questao();
        q45.Question = "Qual foi o ano de fundação de Roma?";
        q45.Answer01 = "753 a.C.";
        q45.Answer02 = "509 a.C.";
        q45.Answer03 = "476 a.C.";
        q45.Answer04 = "100 a.C.";
        q45.Answer05 = "44 a.C.";
        q45.CorrectAnswer = 1;
        q45.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q45);

        var q46 = new Questao();
        q46.Question = "Qual é a capital do Canadá?";
        q46.Answer01 = "Toronto";
        q46.Answer02 = "Montreal";
        q46.Answer03 = "Ottawa";
        q46.Answer04 = "Vancouver";
        q46.Answer05 = "Quebec";
        q46.CorrectAnswer = 3;
        q46.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q46);

        var q47 = new Questao();
        q47.Question = "Qual é a unidade básica da vida?";
        q47.Answer01 = "Átomo";
        q47.Answer02 = "Célula";
        q47.Answer03 = "Molécula";
        q47.Answer04 = "Tecido";
        q47.Answer05 = "Órgão";
        q47.CorrectAnswer = 2;
        q47.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q47);

        var q48 = new Questao();
        q48.Question = "Qual a velocidade da luz no vácuo?";
        q48.Answer01 = "200.000 km/s";
        q48.Answer02 = "300.000 km/s";
        q48.Answer03 = "400.000 km/s";
        q48.Answer04 = "500.000 km/s";
        q48.Answer05 = "600.000 km/s";
        q48.CorrectAnswer = 2;
        q48.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q48);

        var q49 = new Questao();
        q49.Question = "Quantos ossos tem o corpo humano adulto?";
        q49.Answer01 = "196";
        q49.Answer02 = "206";
        q49.Answer03 = "216";
        q49.Answer04 = "226";
        q49.Answer05 = "236";
        q49.CorrectAnswer = 2;
        q49.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q49);

        var q50 = new Questao();
        q50.Question = "Em que país está localizada a Torre Eiffel?";
        q50.Answer01 = "Itália";
        q50.Answer02 = "Alemanha";
        q50.Answer03 = "Reino Unido";
        q50.Answer04 = "França";
        q50.Answer05 = "Espanha";
        q50.CorrectAnswer = 4;
        q50.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q50);

        var q51 = new Questao();
        q51.Question = "Qual é a maior espécie de felino?";
        q51.Answer01 = "Leão";
        q51.Answer02 = "Onça";
        q51.Answer03 = "Tigre";
        q51.Answer04 = "Leopardo";
        q51.Answer05 = "Guepardo";
        q51.CorrectAnswer = 3;
        q51.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q51);

        var q52 = new Questao();
        q52.Question = "Qual o metal cujo símbolo químico é 'Au'?";
        q52.Answer01 = "Prata";
        q52.Answer02 = "Ferro";
        q52.Answer03 = "Alumínio";
        q52.Answer04 = "Ouro";
        q52.Answer05 = "Cobre";
        q52.CorrectAnswer = 4;
        q52.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q52);

        var q53 = new Questao();
        q53.Question = "Quem inventou a lâmpada elétrica?";
        q53.Answer01 = "Nikola Tesla";
        q53.Answer02 = "Galileu Galilei";
        q53.Answer03 = "Albert Einstein";
        q53.Answer04 = "Thomas Edison";
        q53.Answer05 = "Alexander Graham Bell";
        q53.CorrectAnswer = 4;
        q53.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q53);

        var q54 = new Questao();
        q54.Question = "Qual a maior montanha do mundo?";
        q54.Answer01 = "Monte Everest";
        q54.Answer02 = "K2";
        q54.Answer03 = "Kangchenjunga";
        q54.Answer04 = "Monte Kilimanjaro";
        q54.Answer05 = "Monte McKinley";
        q54.CorrectAnswer = 1;
        q54.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q54);

        var q55 = new Questao();
        q55.Question = "Qual o maior mamífero do mundo?";
        q55.Answer01 = "Elefante";
        q55.Answer02 = "Girafa";
        q55.Answer03 = "Rinoceronte";
        q55.Answer04 = "Hipopótamo";
        q55.Answer05 = "Sua Irmã";
        q55.CorrectAnswer = 5;
        q55.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q55);

        var q56 = new Questao();
        q56.Question = "Qual o nome do cientista que propôs a teoria da relatividade?";
        q56.Answer01 = "Isaac Newton";
        q56.Answer02 = "Charles Darwin";
        q56.Answer03 = "Nikola Tesla";
        q56.Answer04 = "Galileu Galilei";
        q56.Answer05 = "Albert Einstein";
        q56.CorrectAnswer = 5;
        q56.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q56);

        var q57 = new Questao();
        q57.Question = "Qual o país conhecido como a terra dos cangurus?";
        q57.Answer01 = "África do Sul";
        q57.Answer02 = "Nova Zelândia";
        q57.Answer03 = "Canadá";
        q57.Answer04 = "Austrália";
        q57.Answer05 = "Estados Unidos";
        q57.CorrectAnswer = 4;
        q57.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q57);

        var q58 = new Questao();
        q58.Question = "Em que país fica a Grande Muralha?";
        q58.Answer01 = "Japão";
        q58.Answer02 = "Coreia do Sul";
        q58.Answer03 = "China";
        q58.Answer04 = "Tailândia";
        q58.Answer05 = "Vietnã";
        q58.CorrectAnswer = 3;
        q58.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q58);

        var q59 = new Questao();
        q59.Question = "Qual é o rio mais longo do mundo?";
        q59.Answer01 = "Rio Amazonas";
        q59.Answer02 = "Rio Nilo";
        q59.Answer03 = "Rio Yangtzé";
        q59.Answer04 = "Rio Mississipi";
        q59.Answer05 = "Rio Congo";
        q59.CorrectAnswer = 2;
        q59.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q59);

        var q60 = new Questao();
        q60.Question = "Qual o maior deserto do mundo?";
        q60.Answer01 = "Deserto do Saara";
        q60.Answer02 = "Deserto de Gobi";
        q60.Answer03 = "Deserto da Antártica";
        q60.Answer04 = "Deserto de Kalahari";
        q60.Answer05 = "Deserto da Arábia";
        q60.CorrectAnswer = 3;
        q60.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q60);

        var q61 = new Questao();
        q61.Question = "Qual o animal mais rápido do mundo?";
        q61.Answer01 = "Tigre";
        q61.Answer02 = "Guepardo";
        q61.Answer03 = "Águia";
        q61.Answer04 = "Leopardo";
        q61.Answer05 = "Cavalo";
        q61.CorrectAnswer = 2;
        q61.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q61);

        var q62 = new Questao();
        q62.Question = "Quem pintou a Mona Lisa?";
        q62.Answer01 = "Leonardo da Vinci";
        q62.Answer02 = "Michelangelo";
        q62.Answer03 = "Raphael";
        q62.Answer04 = "Donatello";
        q62.Answer05 = "Van Gogh";
        q62.CorrectAnswer = 1;
        q62.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q62);

        var q63 = new Questao();
        q63.Question = "Qual a capital da Rússia?";
        q63.Answer01 = "São Petersburgo";
        q63.Answer02 = "Moscou";
        q63.Answer03 = "Kiev";
        q63.Answer04 = "Vladivostok";
        q63.Answer05 = "Varsóvia";
        q63.CorrectAnswer = 2;
        q63.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q63);

        var q64 = new Questao();
        q64.Question = "Qual o maior planeta do Sistema Solar?";
        q64.Answer01 = "Saturno";
        q64.Answer02 = "Netuno";
        q64.Answer03 = "Júpiter";
        q64.Answer04 = "Urano";
        q64.Answer05 = "Marte";
        q64.CorrectAnswer = 3;
        q64.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q64);

        var q65 = new Questao();
        q65.Question = "Qual o nome do maior oceano da Terra?";
        q65.Answer01 = "Oceano Atlântico";
        q65.Answer02 = "Oceano Índico";
        q65.Answer03 = "Oceano Pacífico";
        q65.Answer04 = "Oceano Ártico";
        q65.Answer05 = "Oceano Antártico";
        q65.CorrectAnswer = 3;
        q65.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q65);

        var q66 = new Questao();
        q66.Question = "Qual é o número atômico do hidrogênio?";
        q66.Answer01 = "1";
        q66.Answer02 = "2";
        q66.Answer03 = "3";
        q66.Answer04 = "4";
        q66.Answer05 = "5";
        q66.CorrectAnswer = 1;
        q66.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q66);

        var q67 = new Questao();
        q67.Question = "Quantos continentes existem no mundo?";
        q67.Answer01 = "5";
        q67.Answer02 = "6";
        q67.Answer03 = "7";
        q67.Answer04 = "8";
        q67.Answer05 = "9";
        q67.CorrectAnswer = 3;
        q67.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q67);

        var q68 = new Questao();
        q68.Question = "Qual é o elemento químico mais abundante na atmosfera da Terra?";
        q68.Answer01 = "Oxigênio";
        q68.Answer02 = "Hidrogênio";
        q68.Answer03 = "Nitrogênio";
        q68.Answer04 = "Carbono";
        q68.Answer05 = "Argônio";
        q68.CorrectAnswer = 3;
        q68.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q68);

        var q69 = new Questao();
        q69.Question = "Quem foi o primeiro homem a pisar na Lua?";
        q69.Answer01 = "Buzz Aldrin";
        q69.Answer02 = "Yuri Gagarin";
        q69.Answer03 = "Michael Collins";
        q69.Answer04 = "Neil Armstrong";
        q69.Answer05 = "John Glenn";
        q69.CorrectAnswer = 4;
        q69.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q69);

        var q70 = new Questao();
        q70.Question = "Qual é a fórmula química do sal de cozinha?";
        q70.Answer01 = "NaCl";
        q70.Answer02 = "KCl";
        q70.Answer03 = "CaCl2";
        q70.Answer04 = "NaOH";
        q70.Answer05 = "MgCl2";
        q70.CorrectAnswer = 1;
        q70.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q70);

        var q71 = new Questao();
        q71.Question = "Quem escreveu 'Dom Quixote'?";
        q71.Answer01 = "Miguel de Cervantes";
        q71.Answer02 = "Gabriel García Márquez";
        q71.Answer03 = "Pablo Neruda";
        q71.Answer04 = "Jorge Luis Borges";
        q71.Answer05 = "Mario Vargas Llosa";
        q71.CorrectAnswer = 1;
        q71.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q71);

        var q72 = new Questao();
        q72.Question = "Qual é a unidade de medida da resistência elétrica?";
        q72.Answer01 = "Volt";
        q72.Answer02 = "Ampere";
        q72.Answer03 = "Ohm";
        q72.Answer04 = "Watt";
        q72.Answer05 = "Joule";
        q72.CorrectAnswer = 3;
        q72.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q72);

        var q73 = new Questao();
        q73.Question = "Qual é a moeda oficial do Reino Unido?";
        q73.Answer01 = "Euro";
        q73.Answer02 = "Dólar";
        q73.Answer03 = "Libra Esterlina";
        q73.Answer04 = "Iene";
        q73.Answer05 = "Rublo";
        q73.CorrectAnswer = 3;
        q73.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q73);

        var q74 = new Questao();
        q74.Question = "Qual o nome do maior osso do corpo humano?";
        q74.Answer01 = "Tíbia";
        q74.Answer02 = "Fêmur";
        q74.Answer03 = "Úmero";
        q74.Answer04 = "Esterno";
        q74.Answer05 = "Rádio";
        q74.CorrectAnswer = 2;
        q74.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q74);

        var q75 = new Questao();
        q75.Question = "Quem foi o autor de 'A Origem das Espécies'?";
        q75.Answer01 = "Albert Einstein";
        q75.Answer02 = "Isaac Newton";
        q75.Answer03 = "Charles Darwin";
        q75.Answer04 = "Galileu Galilei";
        q75.Answer05 = "Louis Pasteur";
        q75.CorrectAnswer = 3;
        q75.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q75);

        var q76 = new Questao();
        q76.Question = "Qual é o maior estado do Brasil em extensão territorial?";
        q76.Answer01 = "São Paulo";
        q76.Answer02 = "Mato Grosso";
        q76.Answer03 = "Amazonas";
        q76.Answer04 = "Bahia";
        q76.Answer05 = "Minas Gerais";
        q76.CorrectAnswer = 3;
        q76.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q76);

        var q77 = new Questao();
        q77.Question = "Qual é o elemento mais abundante no corpo humano?";
        q77.Answer01 = "Oxigênio";
        q77.Answer02 = "Carbono";
        q77.Answer03 = "Hidrogênio";
        q77.Answer04 = "Cálcio";
        q77.Answer05 = "Nitrogênio";
        q77.CorrectAnswer = 1;
        q77.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q77);

        var q78 = new Questao();
        q78.Question = "Quantos dias tem um ano bissexto?";
        q78.Answer01 = "364";
        q78.Answer02 = "365";
        q78.Answer03 = "366";
        q78.Answer04 = "367";
        q78.Answer05 = "368";
        q78.CorrectAnswer = 3;
        q78.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q78);

        var q79 = new Questao();
        q79.Question = "Qual é o menor planeta do Sistema Solar?";
        q79.Answer01 = "Marte";
        q79.Answer02 = "Vênus";
        q79.Answer03 = "Mercúrio";
        q79.Answer04 = "Plutão";
        q79.Answer05 = "Netuno";
        q79.CorrectAnswer = 3;
        q79.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q79);

        var q80 = new Questao();
        q80.Question = "Qual a capital do estado da Califórnia?";
        q80.Answer01 = "Los Angeles";
        q80.Answer02 = "San Francisco";
        q80.Answer03 = "Sacramento";
        q80.Answer04 = "San Diego";
        q80.Answer05 = "Oakland";
        q80.CorrectAnswer = 3;
        q80.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q80);

        var q81 = new Questao();
        q81.Question = "Quem foi o autor da Teoria da Gravidade?";
        q81.Answer01 = "Galileu Galilei";
        q81.Answer02 = "Albert Einstein";
        q81.Answer03 = "Charles Darwin";
        q81.Answer04 = "Isaac Newton";
        q81.Answer05 = "Niels Bohr";
        q81.CorrectAnswer = 4;
        q81.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q81);

        var q82 = new Questao();
        q82.Question = "Qual foi o primeiro animal a ser clonado com sucesso?";
        q82.Answer01 = "Ovelha Dolly";
        q82.Answer02 = "Gato Snowball";
        q82.Answer03 = "Cão Rex";
        q82.Answer04 = "Porco Piggy";
        q82.Answer05 = "Rato Mickey";
        q82.CorrectAnswer = 1;
        q82.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q82);

        var q83 = new Questao();
        q83.Question = "Qual é a língua mais falada no mundo?";
        q83.Answer01 = "Inglês";
        q83.Answer02 = "Espanhol";
        q83.Answer03 = "Chinês Mandarim";
        q83.Answer04 = "Francês";
        q83.Answer05 = "Árabe";
        q83.CorrectAnswer = 3;
        q83.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q83);

        var q84 = new Questao();
        q84.Question = "Qual é o símbolo químico da água?";
        q84.Answer01 = "CO2";
        q84.Answer02 = "O2";
        q84.Answer03 = "H2O";
        q84.Answer04 = "HO2";
        q84.Answer05 = "H3O";
        q84.CorrectAnswer = 3;
        q84.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q84);

        var q85 = new Questao();
        q85.Question = "Quem foi o primeiro presidente dos Estados Unidos?";
        q85.Answer01 = "George Washington";
        q85.Answer02 = "Abraham Lincoln";
        q85.Answer03 = "Thomas Jefferson";
        q85.Answer04 = "John Adams";
        q85.Answer05 = "James Madison";
        q85.CorrectAnswer = 1;
        q85.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q85);

        var q86 = new Questao();
        q86.Question = "Qual é a maior ilha do mundo?";
        q86.Answer01 = "Groenlândia";
        q86.Answer02 = "Ilha de Java";
        q86.Answer03 = "Ilha de Sumatra";
        q86.Answer04 = "Ilha de Madagascar";
        q86.Answer05 = "Ilha da Nova Guiné";
        q86.CorrectAnswer = 1;
        q86.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q86);

        var q87 = new Questao();
        q87.Question = "Qual é o nome do primeiro satélite artificial lançado pela URSS?";
        q87.Answer01 = "Sputnik 1";
        q87.Answer02 = "Apollo 11";
        q87.Answer03 = "Explorer 1";
        q87.Answer04 = "Vostok 1";
        q87.Answer05 = "Mercury 1";
        q87.CorrectAnswer = 1;
        q87.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q87);

        var q88 = new Questao();
        q88.Question = "Qual foi o evento que marcou o início da Segunda Guerra Mundial?";
        q88.Answer01 = "A invasão da Polônia";
        q88.Answer02 = "A Batalha de Stalingrado";
        q88.Answer03 = "O Ataque a Pearl Harbor";
        q88.Answer04 = "O Tratado de Versalhes";
        q88.Answer05 = "A Queda de Berlim";
        q88.CorrectAnswer = 1;
        q88.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q88);

        var q89 = new Questao();
        q89.Question = "Em que ano o homem chegou à Lua?";
        q89.Answer01 = "1959";
        q89.Answer02 = "1965";
        q89.Answer03 = "1969";
        q89.Answer04 = "1971";
        q89.Answer05 = "1975";
        q89.CorrectAnswer = 3;
        q89.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q89);

        var q90 = new Questao();
        q90.Question = "Qual é o maior continente em termos de área?";
        q90.Answer01 = "África";
        q90.Answer02 = "América do Sul";
        q90.Answer03 = "Ásia";
        q90.Answer04 = "Europa";
        q90.Answer05 = "Oceania";
        q90.CorrectAnswer = 3;
        q90.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q90);

        var q91 = new Questao();
        q91.Question = "Qual o símbolo químico do elemento ferro?";
        q91.Answer01 = "Fe";
        q91.Answer02 = "F";
        q91.Answer03 = "Fr";
        q91.Answer04 = "Fa";
        q91.Answer05 = "Fi";
        q91.CorrectAnswer = 1;
        q91.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q91);

        var q92 = new Questao();
        q92.Question = "Quem foi o descobridor do Brasil?";
        q92.Answer01 = "Pedro Álvares Cabral";
        q92.Answer02 = "Vasco da Gama";
        q92.Answer03 = "Cristóvão Colombo";
        q92.Answer04 = "Fernão de Magalhães";
        q92.Answer05 = "Américo Vespúcio";
        q92.CorrectAnswer = 1;
        q92.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q92);

        var q93 = new Questao();
        q93.Question = "Em que continente fica o deserto do Saara?";
        q93.Answer01 = "Ásia";
        q93.Answer02 = "América do Sul";
        q93.Answer03 = "Africa";
        q93.Answer04 = "Palmeiras";
        q93.Answer05 = "Junin rodoviarias";
        q93.CorrectAnswer = 1;
        q93.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q93);

        var q94 = new Questao();
        q94.Question = "Em que continente fica o deserto do Saara?";
        q94.Answer01 = "Ásia";
        q94.Answer02 = "América do Sul";
        q94.Answer03 = "Africa";
        q94.Answer04 = "Palmeiras";
        q94.Answer05 = "Junin rodoviarias";
        q94.CorrectAnswer = 1;
        q94.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q94);

        var q95 = new Questao();
        q95.Question = "Em que continente fica o deserto do Saara?";
        q95.Answer01 = "Ásia";
        q95.Answer02 = "América do Sul";
        q95.Answer03 = "Africa";
        q95.Answer04 = "Palmeiras";
        q95.Answer05 = "Junin rodoviarias";
        q95.CorrectAnswer = 1;
        q95.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q95);

        var q96 = new Questao();
        q96.Question = "Em que continente fica o deserto do Saara?";
        q96.Answer01 = "Ásia";
        q96.Answer02 = "América do Sul";
        q96.Answer03 = "Africa";
        q96.Answer04 = "Palmeiras";
        q96.Answer05 = "Junin rodoviarias";
        q96.CorrectAnswer = 1;
        q96.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q96);

        var q97 = new Questao();
        q97.Question = "Em que continente fica o deserto do Saara?";
        q97.Answer01 = "Ásia";
        q97.Answer02 = "América do Sul";
        q97.Answer03 = "Africa";
        q97.Answer04 = "Palmeiras";
        q97.Answer05 = "Junin rodoviarias";
        q97.CorrectAnswer = 1;
        q97.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q97);

        var q98 = new Questao();
        q98.Question = "Em que continente fica o deserto do Saara?";
        q98.Answer01 = "Ásia";
        q98.Answer02 = "América do Sul";
        q98.Answer03 = "Africa";
        q98.Answer04 = "Palmeiras";
        q98.Answer05 = "Junin rodoviarias";
        q98.CorrectAnswer = 1;
        q98.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q98);

        var q99 = new Questao();
        q99.Question = "Em que continente fica o deserto do Saara?";
        q99.Answer01 = "Ásia";
        q99.Answer02 = "América do Sul";
        q99.Answer03 = "Africa";
        q99.Answer04 = "Palmeiras";
        q99.Answer05 = "Junin rodoviarias";
        q99.CorrectAnswer = 1;
        q99.ConfiguraEstruturaDesenho(labelPergunta, button1, button2, button3, button4, button5);
        listaQuestoes.Add(q99);
    }

    public void ProximaQuestao(){
        var numRandom = Random.Shared.Next(0, listaQuestoes.Count- 1);

        while(listaQuestaoRespondida.Contains(numRandom)){
            numRandom = Random.Shared.Next(0,listaQuestoes.Count - 1);
        } 

        listaQuestaoRespondida.Add(numRandom);
        questaoAtual = listaQuestoes[numRandom];
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