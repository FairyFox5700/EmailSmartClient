﻿namespace EmailSmartClient.Common
{
    public class EmailConfiguration:IEmailConfiguration
    {
        public string SmtpServer { get; }
        public int SmtpPort { get; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string PopServer { get; }
        public int PopPort { get; }
        public string PopUsername { get; }
        public string PopPassword { get; }
    }
}