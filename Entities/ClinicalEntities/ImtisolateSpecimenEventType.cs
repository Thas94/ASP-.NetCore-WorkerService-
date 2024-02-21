using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSpecimenEventType
{
    public int Id { get; set; }

    public int FkIsolateEventId { get; set; }

    public int FkSpecimenGroupId { get; set; }

    public DateTime CreatedDate { get; set; }

    public virtual IsolateEventType FkIsolateEvent { get; set; } = null!;

    public virtual ImtspecimenGroup FkSpecimenGroup { get; set; } = null!;
}
