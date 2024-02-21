using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditDrugDefaultQuestion
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int DayId { get; set; }

    public bool IsDeleted { get; set; }

    public string? RxPurpose { get; set; }

    public bool? IsMultiSelect { get; set; }

    public int? DisplayOrder { get; set; }

    public bool? IsDefaultAndPerDrugQestion { get; set; }

    public virtual ICollection<AbsAuditQuestionOption> AbsAuditQuestionOptions { get; set; } = new List<AbsAuditQuestionOption>();

    public virtual AbsAuditDay Day { get; set; } = null!;

    public virtual AbsAuditQuestion Question { get; set; } = null!;
}
