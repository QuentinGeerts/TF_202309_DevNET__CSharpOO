namespace EventHandlerEvent
{
    internal class Emetteur
    {

        // Déclaration d'un événement
        public event EventHandler MonEvenement;

        // Méthode qui déclenche l'événement
        public void DeclencherEvenement()
        {
            Console.WriteLine("L'événement va être déclenché");
            // Vérifie si quelqu'un écoute l'événement, puis le déclenche
            MonEvenement?.Invoke(this, EventArgs.Empty);
        }
    }
}