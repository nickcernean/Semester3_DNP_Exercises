using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoWebClient.Models;

namespace ToDoWebClient.Data
{
    public class CloudTodoData :ITodosData
    {
        private string uri = "https://localhost:5003";
        private readonly HttpClient client;
        private IList<ToDo> toDoList;
        private HttpClientHandler clientHandler;
        public CloudTodoData()
        {   clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback=(sender, cert, chain, sslPolicyErrors) => { return true; };
            client = new HttpClient(clientHandler);
        }
        public async Task<IList<ToDo>> GetTodosAsync()
        {
            Task<string> stringAsync = client.GetStringAsync(uri + "/todos");
            string message = await stringAsync;
            List<ToDo> result = JsonSerializer.Deserialize<List<ToDo>>(message);
            Console.WriteLine(message);
            toDoList = result;
            return toDoList;
        }

        public async Task AddTodoAsync(ToDo todo)
        {
            string todoAsJson = JsonSerializer.Serialize(todo);
            Console.WriteLine();
            HttpContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            await client.PostAsync(uri + "/todos", content);
        }

        public async Task RemoveTodoAsync(int todoId)
        {
            await client.DeleteAsync($"{uri}/todos/{todoId}");
            
        }

        public async Task UpdateAsync(ToDo toDo)
        {
            string todoAsJson = JsonSerializer.Serialize(toDo);
            HttpContent content = new StringContent(todoAsJson, Encoding.UTF8, "application/json");
            await client.PatchAsync($"{uri}/todos/{toDo.TodoId}", content);
        }

        public ToDo Get(int Id)
        {
          return  toDoList.FirstOrDefault(t => t.TodoId == Id);
        }
    }
}