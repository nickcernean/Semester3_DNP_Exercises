using System.Collections;
using System.Collections.Generic;
using Ex2_RestrictedAccessToDo.Models;

namespace Ex2_RestrictedAccessToDo.Data
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