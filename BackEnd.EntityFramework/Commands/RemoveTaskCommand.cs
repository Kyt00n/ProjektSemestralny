using BackEnd.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.EntityFramework.Commands
{
    public class RemoveTaskCommand:IRemoveTaskCommand
    {
        private readonly TasksDbContextFactory _dbContextFactory;

        public RemoveTaskCommand(TasksDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task Execute(Guid id)
        {
            using (TaskDBcontext context = _dbContextFactory.Create())
            {
                TasksDTO tasksDTO = new TasksDTO()
                {
                    Id = id,
                };
                context.Tasks.Remove(tasksDTO);
                await context.SaveChangesAsync();

            }
        }
    }
}
