using Enterprise.Application.DTOs;
using Enterprise.Domains;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace Enterprise.API.ApiControllers;

[ApiController]
[Route("/api/[controller]")]
public class CustomerController : ControllerBase
{
    [HttpGet]
    [SwaggerOperation(Summary = "Get List of Customers")]
    [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(Result<List<CustomerResp>>))]
    public Task<IActionResult> GetCustomersList()
    {
        var customers = new List<CustomerResp>()
        {
            new(1, "Anand", new Address(1, "123 Street", null, "Fountain Hills", "Arizona", 99502), 200),
            new(2, "Harshil", new Address(2, "123 Street", null, "Fountain Hills", "Arizona", 99502), 300),
            new(3, "Ronak", new Address(3, "123 Street", null, "Fountain Hills", "Arizona", 99502), 500),
            new(4, "Kaval", new Address(5, "123 Street", null, "Fountain Hills", "Arizona", 99502), 2300),
        };
        return Task.FromResult<IActionResult>(Ok(Result<List<CustomerResp>>.Success(customers)));
    }
}