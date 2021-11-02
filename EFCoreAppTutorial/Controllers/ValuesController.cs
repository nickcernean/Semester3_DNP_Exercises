using EFCoreAppTutorial.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EFCoreAppTutorial.Controllers
{
    public class ValuesController : ControllerBase
    {
        private readonly ApplicationContext _context;

        public ValuesController(ApplicationContext applicationContext)
        {
            _context = applicationContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var entity = _context.Model.FindEntityType(typeof(Student).FullName);
            var tableName = entity.GetTableName();
            var schemaName = entity.GetSchema();
            var key = entity.FindPrimaryKey();
            var properties = entity.GetProperties();
            return null;
        }
    }
}