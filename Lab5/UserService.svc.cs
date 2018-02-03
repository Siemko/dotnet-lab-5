using System;
using System.Linq;
using Lab5.Core;
using Lab5.Core.Entities;
using Lab5.Models;

namespace Lab5
{
    public class UserService : IUserService
    {
        private readonly DataContext _dataContext;

        public UserService()
        {
            _dataContext = new DataContext();
        }

        public ResponseModel Delete(int id)
        {
            try
            {
                var user = _dataContext.Users.Find(id);
                if (user != null) _dataContext.Users.Remove(user);
                _dataContext.SaveChanges();
                return new ResponseModel {IsSuccess = true};
            }
            catch (Exception e)
            {
                return new ResponseModel {IsSuccess = false, ErrorMessage = e.Message};
            }
        }

        public ResponseModel Edit(UserModel model)
        {
            try
            {
                var user = _dataContext.Users.Find(model.Id);
                if (user != null)
                {
                    user.Name = model.Name;
                    user.Surname = model.Surname;
                }

                _dataContext.SaveChanges();
                return new ResponseModel {IsSuccess = true};
            }
            catch (Exception e)
            {
                return new ResponseModel {IsSuccess = false, ErrorMessage = e.Message};
            }
        }

        public ResponseModel GetAllUsers()
        {
            try
            {
                return new ResponseModel
                {
                    Body = _dataContext.Users.ToList().Select(u => new UserModel(u)),
                    IsSuccess = true
                };
            }
            catch (Exception e)
            {
                return new ResponseModel {IsSuccess = false, ErrorMessage = e.Message};
            }
        }

        public ResponseModel Login(LoginModel model)
        {
            try
            {
                var user = _dataContext.Users.FirstOrDefault(u => u.Username == model.Username);
                if (user == null) throw new Exception("User not fouind.");
                if (user.Password != model.Password)
                    throw new Exception("User password is incorrect");
                return new ResponseModel {Body = Guid.NewGuid(), IsSuccess = true};

                throw new Exception("User not fouind.");
            }
            catch (Exception e)
            {
                return new ResponseModel {IsSuccess = false, ErrorMessage = e.Message};
            }
        }

        public ResponseModel Register(UserModel model)
        {
            try
            {
                var user = new User
                {
                    Name = model.Name,
                    Surname = model.Surname,
                    Password = model.Password,
                    Username = model.Username
                };
                _dataContext.Users.Add(user);
                _dataContext.SaveChanges();
                return new ResponseModel {IsSuccess = true};
            }
            catch (Exception e)
            {
                return new ResponseModel {IsSuccess = false, ErrorMessage = e.Message};
            }
        }
    }
}