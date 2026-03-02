using System;
using System.Numerics;
using System.Runtime.ConstrainedExecution;

namespace Impiccato
{
    internal class Program
    {
        static void facile(string[] facili, int vita)
        {
            Random random = new Random();
            int num = random.Next(0, facili.Length);

            for(int i = 0; i < facili[num].Length; i++)
            {
                Console.Write("_ ");
            }

            while(vita > 0)
            {

            }
        }
        static void Main(string[] args)
        {
            string[] cibiFacile = {"Pane", "Mela", "Riso", "Uva", "Pera", "Sale", "Vino"};
            string[] cibiMedio = { "Banana", "Carota", "Patata", "Fragola", "Limone", "Biscotto", "Cipolla", "Zucchina", "Pizzetta", "Panino"};
            string[] cibiDifficili = { "Melanzana", "Pomodoro", "Marmellata", "Prezzemolo", "Stracciatella", "Cioccolato", "Tagliatelle", "Pistacchio", "Finocchio", "Melograno" };

            int vita = 6;
            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Scegli la modalià         |");
            Console.WriteLine("| 1) facile                 |");
            Console.WriteLine("| 2) media                  |");
            Console.WriteLine("| 3) difficile              |");
            Console.WriteLine("-----------------------------");
            int scelta = Convert.ToInt32(Console.ReadLine());

            if(scelta == 1)
            {
                facile(cibiFacile, vita);
            }
            
        }
    }
}
