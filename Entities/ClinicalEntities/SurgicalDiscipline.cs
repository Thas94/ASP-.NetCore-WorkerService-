using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class SurgicalDiscipline
{
    public int Id { get; set; }

    public string Text { get; set; } = null!;
}
