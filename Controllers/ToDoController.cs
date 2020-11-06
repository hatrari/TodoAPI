using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using todo.Interfaces;
using todo.Entities;

namespace todo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ToDoController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ToDoController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<ToDo> Get()
        {
            return _unitOfWork.ToDo.FindAll();
        }
        [HttpPost]
        public ToDo Post([FromBody] ToDo todo)
        {
            _unitOfWork.ToDo.Create(todo);
            _unitOfWork.Save();
            return todo;
        }
    }
}
