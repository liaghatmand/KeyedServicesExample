using KeyedServicesExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServicesExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly INotifier _notifier;
        private readonly IEnumerable<INotifier> _notifiers;

        public HomeController(INotifier notifier, IEnumerable<INotifier> notifiers)
        {
            _notifier = notifier;
            _notifiers = notifiers;
        }

        [HttpGet]
        public ActionResult Index() {
            foreach (var item in _notifiers)
            {
                if(item is SMSNotifier)
                {
                    item.Send("Message");
                }
                else
                {
                    item.Send("Message");
                }

            }
            
            return Ok("Ok From Index");
        }
    }
}
