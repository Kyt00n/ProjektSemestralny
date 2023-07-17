using BackEnd.Commands;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.EntityFramework.Commands
{
    public class EditTaskCommand:IEditTaskCommand
    {
        private readonly TasksDbContextFactory _dbContextFactory;

        public EditTaskCommand(TasksDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task Execute(TaskModel model)
        {
            using (TaskDBcontext context = _dbContextFactory.Create())
            {
                TasksDTO tasksDTO = new TasksDTO()
                {
                    Id = model.Id,
                    TaskName = model.TaskName,
                    TaskDescription = model.TaskDescription,
                    TaskPriority = model.TaskPriority,
                    TaskLocation = model.TaskLocation
                };
                context.Tasks.Update(tasksDTO);
                await context.SaveChangesAsync();

            }
        }
    }
        
}
