using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
