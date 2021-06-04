using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using PierresSweets.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace PierresSweets.Controllers
{
  public class HomeController : Controller
  {
    private readonly PierresSweetsContext _db;

    public HomeController(PierresSweetsContext db)
    {
      _db = db;
    }

    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Treat> treatList = _db.Treats.ToList();
      List<Flavor> flavorList = _db.Flavors.ToList();
      model.Add("Treats", treatList);
      model.Add("Flavors", flavorList);
      return View(model);
    }
  }
}