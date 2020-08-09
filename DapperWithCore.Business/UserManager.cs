using DapperWithCore.Business.Interfaces;
using DapperWithCore.Entities;
using DapperWithCore.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace DapperWithCore.Business
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool AddUser(User user)
        {
            try
            {
                _userRepository.AddUser(user);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteUser(int id)
        {
            try
            {
                _userRepository.DeleteUser(id: id);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IList<User> GetAllUsers()
        {
            try
            {
                return _userRepository.GetAllUsers();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public User GetUser(int id)
        {
            try
            {
                return _userRepository.GetUser(id);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateUser(User user)
        {
            try
            {
                _userRepository.UpdateUser(user);
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
