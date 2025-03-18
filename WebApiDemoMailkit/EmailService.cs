using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;

namespace WebApiDemoMailkit;

public class EmailService : IEmailService
{
    private readonly IConfiguration _configuration;

    public EmailService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public async Task<string> SendEmail(string toEmail, string mailSubject, string mailBody)
    {
        try
        {
            var smtpServer = _configuration["EmailSettings:SmtpServer"];
            var port = int.Parse(_configuration["EmailSettings:Port"]);
            var fromMail = _configuration["EmailSettings:Username"];
            var password = _configuration["EmailSettings:Password"];

            var email = new MimeMessage();
            email.From.Add(new MailboxAddress("Your Name", fromMail));
            email.To.Add(new MailboxAddress("To Name", toEmail));
            email.Subject = mailSubject;
            email.Body = new TextPart("html") { Text = mailBody };

            using var smtp = new SmtpClient();
            await smtp.ConnectAsync(smtpServer, port, SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(fromMail, password);
            await smtp.SendAsync(email);
            await smtp.DisconnectAsync(true);

            return "Email sent successfully!";
        }
        catch (Exception ex)
        {
            // Log the exception (not done here for simplicity)
            return $"Email sending failed. Error: {ex.Message}";
        }
    }
}