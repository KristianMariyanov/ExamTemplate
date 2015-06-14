namespace Exam.Web.Controllers
{
    using System.Web.Mvc;

    using Exam.Data;

    public abstract class BaseController : Controller
    {
        protected BaseController(IExamData data)
        {
            this.Data = data;
        }

        protected IExamData Data { get; set; }
    }
}