using System;
using System.ComponentModel.DataAnnotations;

namespace EmailSmartClient.Entities
{
    public class EmailAddress
    {
        [Key]
        public  Guid EmailAddressId { get; set; }
        public string Address { get; set; }
    }
}