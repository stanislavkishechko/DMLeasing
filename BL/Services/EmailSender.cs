using BL.Common.Interfaces;
using MailKit.Net.Smtp;
using Microsoft.Extensions.Logging;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly ILogger<EmailSender> logger;

        public EmailSender(ILogger<EmailSender> logger)
        {
            this.logger = logger;
        }

        public void SendEmail(string name, string email, string text)
        {

            try
            {
                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress(name, email));
                message.To.Add(new MailboxAddress(Config.CompanyName, Config.CompanyEmail));
                message.Subject = "Message from client";
                message.Body = new BodyBuilder() { HtmlBody = $"<div> {text} </div>" }.ToMessageBody();

                using (SmtpClient client = new SmtpClient())
                {
                    client.Connect("smtp.gmail.com", 465, true);
                    client.Authenticate("kishechko.stanislav@sfk.nau.edu.ua", "101maybe1");
                    client.Send(message);

                    client.Disconnect(true);
                }
                logger.LogInformation("Message send success");
            }
            catch (Exception e)
            {
                logger.LogError(e.GetBaseException().Message);
            }
        }
    }
}
