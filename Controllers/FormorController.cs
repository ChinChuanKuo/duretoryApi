using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using duretoryApi.Models;

namespace duretoryApi.Controllers
{
    [EnableCors("Formor")]
    [ApiController]
    [Route("[controller]")]
    public class FormorController : Controller
    {
        [HttpPost]
        [Route("searchData")]
        public JsonResult searchData([FromBody] userData userData)
        {
            string clientip = Request.HttpContext.Connection.RemoteIpAddress.ToString().TrimEnd() == "::1" ? "127.0.0.1" : Request.HttpContext.Connection.RemoteIpAddress.ToString().TrimEnd();
            return Json(new FormorClass().GetSearchModels(userData, clientip));
        }

        [HttpPost]
        [Route("insertData")]
        public JsonResult insertData([FromBody] iItemsData iItemsData)
        {
            string clientip = Request.HttpContext.Connection.RemoteIpAddress.ToString().TrimEnd() == "::1" ? "127.0.0.1" : Request.HttpContext.Connection.RemoteIpAddress.ToString().TrimEnd();
            return Json(new FormorClass().GetInsertModels(iItemsData, clientip));
        }
    }
}