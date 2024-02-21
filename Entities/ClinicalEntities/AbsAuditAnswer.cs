using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditAnswer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int DayId { get; set; }

    public int AuditId { get; set; }

    public string? Text { get; set; }

    public int? QuestionOptionId { get; set; }

    public string? SelectableOptionId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public virtual ImtabxauditHeader Audit { get; set; } = null!;

    public virtual AbsAuditDay Day { get; set; } = null!;

    public virtual AbsAuditQuestion Question { get; set; } = null!;
}
