/**
 *  Jogo da Vela v 1.0b
 *  Desenvolvido por Adriano Righi
 *  contato@adrianorighi.com
 *  Disciplina POO II
 *  15/06/2016
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoDaVelha
{
    public class Game
    {
        public Player Jogador { get; set; }
        public Player Vencedor { get; set; }
        public int pontosX = 0;
        public int pontosO = 0;
        public int empates = 0;
        public int nJogadas = 0;

        public void TrocaJogador()
        {
            Jogador = Jogador == Player.O ? Player.X : Player.O;
        }

        public string InsereJogada()
        {
            String player = Jogador == Player.X ? "X" : "O";
            TrocaJogador();
            this.nJogadas++;

            return player;
        }

        public void SetVencedor(List<Button> tabuleiro)
        {
            Vencedor = VerificaVencedor(tabuleiro);
            if (Vencedor == Player.X)
            {
                pontosX++;

            }
            if (Vencedor == Player.O)
            {
                pontosO++;
            }
            if (Vencedor == Player.Empate)
            {
                empates++;
            }

        }
        public Player VerificaVencedor(List<Button> tabuleiro)
        {
            if (!String.IsNullOrEmpty(tabuleiro[0].Text))
            {
                if (tabuleiro[0].Text == tabuleiro[1].Text && tabuleiro[1].Text == tabuleiro[2].Text)
                {
                    return tabuleiro[0].Text == "X" ? Player.X : Player.O;
                }

                if (tabuleiro[0].Text == tabuleiro[4].Text && tabuleiro[4].Text == tabuleiro[8].Text)
                {
                    return tabuleiro[0].Text == "X" ? Player.X : Player.O;
                }

                if (tabuleiro[0].Text == tabuleiro[3].Text && tabuleiro[3].Text == tabuleiro[6].Text)
                {
                    return tabuleiro[0].Text == "X" ? Player.X : Player.O;
                }
            }

            if (!String.IsNullOrEmpty(tabuleiro[3].Text))
            {
                if (tabuleiro[3].Text == tabuleiro[4].Text && tabuleiro[4].Text == tabuleiro[5].Text)
                {
                    return tabuleiro[3].Text == "X" ? Player.X : Player.O;
                }
            }

            if (!String.IsNullOrEmpty(tabuleiro[6].Text))
            {
                if (tabuleiro[6].Text == tabuleiro[7].Text && tabuleiro[7].Text == tabuleiro[8].Text)
                {
                    return tabuleiro[6].Text == "X" ? Player.X : Player.O;
                }

                if (tabuleiro[6].Text == tabuleiro[4].Text && tabuleiro[4].Text == tabuleiro[2].Text)
                {
                    return tabuleiro[6].Text == "X" ? Player.X : Player.O;
                }
            }

            if (!String.IsNullOrEmpty(tabuleiro[1].Text))
            {
                if (tabuleiro[1].Text == tabuleiro[4].Text && tabuleiro[4].Text == tabuleiro[7].Text)
                {
                    return tabuleiro[1].Text == "X" ? Player.X : Player.O;
                }
            }

            if (!String.IsNullOrEmpty(tabuleiro[2].Text))
            {
                if (tabuleiro[2].Text == tabuleiro[5].Text && tabuleiro[5].Text == tabuleiro[8].Text)
                {
                    return tabuleiro[2].Text == "X" ? Player.X : Player.O;
                }
            }


            if (nJogadas == 9)
            {
                return Player.Empate;
            }

            return Player.None;
        }

    }
    public enum Player
    {
        X = 0,
        O = 1,
        Empate = 2,
        None = 9
    }
}
