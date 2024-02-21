using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CreassessmentQuestionOption
{
    public int Id { get; set; }

    public int QuestionId { get; set; }

    public int OptionId { get; set; }
}
