using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoKenPo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btnPaper_Click(object sender, EventArgs e)
        {
            StarGame(2);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StarGame(1);
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            StarGame(0);
        }

        private void StarGame(int Opcao)
        {
            label3.Visible = false;
            Game jogo = new Game();

            switch (jogo.Jogar(Opcao))
            {
                case Game.Result.Ganhar:
                    picResult.BackgroundImage = Image.FromFile("images/Ganhar.png");
                    goto default;
                    
                
                case Game.Result.Perder:
                    picResult.BackgroundImage = Image.FromFile("images/Perder.png");
                    goto default;

                case Game.Result.Empatar:
                    picResult.BackgroundImage = Image.FromFile("images/Empatar.png");
                    goto default;

                default:
                    pictureBox1.Image = Game.imgJogador;
                    pictureBox2.Image = Game.imgPC;
                    break;
            }
        }

        private void picResult_Click(object sender, EventArgs e)
        {

        }
    }
}
