using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class InterventionAdditionalTypeGroup
{
    public int InterventionAdditionalTypeGroupId { get; set; }

    public int InterventionTypeId { get; set; }

    public int InterventionAdditionalTypeId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual InterventionAdditionalType InterventionAdditionalType { get; set; } = null!;

    public virtual InterventionType InterventionType { get; set; } = null!;
}
