using Dapper;
using DapperWithCore.Entities;
using DapperWithCore.Repository.Interfaces;
using System;
using System.Collections.Generic;

namespace DapperWithCore.Repository
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public bool AddUser(User user)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("UserName", user.UserName);
                parameters.Add("UserMobile", user.UserMobile);
                parameters.Add("UserEmail", user.UserEmail);
                parameters.Add("FaceBookUrl", user.FaceBookUrl);
                parameters.Add("LinkedInUrl", user.LinkedInUrl);
                parameters.Add("TwitterUrl", user.TwitterUrl);
                parameters.Add("PersonalWebUrl", user.PersonalWebUrl);

                SqlMapper.Execute(
                    cnn: _connection,
                    sql: "AddUser",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );

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
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@UserId", id);
         
                SqlMapper.Execute(
                    cnn: _connection,
                    sql: "DeleteUser",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IList<User> GetAllUsers()
            =>
            SqlMapper.Query<User>(
                cnn: _connection,
                sql: "GetAllUsers",
                commandType: System.Data.CommandType.StoredProcedure
                ).AsList();


        public User GetUser(int id)
         =>
            SqlMapper.QuerySingleOrDefault<User>(
                cnn: _connection,
                sql: "GetAllUsers",
                commandType: System.Data.CommandType.StoredProcedure
                );

        public bool UpdateUser(User user)
        {
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("UserId", user.UserId);
                parameters.Add("UserName", user.UserName);
                parameters.Add("UserMobile", user.UserMobile);
                parameters.Add("UserEmail", user.UserEmail);
                parameters.Add("FaceBookUrl", user.FaceBookUrl);
                parameters.Add("LinkedInUrl", user.LinkedInUrl);
                parameters.Add("TwitterUrl", user.TwitterUrl);
                parameters.Add("PersonalWebUrl", user.PersonalWebUrl);

                SqlMapper.Execute(
                    cnn: _connection,
                    sql: "UpdateUser",
                    param: parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            };
        }
    }
}


/*
 
{
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User> GetAll() =>
            SqlMapper.Query<User>(_connection, "GetAllUsers", commandType: System.Data.CommandType.StoredProcedure).AsList();

        public IEnumerable<User> Get()
        {
            return SqlMapper.Query<User>(
                 cnn: _connection,
                sql: "GetAllUsers",
                commandType: System.Data.CommandType.StoredProcedure).AsList();
        }

        public User Get(int id)
        {
            IEnumerable<User> users = SqlMapper.Query<User>(
                  cnn: _connection,
                  sql: $"select * from User where id = {id}",
                  commandType: System.Data.CommandType.Text
                  ).AsList();

            return null;
        }
        public void Update(User entity)
        {
            throw new NotImplementedException();
        }
    }     
*/
