using Microsoft.AspNetCore.SignalR;
using System.Text.Json.Serialization;

namespace EcommerceApi.Models;

#pragma warning disable CS8618
public class User
{
    public string DisplayName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; } // This will be hashed when it is stored in DB
}

public class LoginResponse
{
    public string DisplayName { get; set; }
    public string Email { get; set; }
}