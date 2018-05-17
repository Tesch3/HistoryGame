using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ShowDoMilhao
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public Jogador Jogador;
        public List<Pergunta> Perguntas;
        public int IDPerguntaAtual;

        public MainWindow()
        {
            Perguntas = new List<Pergunta>();
            InitializeComponent();
            IDPerguntaAtual = 0;

            var pergunta1 = new Pergunta
            {
                Enunciado = "O que significa a abreviatura de ONU?",
                Resposta1 = "Oceano, Nação e União",
                Resposta2 = "Organização das Nações Unidas",
                Resposta3 = "Oceano Noturno Universal",
                Resposta4 = "Organização do Nível Universal",
                Resposta5 = "Organização de uma Nação Unida",
                RespostaCorreta = 2
            };

            var pergunta2 = new Pergunta
            {
                Enunciado = "Onde se localizava o Império Asteca??",
                Resposta1 = "México",
                Resposta2 = "Argentina",
                Resposta3 = "Chile",
                Resposta4 = "Peru",
                Resposta5 = "Paraguai",
                RespostaCorreta = 1
            };

            var pergunta3 = new Pergunta
            {
                Enunciado = "Quais dos acontecimentos abaixo, ocorreram durante a Belle Époque? ",
                Resposta1 = "Contraste social e a arte Nouveau",
                Resposta2 = "Impressionismo e positivismo",
                Resposta3 = "Contraste social e tecnologia",
                Resposta4 = "Arte Nouveau e positivismo",
                Resposta5 = "Efervescência cultural e evolucionismo",
                RespostaCorreta = 1
            };

            var pergunta4 = new Pergunta
            {
                Enunciado = "Qual o nome de uma das formas de punições em Esparta?",
                Resposta1 = "Olimpíadas",
                Resposta2 = "Odisséia",
                Resposta3 = "Oligarquia",
                Resposta4 = "Ostracismo",
                Resposta5 = "Nenhuma das anteriores",
                RespostaCorreta = 4
            };

            var pergunta5 = new Pergunta
            {
                Enunciado = "Qual a estratégia usada pelos alemães que foi usada para conquistar a França e a Polônia?",
                Resposta1 = "Blitzkrieg",
                Resposta2 = "Trincheiras",
                Resposta3 = "Ataques somente por terra",
                Resposta4 = "Ataques por mar",
                Resposta5 = "Bombas nucleares",
                RespostaCorreta = 1
            };

            var pergunta6 = new Pergunta
            {
                Enunciado = "Quem foi Julio César?",
                Resposta1 = "Gladiador.",
                Resposta2 = "Imperador e conquistador grego.",
                Resposta3 = "Imperador, conquistador, um Augusto e ditador.",
                Resposta4 = "Faraó.",
                Resposta5 = "Parente de Tibério Graco.o",
                RespostaCorreta = 3
            };

            var pergunta7 = new Pergunta
            {
                Enunciado = "Após o governo dos cem dias, Napoleão foi definitivamente derrotado. Qual foi a batalha que Bonaparte foi definitivamente derrotado?",
                Resposta1 = "Batalha de Trafalgar",
                Resposta2 = "Batalha de Waterloo.",
                Resposta3 = "Guerra do Paraguai.",
                Resposta4 = "Primeira guerra mundial",
                Resposta5 = "Guerra dos Farrapos",
                RespostaCorreta = 2
            };

            var pergunta8 = new Pergunta
            {
                Enunciado = "Qual era ordem e os 3 estamentos da sociedade francesa pré-revolucionaria?",
                Resposta1 = "Clero, Nobreza e Povo ",
                Resposta2 = "Nobreza,Clero e Povo",
                Resposta3 = "Nobreza, Povo e Clero",
                Resposta4 = "Povo, Nobreza e Clero",
                Resposta5 = "Povo, Clero e Sans-culote",
                RespostaCorreta = 2
            };

            var pergunta9 = new Pergunta
            {
                Enunciado = "Quem foi o líder na Guerra de Canudos?",
                Resposta1 = "Antônio Conselheiro.",
                Resposta2 = "O Conselheiro.",
                Resposta3 = "Antonio Vicente Mendes Maciel.",
                Resposta4 = "Felipe Duarte",
                Resposta5 = "Todas as alternativas acima estão corretas.",
                RespostaCorreta = 5
            };

            var pergunta10 = new Pergunta
            {
                Enunciado = "A Mesopotâmia fica situada entre quais rios?",
                Resposta1 = "Eufrates e Nilo",
                Resposta2 = "Tarim e Tigre",
                Resposta3 = "Tigre e Eufrates",
                Resposta4 = "Tarim e Nilo",
                Resposta5 = "Nenhuma das alternativas",
                RespostaCorreta = 3
            };

            Perguntas.Add(pergunta1);
            Perguntas.Add(pergunta2);
            Perguntas.Add(pergunta3);
            Perguntas.Add(pergunta4);
            Perguntas.Add(pergunta5);
            Perguntas.Add(pergunta6);
            Perguntas.Add(pergunta7);
            Perguntas.Add(pergunta8);
            Perguntas.Add(pergunta9);
            Perguntas.Add(pergunta10);



        }

        private void MostrarPergunta(Pergunta pergunta)
        {
            LabelPontuacao.Content = "Pontuação " + Jogador.Pontuacao;
            TextBlockEnunciado.Text = pergunta.Enunciado;
            RadioButtonResposta1.Content = pergunta.Resposta1;
            RadioButtonResposta2.Content = pergunta.Resposta2;
            RadioButtonResposta3.Content = pergunta.Resposta3;
            RadioButtonResposta4.Content = pergunta.Resposta4;
            RadioButtonResposta5.Content = pergunta.Resposta5;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var nome = TextBoxNomeJogador.Text;
            this.Jogador = new Jogador(nome, 0);
            GridTelaAbertura.Visibility = Visibility.Hidden;
            GridTelaPergunta.Visibility = Visibility.Visible;

            LabelNomeJogador.Content = 
                this.Jogador.Nome 
                + " jogando";

            MostrarPergunta(Perguntas[0]);

            Console.WriteLine(this.Jogador.Nome);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            // Checar se a resposta está correta
            var perguntaAtual = Perguntas[IDPerguntaAtual];
            var respostaPergunta = perguntaAtual.RespostaCorreta;

            int respostaSelecionada = 0;

            if(RadioButtonResposta1.IsChecked.Value) respostaSelecionada = 1;
            else if(RadioButtonResposta2.IsChecked.Value) respostaSelecionada = 2;
            else if(RadioButtonResposta3.IsChecked.Value) respostaSelecionada = 3;
            else if(RadioButtonResposta4.IsChecked.Value) respostaSelecionada = 4;
            else if(RadioButtonResposta5.IsChecked.Value) respostaSelecionada = 5;        

            if(respostaSelecionada == respostaPergunta)
            {
                Jogador.Pontuacao = Jogador.Pontuacao + 10;
            }
            else
            {
                MostrarFinal();
            }

            IDPerguntaAtual = IDPerguntaAtual + 1;

            if(IDPerguntaAtual < Perguntas.Count)
            {
                MostrarPergunta(Perguntas[IDPerguntaAtual]);
            }
            else
            {
                MostrarFinal();
            }
        }

        private void MostrarFinal()
        {
            GridTelaPergunta.Visibility = Visibility.Hidden;
            GridTelaFinal.Visibility = Visibility.Visible;

            TextBlockFinal.Text =
                "O jogo acabou!\n A sua pontuação foi: " +
                Jogador.Pontuacao +
                " pontos!";
        }
    }

    public class Pergunta
    {
        public string Enunciado;
        public string Resposta1;
        public string Resposta2;
        public string Resposta3;
        public string Resposta4;
        public string Resposta5;
        public int RespostaCorreta;
    }
}
