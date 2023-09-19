using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Personnages
{
    internal class Orque : Monstre, IOr
    {
        public int Or { get; }

        public Orque()
        {
            Or = De6.Lance();
        }
    }
}
