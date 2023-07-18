using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BackEnd.EntityFramework
{
    public class TasksDesignTimeDbContextFactory : IDesignTimeDbContextFactory<TaskDBcontext>
    {
        
        public TaskDBcontext CreateDbContext(string[] args = null)
        {
            
            return new TaskDBcontext(new DbContextOptionsBuilder().UseSqlite("Data Source=ProjektSemestralny.db").Options);
        }
    }
}
