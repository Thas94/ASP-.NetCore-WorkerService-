using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DrugClassAmpath
{
    public double DrugId { get; set; }

    public double? LabId { get; set; }

    public string? Drug { get; set; }

    public string? AtcCode { get; set; }

    public string? LabDrugCode { get; set; }

    public string? DrugClassesForDrugBug { get; set; }

    public double? NumberDrugBugClass { get; set; }
}
