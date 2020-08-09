using DapperWithCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWithCore.Business.Interfaces
{
    public interface IStoreExceptionManager
    {
        bool StoreException(ExceptionModel exceptionModel);
    }
}
