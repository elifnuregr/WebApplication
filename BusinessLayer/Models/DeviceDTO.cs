using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class DeviceDTO
    {
        public int Id { get; set; }

        public string SerialNumber { get; set; } = null!;

        public int? ParameterId { get; set; }

        public bool? IsActive { get; set; }

        public DateTime? FirstParameterDate { get; set; }

        public DateTime? LastParameterDate { get; set; }

        public bool? IsDeleted { get; set; }

        public int CreatedUser { get; set; }

        public int? UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public string? ParameterName { get; set; }
    }
}
