using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DrugClassVermaak
{
    public string? AtcCode { get; set; }

    public string? AntimicrobialAgent { get; set; }

    public string? TestMnemonic { get; set; }

    public string? ClassesForDrugBug { get; set; }

    public double? NumberDrugBugClass { get; set; }

    public double? TestId { get; set; }
}
