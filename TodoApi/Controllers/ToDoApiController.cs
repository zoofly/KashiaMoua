using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [ApiController]
    [Route("[controller")]
    public class TodoApiController : ControllerBase
    {
        private static List< TodoApi > TodoApiList = new List<TodoApi>();

        [HttpGet]
        public IEnumerable<TodoApi> GetTodoApis()
        {
            return TodoApiList;
        }
        [HttpPost]
        public IActionResult Post([FromBody] TodoApi person)
        {
            TodoApiList.Add(person);

            return CreatedAtAction
        }
    }
}