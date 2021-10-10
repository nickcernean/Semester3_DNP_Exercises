using System.Collections;
using System.Collections.Generic;
using Ex2_ToDoLogIn.Models;

namespace Ex2_ToDoLogIn.Data
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