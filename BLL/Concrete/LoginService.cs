using BLL.Abstract;
using DataAccess;
using DataAccess.Context;
using Entity.Models;
using Entity.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete;

public class LoginService : ILoginService
{
    public User? Login(PmLogin param)
    {
        using (IUnitOfWork _unit = new UnitOfWork(new WebAppDbContext()))
        {
            var User = _unit.UserRepository.GetByExpression(x => x.Email.Trim().Equals(param.Email.Trim()));

            if(User != null && User.Password.Trim().Equals(param.Password.Trim()))
            {
                return User;
            }
            return null;
        }
    }
}
