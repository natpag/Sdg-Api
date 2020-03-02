using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace Sdg_Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MumblingController : ControllerBase
  {
    [HttpGet("mumbling")]
    public string Mumbling(string s)
    {
      s = s.ToLower();
      var timesToRepeatLetter = 1;
      var answerString = "";

      foreach (var letter in s)
      {
        for (var i = 0; i <= timesToRepeatLetter; i++)
        {
          if (i == 0)
          {
            answerString += letter.ToString().ToUpper();
          }
          else
          {
            answerString += letter;
          }
        }
        answerString += "-";
        timesToRepeatLetter++;
      }
      return answerString.TrimEnd('-');
    }

  }
}