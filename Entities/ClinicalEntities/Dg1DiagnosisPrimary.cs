using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Dg1DiagnosisPrimary
{
    public int Dg1id { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Dg11SetIddg1 { get; set; }

    public string? Dg12DiagnosisCodingMethod { get; set; }

    public string? Dg130DiagnosisCodeDg1identifier { get; set; }

    public string? Dg131DiagnosisCodeDg1text { get; set; }

    public string? Dg132DiagnosisCodeDg1nameofCodingSystem { get; set; }

    public string? Dg14DiagnosisDescription { get; set; }

    public DateTime? Dg15DiagnosisDateTime { get; set; }

    public string? Dg16DiagnosisType { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
