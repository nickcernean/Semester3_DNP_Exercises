using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Ex2_ToDoTutorial.Data;
using Ex2_ToDoTutorial.Models;
using Microsoft.AspNetCore.Mvc;

namespace ToDoWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodosData todosData;

        public TodosController(ITodosData todosData)
        {
            this.todosData = todosData;
        }


        [HttpGet]
        public async Task<ActionResult<IList<ToDo>>> GetTodos([FromQuery] bool? isCompleted, [FromQuery] int? userId)
        {
            try
            {
                IList<ToDo> todos = await todosData.GetTodosAsync();
                string todosAsJson = JsonSerializer.Serialize(todos);
                return Ok(todosAsJson);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult> DeleteToDo([FromRoute] int id)
        {
            try
            {
                await todosData.RemoveTodoAsync(id);
                return Ok();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<ToDo>> AddTodo([FromBody] ToDo toDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                ToDo added = await todosData.AddTodoAsync(toDo);
                return Created($"/{added.TodoId}", added);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<ToDo>> UpdateTodo([FromBody] ToDo toDo)
        {
            try
            {
                ToDo updatedTodo = await todosData.UpdateAsync(toDo);
                return Ok(updatedTodo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}