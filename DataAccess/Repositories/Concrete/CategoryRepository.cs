using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.Concrete;

public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
{
    public CategoryRepository(WebAppDbContext dbContext) : base(dbContext)
    {
    }

    public WebAppDbContext WebAppContext { get { return (WebAppDbContext)dbContext; } }
}
