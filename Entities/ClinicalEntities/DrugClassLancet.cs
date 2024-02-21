using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DrugClassLancet
{
    public string? Mnemonic { get; set; }

    public string? Name { get; set; }

    public string? AtcCode { get; set; }

    public string? DrugBugClassesForAnitbiograms { get; set; }

    public double? NumberDrugBugClass { get; set; }

    public string? Abbreviation { get; set; }

    public string? Subgroup { get; set; }

    public string? Group { get; set; }
}
