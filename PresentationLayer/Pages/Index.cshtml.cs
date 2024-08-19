using BusinessLayer.Interface;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace PresentationLayer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<DeviceDTO> deviceList;
        public IDeviceService _deviceService;
        public List<ParameterDTO> parameterList;
        public IParameterService _parameterService;
        public IUserService _userService;

        public UserDTO User { get; set; }

        public IndexModel(ILogger<IndexModel> logger,
            IDeviceService deviceService,
            IParameterService parameterService,
            IUserService tuserService)
        {
            _logger = logger;
            _deviceService = deviceService;
            _parameterService = parameterService;
            _userService = tuserService;
        }

        public void OnGet(LoginViewModel model)
        {
            deviceList = _deviceService.GetAllDevices();
            parameterList = _parameterService.GetAllParameters();
            User = _userService.GetUserInfoByUserName(model.UserName);
        }
    }
}

