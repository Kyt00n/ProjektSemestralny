﻿using BackEnd.Models;

namespace BackEnd.Commands
{
    /// <summary>
    /// Interfaces for Commands: Commands in my case are Create, Update and Delete from CRUD application
    /// </summary>
    public interface IRemoveTaskCommand
    {
        Task Execute(Guid id);
    }
}
