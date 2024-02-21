using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtglobalFlag
{
    public int LogId { get; set; }

    public int IsolateId { get; set; }

    public int AlertId { get; set; }

    public int IsolateFlagId { get; set; }

    public virtual ImtisolateInflag IsolateFlag { get; set; } = null!;
}
