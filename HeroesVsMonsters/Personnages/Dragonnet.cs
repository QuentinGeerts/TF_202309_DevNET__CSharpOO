using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Personnages
{
    internal class Dragonnet : Monstre, IOr, ICuir
    {
        public int Cuir { get; }

        public int Or { get; }

        public Dragonnet()
        {
            Cuir = De4.Lance();
            Or = De6.Lance();
        }
    }
}
