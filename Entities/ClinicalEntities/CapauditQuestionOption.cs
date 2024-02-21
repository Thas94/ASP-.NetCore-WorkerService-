using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CapauditQuestionOption
{
    public int Id { get; set; }

    public int AuditChecklistId { get; set; }

    public int? QuestionId { get; set; }

    public int CapquestionOptionLookupId { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsDefaultValue { get; set; }

    public virtual AuditChecklistCategory AuditChecklist { get; set; } = null!;

    public virtual CapauditQuestionOptionLookup CapquestionOptionLookup { get; set; } = null!;

    public virtual CapauditQuestion? Question { get; set; }
}
