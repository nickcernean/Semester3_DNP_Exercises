using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.Json;
using Ex2_ToDoTutorial.Models;

namespace Ex2_ToDoTutorial.Data
{
    public class ToDoJsonData : ITodosData
    {
        private string todoFile = "todos.json";
        private IList<ToDo> todos;

        public ToDoJsonData()
        {
            if (!File.Exists(todoFile))
            {   Seed();
            WriteTodosFile();            }
            else
            {
                string content = File.ReadAllText(todoFile);
                todos = JsonSerializer.Deserialize<IList<ToDo>>(content);

            }
        }

        public IList<ToDo> GetTodos()
        {
            List<ToDo> tmp = new List<ToDo>(todos);
            return tmp;
        }

        public void AddTodo(ToDo todo)
        {
            int max = todos.Max(todo => todo.TodoId);
            todo.TodoId = (++max);
            todos.Add(todo);
            WriteTodosFile();
        }

        public void RemoveTodo(int todoId)
        {
            ToDo toRemove = todos.First(t => t.TodoId == todoId);
            todos.Remove(toRemove);
            WriteTodosFile();
        }

        public void Update(ToDo toDo)
        {
            ToDo toUpdate = todos.First(t => t.TodoId == toDo.TodoId);
            toUpdate.IsCompleted = toDo.IsCompleted;
            toUpdate.Title = toDo.Title;
            WriteTodosFile();
        }

        public ToDo Get(int id)
        {
            return todos.FirstOrDefault(t => t.TodoId == id);
        }

        private void WriteTodosFile()
        {
            string todosAsJson = JsonSerializer.Serialize(todos);
            File.WriteAllText(todoFile, todosAsJson);
        }

        private void Seed()
        {
            ToDo[] ts =
            {
                new ToDo
                {
                    UserId = 1,
                    TodoId = 1,
                    Title = "Do dishes",
                    IsCompleted = false
                },
                new ToDo
                {
                    UserId = 1,
                    TodoId = 2,
                    Title = "Walk the dog",
                    IsCompleted = false
                },new ToDo
                {
                    UserId = 2,
                    TodoId = 3,
                    Title = "Do DNP Homework",
                    IsCompleted = false
                },new ToDo
                {
                    UserId = 3,
                    TodoId = 4,
                    Title = "Do dishes",
                    IsCompleted = false
                },new ToDo
                {
                    UserId = 4,
                    TodoId = 5,
                    Title = "Do dishes",
                    IsCompleted = false
                }


            };
            todos = ts.ToList();
        }
    } 
}