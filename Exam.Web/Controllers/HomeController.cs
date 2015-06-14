namespace Exam.Web.Controllers
{
    using System.Web.Mvc;

    using Exam.Data;

    public class HomeController : BaseController
    {
        public HomeController(IExamData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            this.Data.Users.All();
            return this.View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}