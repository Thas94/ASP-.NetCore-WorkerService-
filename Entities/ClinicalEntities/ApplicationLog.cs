using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ApplicationLog
{
    public long Id { get; set; }

    public string? Message { get; set; }

    public string? MessageTemplate { get; set; }

    public string? Level { get; set; }

    public DateTimeOffset TimeStamp { get; set; }

    public string? Exception { get; set; }

    public string? Properties { get; set; }

    public string? LogEvent { get; set; }
}
