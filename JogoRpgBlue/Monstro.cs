using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRpgBlue
{
    public class Monstro
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Exp { get; set; }
        public int Ataque { get; set; }

        public Monstro()
        {
        }

        public void Rat(string nome = "Rat", int vida = 5, int exp = 3)
        {
            Ataque = new Random().Next(0, 2);

            if (Ataque < 2)
            {
                Ataque = 0;
            }

            Nome = nome;
            Vida = vida;
            Exp = exp;
        }

        /*public void Orc(string nome = "Orc", int vida = 30 ,int exp = 10)
        {
            Ataque = new Random().Next(0, 10);
            Nome = "Orc";
            Vida = 30;
            Exp = 10;
        }*/

    }
}
