using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class NotificationDetailDuplicateWorkFlow
{
    public int DetailDuplicateWorkFlowId { get; set; }

    public int FlagId { get; set; }

    public int ExecutionPlanId { get; set; }

    public string LookupType { get; set; } = null!;

    public string LookupTableName { get; set; } = null!;

    public string LookupColumnName { get; set; } = null!;

    public string ResultTableName { get; set; } = null!;

    public string ResultColumnName { get; set; } = null!;

    public int ConditionId { get; set; }
}
