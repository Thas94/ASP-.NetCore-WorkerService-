using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtcmlresultstemp
{
    public int ResultId { get; set; }

    public int GroupId { get; set; }

    public int LabId { get; set; }

    public string Labcode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public bool? Active { get; set; }
}
