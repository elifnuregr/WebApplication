using BusinessLayer.Interface;
using BusinessLayer.Models;
using DomainLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class DeviceService : IDeviceService
    {
        private IDeviceRepository _deviceRepository;

        public DeviceService(IDeviceRepository deviceRepository)
        {
            _deviceRepository = deviceRepository;
        }
        public List<DeviceDTO> GetAllDevices()
        {
            List<DeviceDTO> deviceList = new List<DeviceDTO>();
            var dataList = _deviceRepository.GetAll();
            if (dataList != null && deviceList.Count > 0)
            {
                foreach (var device in dataList)
                {
                    DeviceDTO deviceDTO = new DeviceDTO();
                    deviceDTO.Id = device.Id;
                    device.SerialNumber = device.SerialNumber;
                    device.ParameterId = device.ParameterId;
                    device.IsActive = device.IsActive;
                    device.FirstParameterDate = device.FirstParameterDate;
                    device.LastParameterDate = device.LastParameterDate;
                    device.IsDeleted = device.IsDeleted;
                    device.CreatedDate = device.CreatedDate;
                    device.UpdatedDate = device.UpdatedDate;

                    deviceList.Add(deviceDTO);
                }
            }

            return deviceList;
        }
    }
}
