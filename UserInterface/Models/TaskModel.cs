﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface.Models
{
    public class TaskModel
    {
        

        public string TaskName { get; }
        public string TaskDescription { get; }
        public string TaskPriority { get; }
        public string TaskLocation { get; }
        public TaskModel(string taskName, string taskDescription, string taskPriority, string taskLocation)
        {
            TaskName = taskName;
            TaskDescription = taskDescription;
            TaskPriority = taskPriority;
            TaskLocation = taskLocation;
        }
    }
}