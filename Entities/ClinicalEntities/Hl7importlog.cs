using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Hl7importlog
{
    public int ImportlogId { get; set; }

    public int Saphl7msgId { get; set; }

    public string ImportLogReport { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
