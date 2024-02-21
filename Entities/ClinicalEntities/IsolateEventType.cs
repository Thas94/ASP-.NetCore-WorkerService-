using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class IsolateEventType
{
    public int IsolateEventId { get; set; }

    public string Description { get; set; } = null!;

    public bool IsActive { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual ICollection<ImtisolateSpecimenEventType> ImtisolateSpecimenEventTypes { get; set; } = new List<ImtisolateSpecimenEventType>();
}
