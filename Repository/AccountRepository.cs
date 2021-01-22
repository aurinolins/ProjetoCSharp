using System;
using System.Threading.Tasks;
using app02.Models.Entidades;
using Microsoft.AspNetCore.Identity;
namespace app02.Repository

{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<IdentityUser> _userManager;

        public AccountRepository(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IdentityResult> CreateUser(SignUpUser usermodel)
        {
            var user = new IdentityUser() {Email = usermodel.Email, UserName = usermodel.Email};

            var result = await _userManager.CreateAsync(user , usermodel.Password);
            return result;
        }

       
    }
}
