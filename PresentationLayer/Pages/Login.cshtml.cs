using BusinessLayer.Interface;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationLayer.Pages
{
    public class LoginModel : PageModel
    {
        private IUserService _tUserService;
        [BindProperty]
        public User login { get; set; }
        public LoginModel(
            IUserService tUserService)
        {
            _tUserService = tUserService;
        }
        public void OnGet()
        {
            login = new User();
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
