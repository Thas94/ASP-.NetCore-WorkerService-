using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdohNotifcation
{
    public int Dohid { get; set; }

    public int IsolateId { get; set; }

    public int InstitutionId { get; set; }

    public string? Comment { get; set; }

    public bool? Submitted { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
