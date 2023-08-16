using DataAccess.Context;
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
    public ProductRepository(WebAppDbContext dbContext) : base(dbContext) { }

    public WebAppDbContext WebAppContext { get { return (WebAppDbContext)dbContext; } }

    public List<Product> GetAllProducts()
    {
        using (WebAppContext)
        {
            return WebAppContext.Products
                .Include(x => x.Category)
                .Include(x => x.Seller)
                .ThenInclude(x => x.City)
                .ToList(); //ThenInclude diye devam edilebilir. ThenInclude bağlı olduğuna göre çalışıyor.
        }
    }
}

