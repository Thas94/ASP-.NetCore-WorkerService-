using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateQuestion
{
    public int IsolateQuestionId { get; set; }

    public string Description { get; set; } = null!;

    public virtual ImtisolateSubQuestion? ImtisolateSubQuestion { get; set; }
}
