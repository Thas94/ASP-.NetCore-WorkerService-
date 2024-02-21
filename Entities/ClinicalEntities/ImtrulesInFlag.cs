using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtrulesInFlag
{
    public int FlagId { get; set; }

    public int ApplicationTypeId { get; set; }

    public int AlertCategoryId { get; set; }

    public string RuleDescription { get; set; } = null!;

    public string? FlagDescription { get; set; }

    public string? RuleNotes { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? ExecutionPlanId { get; set; }

    public bool? IsMonitoringRule { get; set; }

    public int? RunForRuleId { get; set; }

    public int OrderOfExecution { get; set; }

    public int? LabId { get; set; }

    public int? RuleGroup { get; set; }

    public string? RuleDefinition { get; set; }

    public string? RequiredOrganismName { get; set; }

    public int? FlaggroupId { get; set; }

    public bool CreatesNotificationForIsolate { get; set; }

    public bool? HasDefaultOrganismForNotifications { get; set; }

    public virtual ImtnotificationFlagGroup? Flaggroup { get; set; }
}
