namespace chemist.Services
{
    using chemist.Data.Models;
    public interface IProductService
    {
        public void Insert(Product product);
        public void Delete(Product product);
        public void Update(Product product);    
        public Product Get(int productId);    
        public IEnumerable<Product> GetRange(int start, int end);
     
    }
}