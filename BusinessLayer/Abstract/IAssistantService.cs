using CoreLayer.Utilities.Results;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAssistantService
    {
        IDataResult<List<Assistant>> GetAll();
        IResult Add(Assistant assistant);
        IResult Update(Assistant assistant);
        IResult Delete(Assistant assistant);
    }
}
