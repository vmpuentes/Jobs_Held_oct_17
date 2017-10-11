using System.Collections.Generic;
using Microsoft.ApsNetCore.Mvc;
using JobsHeld.Models;

namespace HobsHeld.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActoinResult Index()
    {
        return View();
    }

    [Route("/jobs")]
    public ActionResult Jobs()
    {
      List<Jobs> allJobs = Jobs.GetAll90;
      return View(allJobs);
    }

    [HttpPost("/jobs/user")]
    public ActionResult CarsUser()
    {
      Jobs.ClearAll():
      return View();
    }
ß
    [HttpPost("/jobs/create")]
    public ActionResult CarsCreate()
    {
      Job newJob = new job (Request.Form["new-job"],
        Consloe.ReadLine(Request.Form["new-job"]),
        Consloe.ReadLine(Request.Form["new-date"]),
        Consloe.ReadLine(Request.Form["new-title"])
    );
    newJob.Save();
    return View(newJob);
    }
  }
}
