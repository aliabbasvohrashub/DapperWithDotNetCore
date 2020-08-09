using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DapperWithCore.Repository
{
    public class BaseRepository : IDisposable
    {
        protected IDbConnection _connection;
        public BaseRepository()
        {
            string connectionString = "Data Source=DESKTOP-IPDVQI7;Initial Catalog=DataManagement;Integrated Security=True";
            _connection = new SqlConnection(connectionString);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
