using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BusinessOrderService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessOrdersController : ControllerBase
    {
        // GET api/businessorders
        [HttpGet]
        public ActionResult<IEnumerable<IEnumerable<string>>> Get()
        {
            BusinessOrdersService service = new BusinessOrdersService();
            var businessOrderReports = service.GetBusinessOrderReports();
            return businessOrderReports;
        }
    }
}