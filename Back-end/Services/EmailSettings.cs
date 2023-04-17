namespace Back_end.Services
{
    public class EmailSettings
    {
        public string EmailFrom { get; set; }
        public string NameFrom { get; set; }
        public string SmtpServer { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
    }
}
