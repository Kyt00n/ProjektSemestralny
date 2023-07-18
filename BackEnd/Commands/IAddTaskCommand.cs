using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Commands
{
    /// <summary>
    /// Interfaces for Commands: Commands in my case are Create, Update and Delete from CRUD application
    /// </summary>
    public interface IAddTaskCommand
    {
        Task Execute(TaskModel model);
    }
}
