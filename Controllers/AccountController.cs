using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using app02.Repository;
using app02.Models.Entidades;

namespace app02.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountRepository _usermanager;

        public AccountController(IAccountRepository usermanager)
        {
            _usermanager = usermanager;
        }

        [Route("Signup")]
        public IActionResult Signup()
        {
            return View();
        }
        [Route("Signup")]
        [HttpPost]
        public async Task<IActionResult> Signup(SignUpUser usermodel)
        {
            if (ModelState.IsValid)
            {
                var result = await _usermanager.CreateUser(usermodel);
                if (!result.Succeeded)
                {
                    foreach (var errorMessage in result.Errors)
                    {
                        ModelState.AddModelError(" ", errorMessage.Description);
                    }
                }
                ModelState.Clear();
            }
            return View();
        }
    }
}
