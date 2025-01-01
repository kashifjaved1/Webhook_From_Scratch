namespace Webhook.Data
{
    // This ↓↓↓:
    //public class PublishRequest
    //{
    //    public required string Topic { get; set; }
    //    public required object Message { get; set; }

    //    public PublishRequest(string topic, object message)
    //    {
    //        Topic = topic;
    //        Message = message;
    //    }
    //}

    // Or this ↓↓↓, are similar.
    public record PublishRequest(string Topic, object Message);
}
