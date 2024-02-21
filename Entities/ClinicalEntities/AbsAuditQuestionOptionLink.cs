using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditQuestionOptionLink
{
    public int Id { get; set; }

    public int QuestionOptionId { get; set; }

    public int HideQuestionId { get; set; }
}
