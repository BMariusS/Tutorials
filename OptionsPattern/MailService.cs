using Microsoft.Extensions.Options;

namespace OptionsPattern
{
    public class MailService
    {
        private readonly MailSettingsOptions? _mailSettings;
        
        // Code used to demonstrate without options pattern
        // private readonly IConfiguration _configuration;

        // public MailService(IOptions<MailSettingsOptions> mailSettings, IConfiguration configuration)
        // {
        //     _configuration = configuration;
        //     _mailSettings = mailSettings.Value;
        // }

        public MailService(IOptions<MailSettingsOptions> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public string? FormatMailToString()
        {
            // Code used to demonstrate without options pattern
//              var mailBaseUri = _configuration.GetValue<string>("MailSettings:BaseUri");
//              var mailApiKey = _configuration.GetValue<string>("MailSettings:ApiKey");
//              var mailDomain = _configuration.GetValue<string>("MailSettings:Domain");
//              var mailFrom = _configuration.GetValue<string>("MailSettings:From");
//              var mailString = $$"""
//                                   BaseUri = {{mailBaseUri}},
//                                   ApiKey = {{mailApiKey}},
//                                   Domain = {{mailDomain}},
//                                   From = {{mailFrom}}
//                                  """;
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
