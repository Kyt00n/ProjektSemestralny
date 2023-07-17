using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Queries
{
    public interface IGetAllTasksQuery
    {
        Task<IEnumerable<TaskModel>> Execute();
    }
}
