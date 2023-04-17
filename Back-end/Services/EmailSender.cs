using Microsoft.Extensions.Options;
using MimeKit;
using SendGrid;
using SendGrid.Helpers.Mail;
using MailKit.Net.Smtp;
using System.Threading.Tasks;

public interface IEmailSender
{
    void SendForgotPasswordEmailAsync(string name, string email, string newPassword);
}

public class EmailSender : IEmailSender
{
    private readonly EmailSenderOptions _emailSenderOptions;

    public EmailSender(IOptions<EmailSenderOptions> emailSenderOptions)
    {
        _emailSenderOptions = emailSenderOptions.Value;
    }

    public void SendForgotPasswordEmailAsync(string name,string email, string newPassword)
    {
        var message = new MimeMessage();
        message.From.Add(new MailboxAddress("Parking Everwhere", "swp391g11@fpt.edu.vn"));
        message.To.Add(new MailboxAddress(name, email));
        message.Subject = "Mail cung cap mat khau tam thoi";
        message.Body = new TextPart("plain")
        {
            Text = $"Password mới tạm thời của bạn là: {newPassword}",
          
        };

        using (var client = new SmtpClient())
        {
            client.Connect("smtp.ethereal.email", 587, MailKit.Security.SecureSocketOptions.StartTls);
            client.Authenticate("ken.weimann61@ethereal.email", "K44HaCPQZ7WGsyGY6X");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
