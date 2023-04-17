
using FQ23L056_FakeApi.DTOs;

namespace FQ23L056_FakeApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        // GET: api/<TaskController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_taskRepository.Get().ToList());
        }

        // GET api/<TaskController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            UserTask? userTask = _taskRepository.Get(id);

            if (userTask is null) 
            {
                return NotFound();
            }

            return Ok(userTask);
        }

        // POST api/<TaskController>
        [HttpPost]
        public IActionResult Post([FromBody] CreateTaskDto dto)
        {
            if(_taskRepository.Insert(new UserTask(dto.Title)))
            {
                return NoContent();
            }

            return BadRequest();
        }

        // PUT api/<TaskController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UpdateTaskDto dto)
        {
            if (_taskRepository.Update(id, new UserTask(dto.Title) { Done = dto.Done }))
            {
                return NoContent();
            }
            return NotFound();
        }

        // DELETE api/<TaskController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_taskRepository.Delete(id))
            {
                return NoContent();
            }
            return NotFound();
        }
    }
}
