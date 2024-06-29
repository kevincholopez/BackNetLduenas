using System.Web.Mvc;

namespace DemoCS1.Controllers
{
    public class PersonsController : Controller
    {
        public string Version()
        {
            return "1.0.0.0";
        }
    }
}