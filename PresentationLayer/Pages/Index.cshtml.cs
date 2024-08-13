using BusinessLayer.Interface;
using BusinessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace PresentationLayer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public List<DeviceDTO> deviceList;
        public IDeviceService _deviceService;
        public IndexModel(ILogger<IndexModel> logger,
            IDeviceService deviceService)
        {
            _logger = logger;
            _deviceService = deviceService;
        }

        public void OnGet()
        {
            deviceList = _deviceService.GetAllDevices();
        }
    }
}
