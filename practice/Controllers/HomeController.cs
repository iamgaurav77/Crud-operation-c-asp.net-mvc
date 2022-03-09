using System.Web.Mvc;
using System.Data;
using practice.Models.BusinessLayer;
using practice.Models.DomainModel;


namespace practice.Controllers
{
    public class HomeController : Controller
    {
       
        private UserBO obq;
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult insert()
        { 
            return View();
        }

        public ActionResult Display()
        {
            obq = new UserBO();
            DataTable dt = obq.GetData();
            return View(dt);
        }

        public ActionResult table()
        {
            obq = new UserBO();
            DataTable dt = obq.GetData();
            return View(dt);
        }

       

        [HttpPost]
        public ActionResult insertSubmit(User model)
        {
            obq = new UserBO();
            obq.InsertData(model);
            return RedirectToAction("Display");
        }

        [HttpPost]

        public ActionResult delete(User model)
        {
            obq = new UserBO();
            obq.DeleteData(model);
            return RedirectToAction("Display");
        }

        public ActionResult GetEdit(User model)
        {
            obq = new UserBO();
            DataTable dt = obq.GetEditData(model);
            return View(dt);
        }

        [HttpPost]

        public ActionResult EditSubmit(User model)
        {
            obq = new UserBO();
            obq.PostEditData(model);
            return RedirectToAction("Display");
        }
    }
}