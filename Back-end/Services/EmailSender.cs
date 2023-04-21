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
        message.Subject = "Mail cấp lại mật khẩu mới";
        message.Body = new TextPart("plain")
        {
            Text = $"Mật khẩu mới của bạn là: {newPassword}",
          
        };

        using (var client = new SmtpClient())
        {
            client.Connect("smtp.gmail.com", 587,false);
            client.Authenticate("phucnvhd772000@gmail.com", "rjqfstzhxcrsvoan");
            client.Send(message);
            client.Disconnect(true);
        }
    }
}
