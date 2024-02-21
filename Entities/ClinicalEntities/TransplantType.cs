using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

/// <summary>
/// Stores the Transplant Types synced from SAP using data services
/// </summary>
public partial class TransplantType
{
    public int TransplantTypeId { get; set; }

    public string TypeCode { get; set; } = null!;

    public string TypeDescription { get; set; } = null!;

    public DateTime TypeBegin { get; set; }

    public DateTime TypeEnd { get; set; }

    public virtual ICollection<TransplantUserNotification> TransplantUserNotifications { get; set; } = new List<TransplantUserNotification>();
}
