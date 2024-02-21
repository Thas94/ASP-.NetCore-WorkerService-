using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class XiEvnEventTypeCode
{
    public string EventTypeCode { get; set; } = null!;

    public string EventTypeDescription { get; set; } = null!;

    public DateTime DateTimeInserted { get; set; }
}
