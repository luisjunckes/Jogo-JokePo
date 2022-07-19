using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoKenPo
{
    class Game
    {
        public enum Result
        {
            Ganhar, Perder, Empatar
        }
        public static Image[] images =
        {
            Image.FromFile("images/Pedra.png"),
            Image.FromFile("images/Tesoura.png"),
            Image.FromFile("images/Papel.png")
        };

        public static Image imgPC { get; private set; }
        public static Image imgJogador { get; private set; }

        public Result Jogar(int jogador)
        {
            int pc = JogadaPC();
            imgJogador = images[jogador];
            imgPC = images[pc];

            if (jogador==pc)
            {
                return Result.Empatar;
            }
            else if ((jogador == 0 && pc == 1) || (jogador == 1 && pc == 2) || (jogador == 2 && pc == 0))
            {
                return Result.Ganhar;
            }
            else
            {
                return Result.Perder;
            }

            
        }

        private int JogadaPC()
        {
            
            int mil = DateTime.Now.Millisecond;
            
            if (mil < 333)
            {
                return 0;
            }
            else if (mil >= 333 && mil < 667)
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }

    }
    
    
}
