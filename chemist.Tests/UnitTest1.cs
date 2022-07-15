namespace chemist.Tests;

using System;
using chemist.Data.Models;
using chemist.Repositories;
using chemist.Services;
using Moq;

public class UnitTest1
{
    
    private List<Product> mainList = new List<Product>{
            new Product{Id=1,Name ="test1", Price = 1},
            new Product{Id=2,Name ="test2", Price = 2},
            new Product{Id=2,Name ="test2", Price = 3},

        };
    
    
    [Fact]
    public void GetTest()
    {
        var moq = new Mock<IProductRepository>();


        moq.Setup(p => p.GetRange(It.IsAny<int>(), It.IsAny<int>())).Returns(mainList);

        var productService = new ProductService(moq.Object);

        var products = productService.GetRange(1, 10);

        Assert.Equal(products.Count(), mainList.Count());

    }

    [Fact]
    public void DeleteTest()
    {
        var moq = new Mock<IProductRepository>();
        

        moq.Setup(p => p.GetRange(It.IsAny<int>(), It.IsAny<int>())).Returns(mainList);
        moq.Setup(p => p.Delete(It.IsAny<Product>())).Callback(removeProduct);

        var productService = new ProductService(moq.Object);

        productService.Delete(mainList.FirstOrDefault());

        var products = productService.GetRange(1, 10);

        Assert.Equal(products.Count(), mainList.Count());
    }

    private void removeProduct()
    {
        this.mainList.Remove(this.mainList.FirstOrDefault());
    }
}