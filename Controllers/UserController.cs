using Microsoft.AspNetCore.Mvc;
using EcommerceApi.Models;
using EcommerceApi.Repositories;
namespace AcademyApi.Controllers;

[Route("Users")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _repository;

    public UserController(IUserRepository repository)
    {
        _repository = repository;
    }

}