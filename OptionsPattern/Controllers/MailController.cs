using Microsoft.AspNetCore.Mvc;

namespace OptionsPattern.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MailController : ControllerBase
    {
        private readonly MailService _mailService;
        public MailController(MailService mailService)
        {
            _mailService = mailService;
        }

        [HttpGet]
        [Route("settings")]
        public string? Get()
        {
            return _mailService.FormatMailToString();
        }
    }
}