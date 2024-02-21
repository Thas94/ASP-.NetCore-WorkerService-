using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ConsolidatedInsurance
{
    public string Pminumber { get; set; } = null!;

    public string Sapnumber { get; set; } = null!;

    public Guid? Hl7uniqueIdentifier { get; set; }

    public string? MedicalAidAdministrator { get; set; }

    public string? MedicalAidIdnumber { get; set; }

    public string? MedicalAidName { get; set; }

    public string? MedicalAidPlan { get; set; }

    public string? MedicalAidNumber { get; set; }

    public string? MedicalAidMemberDigit { get; set; }

    public string? AuthorisationNumber { get; set; }

    public string? AccountResponsibleIdnumber { get; set; }

    public string? AccountResponsibleSurname { get; set; }

    public string? AccountResponsibleName { get; set; }

    public string? AccountResponsibleTitle { get; set; }

    public string? AccountResponsibleAddressLine1 { get; set; }

    public string? AccountResponsibleAddressLine2 { get; set; }

    public string? AccountResponsibleAddressLine3 { get; set; }

    public string? AccountResponsibleAddressLine4 { get; set; }

    public string? AccountResponsibleAddressPostalCode { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public DateTime? DateTimeUpdated { get; set; }
}
