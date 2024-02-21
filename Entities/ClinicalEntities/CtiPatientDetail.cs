using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class CtiPatientDetail
{
    public int Id { get; set; }

    public string CellNo { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string PmiNo { get; set; } = null!;

    public int PersonLogId { get; set; }
}
