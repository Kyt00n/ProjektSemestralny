using Microsoft.EntityFrameworkCore;


namespace BackEnd.EntityFramework
{
    public class TasksDbContextFactory
    {
        private readonly DbContextOptions options;

        public TasksDbContextFactory(DbContextOptions options)
        {
            this.options = options;
        }

        public TaskDBcontext Create()
        {
            
            return new TaskDBcontext(options);
        }
    }
}
