using System;

namespace JogoRpgBlue
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tela tela = new Tela();
                Console.WriteLine("Digite o nome do seu Heroi: ");
                string nome = Console.ReadLine();
                Console.Clear();
                Heroi heroi = new Heroi(nome);
                tela.Start(heroi);
                if (heroi.Vida <= 0)
                {
                    throw new Exception("Voce Morreu!");
                }
            }
            catch (Exception e)
            {
                int cont = 0;
                while (cont < 100)
                {
                    Console.Write($"{e.Message} ");
                    Console.Write($" {e.Message} ");
                    cont++;
                }
                Console.ReadKey();
                throw new Exception(e.Message);                
            }
        }
    }
}
