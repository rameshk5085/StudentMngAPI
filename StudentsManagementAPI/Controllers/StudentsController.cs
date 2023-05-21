using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentsManagementAPI.Interface;
using StudentsManagementAPI.Models;
using StudentsManagementAPI.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StudentsManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        IDataRepository<Student> dataRepository;
        public StudentsController(IDataRepository<Student> _dataRepository)
        {
            dataRepository = _dataRepository;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            //return dataRepository.GetAll();
            var students = dataRepository.GetAll();
            return Ok(students);
        }

        //// GET api/<StudentsController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        
    }
}
