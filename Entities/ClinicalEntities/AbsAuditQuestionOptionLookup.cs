using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestionOptionLookup
{
    public int Id { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public virtual ICollection<AbsAuditQuestionOption> AbsAuditQuestionOptions { get; set; } = new List<AbsAuditQuestionOption>();
}
