using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtruleExecutionLog
{
    public int LogId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public string CaseNo { get; set; } = null!;

    public int? FlagId { get; set; }

    public int? ConditionId { get; set; }

    public bool? ConditionMet { get; set; }

    public DateTime? ConditionRunDate { get; set; }

    public string? ConditionQuery { get; set; }

    public string? ConditionQueryErrorMessage { get; set; }

    public int? ExecutionPlanId { get; set; }
}
