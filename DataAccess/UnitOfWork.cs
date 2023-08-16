using DataAccess.Context;
using DataAccess.Repositories.Abstract;
using DataAccess.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess;

public class UnitOfWork : IUnitOfWork
{
    private WebAppDbContext _context;

    public UnitOfWork(WebAppDbContext context)
    {
        _context = context;
        CityRepository = new CityRepository(_context);
        UserRepository = new UserRepository(_context);
        ProductRepository = new ProductRepository(_context);
        CategoryRepository = new CategoryRepository(_context);
    }

    public ICityRepository CityRepository { get; private set; }
    public IUserRepository UserRepository { get; private set; }
    public IProductRepository ProductRepository { get; private set; }
    public ICategoryRepository CategoryRepository { get; private set; }



    public int Complete()
    {
        return _context.SaveChanges();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
