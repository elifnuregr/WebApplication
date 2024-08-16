using BusinessLayer.Models;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace PresentationLayer.Pages
{
    public class RegisterModel : PageModel
    {
        private IUserService _tUserService;
        [BindProperty]
        public UserDTO registerModel { get; set; }
        public RegisterModel(IUserService tUserService)
        {
            _tUserService = tUserService;
        }
        public void OnGet()
        {
            registerModel = new UserDTO();
        }
        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                var isExist = _tUserService.IsUserExistByUserName(registerModel.UserName);
                if (!isExist)
                {
                    _tUserService.CreateUser(registerModel);
                    ModelState.AddModelError("", "Kullanýcý oluþturulamadý");

                    return RedirectToPage("/Index", ModelState);

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