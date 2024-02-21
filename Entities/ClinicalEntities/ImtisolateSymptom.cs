using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateSymptom
{
    public int IsolateSymptomId { get; set; }

    public int IsolateId { get; set; }

    public int IsolateSymptomClassificationId { get; set; }
}
