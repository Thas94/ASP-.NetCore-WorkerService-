using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenSource
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<ImtspecimenSiteSourceMapping> ImtspecimenSiteSourceMappings { get; set; } = new List<ImtspecimenSiteSourceMapping>();
}
