using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DeviceTypeIndicationLink
{
    public int Id { get; set; }

    public int DeviceTypeId { get; set; }

    public int DeviceTypeIndicationId { get; set; }
}
