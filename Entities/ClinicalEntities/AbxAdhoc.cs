using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbxAdhoc
{
    public int AbxAdhocId { get; set; }

    public int RouteId { get; set; }

    public int DoseId { get; set; }

    public string? Dose { get; set; }

    public int FrequencyId { get; set; }

    public string PurposOfPrescription { get; set; } = null!;

    public string Diagnosis { get; set; } = null!;

    public string SubDiagnosis { get; set; } = null!;

    public string? MedicationName { get; set; }

    public string? Loading { get; set; }

    public DateTime? PrescriptionTime { get; set; }

    public DateTime AdministrationTime { get; set; }

    public string CaseNo { get; set; } = null!;

    public string? Drug { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? Ltt { get; set; }

    public bool? Tdm { get; set; }
}
