using System;
using Microsoft.AspNetCore.Mvc;


namespace Explosion_Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]


  public class ExplosiveController : ControllerBase
  {
    [HttpGet("{input}")]

    public ActionResult<string> KataExplosive(string input)
    {
      var newString = "";
      foreach (var c in input)
      {
        newString += new String(c, int.Parse(c.ToString()));
      }

      return newString;
    }
  }
}