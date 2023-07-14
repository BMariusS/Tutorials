using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public class MailService
    {
        private readonly MailSettingsOptions? _mailSettings;

        public MailService(IOptions<MailSettingsOptions> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public string? FormatMailToString()
        {
            var mailString = $$"""
                                     BaseUri = {{_mailSettings?.BaseUri}},
                                     ApiKey = {{_mailSettings?.ApiKey}}, 
                                     Domain = {{_mailSettings?.Domain}}, 
                                     From = {{_mailSettings?.From}}
                                     """;
            return mailString;
        }
    }
}
