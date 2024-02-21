using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateGroupWorkflow
{
    public int IsolateGroupWorkflowId { get; set; }

    public int IsolateGroupId { get; set; }

    public int QueryId { get; set; }

    public string GroupDescription { get; set; } = null!;

    public string? IsolateResultType { get; set; }

    public int? LabId { get; set; }
}
