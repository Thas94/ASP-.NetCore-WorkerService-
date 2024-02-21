using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DrugClassPathcare
{
    public string? AntibioticCd { get; set; }

    public string? Name { get; set; }

    public string? AtcCode { get; set; }

    public string? ClassesForDrugBug { get; set; }

    public double? NumberDrugBugClass { get; set; }

    public string? Loinc { get; set; }

    public string? GroupCd { get; set; }

    public string? GroupName { get; set; }

    public string? SubGroupCd { get; set; }

    public string? SubGroupName { get; set; }
}
