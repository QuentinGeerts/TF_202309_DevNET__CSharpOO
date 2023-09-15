using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleDelegate
{
    internal class etudiant
    {
        public delegate void Hurle(string info);

        public  event Hurle DHurle;
        public void HurleAAA()
        {
            if(DHurle != null ) { DHurle("AHHHH je suis christina"); }
        }
        internal void Lancer(CarWash.WashMe listOperation, string plaque)
        {
         
            listOperation(plaque);
            if (DHurle != null)
            {
                DHurle($"J'ai terminé la voiture ; {plaque}");
            }
        }
    }
}
