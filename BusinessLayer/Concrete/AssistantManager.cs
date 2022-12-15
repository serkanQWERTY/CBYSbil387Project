using BusinessLayer.Abstract;
using BusinessLayer.ResultMessage;
using CoreLayer.Utilities.Results;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AssistantManager : IAssistantService
    {
        private IAssistantDal _assistantDal;

        public AssistantManager(IAssistantDal assistantDal)
        {
            _assistantDal = assistantDal;
        }

        public IResult Add(Assistant assistant)
        {
            _assistantDal.Add(assistant);
            return new SuccessResult(Messages.DataAdded);
        }

        public IResult Delete(Assistant assistant)
        {
            _assistantDal.Delete(assistant);
            return new SuccessResult(Messages.DataDeleted);
        }

        public IDataResult<List<Assistant>> GetAll()
        {
            return new SuccessDataResult<List<Assistant>>(_assistantDal.GetAll(), Messages.DataListed);
        }

        public IResult Update(Assistant assistant)
        {
            _assistantDal.Update(assistant);
            return new SuccessResult(Messages.DataUpdated);
        }
    }
}
