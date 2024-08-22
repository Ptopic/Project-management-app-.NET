using ProjectManagement.Common.Email;

namespace ProjectManagement.Services;

public interface IEmailService
{
    Task SendEmailAsync(EmailMessage emailMessage);
}