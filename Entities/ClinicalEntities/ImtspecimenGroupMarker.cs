using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtspecimenGroupMarker
{
    public int ImtSpecimenGroupMarkerId { get; set; }

    public int LabId { get; set; }

    public string TestCode { get; set; } = null!;

    public int SpecimenGroupId { get; set; }

    public bool? IsActive { get; set; }
}
