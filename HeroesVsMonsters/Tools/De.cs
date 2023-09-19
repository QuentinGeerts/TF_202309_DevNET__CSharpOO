using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Tools
{
    internal class De
    {
        public int Minimum { get; private set; } = 1;
        public int Maximum { get; private set; }

        private readonly Random _random;

        public De(int maximum)
        {
            Maximum = maximum;
            _random = new Random();
        }

        public int Lance()
        {
            return _random.Next(Maximum) + Minimum;
        }
    }
}
