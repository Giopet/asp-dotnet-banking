using Banking.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
        private readonly BankingContext _context;

        public AccountsController(BankingContext context)
        {
            _context = context;

            // Runs the seed if that hasn't taken place
            _context.Database.EnsureCreated(); 
        }

        ///// <summary>
        ///// Use without ActionResult when you assume you will have all the time http 200 and no errors.
        ///// </summary>
        ///// <returns></returns>
        //[HttpGet]
        //public IEnumerable<Account> GetAllAccounts()
        //{
        //    return _context.Accounts.ToList();
        //}

        /// <summary>
        /// Return HTTP status codes with a payload of http response as the accounts.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> GetAllAccounts()
        {
            return Ok(await _context.Accounts.ToListAsync());
        }

        /// <summary>
        /// We can use just the id on Route because we have the base Route attribute on class level.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")] // Abbreviation
        //[HttpGet][Route("{id}")]
        //[HttpGet][Route("/api/accounts/{id}")]
        public async Task<ActionResult> GetAccount(int id)
        {
            var account = await _context.Accounts.FindAsync(id);

            if(account == null)
            {
                return NotFound();
            }

            return Ok(account);
        }
    }
}
