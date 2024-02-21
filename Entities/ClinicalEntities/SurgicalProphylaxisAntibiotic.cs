using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalProphylaxisAntibiotic
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;
}
