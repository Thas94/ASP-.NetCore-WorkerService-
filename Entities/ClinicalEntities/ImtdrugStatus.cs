using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtdrugStatus
{
    public int DrugStatusId { get; set; }

    public string CaseNo { get; set; } = null!;

    public int DrugId { get; set; }

    public string Atccode { get; set; } = null!;

    public bool? DrugIsStopped { get; set; }

    public DateTime? DrugStartDate { get; set; }

    public DateTime? DrugStoppedDate { get; set; }

    public bool? DrugIsCancelled { get; set; }

    public DateTime? DrugCancelledDate { get; set; }

    public DateTime? DispensedDate { get; set; }

    public DateTime? DrugLastRestartedDate { get; set; }

    public DateTime? LastDispensedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
