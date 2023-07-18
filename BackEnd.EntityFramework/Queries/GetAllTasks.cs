using BackEnd.Models;
using BackEnd.Queries;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.EntityFramework.Queries
{
    public class GetAllTasks : IGetAllTasksQuery
    {
        private readonly TasksDbContextFactory _dbContextFactory;

        public GetAllTasks(TasksDbContextFactory dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<IEnumerable<TaskModel>> Execute()
        {
            using(TaskDBcontext context = _dbContextFactory.Create())
            {
                IEnumerable<TasksDTO> tasksDTO = await context.Tasks.ToListAsync();

                return tasksDTO.Select(x => new TaskModel(x.Id, x.TaskName, x.TaskDescription, x.TaskPriority, x.TaskLocation));
            }
        }
    }
}
