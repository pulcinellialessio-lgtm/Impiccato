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
            string[] facili = {"cane", "casa", "amico", "pane", "orizzonte", "biscotto"};
            string[] medie = { "aiuola", "corteo", "tanfo", "acquitrino", "vorace", "canaglia" };
            string[] difficili = { "Hippopotomonstrosesquipedaliofobia", "supercalifragilistichespiralitoso", "obbiettivo", "entusiasmo", "contesto", "priorita" };

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
                facile(facili);
            }
        }
    }
}
