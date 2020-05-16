using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using mybudget.Models;
using mybudget.Services;

namespace mybudget.Controllers
{
  [Route("api/v1/[controller]")]
  [ApiController]
  public class BanksController : ControllerBase
  {
    private readonly BanksService _banksService;
    public BanksController(BanksService banksService)
    {
      _banksService = banksService;
    }

    // GET Bank accounts
    [HttpGet]
    public ActionResult<List<Bank>> Get()
    {
      return Ok(_banksService.GetUsersAccounts());
    }

    //Get Accounts/flow
    [HttpGet("flow")]
    public ActionResult<decimal> GetAccounts()
    {
      // string user = HttpContext.User.Identity.Name;
      // return (user is null) ? 
      // Unauthorized("You need to log in to get keeps") :
      // Ok(_repo.GetUsersKeeps(user));
      return Ok(_banksService.getFlow());
    }

    // GET Keeps/5
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

    // POST New Bank
    // [HttpPost]
    // public ActionResult<Bank> Post([FromBody] Bank bank)
    // {
    //   // keep.UserId = HttpContext.User.Identity.Name;
    //   // if (keep.UserId != null)
    //   //   return Ok(_repo.AddKeep(keep));
    //   // return Unauthorized();
    //   return Ok(bank);
    // }

    // PUT accounts/5
    // [HttpPut]
    // public ActionResult<Bank> Put([FromBody] Bank bank)
    // {
    //   return Ok(_repo.editBank(bank));
    // }

    // DELETE accounts/5
    // [HttpDelete("{id}")]
    // public ActionResult<string> Delete(int id)
    // {
    //   if (_repo.DeleteBank(id)) { return Ok("Succssful Deleted"); }
    //   // if (_repo.DeleteBank(id, HttpContext.User.Identity.Name)) { return Ok("Successfully Deleted"); }
    //   return BadRequest("Unable to Delete");
    // }

  }
}