using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtIsolateUrineInfectionCriterion
{
    public int UrineInfectionId { get; set; }

    public string UrineInfectionCriteria { get; set; } = null!;

    public bool IsActive { get; set; }
}
