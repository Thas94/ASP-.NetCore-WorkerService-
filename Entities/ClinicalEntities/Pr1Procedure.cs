using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class Pr1Procedure
{
    public int Pr1Id { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Pr11SetIdPr1 { get; set; }

    public string? Pr12ProcedureCodingMethod { get; set; }

    public string? Pr131ProcedureCodeIdentifier { get; set; }

    public string? Pr132ProcedureCodeText { get; set; }

    public string? Pr132ProcedureCodeNameOfCodingSystem { get; set; }

    public string? Pr14ProcedureDescription { get; set; }

    public string? Pr15ProcedureDateTime { get; set; }

    public string? Pr16ProcedureFunctionalType { get; set; }

    public string? Pr17ProcedureMinutes { get; set; }

    public string? Pr181AnesthesiologistIdNumber { get; set; }

    public string? Pr182AnesthesiologistFamilyName { get; set; }

    public string? Pr183AnesthesiologistGivenName { get; set; }

    public string? Pr184AnesthesiologistSecondAndGivenNames { get; set; }

    public string? Pr185AnesthesiologistSuffix { get; set; }

    public string? Pr186AnesthesiologistPrefix { get; set; }

    public string? Pr187AnesthesiologistDegree { get; set; }

    public string? Pr188AnesthesiologistSourceTable { get; set; }

    public string? Pr189AnesthesiologistAssigningAuthority { get; set; }

    public string? Pr1810AnesthesiologistNameTypeCode { get; set; }

    public string? Pr1811AnesthesiologistIdentifierCheckDigit { get; set; }

    public string? Pr1812AnesthesiologistDigitSchemeEmployed { get; set; }

    public string? Pr1813AnesthesiologistIdentifierTypeCode { get; set; }

    public string? Pr19AnesthesiaCode { get; set; }

    public string? Pr110AnesthesiaMinutes { get; set; }

    public string? Pr1111SurgeonIdNumber { get; set; }

    public string? Pr1112SurgeonFamilyName { get; set; }

    public string? Pr1113SurgeonGivenName { get; set; }

    public string? Pr1114SurgeonSecondAndFurtherGivenNames { get; set; }

    public string? Pr1115SurgeonSuffix { get; set; }

    public string? Pr1116SurgeonPrefix { get; set; }

    public string? Pr1117SurgeonDegree { get; set; }

    public string? Pr1118SurgeonSourceTable { get; set; }

    public string? Pr1119SurgeonAssigningAuthority { get; set; }

    public string? Pr11110SurgeonNameTypeCode { get; set; }

    public string? Pr11111SurgeonIdentifierCheckDigit { get; set; }

    public string? Pr11112SurgeonDigitSchemeEmployed { get; set; }

    public string? Pr11113SurgeonIdentifierTypeCode { get; set; }

    public string? Pr112ProcedurePractitioner { get; set; }

    public string? Pr113ConsentCode { get; set; }

    public string? Pr114ProcedurePriority { get; set; }

    public string? Pr115AssociatedDiagnosisCode { get; set; }

    public string? Pr116ProcedureCodeModifier { get; set; }

    public string? Pr117ProcedureDrgType { get; set; }

    public string? Pr118TissueTypeCode { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public long? Hl7personLogIdcurrentLocation { get; set; }
}
