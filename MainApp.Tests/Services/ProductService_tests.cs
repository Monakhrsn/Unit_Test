using MainApp.Dtos;
using MainApp.Models;
using MainApp.Services;

namespace MainApp.Tests.Services;

public class ProductService_tests
{
    private readonly ProductService _productService = new();
    
    [Fact]
    public void SetNewId_ShouldReturnOnAsId_IfNoProductsExists()
    {
        //act
        int result = _productService.SetNewId();
        
        // assert
       Assert.Equal(1, result);
    }
    
    [Fact]
    public void SetNewId_ShouldReturn2AsId_IfOneProductsExists()
    {
        // arrange
        var product = new Product { Id = 1, Title = "Test Product", Price = 100 };
        
        _productService.AddProductToList(product);
        
        //act
        int result = _productService.SetNewId();
        
        // assert
        Assert.Equal(2, result);
    }
    
    [Fact]
    public void AddProductToList_ShouldReturnTrue_WhenProductIsAdded()
    {
        // arrange
        var product = new Product { Id = 1, Title = "Test Product", Price = 100 };
        
        //act
        bool result = _productService.AddProductToList(product);
        
        // assert
        Assert.True(result);
    }
    
    [Fact]
    public void CreateNewProduct_ShouldReturnTrue_WhenProductIsCreatedSuccessfully()
    {
       //arrange
       var productRegistrationForm = new ProductRegistrationForm { Title = "Test Product", Price = 100 };
       
       //act
       var result = _productService.CreateNewProduct(productRegistrationForm);
       
       // assert 
       Assert.True(result);
    }
}