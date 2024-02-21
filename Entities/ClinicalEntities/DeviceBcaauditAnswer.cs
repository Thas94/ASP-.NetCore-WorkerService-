using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class DeviceBcaauditAnswer
{
    public int AnswerId { get; set; }

    public int QuestionId { get; set; }

    public string CaseNo { get; set; } = null!;

    public bool IsCompliant { get; set; }

    public string BedNo { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string CreatedBy { get; set; } = null!;

    public int? BcaauditDeviceId { get; set; }

    public virtual DeviceBcaauditQuestion Question { get; set; } = null!;
}
