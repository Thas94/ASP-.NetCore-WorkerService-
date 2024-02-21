using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ImtabxauditDetail
{
    public int AbxauditDetailId { get; set; }

    public int AbxauditId { get; set; }

    public string? Rxe22GivenCodeText { get; set; }

    public string? Rxe24GivenCodeAlternateIdentifier { get; set; }

    public string? Rxe3GivenAmountMinimum { get; set; }

    public string? Rxe4GiveAmountMaximum { get; set; }

    public string? Rxe51GiveUnitsIdentifier { get; set; }

    public string? Rxe61GiveDosageFormIdentifier { get; set; }

    public string? Rxe71ProvidersAdministrationInstructionsIdentifier { get; set; }

    public string? Rxe81DeliverToLocationPointOfCare { get; set; }

    public string? Rxe12NumberOfRefills { get; set; }

    public string? Rxe131OrderingProvidersDeaNumberIdNumber { get; set; }

    public string? Rxe141PharmacistTreatmentSuppliersVerifierIdIdNumber { get; set; }

    public string? Rxe1421PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname { get; set; }

    public string? Rxe143PharmacistTreatmentSuppliersVerifierIdGivenName { get; set; }

    public string? Rxe15PrescriptionNumber { get; set; }

    public string? Rxe141QuantityTimingStartDateTimeTimeOfAnEvent { get; set; }

    public string? Rxe151QuantityTimingEndDateTimeTimeOfAnEvent { get; set; }

    public string? AtcproductDescription { get; set; }

    public string? Rxe21GivenCodeIdentifier { get; set; }

    public virtual ImtabxauditHeader Abxaudit { get; set; } = null!;
}
