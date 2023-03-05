using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Banking.API.Controllers
{
    /// <summary>
    /// 1. Created by right click on Controllers -> Add -> API (Empty)
    /// 2. If we dont put api/accounts on the uri on browser (just localhost:7233), 
    /// then the status code will be 404 because we dont have a starting page.
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
