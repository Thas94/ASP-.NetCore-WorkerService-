using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtapirole
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool Active { get; set; }
}
