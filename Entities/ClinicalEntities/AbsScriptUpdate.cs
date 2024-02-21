using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class AbsScriptUpdate
{
    public int AbsScriptUpdatesId { get; set; }

    public int RouteId { get; set; }

    public int? DoseId { get; set; }

    public int FrequencyId { get; set; }

    public string? PurposOfPrescription { get; set; }

    public string? Diagnosis { get; set; }

    public string? MedicationName { get; set; }

    public DateTime? PrescriptionTime { get; set; }

    public DateTime? AdministrationTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int AbsAuditId { get; set; }

    public string? FrequencyValue { get; set; }

    public string? DoseValue { get; set; }

    public string? RouteValue { get; set; }

    public string? LoadingDose { get; set; }

    public bool? Ltt { get; set; }

    public bool? Tdm { get; set; }

    public string? DoctorName { get; set; }

    public int? DiagnosisId { get; set; }

    public int? SubDiagnosisId { get; set; }

    public string? SubDiagnosisOther { get; set; }

    public int? AlternativeRouteId { get; set; }

    public string? AlternativeRouteValue { get; set; }

    public int? AlternativeFrequencyId { get; set; }

    public string? AlternativeFrequencyValue { get; set; }

    public int? AlternativeDoseId { get; set; }

    public string? AlternativeDoseValue { get; set; }

    public string? AlternativeLoadingDose { get; set; }

    public virtual Diagnosis? DiagnosisNavigation { get; set; }

    public virtual AbsDose? Dose { get; set; }

    public virtual DiagnosisSub? SubDiagnosis { get; set; }
}
