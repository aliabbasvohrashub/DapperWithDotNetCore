using DapperWithCore.Entities;
using System.Collections.Generic;

namespace DapperWithCore.Repository.Interfaces
{
    public interface IUserRepository
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
        User GetUser(int id);
        IList<User> GetAllUsers();
    }
}
