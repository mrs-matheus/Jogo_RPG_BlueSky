using System;
using System.Collections.Generic;
using System.Text;


namespace JogoRpgBlue
{
    public class Batalha : IBatalha
    {
        public Monstro _mob;
        public Heroi _heroi;
        public Boss _boss;
        public Batalha(Heroi heroi, Monstro mob)
        {
            _heroi = heroi;
            _mob = mob;
        }
        public Batalha(Heroi heroi, Boss boss)
        {
            _heroi = heroi;
            _boss = boss;
        }

        public void Duelar()
        {
            Console.WriteLine("Você quer atacar ou correr?");
            Console.WriteLine("[A] Atacar ");
            Console.WriteLine("[C] Correr ");
            string resp = Console.ReadLine();
            resp = resp.ToUpper();
            if (resp == "A")
            {
                do
                {
                    int ataqueHeroi = _heroi.Ataque;
                    _mob.Vida = _mob.Vida - ataqueHeroi;
                    Console.WriteLine($"O ataque do {_heroi.Nome} foi de {ataqueHeroi} e o monstro {_mob.Nome} ficou com {_mob.Vida}");
                    int ataqueMob = _mob.Ataque;
                    _heroi.Vida = _heroi.Vida - ataqueMob;
                    Console.WriteLine($"O ataque do {_mob.Nome} foi de {ataqueMob} e o Heroi {_heroi.Nome} ficou com {_heroi.Vida}");

                    Console.ReadKey();

                    if (_mob.Vida <= 0)
                    {
                        _heroi.LevelUp(_mob.Exp);
                        return;

                    }
                    else if (_heroi.Vida <= 0)
                    {
                        Console.WriteLine("Você Morreu!!!");
                        break;
                    }

                    Console.WriteLine("Você quer atacar ou correr?");
                    Console.WriteLine("[A] Atacar ");
                    Console.WriteLine("[C] Correr ");
                    resp = Console.ReadLine();
                    resp = resp.ToUpper();
                    Console.Clear();

                } while (_heroi.Vida > 0 && _mob.Vida > 0 && resp == "A");


                Console.Clear();
            }

        }

        public void DuelarBoss()
        {
            Console.WriteLine("Você quer atacar ou correr?");
            Console.WriteLine("[A] Atacar ");
            Console.WriteLine("[C] Correr ");
            string resp = Console.ReadLine();
            resp = resp.ToUpper();
            if (resp == "A")
            {
                do
                {
                    int ataqueHeroi = _heroi.Ataque;
                    _boss.Vida = _boss.Vida - ataqueHeroi;
                    Console.WriteLine($"O ataque do {_heroi.Nome} foi de {ataqueHeroi} e o monstro {_boss.Nome} ficou com {_boss.Vida}");
                    int ataqueBoss = _boss.Ataque;
                    _heroi.Vida = _heroi.Vida - ataqueBoss;
                    Console.WriteLine($"O ataque do {_boss.Nome} foi de {ataqueBoss} e o Heroi {_heroi.Nome} ficou com {_heroi.Vida}");

                    Console.ReadKey();

                    if (_boss.Vida <= 0)
                    {
                        _heroi.LevelUp(_boss.Exp);
                        return;

                    }
                    else if (_heroi.Vida <= 0)
                    {
                        Console.WriteLine("Você Morreu!!!");
                        break;
                    }

                    Console.WriteLine("Você quer atacar ou correr?");
                    Console.WriteLine("[A] Atacar ");
                    Console.WriteLine("[C] Correr ");
                    resp = Console.ReadLine();
                    resp = resp.ToUpper();
                    Console.Clear();

                } while (_heroi.Vida > 0 && _boss.Vida > 0 && resp == "A");

                Console.Clear();
            }
        }
    }
}
