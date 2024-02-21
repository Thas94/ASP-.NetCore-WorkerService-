using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalProphylaxisQuestionOption
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int OptionId { get; set; }

    public bool IsDefault { get; set; }
}
