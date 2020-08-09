using DapperWithCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWithCore.Repository.Interfaces
{
    public interface IStoreExceptionRepository
    {
        bool AddException(ExceptionModel exceptionModel);
    }
}
