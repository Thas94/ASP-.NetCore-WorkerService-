using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtnotifiableDisease
{
    public int NotifiableDiseaseId { get; set; }

    public string? IsolategroupItem { get; set; }

    public string? NotifiableDisease { get; set; }

    public bool? Active { get; set; }
}
