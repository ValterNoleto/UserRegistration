using Microsoft.AspNetCore.Mvc;
using UserRegistration.Api.Data;
using UserRegistration.Api.Models;

namespace UserRegistration.Api.Controllers
{
    [Controller]
    [Route("[controller]")]
    public class UserController : Controller
    {
        private readonly IRepository _repository;

        public UserController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public IActionResult CreateUser(User user)
        {
            if (user is null)
                return BadRequest();

            _repository.Create(user);

            return Created("", user);
        }

        [HttpGet]
        public IActionResult GetUsers() 
        {
            return Ok(_repository.GetAll());
        }
    }
}
