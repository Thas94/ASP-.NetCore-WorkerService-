using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class RxcPharmacyTreatmentComponentOrder
{
    public int PkRxcId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Rxc1RxcomponentType { get; set; }

    public string? Rxc2ComponentCode { get; set; }

    public string? Rxc21ComponentCodeIdentifier { get; set; }

    public string? Rxc22ComponentCodeText { get; set; }

    public string? Rxc23ComponentCodeNameOfCodingSystem { get; set; }

    public string? Rxc24ComponentCodeAlternateIdentifier { get; set; }

    public string? Rxc25ComponentCodeAlternateText { get; set; }

    public string? Rxc26ComponentCodeNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxc3ComponentAmount { get; set; }

    public string? Rxc4ComponentUnits { get; set; }

    public string? Rxc41ComponentUnitsIdentifier { get; set; }

    public string? Rxc42ComponentUnitsText { get; set; }

    public string? Rxc43ComponentUnitsNameOfCodingSystem { get; set; }

    public string? Rxc44ComponentUnitsAlternateIdentifier { get; set; }

    public string? Rxc45ComponentUnitsAlternateText { get; set; }

    public string? Rxc46ComponentUnitsNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxc5ComponentStrength { get; set; }

    public string? Rxc6ComponentStrengthUnits { get; set; }

    public string? Rxc61ComponentStrengthUnitsIdentifier { get; set; }

    public string? Rxc62ComponentStrengthUnitsText { get; set; }

    public string? Rxc63ComponentStrengthUnitsNameOfCodingSystem { get; set; }

    public string? Rxc64ComponentStrengthUnitsAlternateIdentifier { get; set; }

    public string? Rxc65ComponentStrengthUnitsAlternateText { get; set; }

    public string? Rxc66ComponentStrengthUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxc7SupplementaryCode { get; set; }

    public string? Rxc71SupplementaryCodeIdentifier { get; set; }

    public string? Rxc72SupplementaryCodeText { get; set; }

    public string? Rxc73SupplementaryCodeNameOfCodingSystem { get; set; }

    public string? Rxc74SupplementaryCodeAlternateIdentifier { get; set; }

    public string? Rxc75SupplementaryCodeAlternateText { get; set; }

    public string? Rxc76SupplementaryCodeNameOfAlternateCodingSystem { get; set; }
}
