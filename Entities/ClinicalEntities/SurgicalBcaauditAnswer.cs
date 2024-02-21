using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalBcaauditAnswer
{
    public int AnswerId { get; set; }

    public int QuestionId { get; set; }

    public string CaseNo { get; set; } = null!;

    public bool IsCompliant { get; set; }

    public string BedNo { get; set; } = null!;

    public string? ProcedureCodeIdentifier { get; set; }

    public DateTime? ProcedureDateTime { get; set; }

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int ProcedureId { get; set; }

    public virtual SurgicalBcaauditQuestion Question { get; set; } = null!;
}
