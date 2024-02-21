using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DohnotifiableCondition
{
    public int DohnotifiableConditionId { get; set; }

    public string DohnotifiableCondition1 { get; set; } = null!;

    public bool Active { get; set; }
}
