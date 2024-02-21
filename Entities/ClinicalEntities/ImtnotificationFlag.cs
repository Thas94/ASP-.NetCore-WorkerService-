using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtnotificationFlag
{
    public int NotificationFlagId { get; set; }

    public int ApplicationTypeId { get; set; }

    public int FlagId { get; set; }

    public string FlagName { get; set; } = null!;

    public int PermutationFlagId { get; set; }

    public string PermutationFlagName { get; set; } = null!;

    public int LabId { get; set; }

    public bool Active { get; set; }

    public int? Sequence { get; set; }
}
