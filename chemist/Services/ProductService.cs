using chemist.Data.Models;
using chemist.Repositories;

namespace chemist.Services
{
    public class ProductService:IProductService
    {
        private IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Delete(Product product)
        {
            _productRepository.Delete(product);
        }

        public Product Get(int productId)
        {
            return _productRepository.Get(productId);
        }

        public IEnumerable<Product> GetRange(int start, int numberOfItems)
        {
            return _productRepository.GetRange(start,numberOfItems);
        }

        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}