﻿using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class ToDoItemRepository : IToDoItemRepository
    {
        private readonly ApplicationDbContext context;

        public ToDoItemRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<Guid> AddAsync(ToDoItem toDoItem)
        {
            await context.ToDoItems.AddAsync(toDoItem);
            await context.SaveChangesAsync();
            return toDoItem.Id;
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ToDoItem>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ToDoItem> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(ToDoItem item)
        {
            throw new NotImplementedException();
        }
    }
}
