using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Models
{
    public class ParameterDTO
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public bool? IsDeleted { get; set; }

        public int CreatedUser { get; set; }

        public int? UpdatedUser { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
