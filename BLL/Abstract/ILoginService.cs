﻿using Entity.Models;
using Entity.PModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Abstract;

public interface ILoginService
{
    public User? Login(PmLogin param); //User varsa dön / ?nullable demek
}
