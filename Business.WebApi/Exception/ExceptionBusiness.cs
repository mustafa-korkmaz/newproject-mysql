using System.Threading.Tasks;
using Common.Enumerations;
using Common.Helper;
using Common.Response;
using DAL;
using DAL.Models;

namespace Business.WebApi.Exception
{
    public class ExceptionBusiness
    {
        private readonly UnitOfWork _uow = new UnitOfWork();
        private readonly IRepository<SporComplexException> _exceptionRepository;

        public ExceptionBusiness()
        {
            _exceptionRepository = _uow.Repository<SporComplexException>();
        }

        public BusinessResponse SaveException(System.Exception exception)
        {
            var sporComplexException = new SporComplexException
            {
                Message = exception.Message,
                StackTrace = exception.StackTrace,
                CreatedAt = Statics.GetTurkeyCurrentDateTime()
            };

            _exceptionRepository.Insert(sporComplexException);

            _uow.Save();

            return new BusinessResponse { ResponseCode = ResponseCode.Success };
        }

        public BusinessResponse SaveExceptionAsync(System.Exception exception)
        {
            var sporComplexException = new SporComplexException
            {
                Message = exception.Message,
                StackTrace = exception.StackTrace,
                CreatedAt = Statics.GetTurkeyCurrentDateTime()
            };

            Task.Run(() =>
            {
                _exceptionRepository.Insert(sporComplexException);

                _uow.Save();
            });

            return new BusinessResponse { ResponseCode = ResponseCode.Success };
        }
    }
}