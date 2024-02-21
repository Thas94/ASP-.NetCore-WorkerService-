using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSerologyMapping
{
    public int SerologyMappingId { get; set; }

    public string SerologyLabName { get; set; } = null!;

    public string OrderCode { get; set; } = null!;

    public string ImtIsolateName { get; set; } = null!;

    public int LabId { get; set; }

    public bool? IsActive { get; set; }
}
