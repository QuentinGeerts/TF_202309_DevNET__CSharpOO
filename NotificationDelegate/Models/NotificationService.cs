using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationDelegate.Models
{
    // Définition du délégué pour les méthodes de notification
    public delegate void NotificationDelegate(string message);

    internal class NotificationService
    {
         // Délégué pour la méthode de notification
         private NotificationDelegate _notificationDelegate;

        // Méthode pour enregistrer la méthode de notification
        public void RegisterNotification (NotificationDelegate method)
        {
            _notificationDelegate += method;
        }

        public void UnregisterNotification (NotificationDelegate method)
        {
            _notificationDelegate -= method;
        }

        // Méthode pour envoyer une notification
        public void SendNotification (string message)
        {
            if (_notificationDelegate != null) 
                // _notificationDelegate.Invoke(message);
                _notificationDelegate(message);
        }
    }
}
