using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

/// <summary>
/// Stores the configuration for which staff members need to receive region and type specific Transplant notfications.
/// </summary>
public partial class TransplantUserNotification
{
    public int TransplantUserNotificationId { get; set; }

    public int TransplantRegionId { get; set; }

    public int TransplantTypeId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public virtual TransplantRegion TransplantRegion { get; set; } = null!;

    public virtual TransplantType TransplantType { get; set; } = null!;
}
