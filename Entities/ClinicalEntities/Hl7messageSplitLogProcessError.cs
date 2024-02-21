using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Hl7messageSplitLogProcessError
{
    public int SplitLogProcessErrorId { get; set; }

    public int SplitLogId { get; set; }

    public int? RecordType { get; set; }

    public string? ErrorMessage { get; set; }

    public string? InnerException { get; set; }
}
