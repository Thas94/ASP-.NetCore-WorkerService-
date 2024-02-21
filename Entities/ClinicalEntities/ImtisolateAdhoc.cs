using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtisolateAdhoc
{
    public int Id { get; set; }

    public string? CaseNumber { get; set; }

    public string? OrganismName { get; set; }

    public string? FlagDescription { get; set; }

    public string? PanelDescription { get; set; }

    public int? SpecimenGroupId { get; set; }

    public string? Site { get; set; }

    public int? LabId { get; set; }

    public string? OtherLabDescription { get; set; }

    public int? HospitalId { get; set; }

    public string? CreatedBy { get; set; }

    public string? Base64PdfReport { get; set; }

    public DateTime? StartDate { get; set; }

    public int? IsolateId { get; set; }

    public int? AlertId { get; set; }

    public Guid? Hl7UniqueIdentifier { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? Source { get; set; }

    public int? IppAlertId { get; set; }

    public int? AbsAlertId { get; set; }
}
