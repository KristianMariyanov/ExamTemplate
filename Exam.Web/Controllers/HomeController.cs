namespace Exam.Web.Controllers
{
    using System.Linq;
    using System.Web.Mvc;

    using AutoMapper.QueryableExtensions;

    using Exam.Data;
    using Exam.Web.ViewModels;

    public class HomeController : BaseController
    {
        public HomeController(IExamData data)
            : base(data)
        {
        }

        public ActionResult Index()
        {
            var users = this.Data.Users.All().Project().To<UserViewModel>().ToList();

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