using MainApp.Dtos;
using MainApp.Models;

namespace MainApp.Factories;

public static class ProductFactory
{
    public static ProductRegistrationForm Create() => new();

    public static Product Create(ProductRegistrationForm productRegistrationForm) => new()
    {
        Title = productRegistrationForm.Title,
        Price = productRegistrationForm.Price,
    };
}