using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtruleEngineService
{
    public int ServiceId { get; set; }

    public string ServiceDescription { get; set; } = null!;

    public bool Active { get; set; }

    public bool ServiceCanRun { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
