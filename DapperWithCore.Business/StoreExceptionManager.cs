using DapperWithCore.Business.Interfaces;
using DapperWithCore.Entities;
using DapperWithCore.Repository.Interfaces;

namespace DapperWithCore.Business
{
    public class StoreExceptionManager : IStoreExceptionManager
    {
        private readonly IStoreExceptionRepository _storeExceptionRepository;
        public StoreExceptionManager(IStoreExceptionRepository storeExceptionRepository)
        {
            _storeExceptionRepository = storeExceptionRepository;
        }
        public bool StoreException(ExceptionModel exceptionModel)
        {
            return _storeExceptionRepository.AddException(exceptionModel);
        }
    }
}
