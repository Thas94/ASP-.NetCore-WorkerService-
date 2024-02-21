using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DeviceTypeSiteLink
{
    public int Id { get; set; }

    public int DeviceTypeId { get; set; }

    public int DeviceTypeSiteId { get; set; }
}
