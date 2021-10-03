using System.Collections;
using System.Collections.Generic;
using Ex2_ToDoTutorial.Models;

namespace Ex2_ToDoTutorial.Data
{
    public interface ITodosData
    {
        IList<ToDo> GetTodos();
        void AddTodo(ToDo todo);
        void RemoveTodo(int todoId);
        void Update(ToDo toDo);
        ToDo Get(int id);
    }
}