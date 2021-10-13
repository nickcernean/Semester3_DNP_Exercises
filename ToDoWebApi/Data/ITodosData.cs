using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ex2_ToDoTutorial.Models;

namespace Ex2_ToDoTutorial.Data
{
    public interface ITodosData
    {
        Task<IList<ToDo>> GetTodosAsync();
        Task<ToDo> AddTodoAsync(ToDo todo);
        Task RemoveTodoAsync(int todoId);
        Task<ToDo> UpdateAsync(ToDo toDo);
    }
}