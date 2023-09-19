using HeroesVsMonsters.Tools;

namespace HeroesVsMonsters.Personnages
{
    internal class Personnage
    {
        private int _pv;

        public int Pv {
            get => _pv;
            private set 
            {
                _pv = value;
                if (_pv <= 0 && Meurt != null) Meurt(this);
            } 
        }
        public int Endurance { get; private set; }
        public int Force { get; private set; }

        protected De De4 { get; }
        protected De De6 { get; }

        // Si on devait le faire sans délégué générique
        // public delegate void personnageMeurtDelegate (Personnage personnage);
        // public event personnageMeurtDelegate Meurt;

        public event Action<Personnage> Meurt;

        public Personnage()
        {
            De4 = new De(4);
            De6 = new De(6);

            Force = GenerateStats();
            Endurance = GenerateStats();
            ReinitialiserPV();
        }

        protected void ReinitialiserPV ()
        {
            Pv = Endurance + Modificateur(Endurance);
        }

        private int GenerateStats ()
        {
            int[] lances = new int[4];

            // Initialisation des lancés
            for (int i = 0; i < lances.Length; i++) 
            {
                lances[i] = De6.Lance();
            }

            // Récupération des 3 meilleurs lancés
            // Tri du tableau
            for (int i = 0; i < lances.Length - 1; i++)
            {
                for (int j = i + 1; j < lances.Length; j++)
                {
                    if (lances[i] < lances[j])
                    {
                        int temp = lances[i];
                        lances[i] = lances[j];
                        lances[j] = temp;

                        // (lances[i], lances[j]) = (lances[j], lances[i]);
                    }
                }

            }

            return lances[0] + lances[1] + lances[2];
        }

        private int Modificateur (int stats)
        {
            //if (stats < 5) return -1;
            //else if (stats < 10) return 0;
            //else if (stats < 15) return 1;
            //else return 2;

            return stats < 5 ? -1 :
                stats < 10 ? 0 :
                stats < 15 ? 1 : 2;
        }

        public void Frappe (Personnage cible)
        {
            // Calculer les dégats
            int degats = De4.Lance() + Modificateur(Force);

            Console.WriteLine($"{GetType().Name} frappe {cible.GetType().Name} et lui inflige {degats} points de dégat.");

            cible.Pv -= degats;
        }

        public string Information ()
        {
            return $"{GetType().Name}\n" +
                $"Pv: {Pv}\n" +
                $"Force: {Force}\n" +
                $"Endurance: {Endurance}\n";
        }
    }
}
