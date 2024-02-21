using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class PersonLog
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? EmailAddress { get; set; }

    public string? HospitalCode { get; set; }

    public string? CaseNo { get; set; }

    public string? PmiNo { get; set; }

    public string? WardNo { get; set; }

    public string? CellNo { get; set; }

    public string? TriggerEvent { get; set; }

    public bool? SurveySent { get; set; }

    public int? SmsSent { get; set; }

    public DateTime? DateTime { get; set; }

    public string? Gpconsent { get; set; }

    public string? MiddleInitial { get; set; }

    public string? Suffix { get; set; }

    public string? Prefix { get; set; }

    public string? ConsultingDoctorHpcsa { get; set; }

    public string? ConsultingDoctorFirstName { get; set; }

    public string? ConsultingDoctorLastName { get; set; }

    public string? AdmittingDoctorHpcsa { get; set; }

    public string? AdmittingDoctorFirstName { get; set; }

    public string? AdmittingDoctorLastName { get; set; }

    public string? Transplant { get; set; }

    public string? BedStatus { get; set; }

    public string? WardDescription { get; set; }

    public string? InfectionControl { get; set; }

    public int? ActiveSmssent { get; set; }

    public string? Vip { get; set; }

    public string? Emergency { get; set; }

    public string? DeadPatient { get; set; }

    public int? EmailSent { get; set; }

    public DateTime? ImportDate { get; set; }

    public string? DocumentNo { get; set; }

    public DateTime? EventDate { get; set; }

    public DateTime? PlannedDate { get; set; }

    public string? Message { get; set; }
}
