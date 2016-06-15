/**
 *  Jogo da Vela v 1.0b
 *  Desenvolvido por Adriano Righi
 *  contato@adrianorighi.com
 *  Disciplina POO II
 *  15/06/2016
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public partial class Form1 : Form
    {
        public Game game { get; set; }
        public List<Button> ListaBotoes { get; set; }
        public List<Label> ListaLabels { get; set; }

        public Form1()
        {
            InitializeComponent();
            game = new Game();
            LinkLabel.Link linkDesenv = new LinkLabel.Link();
            linkDesenv.LinkData = "https://github.com/adrianorighi";
            lblDesenv.Links.Add(linkDesenv);
            
            NovoJogo();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            NovoJogo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button3.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button4.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button4.Enabled = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button5.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button5.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.button6.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button6.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.button7.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button7.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.button8.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.button9.Text = game.InsereJogada();
            game.SetVencedor(ListaBotoes);
            SetValores();
            this.button9.Enabled = false;
        }

        private void btnZerarPont_Click(object sender, EventArgs e)
        {
            ZerarContadores();
        }

        public void PreencheLista()
        {
            ListaBotoes = new List<Button>();
            ListaBotoes.Add(button1);
            ListaBotoes.Add(button2);
            ListaBotoes.Add(button3);
            ListaBotoes.Add(button4);
            ListaBotoes.Add(button5);
            ListaBotoes.Add(button6);
            ListaBotoes.Add(button7);
            ListaBotoes.Add(button8);
            ListaBotoes.Add(button9);
        }

        public void BloquearTabuleiro()
        {
            this.button2.Enabled = false;
            this.button3.Enabled = false;
            this.button4.Enabled = false;
            this.button5.Enabled = false;
            this.button6.Enabled = false;
            this.button1.Enabled = false;
            this.button7.Enabled = false;
            this.button8.Enabled = false;
            this.button9.Enabled = false;
        }

        /*
        * Função para iniciar novo jogo
        */
        public void NovoJogo()
        {
            LimparTabuleiro();
            PreencheLista();
            game.Jogador = Player.X;
            game.nJogadas = 0;
        }

        /*
         * Função para limpar o tabuleiro e habilitar os botões
         */
        public void LimparTabuleiro()
        {
            this.button1.Text = String.Empty;
            this.button1.Enabled = true;
            this.button2.Text = String.Empty;
            this.button2.Enabled = true;
            this.button3.Text = String.Empty;
            this.button3.Enabled = true;
            this.button4.Text = String.Empty;
            this.button4.Enabled = true;
            this.button5.Text = String.Empty;
            this.button5.Enabled = true;
            this.button6.Text = String.Empty;
            this.button6.Enabled = true;
            this.button7.Text = String.Empty;
            this.button7.Enabled = true;
            this.button8.Text = String.Empty;
            this.button8.Enabled = true;
            this.button9.Text = String.Empty;
            this.button9.Enabled = true;
        }

        public void SetValores()
        {
            if (game.nJogadas == 9 || game.Vencedor != Player.None)
            {
                MessageBox.Show("Vencedor Jogador: " + game.Vencedor.ToString());
                BloquearTabuleiro();
            }

            lblVitoriasX.Text = "Vitórias X: " + game.pontosX.ToString();
            lblVitoriasO.Text = "Vitórias O: " + game.pontosO.ToString();
            lblEmpate.Text = "Empates: " + game.empates.ToString();
        }

        /*
         * Função para zerar as pontuações
         */
        public void ZerarContadores()
        {
            game.pontosX = 0;
            game.pontosO = 0;
            game.empates = 0;
            game.nJogadas = 0;
            game.Vencedor = Player.None;
            SetValores();
            LimparTabuleiro();
        }

        private void lblDesenv_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(e.Link.LinkData as string);
        }

    }
}
