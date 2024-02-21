using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtcmlresult
{
    public int ResultId { get; set; }

    public int GroupId { get; set; }

    public int LabId { get; set; }

    public string? PrintCode { get; set; }

    public string Mnemonic { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedDate { get; set; }

    public virtual Imtcmlgroup Group { get; set; } = null!;

    public virtual Imtlab Lab { get; set; } = null!;
}
