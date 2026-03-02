namespace Impiccato
{
    internal class Program
    {
        static void facile(string[] facili, ref int vita, char[] lettere)
        {
            Random random = new Random();
            int num = random.Next(0, facili.Length);
            string risultato = "";
            bool trovato = false;
            int a = 0;

            for (int i = 0; i < facili[num].Length; i++)
            {
                risultato += "_";
            }

            Console.WriteLine(risultato);
            char[] risultatoArray = risultato.ToCharArray();

            facili[num] = facili[num].ToLower();

            while (vita > 0)
            {
                Console.WriteLine("Inserisci una lettera: ");
                char lettera = Convert.ToChar(Console.ReadLine());

                trovato = facili[num].Contains(lettera);

                if(trovato == true)
                {
                    
                    for(int i = 0; i < facili[num].Length; i++)
                    {
                        if (facili[num][i] == lettera)
                        {
                            risultatoArray[i] = lettera;
                        }
                    }
                    Console.WriteLine(risultatoArray);
                    
                    lettere[a] = lettera;
                    a++;
                }
                else
                {
                    vita--;
                    Console.WriteLine("Lettera non trovata, ti rimangono " + vita + " vite");

                    lettere[a] = lettera;
                    a++;
                }

                Console.Write("Lettere inserite: ");
                for(int i = 0; i < lettere.Length; i++)
                {
                    Console.Write(lettere[i] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            string[] cibiFacile = { "Pane", "Mela", "Riso", "Uva", "Pera", "Sale", "Vino" };
            string[] cibiMedio = { "Banana", "Carota", "Patata", "Fragola", "Limone", "Biscotto", "Cipolla", "Zucchina", "Pizzetta", "Panino" };
            string[] cibiDifficili = { "Melanzana", "Pomodoro", "Marmellata", "Prezzemolo", "Stracciatella", "Cioccolato", "Tagliatelle", "Pistacchio", "Finocchio", "Melograno" };

            string[] animaliFacile = { "Gatto", "Cane", "Topo", "Pesce", "Uccello", "Mucca", "Orso", "Leone", "Tigre", };
            string[] animaliMedio = { "Elefante", "Giraffa", "Coccodrillo", "Pinguino", "Zebra", "Scimmia", "Ippopotamo" };
            string[] animaliDifficili = { "Rinoceronte", "Canguro", "Pavone", "Fenicottero", "Orangotango", "Ghepardo", "Iguana" };

            string[] sportFacile = { "Calcio", "Tennis", "Pallavolo", "Basket", "Nuoto", "Ciclismo", "Atletica" };
            string[] sportMedio = { "Rugby", "Pallanuoto", "Sci", "Snowboard", "Pattinaggio", "Karate", "Boxe" };
            string[] sportDifficili = { "Pallamano", "Hockey su ghiaccio", "Curling", "Scherma", "Equitazione", "Tiro con arco", "Lotta" };

            char[] lettere = new char[30];
            int vita = 116, scelta;

            Console.WriteLine("-----------------------------");
            Console.WriteLine("| Scegli la categoria        |");
            Console.WriteLine("| 1) Cibi                    |");
            Console.WriteLine("| 2) Animali                 |");
            Console.WriteLine("| 3) Sport                   |");
            Console.WriteLine("-----------------------------");
            int categoria = Convert.ToInt32(Console.ReadLine());

            if (categoria == 1)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("| Scegli la modalià         |");
                Console.WriteLine("| 1) facile                 |");
                Console.WriteLine("| 2) media                  |");
                Console.WriteLine("| 3) difficile              |");
                Console.WriteLine("-----------------------------");
                scelta = Convert.ToInt32(Console.ReadLine());

                if(scelta == 1)
                {
                    facile(cibiFacile, ref vita, lettere);
                }
                
            }
            else if (categoria == 2)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("| Scegli la modalià         |");
                Console.WriteLine("| 1) facile                 |");
                Console.WriteLine("| 2) media                  |");
                Console.WriteLine("| 3) difficile              |");
                Console.WriteLine("-----------------------------");
                scelta = Convert.ToInt32(Console.ReadLine());
            }
            else if (categoria == 3)
            {
                Console.WriteLine("-----------------------------");
                Console.WriteLine("| Scegli la modalià         |");
                Console.WriteLine("| 1) facile                 |");
                Console.WriteLine("| 2) media                  |");
                Console.WriteLine("| 3) difficile              |");
                Console.WriteLine("-----------------------------");
                scelta = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
