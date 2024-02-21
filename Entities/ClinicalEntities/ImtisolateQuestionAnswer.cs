using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateQuestionAnswer
{
    public int IsolateQuestionAnswerId { get; set; }

    public int IsolateId { get; set; }

    public int IsolateQuestionId { get; set; }

    public int? IsolateQuestionSubId { get; set; }

    public int? QuestionSubId { get; set; }

    public string Answer { get; set; } = null!;

    public string? SubAnwer { get; set; }

    public string? Note { get; set; }

    public bool? Active { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }
}
