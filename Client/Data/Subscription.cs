namespace Client.Data
{
    //This ↓↓↓:
    //public class Subscription
    //{
    //    public required string Topic { get; init; }
    //    public string? CallbackUri { get; init; }

    //    public Subscription(string topic, string callbackUri)
    //    {
    //        Topic = topic;
    //        CallbackUri = callbackUri;
    //    }
    //}

    // Or this ↓↓↓, are similar.
    public record Subscription(string Topic, string CallbackUri);
}
