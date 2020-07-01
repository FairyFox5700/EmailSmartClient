using System.Collections.Generic;
using EmailSmartClient.Models;

namespace EmailSmartClient.BAL
{
    public interface IEmailService
    {
        void Send(EmailMessage emailMessage);
        List<EmailMessage> ReceiveEmail(int maxCount = 10);
    }
}