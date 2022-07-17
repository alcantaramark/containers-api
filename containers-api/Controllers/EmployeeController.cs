using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using containers_api.Models;

namespace containers_api.Controllers
{
    [Route("api/[controller]")]
    public class EmployeeController : Controller
    {
        private readonly ContainersApiDbContext _dbContext;

        public EmployeeController(ContainersApiDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return _dbContext.Employees.AsEnumerable();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return _dbContext.Employees.FirstOrDefault(_ => _.Id == id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

