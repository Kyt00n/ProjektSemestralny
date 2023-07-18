using BackEnd.Models;


namespace BackEnd.Queries
{
    /// <summary>
    /// Interfaces for Queries: Queries in my case are Read from CRUD application
    /// </summary>
    public interface IGetAllTasksQuery
    {
        Task<IEnumerable<TaskModel>> Execute();
    }
}
