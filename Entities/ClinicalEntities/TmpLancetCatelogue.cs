using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class TmpLancetCatelogue
{
    public int Id { get; set; }

    public string? LancetPrintNumber { get; set; }

    public string? GroupName { get; set; }

    public string? TestMnemonic { get; set; }

    public string? TestName { get; set; }
}
