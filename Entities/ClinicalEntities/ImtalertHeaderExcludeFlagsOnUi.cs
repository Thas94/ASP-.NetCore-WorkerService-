using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtalertHeaderExcludeFlagsOnUi
{
    public int ExcludeFlagId { get; set; }

    public int FlagId { get; set; }

    public int ApplicationTypeId { get; set; }
}
