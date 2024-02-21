using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateDohMarkerTemp2
{
    public int IsolateDohMarkerId { get; set; }

    public string TestCode { get; set; } = null!;

    public int LabId { get; set; }

    public bool? IsActive { get; set; }

    public int DohnotifiableConditionId { get; set; }

    public string ResponsibleOrganism { get; set; } = null!;

    public string LabOrganism { get; set; } = null!;
}
