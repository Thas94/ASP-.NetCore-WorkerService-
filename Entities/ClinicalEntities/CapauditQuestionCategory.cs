using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditQuestionCategory
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int AuditChecklistId { get; set; }

    public bool IsDeleted { get; set; }

    public bool? IsMultiSelect { get; set; }

    public virtual AuditChecklistCategory AuditChecklist { get; set; } = null!;

    public virtual CapauditQuestion Question { get; set; } = null!;
}
