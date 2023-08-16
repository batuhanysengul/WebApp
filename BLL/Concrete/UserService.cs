using BLL.Abstract;
using Entity.Models;
using Entity.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete;

public class UserService : IUserService
{
    public List<User> GetUser(PmGetUser param)
    {
        throw new NotImplementedException();
    }

    public bool SignUp()
    {
        throw new NotImplementedException();
    }
}
