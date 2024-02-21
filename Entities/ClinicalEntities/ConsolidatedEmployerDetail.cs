using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ConsolidatedEmployerDetail
{
    public string Pminumber { get; set; } = null!;

    public string Sapnumber { get; set; } = null!;

    public Guid? Hl7uniqueIdentifier { get; set; }

    public string? Employer { get; set; }

    public string? PhoneNumber1 { get; set; }

    public string? PhoneNumber2 { get; set; }

    public string? PhoneNumber3 { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}
