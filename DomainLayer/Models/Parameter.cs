using System;
using System.Collections.Generic;

namespace DomainLayer.Models;

public partial class Parameter
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? IsDeleted { get; set; }

    public int CreatedUser { get; set; }

    public int? UpdatedUser { get; set; }

    public DateTime CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Device> Devices { get; set; } = new List<Device>();
}
