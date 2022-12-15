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
    public class ReservationsController : ControllerBase
    {
        private IReservationService _reservationService;

        public ReservationsController(IReservationService reservationService)
        {
            _reservationService = reservationService;
        }

        [HttpGet("getall")]
        public IDataResult<List<Reservation>> GetAll()
        {
            return _reservationService.GetAll();
        }

        [HttpPost("add")]
        public IResult Add(Reservation reservation)
        {
            return _reservationService.Add(reservation);
        }

        [HttpPost("update")]
        public IResult Update(Reservation reservation)
        {
            return _reservationService.Update(reservation);
        }
        [HttpPost("delete")]
        public IResult Delete(Reservation reservation)
        {
            return _reservationService.Delete(reservation);
        }
    }
}
