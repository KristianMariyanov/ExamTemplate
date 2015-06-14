namespace Exam.Web.ViewModels
{
    using Exam.Models;
    using Exam.Web.Infrastructure.Mapping;

    public class UserViewModel : IMapFrom<ApplicationUser>
    {
        public string Id { get; set; }

        public string UserName { get; set; }
    }
}