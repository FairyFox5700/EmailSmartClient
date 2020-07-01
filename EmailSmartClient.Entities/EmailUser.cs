using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmailSmartClient.Entities
{
    public class EmailUser
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public  string UserId { get; set; }
        public  string Name { get; set; } 
        //public ICollection<Mailbox> Mailboxes { get; set; } 
    }
}