using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService
    {
        IDataResult<List<Reservation>> GetAll();
        IResult Add(Reservation reservation);
        IResult Update(Reservation reservation);
        IResult Delete(Reservation reservation);
    }
}
