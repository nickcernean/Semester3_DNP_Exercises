using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TodoWEBAPIDB.Data;
using TodoWEBAPIDB.Models;

namespace TodoWEBAPIDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodosController : ControllerBase
    {
        private ITodosService todosData;

        public TodosController(ITodosService todosData)
        {
            this.todosData = todosData;
        }


        [HttpGet]
        public async Task<ActionResult<IList<Todo>>> GetTodos([FromQuery] bool? isCompleted, [FromQuery] int? userId)
        {
            try
            {
                IList<Todo> todos = await todosData.GetTodosAsync();
               // string todosAsJson = JsonSerializer.Serialize(todos);
                return Ok(todos);
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
        public async Task<ActionResult<Todo>> AddTodo([FromBody] Todo toDo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                Todo added = await todosData.AddTodoAsync(toDo);
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
        public async Task<ActionResult<Todo>> UpdateTodo([FromBody] Todo toDo)
        {
            try
            {
                Todo updatedTodo = await todosData.UpdateAsync(toDo);
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