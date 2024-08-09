using BusinessLayer.Models;
using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationLayer.Pages
{
    public class RegisterModel : PageModel
    {
        private IUserService _tUserService;
        [BindProperty]
        public User register { get; set; }
        public RegisterModel(IUserService tUserService)
        {
            _tUserService = tUserService;
        }
        public void OnGet()
        {
            register = new BusinessLayer.Models.User();
        }
    }
}
