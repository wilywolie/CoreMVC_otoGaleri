using CoreMVC_otoGaleri.Data;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC_otoGaleri.Controllers
{
    public class carController : Controller
    {
        private readonly dataList mydata;
        public carController(dataList veriler)
        {
            mydata = veriler;
        }
        public IActionResult Index()
        {
            return View(mydata.markalar);
        }
        public IActionResult modellistele()
        {
            return View(mydata.modeller);
        }
    }
}
