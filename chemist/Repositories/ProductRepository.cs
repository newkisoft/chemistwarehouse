using chemist.Data;
using chemist.Data.Models;

namespace chemist.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private ChemistDbContext _chemistDbContext;
        public ProductRepository(ChemistDbContext chemistDbContext)
        {
            _chemistDbContext = chemistDbContext;
        }
        public void Delete(Product product)
        {
            _chemistDbContext.Product.Remove(product);
            _chemistDbContext.SaveChanges();
        }

        public Product Get(int productId)
        {
            return _chemistDbContext.Product.FirstOrDefault(p => p.Id == productId);
        }

        public IEnumerable<Product> GetRange(int start, int numberOfItems)
        {
            return _chemistDbContext.Product.Skip(start).Take(numberOfItems);
        }

        public void Insert(Product product)
        {
            _chemistDbContext.Product.Add(product);
            _chemistDbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            _chemistDbContext.Product.Update(product);
            _chemistDbContext.SaveChanges();
        }
    }
}