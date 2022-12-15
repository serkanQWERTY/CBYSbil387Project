using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssistantsController : ControllerBase
    {
        private IAssistantService _assistantService;

        public AssistantsController(IAssistantService assistantService)
        {
            _assistantService = assistantService;
        }

        [HttpGet("getall")]
        public IDataResult<List<Assistant>> GetAll()
        {
            return _assistantService.GetAll();
        }

        [HttpPost("add")]
        public IResult Add(Assistant assistant)
        {
            return _assistantService.Add(assistant);
        }

        [HttpPost("update")]
        public IResult Update(Assistant assistant)
        {
            return _assistantService.Update(assistant);
        }

        [HttpPost("delete")]
        public IResult Delete(Assistant assistant)
        {
            return _assistantService.Delete(assistant);
        }
    }
}
