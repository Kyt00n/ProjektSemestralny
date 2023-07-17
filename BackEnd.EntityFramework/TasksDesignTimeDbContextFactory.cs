using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
