using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtcmlgroup
{
    public int GroupId { get; set; }

    public string GroupName { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdateDate { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<Imtcmlresult> Imtcmlresults { get; set; } = new List<Imtcmlresult>();
}
