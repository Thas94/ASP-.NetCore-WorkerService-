using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PatientActivityLogType
{
    public int PatientActivityLogTypeId { get; set; }

    public int ContentTypeId { get; set; }

    public string Name { get; set; } = null!;
}
