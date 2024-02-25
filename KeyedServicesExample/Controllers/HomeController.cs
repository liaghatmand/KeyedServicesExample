using KeyedServicesExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServicesExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly INotifier _emailNotifier;
        private readonly INotifier _sMSNotifier;
       
        public HomeController([FromKeyedServices("SMS")]INotifier SMSNotifier, [FromKeyedServices("Email")] INotifier EmailNotifier)
        {
            _sMSNotifier = SMSNotifier;
            _emailNotifier = EmailNotifier;
        }

        [HttpGet]
        public ActionResult Index() {
           
            _sMSNotifier.Send("Message");
            _emailNotifier.Send("Message");
            return Ok("Ok From Index");
        }
    }
}
