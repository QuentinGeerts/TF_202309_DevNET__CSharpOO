using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleDelegate
{
    internal class CarWash
    {
        //Création du type delegate
        public delegate void  WashMe(string plaque);//1 liste d'action qui pourra exécuter toutes les fonctions qui ont le même prototype

        //Creer une variable du type créé juste avant
        public WashMe ListOperation;

        public CarWash()
        {
            //Ajouter les fonctions dans le delgate
            ListOperation += FairePayer;
            ListOperation += PreparerVoiture;
            ListOperation += LaverVoiture;
            ListOperation += SecherVoiture;

            //ListOperation += delegate (string plaque) { Console.WriteLine($"Preparation voiture {plaque}"); };
            //ListOperation += delegate (string plaque) { Console.WriteLine($"Lavache voiture {plaque}"); };
            //ListOperation += delegate (string plaque) { Console.WriteLine($"Sechage voiture {plaque}"); };
            //ListOperation += delegate (string plaque) { Console.WriteLine($"Payage voiture {plaque}"); };

        }

        private void PreparerVoiture(string plaque)
        {
            Console.WriteLine($"Preparation voiture {plaque}");
        }

        private void LaverVoiture(string plaque)
        {
            Console.WriteLine($"Lavache voiture {plaque}");
        }
        private void SecherVoiture(string plaque)
        {
            Console.WriteLine($"Saichache voiture {plaque}");
        }
        private void FairePayer(string plaque)
        {
            Console.WriteLine($"Payer pour la voiture {plaque}");
        }

        internal void ChangementDeForfait(int v)
        {
           if(v==1)
            {
                ListOperation -= FairePayer;
                ListOperation -= SecherVoiture;
            }
           else
            {
                ListOperation += FairePayer;
                ListOperation += SecherVoiture;
            }
        }
    }
}
