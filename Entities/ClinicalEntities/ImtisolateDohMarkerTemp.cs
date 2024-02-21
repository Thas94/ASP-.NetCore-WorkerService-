using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateDohMarkerTemp
{
    public int IsolateDohMarkerId { get; set; }

    public string TestCode { get; set; } = null!;

    public int LabId { get; set; }

    public bool? IsActive { get; set; }
}
