namespace Exam.Data
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    using Exam.Data.Contracts;
    using Exam.Data.Migrations;
    using Exam.Data.Repositories;
    using Exam.Models;

    public class ExamData : IExamData
    {
        private readonly IApplicationDbContext context;
        private readonly IDictionary<Type, object> repositories = new Dictionary<Type, object>();

        public ExamData(IApplicationDbContext context)
        {
            this.context = context;
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ApplicationDbContext, Configuration>());
        }

        public IApplicationDbContext Context
        {
            get { return this.context; }
        }

        public IGenericRepository<Test> Tests
        {
            get { return this.GetRepository<Test>(); }
        }

        public IGenericRepository<ApplicationUser> Users
        {
            get { return this.GetRepository<ApplicationUser>(); }
        }

        public int SaveChanges()
        {
            return this.Context.SaveChanges();
        }

        private IGenericRepository<T> GetRepository<T>() where T : class
        {
            if (!this.repositories.ContainsKey(typeof(T)))
            {
                var type = typeof(GenericRepository<T>);

                this.repositories.Add(typeof(T), Activator.CreateInstance(type, this.context));
            }

            return (IGenericRepository<T>)this.repositories[typeof(T)];
        }
    }
}
