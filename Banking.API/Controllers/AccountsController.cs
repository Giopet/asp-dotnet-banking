using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers
{
    /// <summary>
    /// Created by right click on Controllers -> Add -> API (Empty)
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public string GetAccounts()
        {
            return "OK";
        }
    }
}
