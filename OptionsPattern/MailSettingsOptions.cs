namespace OptionsPattern
{
    public class MailSettingsOptions
    {
        public const string MailSettings = "MailSettings";

        public string BaseUri { get; set; } = string.Empty;
        public string ApiKey { get; set; } = string.Empty;
        public string Domain { get; set; } = string.Empty;
        public string From { get; set; } = string.Empty;
    }
}
