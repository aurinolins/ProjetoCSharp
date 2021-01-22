using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using app02.Models.Entidades;

namespace app02.Repository
{
    public interface IAccountRepository
    {
        Task<IdentityResult> CreateUser(SignUpUser usermodel);
    }
}