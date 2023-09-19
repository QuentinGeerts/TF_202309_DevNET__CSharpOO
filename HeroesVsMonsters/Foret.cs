using HeroesVsMonsters.Personnages;
using HeroesVsMonsters.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters
{
    internal class Foret
    {

        public Hero Hero { get; set; }
        public Monstre Monstre { get; set; }
        public De DeMonstre { get; set; }

        public bool GameOver { get; set; } = false;
        public int CombatGagne { get; set; } = 0;

        public Foret(Hero hero)
        {
            Hero = hero;
            DeMonstre = new De(3); // A changer en fonction du nombre de monstres qu'on dispose

            Hero.Meurt += Mourir; // Abonnement de mon héro à sa mort
        }

        public void Lance()
        {
            Monstre = GenererMonstre();
            bool Tour = true; // Tour du personnage

            while (!GameOver)
            {
                if (Tour)
                {
                    Hero.Frappe(Monstre);
                }
                else
                {
                    Monstre.Frappe(Hero);
                }

                Tour = !Tour;
                //Thread.Sleep(300);
            }
        }

        private void Mourir (Personnage personnage)
        {
            Console.WriteLine($"{personnage.GetType().Name} est mort.");
            personnage.Meurt -= Mourir; // Désabonnement du monstre

            if (personnage is Hero MonHero)
            {
                GameOver = true;

                Console.WriteLine("Game Over");
                Console.WriteLine($"Le héro a gagné {CombatGagne} combats.");
                Console.WriteLine($"Le héro a accumulé {MonHero.Cuir} pièces d'or.");
                Console.WriteLine($"Le héro a accumulé {MonHero.Cuir} cuirs.");
            }
            else
            {
                CombatGagne++;

                // SeReposer
                Hero.SeReposer();
                // Dépouiller
                Hero.Depouiller((Monstre)personnage);

                // Regenerer un nouveau monstre
                Monstre = GenererMonstre();
            }
        }

        private Monstre GenererMonstre ()
        {
            Monstre monstre = null;

            switch (DeMonstre.Lance())
            {
                case 1:
                    monstre = new Loup();
                    break;
                case 2:
                    monstre = new Orque();
                    break;
                case 3:
                    monstre = new Dragonnet();
                    break;
            }

            // TODO : Abonner le personne `Monstre` à l'événement Meurt
            monstre.Meurt += Mourir;

            Console.WriteLine("Nous rencontrons un monstre : \n" + monstre.Information());

            return monstre;
        }
    }
}
