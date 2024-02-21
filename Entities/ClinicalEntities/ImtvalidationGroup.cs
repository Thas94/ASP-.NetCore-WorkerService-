using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtvalidationGroup
{
    public int ValidationGroupId { get; set; }

    public string ValidationGroupName { get; set; } = null!;

    public bool Active { get; set; }
}
