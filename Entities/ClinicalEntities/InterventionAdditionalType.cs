using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class InterventionAdditionalType
{
    public int InterventionAdditionalTypeId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<InterventionAdditionalTypeGroup> InterventionAdditionalTypeGroups { get; set; } = new List<InterventionAdditionalTypeGroup>();
}
