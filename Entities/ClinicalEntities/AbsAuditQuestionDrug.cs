using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestionDrug
{
    public int Id { get; set; }

    public string DrugAtccode { get; set; } = null!;

    public int QuestionId { get; set; }

    public int DayId { get; set; }

    public bool IsDeleted { get; set; }

    public string RxPurpose { get; set; } = null!;

    public bool? IsMultiSelect { get; set; }

    public int? DisplayOrder { get; set; }

    public virtual ICollection<AbsAuditQuestionOption> AbsAuditQuestionOptions { get; set; } = new List<AbsAuditQuestionOption>();

    public virtual AbsAuditDay Day { get; set; } = null!;

    public virtual AbsAuditQuestion Question { get; set; } = null!;
}
