using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WP3.Models;
using Newtonsoft.Json;
using WP3.Services;


namespace WP3.Controllers
{

    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            //very proud of this, can send multiple endpoints to a page at once.
            ApiGrabber g = new ApiGrabber();
            var node = await g.Grab("about/");
            var node2 = await g.Grab("footer/");
            var node3 = await g.Grab("news/");
            var Api = new ApiMod();
            Api.about = JsonConvert.DeserializeObject<AbtMod>(node);
            Api.foot = JsonConvert.DeserializeObject<FootMod>(node2);
            Api.news = JsonConvert.DeserializeObject<NewsMod>(node3);
            Api.pTitle = "About Us";
            return View(Api);
        }
        public async Task<IActionResult> Pep()
        {
            //Grabs data from the API, makes it a json, feeds it into the veiw.
            ApiGrabber g = new ApiGrabber();
            var node = await g.Grab("people/");
            var node2 = await g.Grab("footer/");
            var Api = new ApiMod();
            Api.pep = JsonConvert.DeserializeObject<PepMod>(node);
            Api.foot = JsonConvert.DeserializeObject<FootMod>(node2);
            Api.pTitle = "People";
            return View(Api);
        }
        public async Task<IActionResult> Emp()
        {
            //Grabs data from the API, makes it a json, feeds it into the veiw.
            ApiGrabber g = new ApiGrabber();
            var node = await g.Grab("employment/");
            var node2 = await g.Grab("footer/");
            var node3 = await g.Grab("map/");
            var Api = new ApiMod();
            Api.emp = JsonConvert.DeserializeObject<EmpMod>(node);
            Api.foot = JsonConvert.DeserializeObject<FootMod>(node2);
            Api.map = node3;
            Api.pTitle = "Employment";
            return View(Api);
        }
        public async Task<IActionResult> Deg()
        {
            //Grabs data from the API, makes it a json, feeds it into the veiw.
            ApiGrabber g = new ApiGrabber();
            var node = await g.Grab("degrees/");
            var node2 = await g.Grab("minors/");
            var node3 = await g.Grab("footer/");
            var node4 = await g.Grab("course/");
            var Api = new ApiMod();
            Api.deg = JsonConvert.DeserializeObject<DegMod>(node);
            Api.min = JsonConvert.DeserializeObject<MinMod>(node2);
            Api.foot = JsonConvert.DeserializeObject<FootMod>(node3);
            //logic needs to be different here since it's a list of courses, not just one object.
            var courseList = JsonConvert.DeserializeObject<List<Course>>(node4);
            Api.crs = new CrsMod { courses = courseList };
            Api.pTitle = "Employment";
            return View(Api);
        }
    }
}
