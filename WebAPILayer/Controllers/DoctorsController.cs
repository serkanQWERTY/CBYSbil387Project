using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private IDoctorService _doctorService;

        public DoctorsController(IDoctorService doctorService)
        {
            _doctorService = doctorService;
        }
        [HttpGet("getall")]
        public IDataResult<List<Doctor>> GetAll()
        {
            return _doctorService.GetAll();
        }
        [HttpPost("add")]
        public IResult Add([FromBody] Doctor doctor)
        {
            return _doctorService.Add(doctor);
        }

        [HttpPost("update")]
        public IResult Update([FromBody] Doctor doctor)
        {
            return _doctorService.Update(doctor);
        }
        [HttpPost("delete")]
        public IResult Delete(Doctor doctor)
        {
            return _doctorService.Delete(doctor);
        }
    }
}