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
        public List<ParameterDTO> parameterList;
        public IParameterService _parameterService;
        public IndexModel(ILogger<IndexModel> logger,
            IDeviceService deviceService,
            IParameterService parameterService)
        {
            _logger = logger;
            _deviceService = deviceService;
            _parameterService = parameterService;
        {
            deviceList = _deviceService.GetAllDevices();
            parameterList=_parameterService.GetAllParameters();
        }
    }
}