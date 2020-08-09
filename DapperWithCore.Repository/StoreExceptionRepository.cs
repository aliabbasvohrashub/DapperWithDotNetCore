using Dapper;
using DapperWithCore.Entities;
using DapperWithCore.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DapperWithCore.Repository
{
    public class StoreExceptionRepository : BaseRepository, IStoreExceptionRepository
    {
        public StoreExceptionRepository()
        {
        }

        public bool AddException(ExceptionModel exceptionModel)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("Path", exceptionModel.Path);
                parameters.Add("Message", exceptionModel.Message);
                parameters.Add("StackTrace", exceptionModel.StackTrace);
                parameters.Add("InnerException", exceptionModel.InnerException);
                SqlMapper.Execute(
                    cnn:_connection,
                    sql: @"insert into Exception([Path],Message,InnerException,StackTrace)
                           values
                           (@Path, @Message, @InnerException, @StackTrace) ",
                    commandType:System.Data.CommandType.Text,
                    param:parameters);
            }
            catch (Exception)
            {

                throw;
            }
            return true;
        }
    }
}
