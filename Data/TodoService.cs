using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TODO_Blazer.DataContext;
using TODO_Blazer.Models;

namespace TODO_Blazer.Data
{
    public class TodoService
    {
        private readonly TodoDbContext _dbContext;

        public TodoService(TodoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Todo>> GetAllTodos()
        {
            return await _dbContext.Todo_Blaze.ToListAsync();
        }

        public async Task<Todo> GetTodoById(int id)
        {
            return await _dbContext.Todo_Blaze.FirstOrDefaultAsync(t => t.TodoCount == id);
        }

        public async Task<bool> AddTodo(Todo todo)
        {
            try
            {
                _dbContext.Todo_Blaze.Add(todo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Handle any exceptions here
                return false;
            }
        }

        public async Task<bool> UpdateTodo(Todo todo)
        {
            try
            {
                _dbContext.Todo_Blaze.Update(todo);
                await _dbContext.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                // Handle any exceptions here
                return false;
            }
        }

        public async Task<bool> DeleteTodo(Todo todo)
        {
            
            if (todo != null)
            {
                try
                {
                    _dbContext.Todo_Blaze.Remove(todo);
                    await _dbContext.SaveChangesAsync();
                    return true;
                }
                catch (Exception)
                {
                    // Handle any exceptions here
                    return false;
                }
            }
            return false;
        }
    }
}
