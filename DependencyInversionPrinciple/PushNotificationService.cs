namespace SOLID.DependencyInversionPrinciple
{
    public class PushNotificationService : IMessageService
{
    public void SendMessage(string message)
    {
        Console.WriteLine($"Sending Push Notification: {message}");
    }
}
}