using System.Threading.Tasks;
using EmailSmartClient.BAL;
using Microsoft.AspNetCore.Mvc;
using Telegram.Bot.Types;

namespace EmailSmartClient.Web.Controllers
{
    public class UpdateController : Controller
    {
        private readonly IUpdateService _updateService;
        // GET
        public UpdateController(IUpdateService updateService)
        {
            _updateService = updateService;
        }

        // POST api/update
        [HttpPost]
        public async Task<IActionResult> Post([FromBody]Update update)
        {
            if (update == null) return Ok();
            
            await _updateService.EchoAsync(update);
            return Ok();
        }
    }
}