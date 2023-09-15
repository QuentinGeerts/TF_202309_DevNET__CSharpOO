namespace EventHandlerEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un émetteur
            Emetteur emetteur = new Emetteur();

            // Création d'un écouteur
            Ecouteur ecouteur = new Ecouteur();

            // Abonnement de l'écouteur à l'évenement
            emetteur.MonEvenement += ecouteur.Reagir;

            // Déclenchement de l'événement
            emetteur.DeclencherEvenement();

            // Désabonnement de l'écouteur de l'événement
            emetteur.MonEvenement -= ecouteur.Reagir;
            
            // Déclenchement de l'événement (sans aucune réaction de l'écouteur)
            emetteur.DeclencherEvenement();
        }
    }
}