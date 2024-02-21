using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtlabDrug
{
    public int DrugId { get; set; }

    public int LabId { get; set; }

    public string? Drug { get; set; }

    public string? LabDrugCode { get; set; }

    public bool? IsGrouped { get; set; }

    public string? Atccode { get; set; }

    public int? DrugGroupId { get; set; }
}
