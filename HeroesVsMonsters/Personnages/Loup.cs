using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Personnages
{
    internal class Loup : Monstre, ICuir
    {
        public int Cuir { get; }

        public Loup()
        {
            Cuir = De4.Lance();
        }
    }
}
