namespace Webhook.Data
{
    // This ↓↓↓:
    //public class Subscription
    //{
    //    public required string Topic { get; set; }
    //    public required string CallbackUri { get; set; }

    //    public Subscription(string topic, string callbackUri)
    //    {
    //        Topic = topic;
    //        CallbackUri = callbackUri;
    //    }
    //}

    // Or this ↓↓↓, are similar.
    public record Subscription(string Topic, string CallbackUri);
}
