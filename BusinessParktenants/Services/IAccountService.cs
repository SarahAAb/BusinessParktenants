using BusinessParktenants.Models;
using Microsoft.AspNetCore.Identity;

namespace BusinessParktenants.Services
{
    public interface IAccountService
    {
        Task LogOut();
        Task<SignInResult> SignIn(SignIn signIn);

        Task<IdentityResult> CreateAccount(SignUp signUp);
        Task<IdentityResult> InsertRole(Role role);
        List<UsersDTO> UsersList();
        Task<List<UserRoles>> UserRole(string userId);
        Task UpdateRoles(List<UserRoles> userRoles);
        Task<ApplicationUsers> GetUserInfo(string name);
        List<string> GetRoles(ApplicationUsers user);
        Task<List<UsersDTO>> EmpList();
    }
}
