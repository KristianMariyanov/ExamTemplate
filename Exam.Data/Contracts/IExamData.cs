namespace Exam.Data
{
    using Exam.Data.Contracts;
    using Exam.Models;

    public interface IExamData
    {
        IApplicationDbContext Context { get; }

        IGenericRepository<Test> Tests { get; }

        IGenericRepository<ApplicationUser> Users { get; }

        int SaveChanges();
    }
}
