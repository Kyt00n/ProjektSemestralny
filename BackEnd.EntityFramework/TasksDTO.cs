using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.EntityFramework
{
    /// <summary>
    /// DTO is decoupled from the Model  in Domain Layer. So there is a posibility to add new
    /// properties not used in models. 
    /// </summary>
    public class TasksDTO
    {
        public Guid Id { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskPriority { get; set; }
        public string TaskLocation { get; set; }
    }
}
