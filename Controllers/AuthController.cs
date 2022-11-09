using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Trending_News.Models;

namespace Trending_News.Controllers
{
  [Route("api/[Controller]")]
  public class AuthController : Controller
  {
    public TrendingNewsContext Context { get; set; }

    public AuthController(TrendingNewsContext _Context)
    {
      this.Context = _Context;

    }

    [HttpGet]
    public IActionResult Index()
    {
      // return new ObjectResult(Context.Login.Select(p => new { p.UserName, p.Password, p.id }).ToList());
      return new ObjectResult(Context.Logins.ToList());
    }


   




  }








  }
