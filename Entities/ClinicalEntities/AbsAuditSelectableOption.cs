using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsAuditSelectableOption
{
    public string Id { get; set; } = null!;

    public int? DefaultQuestionId { get; set; }

    public int? QuestionDrugId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
