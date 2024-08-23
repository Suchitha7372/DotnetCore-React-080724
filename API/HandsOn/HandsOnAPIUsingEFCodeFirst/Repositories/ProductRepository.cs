using HandsOnAPIUsingEFCodeFirst.Entities;
using Microsoft.EntityFrameworkCore;

namespace HandsOnAPIUsingEFCodeFirst.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ECommContext _context;

<<<<<<< Updated upstream
        public ProductRepository(ECommContext context)
=======
        public ProductRepository(ECommContext context)//dependency injection
>>>>>>> Stashed changes
        {
            _context = context;
        }

<<<<<<< Updated upstream
=======


>>>>>>> Stashed changes
        //public ProductRepository()
        //{
        //    _context = new ECommContext();
        //}
        public void Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var product = _context.Products.Find(Id);
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetProduct(int Id)
        {
            var product = _context.Products.Find(Id);
            return product;
        }

        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
