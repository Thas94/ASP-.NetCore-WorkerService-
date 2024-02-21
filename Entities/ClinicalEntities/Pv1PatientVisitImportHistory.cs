using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Pv1PatientVisitImportHistory
{
    public Guid? Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public long? Pv11SetIdpv1 { get; set; }

    public string Pv12PatientClass { get; set; } = null!;

    public string? Pv130AssignedPatientLocationPointOfCare { get; set; }

    public string? Pv131AssignedPatientLocationRoom { get; set; }

    public string? Pv132AssignedPatientLocationBed { get; set; }

    public string? Pv133AssignedPatientLocationFacility { get; set; }

    public string? Pv134AssignedPatientLocationLocationStatus { get; set; }

    public string? Pv135AssignedPatientLocationPersonLocationType { get; set; }

    public string? Pv136AssignedPatientLocationBuilding { get; set; }

    public string? Pv137AssignedPatientLocationFloor { get; set; }

    public string? Pv138AssignedPatientLocationLocationDescription { get; set; }

    public string? Pv14AdmissionType { get; set; }

    public string? Pv150PreadmitNumberIdnumber { get; set; }

    public string? Pv160PriorPatientLocationPointOfCare { get; set; }

    public string? Pv161PriorPatientLocationRoom { get; set; }

    public string? Pv162PriorPatientLocationBed { get; set; }

    public string? Pv170AttendingDoctorIdnumber { get; set; }

    public string? Pv171AttendingDoctorFamilyName { get; set; }

    public string? Pv172AttendingDoctorGivenName { get; set; }

    public string? Pv180ReferringDoctorIdnumber { get; set; }

    public string? Pv181ReferringDoctorFamilyName { get; set; }

    public string? Pv182ReferringDoctorGivenName { get; set; }

    public string? Pv190ConsultingDoctorIdnumber { get; set; }

    public string? Pv191ConsultingDoctorFamilyName { get; set; }

    public string? Pv192ConsultingDoctorGivenName { get; set; }

    public string? Pv110HospitalService { get; set; }

    public string? Pv1110TemporaryLocationPointOfCare { get; set; }

    public string? Pv1111TemporaryLocationRoom { get; set; }

    public string? Pv1112TemporaryLocationBed { get; set; }

    public string? Pv112PreadmitTestIndicator { get; set; }

    public string? Pv113ReadmissionIndicator { get; set; }

    public string? Pv114AdmitSource { get; set; }

    public string? Pv115AmbulatoryStatus { get; set; }

    public string? Pv116Vipindicator { get; set; }

    public string? Pv1170AdmittingDoctorIdnumber { get; set; }

    public string? Pv1171AdmittingDoctorFamilyName { get; set; }

    public string? Pv1172AdmittingDoctorGivenName { get; set; }

    public string? Pv118PatientType { get; set; }

    public string? Pv1190VisitNumberIdnumber { get; set; }

    public string? Pv1200FinancialClassFinancialClassCode { get; set; }

    public string? Pv121ChargePriceIndicator { get; set; }

    public string? Pv122CourtesyCode { get; set; }

    public string? Pv123CreditRating { get; set; }

    public string? Pv124ContractCode { get; set; }

    public DateTime? Pv125ContractEffectiveDate { get; set; }

    public decimal? Pv126ContractAmount { get; set; }

    public decimal? Pv127ContractPeriod { get; set; }

    public string? Pv128InterestCode { get; set; }

    public string? Pv129TransfertoBadDebtCode { get; set; }

    public DateTime? Pv130TransfertoBadDebtDate { get; set; }

    public string? Pv131BadDebtAgencyCode { get; set; }

    public decimal? Pv132BadDebtTransferAmount { get; set; }

    public decimal? Pv133BadDebtRecoveryAmount { get; set; }

    public string? Pv134DeleteAccountIndicator { get; set; }

    public DateTime? Pv135DeleteAccountDate { get; set; }

    public string? Pv136DischargeDisposition { get; set; }

    public string? Pv137DischargedToLocation { get; set; }

    public string? Pv138DietType { get; set; }

    public string? Pv139ServicingFacility { get; set; }

    public string? Pv140BedStatus { get; set; }

    public string? Pv141AccountStatus { get; set; }

    public string? Pv142PendingLocation { get; set; }

    public string? Pv143PriorTemporaryLocation { get; set; }

    public DateTime? Pv144AdmitDateTime { get; set; }

    public DateTime? Pv145DischargeDateTime { get; set; }

    public DateTime DateTimeInserted { get; set; }
}
