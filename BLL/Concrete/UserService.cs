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

public class UserService : IUserService
{
    public bool SignUp()
    {
        throw new NotImplementedException();
    }
    public List<User> GetUser(PmGetUser param) //Id, Name, Email
    {
        using (IUnitOfWork _unit = new UnitOfWork(new WebAppDbContext()))
        {
            var Users = _unit.UserRepository.GetAll().ToList(); //All DbUsers

            if (param != null)
            {
                if (param.Id.HasValue) //int? özelliği ile HasValue gelir
                {
                    Users = Users.Where(x => x.Id == param.Id).ToList();
                }
                if (!string.IsNullOrEmpty(param.Name))
                {
                    Users = Users.Where(x => x.Name.ToLower().Contains(param.Name)).ToList();
                }
                if (!string.IsNullOrEmpty(param.Email))
                {
                    Users = Users.Where(x=> x.Email.ToLower().Contains(param.Email)).ToList();
                }
            }
            return null;
        }     
    }

    
}
