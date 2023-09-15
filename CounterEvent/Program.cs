namespace CounterEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter counter = new Counter();
            Displayer displayer = new Displayer();

            // Abonnement de la méthode d'affichement de la valeur à l'événement ChangedValue
            counter.ChangedValue += displayer.DisplayNewValue;

            // Incrémentation du compteur (déclenche l'événement)
            counter.Increment(); // Affiche "Nouvelle valeur du compteur : 1"
            counter.Increment(); // Affiche "Nouvelle valeur du compteur : 2"

            // Désabonnement de la méthode "DisplayNewValue" de l'événement
            counter.ChangedValue -= displayer.DisplayNewValue;

            // Incrémentation du compteur (l'événement n'est plus géré)
            counter.Increment(); 
        }
    }
}