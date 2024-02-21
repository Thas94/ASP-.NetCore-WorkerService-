using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class OrderDrugClass
{
    public double? Order { get; set; }

    public string? DrugClassesForDrugBug { get; set; }

    public string? Abbr { get; set; }
}
