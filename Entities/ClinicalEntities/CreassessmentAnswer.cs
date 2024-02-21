using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CreassessmentAnswer
{
    public int Id { get; set; }

    public string CaseNo { get; set; } = null!;

    public int QuestionId { get; set; }

    public int AlertId { get; set; }

    public string SelectedOptionId { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;
}
