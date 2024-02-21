using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtrulesInFlagsGroup
{
    public int Id { get; set; }

    public string GroupName { get; set; } = null!;
}
