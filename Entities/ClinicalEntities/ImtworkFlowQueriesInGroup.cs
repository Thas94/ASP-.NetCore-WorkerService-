using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtworkFlowQueriesInGroup
{
    public int LogId { get; set; }

    public int WorkFlowId { get; set; }

    public int QuerId { get; set; }

    public bool? Active { get; set; }

    public string? ReturnType { get; set; }

    public string? ReturnLookupValue { get; set; }

    public bool? IsMainQuery { get; set; }

    public string? ConditionColumn { get; set; }

    public int? WorkFlowRuleDetailId { get; set; }
}
