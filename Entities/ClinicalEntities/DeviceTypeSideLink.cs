using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DeviceTypeSideLink
{
    public int Id { get; set; }

    public int DeviceTypeId { get; set; }

    public int DeviceTypeSideId { get; set; }

    public int? LinkedDeviceTypeSiteId { get; set; }
}
