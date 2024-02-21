using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtatccodesInLabDrug
{
    public int LogId { get; set; }

    public int? LabDrugId { get; set; }

    public string? Atccode { get; set; }
}
