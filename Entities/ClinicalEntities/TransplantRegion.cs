using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

/// <summary>
/// Stores the Transplant Regions synced from SAP using data services
/// </summary>
public partial class TransplantRegion
{
    public int TransplantRegionId { get; set; }

    public string RegionCode { get; set; } = null!;

    public string RegionDescription { get; set; } = null!;

    public DateTime RegionBegin { get; set; }

    public DateTime RegionEnd { get; set; }

    public virtual ICollection<TransplantUserNotification> TransplantUserNotifications { get; set; } = new List<TransplantUserNotification>();
}
