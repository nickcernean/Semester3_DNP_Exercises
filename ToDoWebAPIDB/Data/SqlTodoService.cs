using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TodoWEBAPIDB.Models;
using TodoWEBAPIDB.Persistence;

namespace TodoWEBAPIDB.Data
{
    public class SqlTodoService : ITodosService
    {
        private TodoContext ctx;

        public SqlTodoService(TodoContext ctx)
        {
            this.ctx = ctx;
        }

        public async Task<IList<Todo>> GetTodosAsync()
        {
            return await ctx.Todos.ToListAsync();
        }

        public async Task<Todo> AddTodoAsync(Todo todo)
        {
            EntityEntry<Todo> newlyAdded = await ctx.Todos.AddAsync(todo);
            await ctx.SaveChangesAsync();
            return newlyAdded.Entity;
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            Todo toDelete = await ctx.Todos.FirstOrDefaultAsync(t => t.TodoId == todoId);
            if (toDelete != null)
            {
                ctx.Todos.Remove(toDelete);
                await ctx.SaveChangesAsync();
            }
        }

        public async Task<Todo> UpdateAsync(Todo todo)
        {
            try
            {
                Todo toUpdate = await ctx.Todos.FirstAsync(t => t.TodoId == todo.TodoId);
                toUpdate.IsCompleted = todo.IsCompleted;
                ctx.Update(toUpdate);
                await ctx.SaveChangesAsync();
                return toUpdate;
            }
            catch (Exception e)
            {
                throw new Exception($"Did not find todo with id{todo.TodoId}");
            }
        }
    }
}