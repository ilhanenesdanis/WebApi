using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiUdemy.Data;
using WebApiUdemy.Interface;

namespace WebApiUdemy.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductContext _context;

        public ProductRepository(ProductContext context)
        {
            _context = context;
        }

        public async Task<Product> Create(Product product)
        {
           await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _context.Products.AsNoTracking().ToListAsync();
        }

        public async Task<Product> GetById(int id)
        {
            return await _context.Products.AsNoTracking().SingleOrDefaultAsync(X => X.Id == id);
        }

        public async Task Remover(int id)
        {
            var Delete = await _context.Products.FindAsync(id);
            _context.Products.Remove(Delete);
            await _context.SaveChangesAsync();
        }

        public async Task Update(Product product)
        {
            var entitu = await _context.Products.FindAsync(product.Id);
            _context.Entry(entitu).CurrentValues.SetValues(product);
            await _context.SaveChangesAsync();
        }
    }
}
