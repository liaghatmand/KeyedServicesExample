using KeyedServicesExample.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KeyedServicesExample.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class HomeController : ControllerBase
    {
        private readonly INotifier _notifier;

        public HomeController(INotifier notifier)
        {
            _notifier = notifier;
        }

        [HttpGet]
        public ActionResult Index() {
            _notifier.Send("Message");
            return Ok("Ok From Index");
        }
    }
}
