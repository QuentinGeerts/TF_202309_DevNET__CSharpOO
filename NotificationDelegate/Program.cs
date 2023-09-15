using NotificationDelegate.Models;

namespace NotificationDelegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotificationService notificationService = new();

            // Enregistrer les méthodes de notification personnalisés
            notificationService.RegisterNotification(SendEmail);
            notificationService.RegisterNotification(SendSMS);

            // Envoyer des notifications
            notificationService.SendNotification("Notification : Bonjour !"); // EMAIL & SMS

            Console.WriteLine("---");
            
            notificationService.UnregisterNotification(SendEmail);
            notificationService.SendNotification("Notification : Comment allez-vous ? ");

        }

        static void SendEmail (string message)
        {
            Console.WriteLine("Envoi d'email : " + message);
        }

        static void SendSMS (string message)
        {
            Console.WriteLine("Envoi de SMS : " + message);
        }
    }
}