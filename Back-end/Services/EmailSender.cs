using Microsoft.Extensions.Options;
using SendGrid;
using SendGrid.Helpers.Mail;
using System.Threading.Tasks;

public interface IEmailSender
{
    Task SendForgotPasswordEmailAsync(string email, string resetToken);
}

public class EmailSender : IEmailSender
{
    private readonly EmailSenderOptions _emailSenderOptions;

    public EmailSender(IOptions<EmailSenderOptions> emailSenderOptions)
    {
        _emailSenderOptions = emailSenderOptions.Value;
    }

    public async Task SendForgotPasswordEmailAsync(string email, string resetToken)
    {
        var client = new SendGridClient(_emailSenderOptions.ApiKey);
        var from = new EmailAddress(_emailSenderOptions.Email, _emailSenderOptions.DisplayName);
        var to = new EmailAddress(email);
        var subject = "Reset Password";
        var plainTextContent = $"Please reset your password by clicking the link below:\n\n{_emailSenderOptions.ResetPasswordUrl}?token={resetToken}";
        var htmlContent = $"<strong>Please reset your password by clicking the link below:</strong><br><br><a href='{_emailSenderOptions.ResetPasswordUrl}?token={resetToken}'>Reset Password</a>";
        var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
        await client.SendEmailAsync(msg);
    }
}
