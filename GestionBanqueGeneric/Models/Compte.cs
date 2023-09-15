using GestionBanque.Interfaces;
using GestionBanqueEvents.Models;

namespace GestionBanque.Models
{
    internal abstract class Compte : IBanker, ICustomer
    {
        #region Props
        public string Numero { get; set; }
        public double Solde { get; private set; }
        public Personne Titulaire { get; set; }
        public abstract double taux_interet { get;  }

        //public event PassageEnNegatifDelegate PassageEnNegatifEvent;
        public event Action<Compte> PassageEnNegatifEvent;

        #endregion

        #region Constructors
        public Compte(string numero, Personne titulaire)
            {
                Numero= numero;
                Titulaire= titulaire; 
            }
            public Compte(string numero, Personne titulaire, double solde) : this(numero, titulaire)         
            {             
                Solde= solde;
            }
        #endregion

        #region Methods
        public void Depot(double Montant)
        {
            if (Montant < 0) throw new ArgumentOutOfRangeException("Le montant doit être positif");
            Solde += Montant;
        }

        public virtual void Retrait(double Montant)
        {
            if (Montant < 0) throw new ArgumentOutOfRangeException("Le montant doit être positif");
            Solde -= Montant;
        }

        public void AppliquerInteret()
        {
            Solde += (taux_interet * Solde);
        }

        protected void RaisePassageEnNegatifEvent ()
        {
            // if (PassageEnNegatifEvent != null) PassageEnNegatifEvent(this);
            PassageEnNegatifEvent?.Invoke(this); // Sucre syntaxique
        }

        #region Abstract
        protected abstract double CalculerInteret();



        #endregion
        #region Implements
        private bool DemanderPret(double Montant)
        {
            if ((Montant - Solde) > 1500) return false;
            else return true;
        }
        bool IBanker.DemandePret(double Montant)
        {
            if (DemanderPret(Montant))
            { 
                Console.WriteLine($"Demander à la centrale la possibilité d'un prêt de {Montant}");
                return true;
            }
            else return false;
        }

        bool ICustomer.DemandePret(double Montant)
        {
            if (DemanderPret(Montant))
            {
                Console.WriteLine($"Demander au banquier la possibilité d'un prêt de {Montant}");
                return true; 
            }
            else return false;
        }
        #endregion
        #endregion

        #region Surcharge D'opérateur
        public static double operator +(Compte toto, double lasomme)
        {
            return (toto.Solde > 0 ? toto.Solde : 0) + lasomme;
        } 
        #endregion
    }
}
