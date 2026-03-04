namespace Impiccato
{
    internal class Program
    {
        static string parolaNascosta(string parola) // funzione che restituisce una stringa con tanti "_" quanti sono i caratteri della parola da indovinare
        {
            string risultato = "";
            for (int i = 0; i < parola.Length; i++)
            {
                risultato += "_";
            }
            return risultato;
        }
        static void parola(string[] facili, ref int vita, char[] lettere)
        {
            Random random = new Random();
            int num = random.Next(0, facili.Length);

            bool trovato = false, fine = false;
            int a = 0;

            Console.WriteLine(parolaNascosta(facili[num]));
            char[] risultatoArray = parolaNascosta(facili[num]).ToCharArray();

            facili[num] = facili[num].ToLower();

            while (vita > 0 && fine == false) // ciclo che continua finché il giocatore ha vite e non ha indovinato la parola
            {
                Console.WriteLine("Vuoi indovinare la parola? (s/n)");
                char risposta = Convert.ToChar(Console.ReadLine());

                if (risposta == 's')
                {
                    Console.WriteLine("Inserisci la parola: ");
                    string parola = Convert.ToString(Console.ReadLine());

                    if (parola == facili[num])
                    {
                        Console.WriteLine("Hai vinto!");
                        fine = true;
                    }
                    else
                    {
                        Console.WriteLine("Parola sbagliata, ti rimangono " + vita + " vite");
                        vita--;
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci una lettera: ");
                    char lettera = Convert.ToChar(Console.ReadLine());

                    trovato = facili[num].Contains(lettera);

                    if (trovato == true)
                    {
                        for (int i = 0; i < facili[num].Length; i++) // ciclo che scorre la parola da indovinare
                        {
                            if (facili[num][i] == lettera) // se la lettera è presente nella parola, viene sostituita al posto del "_" corrispondente
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
                }
                
                Console.Write("Lettere inserite: ");
                for(int i = 0; i < lettere.Length; i++)
                {
                    Console.Write(lettere[i] + " ");
                }
                Console.WriteLine();
            }

            if(vita == 0)
            {
                Console.WriteLine("Hai perso! La parola era: " + facili[num]);
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
            int vita = 10, scelta;
            bool rigiocare = false;

            while (rigiocare == false)
            {
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

                    if (scelta == 1)
                    {
                        parola(cibiFacile, ref vita, lettere);
                    }
                    else if (scelta == 2)
                    {
                        parola(cibiMedio, ref vita, lettere);
                    }
                    else if (scelta == 3)
                    {
                        parola(cibiDifficili, ref vita, lettere);
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

                    if (scelta == 1)
                    {
                        parola(animaliFacile, ref vita, lettere);
                    }
                    else if (scelta == 2)
                    {
                        parola(animaliMedio, ref vita, lettere);
                    }
                    else if (scelta == 3)
                    {
                        parola(animaliDifficili, ref vita, lettere);
                    }
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

                    if (scelta == 1)
                    {
                        parola(sportFacile, ref vita, lettere);
                    }
                    else if (scelta == 2)
                    {
                        parola(sportMedio, ref vita, lettere);
                    }
                    else if (scelta == 3)
                    {
                        parola(sportDifficili, ref vita, lettere);
                    }
                }

                Console.WriteLine("Vuoi rigiocare? (s/n)");
                string risposta = Convert.ToString(Console.ReadLine());

                if (risposta == "s")
                {
                    rigiocare = false;
                    vita = 10;
                    lettere = new char[30];
                }
                else
                {
                    rigiocare = true;
                }
            }
        }
    }
}
