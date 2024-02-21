using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestionMandatoryValidation
{
    public int Id { get; set; }

    public int QuestionOptionId { get; set; }

    public int MandatoryQuestionId { get; set; }

    public virtual AbsAuditQuestion MandatoryQuestion { get; set; } = null!;

    public virtual AbsAuditQuestionOption QuestionOption { get; set; } = null!;
}
