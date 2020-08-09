using DapperWithCore.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DapperWithCore.Business.Interfaces
{
    public interface IUserManager
    {
        bool AddUser(User user);

        bool UpdateUser(User user);

        bool DeleteUser(int id);

        User GetUser(int id);

        IList<User> GetAllUsers();
    }
}
