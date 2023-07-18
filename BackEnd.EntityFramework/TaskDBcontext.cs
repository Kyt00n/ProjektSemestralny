using Microsoft.EntityFrameworkCore;


namespace BackEnd.EntityFramework
{
    public class TaskDBcontext :DbContext
    {
        public TaskDBcontext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<TasksDTO> Tasks { get; set; }
    }
}
