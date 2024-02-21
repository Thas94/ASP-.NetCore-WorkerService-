using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SapwardDevice
{
    public int Id { get; set; }

    public int DeviceId { get; set; }

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string SapNumber { get; set; } = null!;

    public string WardNumber { get; set; } = null!;

    public string? DeviceReference { get; set; }

    public bool Active { get; set; }

    public string CapturedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual Device Device { get; set; } = null!;
}
