using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditAnswer
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int CategoryId { get; set; }

    public int CapAuditDetailId { get; set; }

    public int AuditId { get; set; }

    public string? Text { get; set; }

    public int? QuestionOptionId { get; set; }

    public string? SelectableOptionId { get; set; }

    public string? DynamicSelectableOption { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public virtual ImtabxauditHeader Audit { get; set; } = null!;

    public virtual CapauditDetail CapAuditDetail { get; set; } = null!;

    public virtual AuditChecklistCategory Category { get; set; } = null!;

    public virtual CapauditQuestion Question { get; set; } = null!;
}
