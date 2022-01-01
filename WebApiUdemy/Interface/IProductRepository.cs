using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiUdemy.Data;

namespace WebApiUdemy.Interface
{
    public interface IProductRepository
    {
        public Task<List<Product>> GetAll();
        public Task<Product> GetById(int id);
        public Task<Product> Create(Product product);
        public Task Update(Product product);
        public Task Remover(int id);
    }
}
