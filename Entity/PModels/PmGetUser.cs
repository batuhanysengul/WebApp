﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.PModels;

public class PmGetUser
{
    public int? Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int Seller { get; set; }
}
