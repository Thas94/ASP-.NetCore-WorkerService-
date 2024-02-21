using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class VwAbxautoClosedAuditDay
{
    public int AbxauditId { get; set; }

    public int? InstitutionId { get; set; }

    public bool? Day1Created { get; set; }

    public bool? Day3Created { get; set; }
}
