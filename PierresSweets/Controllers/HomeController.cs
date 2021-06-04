using Microsoft.AspNetCore.Mvc;

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
      return View();
    }

  }
}