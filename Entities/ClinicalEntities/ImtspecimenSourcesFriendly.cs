using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenSourcesFriendly
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public bool? Active { get; set; }

    public virtual ICollection<ImtspecimenSiteSourceMapping> ImtspecimenSiteSourceMappings { get; set; } = new List<ImtspecimenSiteSourceMapping>();
}
