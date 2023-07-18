using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
