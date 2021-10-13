using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoWebClient.Models;

namespace ToDoWebClient.Data
{
    public interface ITodosData
    {
        Task<IList<ToDo>> GetTodosAsync();
        Task AddTodoAsync(ToDo todo);
        Task RemoveTodoAsync(int todoId);
        Task UpdateAsync(ToDo toDo);
        ToDo Get(int Id);
    }
}