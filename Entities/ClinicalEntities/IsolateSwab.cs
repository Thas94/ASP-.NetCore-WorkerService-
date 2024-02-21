using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class IsolateSwab
{
    public int IsolateSwabId { get; set; }

    public string SwabDescription { get; set; } = null!;

    public string SwabCriteria { get; set; } = null!;

    public bool? IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
}
