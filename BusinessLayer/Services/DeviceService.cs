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
        private IParameterRepository _parameterRepository;

        public DeviceService(IDeviceRepository deviceRepository,
            IParameterRepository parameterRepository)
        {
            _deviceRepository = deviceRepository;
            _parameterRepository = parameterRepository;
        }
        public List<DeviceDTO> GetAllDevices()
        {
            List<DeviceDTO> deviceList = new List<DeviceDTO>();
            var dataList = _deviceRepository.GetAll();
            if (dataList != null && dataList.Count > 0)
            {
                foreach (var device in dataList)
                {
                    DeviceDTO deviceDTO = new DeviceDTO();
                    deviceDTO.Id = device.Id;
                    deviceDTO.SerialNumber = device.SerialNumber;
                    deviceDTO.ParameterId = device.ParameterId;
                    deviceDTO.IsActive = device.IsActive;
                    deviceDTO.FirstParameterDate = device.FirstParameterDate;
                    deviceDTO.LastParameterDate = device.LastParameterDate;
                    deviceDTO.IsDeleted = device.IsDeleted;
                    deviceDTO.CreatedDate = device.CreatedDate;
                    deviceDTO.UpdatedDate = device.UpdatedDate;

                    if(deviceDTO != null) 
                        deviceDTO.ParameterName = _parameterRepository.GetById(deviceDTO.ParameterId.Value).Name;

                    deviceList.Add(deviceDTO);
                }
            }

            return deviceList;
        }
    }
}
