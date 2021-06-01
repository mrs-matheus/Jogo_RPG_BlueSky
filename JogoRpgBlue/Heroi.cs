using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRpgBlue
{
    public class Heroi
    {
        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Exp { get; private set; }
        public int Level { get; private set; }
        private int _Ataque { get; set; }
        public int AtaqueBase { get; set; }
        public int Ataque { get => new Random().Next(AtaqueBase, _Ataque); set => _Ataque = value; }

        public Heroi(string nome, int vida = 10, int exp = 0, int level = 1, int _ataque = 10, int ataqueBase = 1)
        {
            Nome = nome;
            Vida = vida;
            Exp = exp;
            Level = level;
            _Ataque = _ataque;
            AtaqueBase = ataqueBase = new Random().Next(1, 10);
        }

        public void LevelUp(int exp)
        {
            Exp += exp;

            if (Exp > 10)
            {
                int up = Exp / 10;
                Level += up;
                Vida = Level * 10;
                _Ataque += Ataque + Level;

                if ((Level % 2) == 0)
                {
                    AtaqueBase += 1;
                }
                Exp = 0;
            }

        }


    }
}
