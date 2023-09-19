using HeroesVsMonsters.Personnages;

namespace HeroesVsMonsters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choix;


            do
            {
                Console.Clear();
                Console.WriteLine("Heroes Vs Monsters");
                Console.WriteLine("1. Humain");
                Console.WriteLine("2. Nain");

                Console.WriteLine("Choix :");
            }
            while (!int.TryParse(Console.ReadLine(), out choix) || !(choix == 1 || choix == 2));

            Hero hero = (choix == 1 ? new Humain() : new Nain());

            Console.WriteLine(hero.Information());

            Console.WriteLine("Création de la forêt :");

            Foret shorewood = new Foret(hero);
            shorewood.Lance();
        }
    }
}