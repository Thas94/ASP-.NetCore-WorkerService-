using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtschedulerExecutionLog
{
    public int LogId { get; set; }

    public int SchedulerId { get; set; }

    public string? SchedulerAction { get; set; }

    public string? SchedulerMessage { get; set; }

    public TimeSpan? ExcutionTimeToRun { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
