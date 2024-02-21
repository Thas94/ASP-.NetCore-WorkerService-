using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Hl7messageSplitLogProcess
{
    public int SplitLogProcessId { get; set; }

    public int SplitLogId { get; set; }

    public int? RecordType { get; set; }
}
