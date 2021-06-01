using System;
using System.Collections.Generic;
using System.Text;

namespace JogoRpgBlue
{
    public class Tela
    {

        public void Start(Heroi heroi)
        {
            Console.WriteLine("| --------------------R P G  B L U E S K Y ------------------|");
            Console.WriteLine($"|Nome:{heroi.Nome}                                                |");
            Console.WriteLine($"|HP:{heroi.Vida}                                                       |");
            Console.WriteLine($"|LVL:{heroi.Level}                                                      |");
            Console.WriteLine($"|ATQ:{heroi.AtaqueBase}                                                       |");
            Console.WriteLine($"|____________________________________________________________|");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Com quem deseja batalhar?");
            Console.WriteLine("[1] Rat ");
            Console.WriteLine("[2] Goblin ");
            Console.WriteLine("[3] OrcKing ");
            Console.WriteLine("[4] BOSS ");

            Monstro mob = new Monstro();
            Boss boss = new Boss();
            string opcao = Console.ReadLine();            
            IBatalha batalha = new Batalha(heroi,mob);
            IBatalha batalhaBoss = new Batalha(heroi, boss);
            if (opcao == "1")
            {
                mob.Rat();
                mob.Nome = EMonstro.Rato.ToString();
                batalha.Duelar();
            }
            else if (opcao == "2")
            {
                mob.Nome = EMonstro.Goblin.ToString();
                mob.Vida = heroi.Level * 5;
                mob.Ataque = heroi.Level * 2;
                batalha.Duelar();
            }
            else if (opcao == "3")
            {
                mob.Nome = EMonstro.OrcKing.ToString();
                mob.Vida = heroi.Level * 10;
                mob.Ataque = heroi.Level * 4;
                batalha.Duelar();
            }
            else if(opcao == "4")
            {                
                boss.Nome = EMonstro.BOSS.ToString();
                boss.Vida = heroi.Level * 40;
                boss.Ataque = heroi.Level * 10;
                boss.Exp = 100000;
                batalhaBoss.DuelarBoss();
            }
            Console.Clear();
            if (heroi.Vida <= 0)
            {
                return;
            }
            Start(heroi);
        }
    }
}
