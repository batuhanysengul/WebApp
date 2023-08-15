﻿using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entity.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class ProductRepository : GenericRepository<Product>, IProductRepository
{
    public ProductRepository(WebAppDbContext dbContext) : base(dbContext)
    {
    }

    public WebAppDbContext WebAppContext { get { return (WebAppDbContext)dbContext; } }
}
