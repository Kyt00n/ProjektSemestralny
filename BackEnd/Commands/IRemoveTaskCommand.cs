using BackEnd.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Commands
{
    public interface IRemoveTaskCommand
    {
        Task Execute(Guid id);
    }
}
