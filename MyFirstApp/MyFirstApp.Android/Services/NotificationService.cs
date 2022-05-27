using Android.App;
using Android.Content;
using AndroidX.Core.App;
using MyFirstApp.Services;


[assembly: Xamarin.Forms.Dependency(typeof(MyFirstApp.Droid.Services.NotificationService))]

namespace MyFirstApp.Droid.Services
{
    internal class NotificationService : INotificationService
    {
        public void Show(string title, string description)
        {
            var notificationManager = GetNotificationManager();

            // Ensure we have a channel.
            notificationManager.CreateNotificationChannel(CreateChannel());

            // Build the notification with the details.
            var notification = CreateNotification(title, description);

            // Show the notification via the system notification manager.
            notificationManager.Notify(NotificationId, notification);
        }

        private const string ChannelId = "AlbumChannel";
        private const string ChannelName = "Album Channel";
        private const string ChannelDescription = "Messages for the Album App";
        private const int NotificationId = 0;

        private static Notification CreateNotification(string title, string description)
        {
            var builder = new NotificationCompat.Builder(MainActivity.Activity, ChannelId)
                .SetContentTitle(title)
                .SetContentText(description)
                .SetSmallIcon(Resource.Drawable.abc_btn_check_material);

            return builder.Build();
        }

        private static NotificationChannel CreateChannel()
        {
            return new NotificationChannel(ChannelId, ChannelName, NotificationImportance.Default)
            {
                Description = ChannelDescription
            };
        }

        private static NotificationManager GetNotificationManager()
        {
            return (NotificationManager)MainActivity.Activity.GetSystemService(Context.NotificationService);
        }
    }
}