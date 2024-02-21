using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Imtadmission
{
    public long Id { get; set; }

    public string? AdmissionNumber { get; set; }

    public DateTime? AdmittedDate { get; set; }

    public DateTime? DischargedDate { get; set; }

    public bool? PatientCurrentlyAdmitted { get; set; }

    public DateTime? PatientDeathDateTime { get; set; }

    public bool? PatientCurrentlyDeceased { get; set; }

    public long? PatientPminumber { get; set; }

    public string? PatientIdnumber { get; set; }

    public DateTime? PatientDob { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<ImtlatestCaseState> ImtlatestCaseStates { get; set; } = new List<ImtlatestCaseState>();
}
