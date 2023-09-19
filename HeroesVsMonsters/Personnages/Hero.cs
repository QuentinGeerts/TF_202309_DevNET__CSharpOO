using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Personnages
{
    internal class Hero : Personnage
    {
        public int Or { get; set; }
        public int Cuir { get; set; }

        public void Depouiller(Monstre monstre)
        {
            if (monstre is ICuir)
            {
                Cuir += ((ICuir) monstre).Cuir;
                Console.WriteLine($"{GetType().Name} dépouille {((ICuir)monstre).Cuir}x cuir à {monstre.GetType().Name}.");
            }

            if (monstre is IOr IOrMonstre)
            {
                Or += IOrMonstre.Or;
                Console.WriteLine($"{GetType().Name} dépouille {IOrMonstre.Or}x or à {monstre.GetType().Name}.");
            }
        }

        public void SeReposer()
        {
            Console.WriteLine($"{GetType().Name} se repose.");
            ReinitialiserPV();
        }
    }
}
