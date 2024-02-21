using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtcontentType
{
    public int ContentTypeId { get; set; }

    public string ContentTypeName { get; set; } = null!;
}
