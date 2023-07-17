using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
