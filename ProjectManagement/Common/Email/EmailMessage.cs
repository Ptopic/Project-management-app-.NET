namespace ProjectManagement.Common.Email;

public class EmailMessage
{
    public string ToAddress { get; private set; }

    public string Body { get; private set; }

    public string Subject { get; private set; }

    public static EmailMessage Create(string toAddress, string body, string subject)
    {
        return new EmailMessage
        {
            ToAddress = toAddress,
            Body = body,
            Subject = subject,
        };
    }
}