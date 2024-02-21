using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class RxePharmacyTreatmentEncodedOrder
{
    public int PkRxeId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public string? Rxe11QuantityTimingQuantity { get; set; }

    public decimal? Rxe111QuantityTimingQuantityQuantity { get; set; }

    public string? Rxe112QuantityTimingUnits { get; set; }

    public string? Rxe121QuantityTimingIntervalRepeatPattern { get; set; }

    public string? Rxe122QuantityTimingIntervalExplicitTimeInterval { get; set; }

    public string? Rxe13QuantityTimingDuration { get; set; }

    public DateTime? Rxe141QuantityTimingStartDateTimeTimeOfAnEvent { get; set; }

    public string? Rxe142QuantityTimingStartDateTimeDegreeOfPrecision { get; set; }

    public DateTime? Rxe151QuantityTimingEndDateTimeTimeOfAnEvent { get; set; }

    public string? Rxe152QuantityTimingEndDateTimeDegreeOfPrecision { get; set; }

    public string? Rxe16QuantityTimingPriority { get; set; }

    public string? Rxe17QuantityTimingCondition { get; set; }

    public string? Rxe18QuantityTimingText { get; set; }

    public string? Rxe19QuantityTimingConjunctionComponent { get; set; }

    public string? Rxe1101QuantityTimingOrderSequencingSequenceResultsFlag { get; set; }

    public string? Rxe1102QuantityTimingOrderSequencingPlacerOrderNumberEntityIdentifier { get; set; }

    public string? Rxe1103QuantityTimingOrderSequencingPlacerOrderNumberNamespaceId { get; set; }

    public string? Rxe1104QuantityTimingOrderSequencingFillerOrderNumberEntityIdentifier { get; set; }

    public string? Rxe1105QuantityTimingOrderSequencingFillerOrderNumberNamespaceId { get; set; }

    public string? Rxe1106QuantityTimingOrderSequencingSequenceConditionValue { get; set; }

    public decimal? Rxe1107QuantityTimingOrderSequencingMaximumNumberOfRepeats { get; set; }

    public string? Rxe1108QuantityTimingOrderSequencingPlacerOrderNumberUniversalId { get; set; }

    public string? Rxe1109QuantityTimingOrderSequencingPlacerOrderNumberUniversalIdtype { get; set; }

    public string? Rxe11010QuantityTimingOrderSequencingFillerOrderNumberUniversalId { get; set; }

    public string? Rxe11011QuantityTimingOrderSequencingFillerOrderNumberUniversalIdtype { get; set; }

    public string? Rxe1111QuantityTimingOccurrenceDurationIdentifier { get; set; }

    public string? Rxe1112QuantityTimingOccurrenceDurationText { get; set; }

    public string? Rxe1113QuantityTimingOccurrenceDurationNameOfCodingSystem { get; set; }

    public string? Rxe1114QuantityTimingOccurrenceDurationAlternateIdentifier { get; set; }

    public string? Rxe1115QuantityTimingOccurrenceDurationAlternateText { get; set; }

    public string? Rxe1116QuantityTimingOccurrenceDurationNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxe112QuantityTimingTotalOccurences { get; set; }

    public string? Rxe21GivenCodeIdentifier { get; set; }

    public string? Rxe22GivenCodeText { get; set; }

    public string? Rxe23GivenCodeNameOfCodingSystem { get; set; }

    public string? Rxe24GivenCodeAlternateIdentifier { get; set; }

    public string? Rxe25GivenCodeAlternateText { get; set; }

    public string? Rxe26GivenCodeNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxe3GivenAmountMinimum { get; set; }

    public decimal? Rxe4GiveAmountMaximum { get; set; }

    public string? Rxe51GiveUnitsIdentifier { get; set; }

    public string? Rxe52GiveUnitsText { get; set; }

    public string? Rxe53GiveUnitsNameOfCodingSystem { get; set; }

    public string? Rxe54GiveUnitsAlternateIdentifier { get; set; }

    public string? Rxe55GiveUnitsAlternateText { get; set; }

    public string? Rxe56GiveUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe61GiveDosageFormIdentifier { get; set; }

    public string? Rxe62GiveDosageFormText { get; set; }

    public string? Rxe63GiveDosageFormNameOfCodingSystem { get; set; }

    public string? Rxe64GiveDosageFormAlternateIdentifier { get; set; }

    public string? Rxe65GiveDosageFormAlternateText { get; set; }

    public string? Rxe66GiveDosageFormNameOfAlternateCodingSystem { get; set; }

    public string? Rxe71ProvidersAdministrationInstructionsIdentifier { get; set; }

    public string? Rxe72ProvidersAdministrationInstructionsText { get; set; }

    public string? Rxe73ProvidersAdministrationInstructionsNameOfCodingSystem { get; set; }

    public string? Rxe74ProvidersAdministrationInstructionsAlternateIdentifier { get; set; }

    public string? Rxe75ProvidersAdministrationInstructionsAlternateText { get; set; }

    public string? Rxe76ProvidersAdministrationInstructionsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe81DeliverToLocationPointOfCare { get; set; }

    public string? Rxe82DeliverToLocationRoom { get; set; }

    public string? Rxe83DeliverToLocationBed { get; set; }

    public string? Rxe841DeliverToLocationFacilityNamespaceId { get; set; }

    public string? Rxe842DeliverToLocationFacilityUniversalId { get; set; }

    public string? Rxe843DeliverToLocationFacilityUniversalIdType { get; set; }

    public string? Rxe85DeliverToLocationLocationStatus { get; set; }

    public string? Rxe86DeliverToLocationPersonLocationType { get; set; }

    public string? Rxe87DeliverToLocationBuilding { get; set; }

    public string? Rxe88DeliverToLocationFloor { get; set; }

    public string? Rxe891DeliverToLocationAddressStreetAddress { get; set; }

    public string? Rxe892DeliverToLocationAddressOtherDesignation { get; set; }

    public string? Rxe893DeliverToLocationAddressCity { get; set; }

    public string? Rxe894DeliverToLocationAddressStateOrProcince { get; set; }

    public string? Rxe895DeliverToLocationAddressZipOrPostalCode { get; set; }

    public string? Rxe896DeliverToLocationAddressCountry { get; set; }

    public string? Rxe897DeliverToLocationAddressAddressType { get; set; }

    public string? Rxe898DeliverToLocationAddressOtherGeographicDesignation { get; set; }

    public string? Rxe9SubstitutionStatus { get; set; }

    public string? Rxe10DispenseAmount { get; set; }

    public string? Rxe111DispenseUnitsIdentifier { get; set; }

    public string? Rxe112DispenseUnitsText { get; set; }

    public string? Rxe113DispenseUnitsNameOfCodingSystem { get; set; }

    public string? Rxe114DispenseUnitsAlternateIdentifier { get; set; }

    public string? Rxe115DispenseUnitsAlternateText { get; set; }

    public string? Rxe116DispenseUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe12NumberOfRefills { get; set; }

    public string? Rxe131OrderingProvidersDeaNumberIdNumber { get; set; }

    public string? Rxe1321OrderingProvidersDeaNumberFamilyNameSurname { get; set; }

    public string? Rxe1322OrderingProvidersDeaNumberFamilyNameOwnSurnamePrefix { get; set; }

    public string? Rxe1323OrderingProvidersDeaNumberFamilyNameOwnSurname { get; set; }

    public string? Rxe1324OrderingProvidersDeaNumberFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Rxe1325OrderingProvidersDeaNumberFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Rxe133OrderingProvidersDeaNumberGivenName { get; set; }

    public string? Rxe134OrderingProvidersDeaNumberSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Rxe135OrderingProvidersDeaNumberSuffix { get; set; }

    public string? Rxe136OrderingProvidersDeaNumberPrefix { get; set; }

    public string? Rxe137OrderingProvidersDeaNumberDegree { get; set; }

    public string? Rxe138OrderingProvidersDeaNumberSourceTable { get; set; }

    public string? Rxe1391OrderingProvidersDeaNumberAssigningAuthorityNamespaceId { get; set; }

    public string? Rxe1392OrderingProvidersDeaNumberAssigningAuthorityUniversalId { get; set; }

    public string? Rxe1393OrderingProvidersDeaNumberAssigningAuthorityUniversalIdType { get; set; }

    public string? Rxe1310OrderingProvidersDeaNumberNameTypeCode { get; set; }

    public string? Rxe1311OrderingProvidersDeaNumberIdentifierCheckDigit { get; set; }

    public string? Rxe1312OrderingProvidersDeaNumberCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Rxe1313OrderingProvidersDeaNumberIdentifierTypeCode { get; set; }

    public string? Rxe13141OrderingProvidersDeaNumberAssigningFacilityNamespaceId { get; set; }

    public string? Rxe13142OrderingProvidersDeaNumberAssigningFacilityUniversalId { get; set; }

    public string? Rxe13143OrderingProvidersDeaNumberAssigningFacilityUniversalIdType { get; set; }

    public string? Rxe1315OrderingProvidersDeaNumberNameRepresentationCode { get; set; }

    public string? Rxe13161OrderingProvidersDeaNumberNameContextIdentifier { get; set; }

    public string? Rxe13162OrderingProvidersDeaNumberNameContextText { get; set; }

    public string? Rxe13163OrderingProvidersDeaNumberNameContextNameOfCodingSystem { get; set; }

    public string? Rxe13164OrderingProvidersDeaNumberNameContextAlternateIdentifier { get; set; }

    public string? Rxe13165OrderingProvidersDeaNumberNameContextAlternateText { get; set; }

    public string? Rxe13166OrderingProvidersDeaNumberNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Rxe13171OrderingProvidersDeaNumberNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Rxe13172OrderingProvidersDeaNumberNameValidityRangeRangeEndDateTime { get; set; }

    public string? Rxe1318OrderingProvidersDeaNumberNameAssemblyOrder { get; set; }

    public string? Rxe141PharmacistTreatmentSuppliersVerifierIdIdNumber { get; set; }

    public string? Rxe1421PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname { get; set; }

    public string? Rxe1422PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurnamePrefix { get; set; }

    public string? Rxe1423PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurname { get; set; }

    public string? Rxe1424PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Rxe1425PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Rxe143PharmacistTreatmentSuppliersVerifierIdGivenName { get; set; }

    public string? Rxe144PharmacistTreatmentSuppliersVerifierIdSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Rxe145PharmacistTreatmentSuppliersVerifierIdSuffix { get; set; }

    public string? Rxe146PharmacistTreatmentSuppliersVerifierIdPrefix { get; set; }

    public string? Rxe147PharmacistTreatmentSuppliersVerifierIdDegree { get; set; }

    public string? Rxe148PharmacistTreatmentSuppliersVerifierIdSourceTable { get; set; }

    public string? Rxe1491PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityNamespaceId { get; set; }

    public string? Rxe1492PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalId { get; set; }

    public string? Rxe1493PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalIdType { get; set; }

    public string? Rxe1410PharmacistTreatmentSuppliersVerifierIdnameTypeCode { get; set; }

    public string? Rxe1411PharmacistTreatmentSuppliersVerifierIdidentifierCheckDigit { get; set; }

    public string? Rxe1412PharmacistTreatmentSuppliersVerifierIdCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Rxe1413PharmacistTreatmentSuppliersVerifierIdIdentifierTypeCode { get; set; }

    public string? Rxe14141PharmacistTreatmentSuppliersVerifierIdAssigningFacilityNamespaceId { get; set; }

    public string? Rxe14142PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalId { get; set; }

    public string? Rxe14143PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalIdType { get; set; }

    public string? Rxe1415PharmacistTreatmentSuppliersVerifierIdNameRepresentationCode { get; set; }

    public string? Rxe14161PharmacistTreatmentSuppliersVerifierIdNameContextIdentifier { get; set; }

    public string? Rxe14162PharmacistTreatmentSuppliersVerifierIdNameContextText { get; set; }

    public string? Rxe14163PharmacistTreatmentSuppliersVerifierIdNameContextNameOfCodingSystem { get; set; }

    public string? Rxe14164PharmacistTreatmentSuppliersVerifierIdNameContextAlternateIdentifier { get; set; }

    public string? Rxe14165PharmacistTreatmentSuppliersVerifierIdNameContextAlternateText { get; set; }

    public string? Rxe14166PharmacistTreatmentSuppliersVerifierIdNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Rxe14171PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Rxe14172PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeEndDateTime { get; set; }

    public string? Rxe1418PharmacistTreatmentSuppliersVerifierIdNameAssemblyOrder { get; set; }

    public string? Rxe15PrescriptionNumber { get; set; }

    public string? Rxe16NumberofRefillsRemaining { get; set; }

    public string? Rxe17NumberOfRefillsDosesDispensed { get; set; }

    public DateTime? Rxe181DtofMostRecentRefillOrDoseDispensedTimeOfAnEvent { get; set; }

    public string? Rxe182DtofMostRecentRefillOrDoseDispensedDegreeOfPrecision { get; set; }

    public decimal? Rxe191TotalDailyDoseQuantity { get; set; }

    public string? Rxe192TotalDailyDoseUnits { get; set; }

    public string? Rxe20NeedsHumanReview { get; set; }

    public string? Rxe211PharmacyTreatmentSuppliersSpecialDispensingInstructionsIdentifier { get; set; }

    public string? Rxe212PharmacyTreatmentSuppliersSpecialDispensingInstructionsText { get; set; }

    public string? Rxe213PharmacyTreatmentSuppliersSpecialDispensingInstructionsNameOfCodingSystem { get; set; }

    public string? Rxe214PharmacyTreatmentSuppliersSpecialDispensingInstructionsAlternateIdentifier { get; set; }

    public string? Rxe215PharmacyTreatmentSuppliersSpecialDispensingInstructionsAlternateText { get; set; }

    public string? Rxe216PharmacyTreatmentSuppliersSpecialDispensingInstructionsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe22GivePerTimeUnits { get; set; }

    public string? Rxe23GiveRateAmount { get; set; }

    public string? Rxe241GiveRateUnitsIdentifier { get; set; }

    public string? Rxe242GiveRateUnitsText { get; set; }

    public string? Rxe243GiveRateUnitsNameOfCodingSystem { get; set; }

    public string? Rxe244GiveRateUnitsAlternateIdentifier { get; set; }

    public string? Rxe245GiveRateUnitsAlternateText { get; set; }

    public string? Rxe246GiveRateUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe25GiveStrength { get; set; }

    public string? Rxe261GiveStrengthUnitsIdentifier { get; set; }

    public string? Rxe262GiveStrengthUnitsText { get; set; }

    public string? Rxe263GiveStrengthUnitsNameOfCodingSystem { get; set; }

    public string? Rxe264GiveStrengthUnitsAlternateIdentifier { get; set; }

    public string? Rxe265GiveStrengthUnitsAlternateText { get; set; }

    public string? Rxe266GiveStrengthUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxe271GiveIndicationIdentifier { get; set; }

    public string? Rxe272GiveIndicationText { get; set; }

    public string? Rxe273GiveIndicationNameOfCodingSystem { get; set; }

    public string? Rxe274GiveIndicationAlternateIdentifier { get; set; }

    public string? Rxe275GiveIndicationAlternateText { get; set; }

    public string? Rxe276GiveIndicationNameOfAlternateCodingSystem { get; set; }

    public string? Rxe28DispensePackageSize { get; set; }

    public string? Rxe291DispensePackageSizeUnitIdentifier { get; set; }

    public string? Rxe292DispensePackageSizeUnitText { get; set; }

    public string? Rxe293DispensePackageSizeUnitNameOfCodingSystem { get; set; }

    public string? Rxe294DispensePackageSizeUnitAlternateIdentifier { get; set; }

    public string? Rxe295DispensePackageSizeUnitAlternateText { get; set; }

    public string? Rxe296DispensePackageSizeUnitNameOfAlternateCodingSystem { get; set; }

    public string? Rxe30DispensePackageMethod { get; set; }

    public string? Rxe311SupplementaryCodeIdenntifier { get; set; }

    public string? Rxe312SupplementaryCodeText { get; set; }

    public string? Rxe313SupplementaryCodeNameOfCodingSystem { get; set; }

    public string? Rxe314SupplementaryCodeAlternateIdentifier { get; set; }

    public string? Rxe315SupplementaryCodeAlternateText { get; set; }

    public string? Rxe316SupplementaryCodeNameOfAlternateCodingSystem { get; set; }

    public long? Hl7personLogId { get; set; }
}
