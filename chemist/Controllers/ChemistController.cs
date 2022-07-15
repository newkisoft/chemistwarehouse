using chemist.Data.Models;
using chemist.Services;
using Microsoft.AspNetCore.Mvc;

namespace chemist.Controllers;

[ApiController]
[Route("[controller]")]
public class ChemistController : ControllerBase
{
    
    private IProductService _productService;

    public ChemistController( IProductService productService)
    {
        _productService = productService;
    }

    [HttpGet("{id}")]
    public Product Get(int id)
    {
        return _productService.Get(id);
    }

    [HttpGet("{start}/{numberOfItems}")]
    public IEnumerable<Product> GetRange(int start,int numberOfItems)
    {
        return _productService.GetRange(start,numberOfItems);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        var product = _productService.Get(id);
        _productService.Delete(product);
    }

    [HttpPost]
    public void Insert(Product product)
    {
        _productService.Insert(product);
    }

    [HttpPut]
    public void Update(Product product)
    {
        _productService.Update(product);
    }
}
