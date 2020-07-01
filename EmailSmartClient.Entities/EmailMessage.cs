using System;
using System.Collections;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailSmartClient.Entities
{
    public class EmailMessage
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  string EmailMessageId { get; set; }
        public DateTime ReceivedTime { get; private set; } 
        public EmailAddress Sender { get; set; }
        public EmailAddress Receipt { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public string Notes { get; set; }
        //public ICollection<EmailTag> EmailTags { get; set; }
        //public ICollection<EmailAttachment> Attachments { get; set; }
        
    }

    public class EmailTag
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  string EmailTagId { get; set; }
        
    }

    public class EmailAttachment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  string EmailAttachmentId { get; set; }
        public string FileName { get; set; }
        public long FileSize { get; set; }
    }
}