using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class OrcCommonOrder
{
    public int PkOrcId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public int? OrderObservationCounter { get; set; }

    public string? Orc1OrderControl { get; set; }

    public string? Orc2PlacerOrderNumber1EntityIdentifier { get; set; }

    public string? Orc2PlacerOrderNumber2NamespaceId { get; set; }

    public string? Orc2PlacerOrderNumber3UniversalId { get; set; }

    public string? Orc2PlacerOrderNumber4UniversalIdType { get; set; }

    public string? Orc3FillerOrderNumber1EntityIdentifier { get; set; }

    public string? Orc3FillerOrderNumber2NamespaceId { get; set; }

    public string? Orc3FillerOrderNumber3UniversalId { get; set; }

    public string? Orc3FillerOrderNumber4UniversalIdType { get; set; }

    public string? Orc4PlacerGroupNumber1EntityIdentifier { get; set; }

    public string? Orc4PlacerGroupNumber2NamespaceId { get; set; }

    public string? Orc4PlacerGroupNumber3UniversalId { get; set; }

    public string? Orc4PlacerGroupNumber4UniversalIdType { get; set; }

    public string? Orc5OrderStatus { get; set; }

    public string? Orc6ResponseFlag { get; set; }

    public string? Orc7QuantityTiming1Quantity1Quantity { get; set; }

    public string? Orc7QuantityTiming1Quantity2Units { get; set; }

    public string? Orc7QuantityTiming2Interval1 { get; set; }

    public string? Orc7QuantityTiming2Interval2 { get; set; }

    public string? Orc7QuantityTiming3Duration { get; set; }

    public string? Orc7QuantityTiming4StartDateTime1TimeOfEvent { get; set; }

    public string? Orc7QuantityTiming4StartDateTime2DegreeOfPrecision { get; set; }

    public string? Orc7QuantityTiming5EndDateTime1TimeOfEvent { get; set; }

    public string? Orc7QuantityTiming5EndDateTime2DegreeOfPrecision { get; set; }

    public string? Orc7QuantityTiming6Priority { get; set; }

    public string? Orc7QuantityTiming7Condition { get; set; }

    public string? Orc7QuantityTiming8Text { get; set; }

    public string? Orc7QuantityTiming9ConjuctionComponent { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing1SequenceResultsFlag { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing2PlacerOrderNumberEntityIdentifier { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing3PlacerOrderNumberNamespaceId { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing4FillerOrderNumberEntityIdentifier { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing5FillerOrderNumberNamespaceId { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing6SequenceConditionValue { get; set; }

    public decimal? Orc7QuantityTiming10OrderSequencing7MaximumNumberOfRepeats { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing8PlacerOrderNumberUniversalId { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing9PlacerOrderNumberUniversalIdtype { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing10FillerOrderNumberUniversalId { get; set; }

    public string? Orc7QuantityTiming10OrderSequencing11FillerOrderNumberUniversalIdtype { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration1Identifier { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration2Text { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration3NameOfCodingSystem { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration4AlternateIdentifier { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration5AlternateText { get; set; }

    public string? Orc7QuantityTiming11OccurenceDuration6NameOfAlternateCodingSystem { get; set; }

    public decimal? Orc7QuantityTiming12TotalOccurences { get; set; }

    public string? Orc811ParentOrderPlacerOrderNumberEntityIdentifier { get; set; }

    public string? Orc812ParentOrderPlacerOrderNumberNamespaceId { get; set; }

    public string? Orc813ParentOrderPlacerOrderNumberUniversalId { get; set; }

    public string? Orc814ParentOrderPlacerOrderNumberUniversalIdType { get; set; }

    public string? Orc821ParentOrderFillerOrderNumberEntityIdentifier { get; set; }

    public string? Orc822ParentOrderFillerOrderNumberNamespaceId { get; set; }

    public string? Orc823ParentOrderFillerOrderNumberUniversalId { get; set; }

    public string? Orc824ParentOrderFillerOrderNumberUniversalIdType { get; set; }

    public string? Orc9DateTimeTransaction1TimeOfAnEvent { get; set; }

    public string? Orc9DateTimeTransaction2DegreeOfPrecision { get; set; }

    public string? Orc101EnteredByIdNumber { get; set; }

    public string? Orc1021EnteredByFamilyNameSurname { get; set; }

    public string? Orc1022EnteredByFamilyNameOwnSurnamePrefix { get; set; }

    public string? Orc1023EnteredByFamilyNameOwnSurname { get; set; }

    public string? Orc1024EnteredByFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Orc1025EnteredByFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Orc103EnteredByGivenName { get; set; }

    public string? Orc104EnteredBySecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Orc105EnteredBySuffix { get; set; }

    public string? Orc106EnteredByPrefix { get; set; }

    public string? Orc107EnteredByDegree { get; set; }

    public string? Orc108EnteredBySourceTable { get; set; }

    public string? Orc1091EnteredByNamespaceId { get; set; }

    public string? Orc1092EnteredByUniversalId { get; set; }

    public string? Orc1093EnteredByUniversalIdType { get; set; }

    public string? Orc1010EnteredByNameTypeCode { get; set; }

    public string? Orc1011EnteredByIdentifierCheckDigit { get; set; }

    public string? Orc1012EnteredByCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Orc1013EnteredByIdentifierTypeCode { get; set; }

    public string? Orc10141EnteredByNamespaceId { get; set; }

    public string? Orc10142EnteredByUniversalId { get; set; }

    public string? Orc10143EnteredByUniversalIdType { get; set; }

    public string? Orc1015EnteredByNameRepresentationCode { get; set; }

    public string? Orc10161EnteredByIdentifier { get; set; }

    public string? Orc10162EnteredByText { get; set; }

    public string? Orc10163EnteredByNameOfCodingSystem { get; set; }

    public string? Orc10164EnteredByIdentifierAlternateIdentifier { get; set; }

    public string? Orc10165EnteredByIdentifierAlternateText { get; set; }

    public string? Orc10166EnteredByIdentifierNameOfAlternateCodingSystem { get; set; }

    public DateTime? Orc10171EnteredByRangeStartDateTime { get; set; }

    public DateTime? Orc10172EnteredByRangeEndDateTime { get; set; }

    public string? Orc1018EnteredByNameAssemblyorder { get; set; }

    public string? Orc11VerifiedBy { get; set; }

    public string? Orc121OrderingProviderIdNumber { get; set; }

    public string? Orc1221OrderingProviderFamilyNameSurname { get; set; }

    public string? Orc1222OrderingProviderFamilyNameOwnSurnamePrefix { get; set; }

    public string? Orc1223OrderingProviderFamilyNameOwnSurname { get; set; }

    public string? Orc1224OrderingProviderFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Orc1225OrderingProviderFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Orc123OrderingProviderGivenName { get; set; }

    public string? Orc124OrderingProviderSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Orc125OrderingProviderSuffix { get; set; }

    public string? Orc126OrderingProviderPrefix { get; set; }

    public string? Orc127OrderingProviderDegree { get; set; }

    public string? Orc128OrderingProviderSourceTable { get; set; }

    public string? Orc1291OrderingProviderAssigningAuthorityNamespaceId { get; set; }

    public string? Orc1292OrderingProviderAssigningAuthorityUniversalId { get; set; }

    public string? Orc1293OrderingProviderAssigningAuthorityUniversalIdType { get; set; }

    public string? Orc1210OrderingProviderNameTypeCode { get; set; }

    public string? Orc1211OrderingProviderIdentifierCheckDigit { get; set; }

    public string? Orc1212OrderingProviderCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Orc1213OrderingProviderIdentifierTypeCode { get; set; }

    public string? Orc12141OrderingProviderAssigningFacilityNamespaceId { get; set; }

    public string? Orc12142OrderingProviderAssigningFacilityUniversalId { get; set; }

    public string? Orc12143OrderingProviderAssigningFacilityUniverslIdType { get; set; }

    public string? Orc1215NameRepresentationCode { get; set; }

    public string? Orc12161OrderingProviderNameContextIdentifier { get; set; }

    public string? Orc12162OrderingProviderNameContextText { get; set; }

    public string? Orc12163OrderingProviderNameContextNameOfCodingSystem { get; set; }

    public string? Orc12164OrderingProviderNameContextAlternateIdentifier { get; set; }

    public string? Orc12165OrderingProviderNameContextAlternateText { get; set; }

    public string? Orc12166OrderingProviderNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Orc12171OrderingProviderNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Orc12172OrderingProviderNameValidityRangeRangeEndDateTime { get; set; }

    public string? Orc1218OrderingProviderNameAssemblyOrder { get; set; }

    public string? Orc131EnterersLocationPointOfCare { get; set; }

    public string? Orc132EnterersLocationRoom { get; set; }

    public string? Orc133EnterersLocationBed { get; set; }

    public string? Orc1341EnterersLocationFacilityNamespaceId { get; set; }

    public string? Orc1342EnterersLocationFacilityUniversalId { get; set; }

    public string? Orc1343EnterersLocationFacilityUniversalIdType { get; set; }

    public string? Orc135EnterersLocationLocationStatus { get; set; }

    public string? Orc136EnterersLocationPersonLocationType { get; set; }

    public string? Orc137EnterersLocationBuilding { get; set; }

    public string? Orc138EnterersLocationFloor { get; set; }

    public string? Orc139EnterersLocationLocationDescription { get; set; }

    public string? Orc141CallBackPhoneNumberTelephoneNumber { get; set; }

    public string? Orc142CallBackPhoneNumberTelecommunicationUseCode { get; set; }

    public string? Orc143CallBackPhoneNumberTelecommunicationEquipmentType { get; set; }

    public string? Orc144CallBackPhoneNumberEmailAddress { get; set; }

    public string? Orc145CallBackPhoneNumberCountryCode { get; set; }

    public string? Orc146CallBackPhoneNumberAreaCityCode { get; set; }

    public string? Orc147CallBackPhoneNumberPhoneNumber { get; set; }

    public string? Orc148CallBackPhoneNumberExtension { get; set; }

    public string? Orc149CallBackPhoneNumberAnyText { get; set; }

    public string? Orc151OrderEffectiveDateTimeTimeOfAnEvent { get; set; }

    public string? Orc152OrderEffectiveDateTimeDegreeOfPrecision { get; set; }

    public string? Orc16OrderControlCodeReason { get; set; }

    public string? Orc17EnteringOrganization { get; set; }

    public string? Orc18EnteringDevice { get; set; }

    public string? Orc19ActionBy { get; set; }

    public string? Orc20AdvancedBeneficiaryNoticeCode { get; set; }

    public string? Orc21OrderingFacilityName { get; set; }

    public string? Orc22OrderingFacilityAddress { get; set; }

    public string? Orc23OrderingFacilityPhoneNumber { get; set; }

    public string? Orc241OrderingProviderAddressStreetAddress { get; set; }

    public string? Orc242OrderingProviderAddressOtherDesignation { get; set; }

    public string? Orc243OrderingProviderAddressCity { get; set; }

    public string? Orc244OrderingProviderAddressStateOrProvince { get; set; }

    public string? Orc245OrderingProviderAddressZipOrPostalCode { get; set; }

    public string? Orc246OrderingProviderAddressCountry { get; set; }

    public string? Orc247OrderingProviderAddressAddressType { get; set; }

    public string? Orc248OrderingProviderAddressOtherGeographicDesignation { get; set; }

    public string? Orc249OrderingProviderAddressCountyParishCode { get; set; }

    public string? Orc2410OrderingProviderAddressCensusTract { get; set; }

    public string? Orc2411OrderingProviderAddressAddressRepresentationCode { get; set; }

    public string? Orc2411OrderingProviderAddressAddressValidityRange { get; set; }

    public string? Orc25OrderStatusModifier { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public virtual ICollection<ObrObservationRequest> ObrObservationRequests { get; set; } = new List<ObrObservationRequest>();
}
