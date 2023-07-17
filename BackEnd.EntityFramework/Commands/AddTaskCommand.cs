﻿using BackEnd.Commands;
using BackEnd.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.EntityFramework.Commands
{
    public class AddTaskCommand: IAddTaskCommand
    {
        private readonly TasksDbContextFactory _dbContextFactory;

        public AddTaskCommand(TasksDbContextFactory dbContextFactory)
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
                context.Tasks.Add(tasksDTO);
                await context.SaveChangesAsync();
                
            }
        }
    }
}
