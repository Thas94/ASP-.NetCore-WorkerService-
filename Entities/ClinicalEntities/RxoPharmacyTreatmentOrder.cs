using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class RxoPharmacyTreatmentOrder
{
    public int PkRxoId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public string? Rxo11RequestedGivenCodeIdentifier { get; set; }

    public string? Rxo12RequestedGivenCodeText { get; set; }

    public string? Rxo13RequestedGivenCodeNameOfCodingSystem { get; set; }

    public string? Rxo14RequestedGivenCodeAlternateIdentifier { get; set; }

    public string? Rxo15RequestedGivenCodeAlternateText { get; set; }

    public string? Rxo16RequestedGivenCodeNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxo2RequestedGiveAmountMinimum { get; set; }

    public decimal? Rxo3RequestedGiveAmountMaximum { get; set; }

    public string? Rxo41RequestedGiveUnitsIdentifier { get; set; }

    public string? Rxo42RequestedGiveUnitsText { get; set; }

    public string? Rxo43RequestedGiveUnitsNameOfCodingSystem { get; set; }

    public string? Rxo44RequestedGiveUnitsAlternateIdentifier { get; set; }

    public string? Rxo45RequestedGiveUnitsAlternateText { get; set; }

    public string? Rxo46RequestedGiveUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxo51RequestedDosageFormIdentifier { get; set; }

    public string? Rxo52RequestedDosageFormText { get; set; }

    public string? Rxo53RequestedDosageFormNameOfCodingSystem { get; set; }

    public string? Rxo54RequestedDosageFormAlternateIdentifier { get; set; }

    public string? Rxo55RequestedDosageFormAlternateText { get; set; }

    public string? Rxo56RequestedDosageFormNameOfAlternateCodingSystem { get; set; }

    public string? Rxo61ProvidersPharmacyTreatmentInstructionsIdentifier { get; set; }

    public string? Rxo62ProvidersPharmacyTreatmentInstructionsText { get; set; }

    public string? Rxo63ProvidersPharmacyTreatmentInstructionsNameOfCodingSystem { get; set; }

    public string? Rxo64ProvidersPharmacyTreatmentInstructionsAlternateIdentifier { get; set; }

    public string? Rxo65ProvidersPharmacyTreatmentInstructionsAlternateText { get; set; }

    public string? Rxo66ProvidersPharmacyTreatmentInstructionsNameOfAlternateCodingSystem { get; set; }

    public string? Rxo71ProvidersAdministrationInstructionsIdentifier { get; set; }

    public string? Rxo72ProvidersAdministrationInstructionsText { get; set; }

    public string? Rxo73ProvidersAdministrationInstructionsNameOfCodingSystem { get; set; }

    public string? Rxo74ProvidersAdministrationInstructionsAlternateIdentifier { get; set; }

    public string? Rxo75ProvidersAdministrationInstructionsAlternateText { get; set; }

    public string? Rxo76ProvidersAdministrationInstructionsNameOfAlternateCodingSystem { get; set; }

    public string? Rxo81DeliverToLocationPointOfCare { get; set; }

    public string? Rxo82DeliverToLocationRoom { get; set; }

    public string? Rxo83DeliverToLocationBed { get; set; }

    public string? Rxo841DeliverToLocationFacilityNamespaceId { get; set; }

    public string? Rxo842DeliverToLocationFacilityUniversalId { get; set; }

    public string? Rxo843DeliverToLocationFacilityUniversalIdType { get; set; }

    public string? Rxo85DeliverToLocationLocationStatus { get; set; }

    public string? Rxo86DeliverToLocationPatientLocationType { get; set; }

    public string? Rxo87DeliverToLocationBuilding { get; set; }

    public string? Rxo88DeliverToLocationFloor { get; set; }

    public string? Rxo891DeliverToLocationAddressStreetAddress { get; set; }

    public string? Rxo892DeliverToLocationAddressOtherDesignated { get; set; }

    public string? Rxo893DeliverToLocationAddressCity { get; set; }

    public string? Rxo894DeliverToLocationAddressStateOrProvince { get; set; }

    public string? Rxo895DeliverToLocationAddressZipOrPostalCode { get; set; }

    public string? Rxo896DeliverToLocationAddressCountry { get; set; }

    public string? Rxo897DeliverToLocationAddressAddressType { get; set; }

    public string? Rxo898DeliverToLocationAddressOtherGeographicDesignation { get; set; }

    public string? Rxo9AllowSubstitutions { get; set; }

    public string? Rxo101RequestedDispenseCodeIdentifier { get; set; }

    public string? Rxo102RequestedDispenseCodeText { get; set; }

    public string? Rxo103RequestedDispenseCodeNameOfCodingSystem { get; set; }

    public string? Rxo104RequestedDispenseCodeAlternateIdentifier { get; set; }

    public string? Rxo105RequestedDispenseCodeAlternateText { get; set; }

    public string? Rxo106RequestedDispenseCodeNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxo11RequestedDispenseAmount { get; set; }

    public string? Rxo121RequestedDispenseUnitsIdentifier { get; set; }

    public string? Rxo122RequestedDispenseUnitsText { get; set; }

    public string? Rxo123RequestedDispenseUnitsNameOfCodingSystem { get; set; }

    public string? Rxo124RequestedDispenseUnitsAlternateIdentifier { get; set; }

    public string? Rxo125RequestedDispenseUnitsAlternateText { get; set; }

    public string? Rxo126RequestedDispenseUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxo13NumberOfRefills { get; set; }

    public string? Rxo141OrderingProvidersDeanumberIdNumber { get; set; }

    public string? Rxo1421OrderingProvidersDeanumberFamilyNameSurname { get; set; }

    public string? Rxo1422OrderingProvidersDeanumberFamilyNameOwnSurnamePrefix { get; set; }

    public string? Rxo1423OrderingProvidersDeanumberFamilyNameOwnSurname { get; set; }

    public string? Rxo1424OrderingProvidersDeanumberFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Rxo1425OrderingProvidersDeanumberFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Rxo143OrderingProvidersDeanumberGivenName { get; set; }

    public string? Rxo144OrderingProvidersDeanumberSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string Rxo145OrderingProvidersDeanumberSuffix { get; set; } = null!;

    public string? Rxo146OrderingProvidersDeanumberPrefix { get; set; }

    public string? Rxo147OrderingProvidersDeanumberDegree { get; set; }

    public string? Rxo148OrderingProvidersDeanumberSourceTable { get; set; }

    public string? Rxo1491OrderingProvidersDeanumberAssigningAuthorityNamespaceId { get; set; }

    public string? Rxo1492OrderingProvidersDeanumberAssigningAuthorityUniversalId { get; set; }

    public string? Rxo1493OrderingProvidersDeanumberAssigningAuthorityUniversalIdType { get; set; }

    public string? Rxo1410OrderingProvidersDeanumberNameTypeCode { get; set; }

    public string? Rxo1411OrderingProvidersDeanumberIdentifierCheckDigit { get; set; }

    public string? Rxo1412OrderingProvidersDeanumberCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Rxo1413OrderingProvidersDeanumberIdentifierTypeCode { get; set; }

    public string? Rxo14141OrderingProvidersDeanumberAssigningFacilityNamespaceId { get; set; }

    public string? Rxo14142OrderingProvidersDeanumberAssigningFacilityUniversalId { get; set; }

    public string? Rxo14143OrderingProvidersDeanumberAssigningFacilityUniversalIdType { get; set; }

    public string? Rxo1415OrderingProvidersDeanumberNameRepresentationCode { get; set; }

    public string? Rxo14161OrderingProvidersDeanumberNameContextIdentifier { get; set; }

    public string? Rxo14162OrderingProvidersDeanumberNameContextText { get; set; }

    public string? Rxo14163OrderingProvidersDeanumberNameContextNameOfCodingSystem { get; set; }

    public string? Rxo14164OrderingProvidersDeanumberNameContextAlternateIdentifier { get; set; }

    public string? Rxo14165OrderingProvidersDeanumberNameContextAlternateText { get; set; }

    public string? Rxo14166OrderingProvidersDeanumberNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Rxo14171OrderingProvidersDeanumberNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Rxo14172OrderingProvidersDeanumberNameValidityRangeRangeEndDateTime { get; set; }

    public string? Rxo1418OrderingProvidersDeanumberNameAssemblyOrder { get; set; }

    public string? Rxo151PharmacistTreatmentSuppliersVerifierIdIdNumber { get; set; }

    public string? Rxo1521PharmacistTreatmentSuppliersVerifierIdFamilyNameSurname { get; set; }

    public string? Rxo1522PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurnamePrefix { get; set; }

    public string? Rxo1523PharmacistTreatmentSuppliersVerifierIdFamilyNameOwnSurname { get; set; }

    public string? Rxo1524PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Rxo1525PharmacistTreatmentSuppliersVerifierIdFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Rxo153PharmacistTreatmentSuppliersVerifierIdGivenName { get; set; }

    public string? Rxo154PharmacistTreatmentSuppliersVerifierIdSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Rxo155PharmacistTreatmentSuppliersVerifierIdSuffix { get; set; }

    public string? Rxo156PharmacistTreatmentSuppliersVerifierIdPrefix { get; set; }

    public string? Rxo157PharmacistTreatmentSuppliersVerifierIdDegree { get; set; }

    public string? Rxo158PharmacistTreatmentSuppliersVerifierIdSourceTable { get; set; }

    public string? Rxo1591PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityNamespaceId { get; set; }

    public string? Rxo1592PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalId { get; set; }

    public string? Rxo1593PharmacistTreatmentSuppliersVerifierIdAssigningAuthorityUniversalIdType { get; set; }

    public string? Rxo1510PharmacistTreatmentSuppliersVerifierIdNameTypeCode { get; set; }

    public string? Rxo1511PharmacistTreatmentSuppliersVerifierIdIdentifierCheckDigit { get; set; }

    public string? Rxo1512PharmacistTreatmentSuppliersVerifierIdCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Rxo1513PharmacistTreatmentSuppliersVerifierIdIdentifierTypeCode { get; set; }

    public string? Rxo15141PharmacistTreatmentSuppliersVerifierIdAssigningFacilityNamespaceId { get; set; }

    public string? Rxo15142PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalId { get; set; }

    public string? Rxo15143PharmacistTreatmentSuppliersVerifierIdAssigningFacilityUniversalIdType { get; set; }

    public string? Rxo1515PharmacistTreatmentSuppliersVerifierIdNameRepresentationCode { get; set; }

    public string? Rxo15161PharmacistTreatmentSuppliersVerifierIdNameContextIdentifier { get; set; }

    public string? Rxo15162PharmacistTreatmentSuppliersVerifierIdNameContextText { get; set; }

    public string? Rxo15163PharmacistTreatmentSuppliersVerifierIdNameContextNameOfCodingSystem { get; set; }

    public string? Rxo15164PharmacistTreatmentSuppliersVerifierIdNameContextAlternateIdentifier { get; set; }

    public string? Rxo15165PharmacistTreatmentSuppliersVerifierIdNameContextAlternateText { get; set; }

    public string? Rxo15166PharmacistTreatmentSuppliersVerifierIdNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Rxo15171PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Rxo15172PharmacistTreatmentSuppliersVerifierIdNameValidityRangeRangeEndDateTime { get; set; }

    public string? Rxo1518PharmacistTreatmentSuppliersVerifierIdNameAssemblyOrder { get; set; }

    public string? Rxo16NeedsHumanReview { get; set; }

    public string? Rxo17RequestedGivePerTimeUnit { get; set; }

    public string? Rxo18RequestedGiveStrength { get; set; }

    public string? Rxo191RequestedGiveStrengthUnitsIdentifier { get; set; }

    public string? Rxo192RequestedGiveStrengthUnitsText { get; set; }

    public string? Rxo193RequestedGiveStrengthUnitsNameOfCodingSystem { get; set; }

    public string? Rxo194RequestedGiveStrengthUnitsAlternateIdentifier { get; set; }

    public string? Rxo195RequestedGiveStrengthUnitsAlternateText { get; set; }

    public string? Rxo196RequestedGiveStrengthUnitsNameOfAlternateCodingSystem { get; set; }

    public string? Rxo201IndicationIdentifier { get; set; }

    public string? Rxo202IndicationText { get; set; }

    public string? Rxo203IndicationNameOfCodingSystem { get; set; }

    public string? Rxo204IndicationAlternateIdentifier { get; set; }

    public string? Rxo205IndicationAlternateText { get; set; }

    public string? Rxo206IndicationNameOfAlternateCodingSystem { get; set; }

    public string? Rxo206Indication { get; set; }

    public string? Rxo21RequestedGiveStrengthUnits { get; set; }

    public string? Rxo221RequestedGiveRateUnitsIdentifier { get; set; }

    public string? Rxo222RequestedGiveRateUnitsText { get; set; }

    public string? Rxo223RequestedGiveRateUnitsNameOfCodingSystem { get; set; }

    public string? Rxo224RequestedGiveRateUnitsAlternateIdentifier { get; set; }

    public string? Rxo225RequestedGiveRateUnitsAlternateText { get; set; }

    public string? Rxo226RequestedGiveRateUnitsNameOfAlternateCodingSystem { get; set; }

    public decimal? Rxo231TotalDailyDoseQuantity { get; set; }

    public string? Rxo232TotalDailyDoseUnits { get; set; }

    public string? Rxo241SupplementaryCodeIdentifier { get; set; }

    public string? Rxo242SupplementaryCodeText { get; set; }

    public string? Rxo243SupplementaryCodeNameOfCodingSystem { get; set; }

    public string? Rxo244SupplementaryCodeAlternateIdentifier { get; set; }

    public string? Rxo245SupplementaryCodeAlternateText { get; set; }

    public string? Rxo246SupplementaryCodeNameOfAlternateCodingSystem { get; set; }
}
