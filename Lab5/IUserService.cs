using System.ServiceModel;
using Lab5.Models;

namespace Lab5
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        ResponseModel GetAllUsers();

        [OperationContract]
        ResponseModel Login(LoginModel model);

        [OperationContract]
        ResponseModel Register(UserModel model);

        [OperationContract]
        ResponseModel Delete(int id);

        [OperationContract]
        ResponseModel Edit(UserModel model);
    }
}