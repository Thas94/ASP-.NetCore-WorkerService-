using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateInflag
{
    public int IsolateFlagId { get; set; }

    public string FlagDescription { get; set; } = null!;

    public int? RuleFlagId { get; set; }

    public int? LabId { get; set; }

    public string? LabDescription { get; set; }

    public int? IsVisible { get; set; }

    public virtual ICollection<ImtglobalFlag> ImtglobalFlags { get; set; } = new List<ImtglobalFlag>();
}
