using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtlab
{
    public int LabId { get; set; }

    public string LabName { get; set; } = null!;

    public bool? Active { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<Imtcmlresult> Imtcmlresults { get; set; } = new List<Imtcmlresult>();

    public virtual ICollection<ImtspecimenAndGroupFromTestName> ImtspecimenAndGroupFromTestNames { get; set; } = new List<ImtspecimenAndGroupFromTestName>();
}
