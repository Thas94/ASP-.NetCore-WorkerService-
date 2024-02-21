using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSubQuestion
{
    public int IsolateQuestionSubId { get; set; }

    public int IsolateQuestionId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public virtual ImtisolateQuestion IsolateQuestionSub { get; set; } = null!;
}
