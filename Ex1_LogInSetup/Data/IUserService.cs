using System.Runtime.CompilerServices;
using Microsoft.AspNetCore.Builder;
using Ex1_LogInSetup.Model;
namespace Ex1_LogInSetup.Data
{
    public interface IUserService
    {
        User ValidateUser(string username, string Password);
    }
}