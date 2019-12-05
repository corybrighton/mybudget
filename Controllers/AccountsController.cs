using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mybudget.Models;

namespace mybudget.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class AccountsController : ControllerBase
  {
    // private readonly KeepRepository _repo;
    // public KeepsController(KeepRepository repo)
    // {
    // _repo = repo;
    // }

    // GET api/Accounts
    [HttpGet]
    public ActionResult<Account> Get()
    {
      Account account = new Account()
      {
        Balance = 15.75M,
        BankID = 1,
        ID = 1,
        Name = "Savings",
        Uncleared = 1.23M,
        UserID = "user"
      };
      return Ok(account);
    }

    //Get api/Accounts/flow
    [HttpGet("flow")]
    public ActionResult<decimal> GetAccounts()
    {
      // string user = HttpContext.User.Identity.Name;
      // return (user is null) ? 
      // Unauthorized("You need to log in to get keeps") :
      // Ok(_repo.GetUsersKeeps(user));
      return Ok(100.5M);
    }

    // GET api/Keeps/5
    // [HttpGet("{id}")]
    // public ActionResult<Keep> Get(int id)
    // {
    //   Keep keep = _repo.GetById(id);
    //   if (keep != null)
    //   {
    //     return Ok(keep);
    //   }
    //   else
    //   {
    //     return NotFound();
    //   }
    // }

    // POST api/Keeps
    // [HttpPost]
    // public ActionResult<string> Post([FromBody] Keep keep)
    // {
    //   keep.UserId = HttpContext.User.Identity.Name;
    //   if (keep.UserId != null)
    //     return Ok(_repo.AddKeep(keep));
    //   return Unauthorized();
    // }

    // PUT api/Keeps/5
    // [HttpPut("{id}")]
    // public ActionResult<string> Put(int id)
    // {
    //   return Ok(_repo.UpdateKeepShares(id));
    // }

    // DELETE api/Burgers/5
    // [HttpDelete("{id}")]
    // public ActionResult<string> Delete(int id)
    // {
    //   if (_repo.DeleteKeep(id, HttpContext.User.Identity.Name)) { return Ok("Successfully Deleted"); }
    //   return BadRequest("Unable to Delete");
    // }

  }
}