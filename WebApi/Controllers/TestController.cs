using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using RepositoryEFCore;
using RepositoryEFCore.Specifications;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly Repository<Person> Repository;
        public TestController(Repository<Person> repository)
        {
            repository = Repository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Repository.FindWithSpecificationPattern(new PeopleByNameSpecification("manuel")));
        }
    }
}
