using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtnotificationFlagGroup
{
    public int NotificationFlagGroupId { get; set; }

    public string? GroupName { get; set; }

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ImtrulesInFlag> ImtrulesInFlags { get; set; } = new List<ImtrulesInFlag>();
}
