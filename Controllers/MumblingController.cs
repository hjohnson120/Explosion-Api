using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Explosion_Api.Controllers
{
  [ApiController]
  [Route("api/[controller]")]


  public class MumblingController : ControllerBase
  {
    [HttpGet("{s}")]

    public ActionResult<string> KataMumbling(string s)
    {
      return String.Join("-", s.Select((x, i) => char.ToUpper(x) + new string(char.ToLower(x), i)));

    }

  }
}