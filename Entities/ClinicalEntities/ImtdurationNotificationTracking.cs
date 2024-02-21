using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdurationNotificationTracking
{
    public int DurationTrackingId { get; set; }

    public int AlertId { get; set; }

    public bool? NotificationDurationTrackingActive { get; set; }

    public DateTime? ExtendedDate { get; set; }

    public DateTime? ReActivatedDate { get; set; }

    public DateTime? StoppedDate { get; set; }

    public bool Lrt { get; set; }

    public string CaseNo { get; set; } = null!;

    public string Rxe21GivenCodeIdentifier { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public virtual ImtalertHeader Alert { get; set; } = null!;
}
