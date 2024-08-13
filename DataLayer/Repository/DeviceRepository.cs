using DataLayer.Context;
using DomainLayer.Interface;
using DomainLayer.Models;

namespace DataLayer.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(StajProjeContext context) : base(context)
        {
        }
    }
}