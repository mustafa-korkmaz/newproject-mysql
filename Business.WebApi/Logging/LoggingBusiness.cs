using System.Threading.Tasks;
using DAL;
using DAL.Models;

namespace Business.WebApi.Logging
{
    public class LoggingBusiness
    {
        private readonly UnitOfWork _uow = new UnitOfWork();

        public void LogRequestAsync(DTO.RequestLog requestLog)
        {
            Task.Run(() =>
            {
                var requestEntity = MappingConfigurator.Mapper.Map<RequestLog>(requestLog);

                _uow.Repository<RequestLog>().Insert(requestEntity);

                _uow.Save();
            });
        }
    }
}