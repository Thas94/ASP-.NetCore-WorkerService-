using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class InterventionTypeContentTypeLink
{
    public int Id { get; set; }

    public int ContentTypeId { get; set; }

    public int InterventionTypeId { get; set; }

    public virtual InterventionType InterventionType { get; set; } = null!;
}
