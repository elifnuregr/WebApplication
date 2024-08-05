using BusinessLayer.Interface;
using BusinessLayer.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages;
using NuGet.Protocol.Plugins;
using WebApplication3.Models;

namespace WebApplication3.Views.Home
{
    public class LoginModel : PageModel
    {
        private IUserService _tUserService;
        [BindProperty]
        public UserModel login { get; set; }
        public LoginModel(
            IUserService tUserService)
        {
            _tUserService = tUserService;
        }
        public void OnGet()
        {
            login = new UserModel();
        }
        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //check the user exists or not
                if (!_tUserService.IsUserExist(login.UserName, login.Password))
                {
                    ModelState.AddModelError("", "Kullanýcý bilgileri hatalý");

                    return Page();
                }

                return RedirectToPage("/CashRegister/Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
