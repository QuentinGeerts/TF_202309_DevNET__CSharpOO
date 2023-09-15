namespace EventHandlerEvent
{
    internal class Ecouteur
    {
        public void Reagir (object sender, EventArgs e)
        {
            Console.WriteLine("L'écouteur réagit à l'événement !");
        }
    }
}