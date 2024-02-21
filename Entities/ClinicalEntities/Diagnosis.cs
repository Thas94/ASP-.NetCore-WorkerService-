using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Diagnosis
{
    public int Id { get; set; }

    public string? CategoryName { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<AbsScriptUpdate> AbsScriptUpdates { get; set; } = new List<AbsScriptUpdate>();

    public virtual ICollection<DiagnosisSub> DiagnosisSubs { get; set; } = new List<DiagnosisSub>();
}
