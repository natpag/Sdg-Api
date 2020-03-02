using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Sdg_Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExplosionController : ControllerBase
  {
    [HttpGet("explosion")]
    public string Explosion(string s)
    {
      var answerString = "";
      foreach (var letter in s)
      {
        var number = int.Parse(letter.ToString());
        for (var i = 0; i < number; i++)
        {
          answerString += letter;
        }
      }
      return answerString;
    }

  }
}