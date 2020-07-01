using System.Collections.Generic;
using EmailSmartClient.Common;
using EmailSmartClient.Models;

namespace EmailSmartClient.BAL.Implementation
{
    public class EmailService:IEmailService
    {
        private readonly IEmailConfiguration _emailConfiguration;
        public EmailService(IEmailConfiguration emailConfiguration)
        {
            _emailConfiguration = emailConfiguration;
        }
        public void Send(EmailMessage emailMessage)
        {
            throw new System.NotImplementedException();
        }

        public List<EmailMessage> ReceiveEmail(int maxCount = 10)
        {
            throw new System.NotImplementedException();
        }
    }
}