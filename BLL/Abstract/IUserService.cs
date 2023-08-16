﻿using Entity.Models;
using Entity.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract;

public interface IUserService
{
    public bool SignUp();
    public List<User> GetUser(PmGetUser param);
}
