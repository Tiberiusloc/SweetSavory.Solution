using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SweetSavory.Models;
using System.Dynamic;
using System.Linq;

namespace SweetSavory.Controllers
{
  public class HomeController : Controller
  {
    private readonly SweetSavoryContext _db;

    public HomeController(SweetSavoryContext db)
    {
      _db = db;
    }
    [HttpGet("/")]
    public ActionResult Index() 
    { 
      dynamic model = new ExpoObject();
      model.Treat = _db.Treats.ToList();
      model.Flavor = _db.Flavors.ToList();
      return View(model); 
    }
  }
}