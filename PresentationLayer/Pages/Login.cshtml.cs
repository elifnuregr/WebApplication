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
        public LoginViewModel login { get; set; }
        public LoginModel(IUserService tUserService)
        {
            _tUserService = tUserService;
        }
        public void OnGet()
        {
            login = new LoginViewModel();
        }
        public async Task<ActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //check the user exists or not
                var isExist = _tUserService.IsUserExist(login.UserName, login.Password);
                if (!isExist)
                {
                    ModelState.AddModelError("", "Kullanýcý bilgileri hatalý");

                    return Page();
                   
                }

                return RedirectToPage("/Index");
            }
            else
            {
                return Page();
            }
        }

    }
}
