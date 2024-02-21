using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ObrObservationRequest
{
    public int PkObrId { get; set; }

    public int FkOrcId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public int? InsertOrder { get; set; }

    public string? Obr1SetIdObr { get; set; }

    public string? Obr21PlacerOrderNumberEntityIdentifier { get; set; }

    public string? Obr22PlacerOrderNumberNamespaceId { get; set; }

    public string? Obr23PlacerOrderNumberUniversalId { get; set; }

    public string? Obr24PlacerOrderNumberUniversalIdType { get; set; }

    public string? Obr31FillerOrderNumberEntityIdentifier { get; set; }

    public string? Obr32FillerOrderNumberNamespaceId { get; set; }

    public string? Obr33FillerOrderNumberUniversalId { get; set; }

    public string? Obr34FillerOrderNumberUniversalIdType { get; set; }

    public string? Obr41UniversalServiceDentifierIdentifier { get; set; }

    public string? Obr42UniversalServiceIdentifierText { get; set; }

    public string? Obr43UniversalServiceIdentifierNameOfCodingSystem { get; set; }

    public string? Obr44UniversalServiceIdentifierAlternateIdentifier { get; set; }

    public string? Obr45UniversalServiceIdentifierAlternateText { get; set; }

    public string? Obr46UniversalServiceIdentifierNameOfAlternateCodingSystem { get; set; }

    public string? Obr5Priority { get; set; }

    public string? Obr61RequestedDateTimeTimeOfEvent { get; set; }

    public string? Obr62RequestedDateTimeDegreeOfPrecision { get; set; }

    public string? Obr71ObservationDateTimeTimeOfEvent { get; set; }

    public string? Obr72ObservationDateTimeDegreeOfPrecision { get; set; }

    public string? Obr81ObservationEndDateTimeTimeOfEvent { get; set; }

    public string? Obr82ObservationEndDateTimeDegreeOfPrecision { get; set; }

    public string? Obr91CollectionVolumeQuantity { get; set; }

    public string? Obr92CollectionVolumeUnits { get; set; }

    public string? Obr101CollectorIdentifierIdNumber { get; set; }

    public string? Obr1021CollectorIdentifierFamilyNameSurname { get; set; }

    public string? Obr1022CollectorIdentifierFamilyNameOwnSurnamePrefix { get; set; }

    public string? Obr1023CollectorIdentifierFamilyNameOwnSurname { get; set; }

    public string? Obr1024CollectorIdentifierFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Obr1025CollectorIdentifierFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Obr103CollectorIdentifierGivenName { get; set; }

    public string? Obr104CollectorIdentifierSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr105CollectorIdentifierSuffix { get; set; }

    public string? Obr106CollectorIdentifierPrefix { get; set; }

    public string? Obr107CollectorIdentifierDegree { get; set; }

    public string? Obr108CollectorIdentifierSourceTable { get; set; }

    public string? Obr1091CollectorIdentifierAssigningAuthorityNamespaceId { get; set; }

    public string? Obr1092CollectorIdentifierAssigningAuthorityUniversalId { get; set; }

    public string? Obr1093CollectorIdentifierAssigningAuthorityUniversalIdType { get; set; }

    public string? Obr1010CollectorIdentifierNameTypeCode { get; set; }

    public string? Obr1011CollectorIdentifierIdentifierCheckDigit { get; set; }

    public string? Obr1012CollectorIdentifierCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Obr1013CollectorIdentifierIdentifierTypeCode { get; set; }

    public string? Obr10141CollectorIdentifierAssigningFacilityNamespaceId { get; set; }

    public string? Obr10142CollectorIdentifierAssigningFacilityUniversalId { get; set; }

    public string? Obr10143CollectorIdentifierAssigningFacilityUniversalIdType { get; set; }

    public string? Obr1015CollectorIdentifierNameRepresentationCode { get; set; }

    public string? Obr10161CollectorIdentifierNameContextIdentifier { get; set; }

    public string? Obr10162CollectorIdentifierNameContextText { get; set; }

    public string? Obr10163CollectorIdentifierNameContextNameOfCodingSystem { get; set; }

    public string? Obr10164CollectorIdentifierNameContextAlternateIdentifier { get; set; }

    public string? Obr10165CollectorIdentifierNameContextAlternateText { get; set; }

    public string? Obr10166CollectorIdentifierNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Obr10171CollectorIdentifierNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Obr10172CollectorIdentifierNameValidityRangeRangeEndDateTime { get; set; }

    public string? Obr1018CollectorIdentifierNameAssemblyOrder { get; set; }

    public string? Obr11SpecimenActionCode { get; set; }

    public string? Obr121DangerCodeIdentifier { get; set; }

    public string? Obr122DangerCodeText { get; set; }

    public string? Obr123DangerCodeNameOfCodingSystem { get; set; }

    public string? Obr124DangerCodeAlternateIdentifier { get; set; }

    public string? Obr125DangerCodeAlternateText { get; set; }

    public string? Obr126DangerCodeNameOfAlternateCodingSystem { get; set; }

    public string? Obr13RelevantClinicalInfo { get; set; }

    public DateTime? Obr141SpecimenReceivedDateTimeTimeOfEvent { get; set; }

    public string? Obr142SpecimenReceivedDateTimeDegreeOfPrecision { get; set; }

    public string? Obr1511SpecimenSourceSpecimenSourceNameOrCodeIdentifier { get; set; }

    public string? Obr1512SpecimenSourceSpecimenSourceNameOrCodeText { get; set; }

    public string? Obr1513SpecimenSourceSpecimenSourceNameOrCodeNameOfCodingSystem { get; set; }

    public string? Obr1514SpecimenSourceSpecimenSourceNameOrCodeAlternateIdentifier { get; set; }

    public string? Obr1515SpecimenSourceSpecimenSourceNameOrCodeAlternateText { get; set; }

    public string? Obr1516SpecimenSourceSpecimenSourceNameOrCodeNameOfAlternateCodingSystem { get; set; }

    public string? Obr152SpecimenSourceAdditives { get; set; }

    public string? Obr153SpecimenSourceFreetext { get; set; }

    public string? Obr1541SpecimenSourceBodySiteIdentifier { get; set; }

    public string? Obr1542SpecimenSourceBodySiteText { get; set; }

    public string? Obr1543SpecimenSourceBodySiteNameOfCodingSystem { get; set; }

    public string? Obr1544SpecimenSourceBodySiteAlternateIdentifier { get; set; }

    public string? Obr1545SpecimenSourceBodySiteAlternateText { get; set; }

    public string? Obr1546SpecimenSourceBodySiteNameOfAlternateCodingSystem { get; set; }

    public string? Obr1551SpecimenSourceSiteModifierIdentifier { get; set; }

    public string? Obr1552SpecimenSourceSiteModifierText { get; set; }

    public string? Obr1553SpecimenSourceSiteModifierNameOfCodingSystem { get; set; }

    public string? Obr1554SpecimenSourceSiteModifierAlternateIdentifier { get; set; }

    public string? Obr1555SpecimenSourceSiteModifierAlternateText { get; set; }

    public string? Obr1556SpecimenSourceSiteModifierNameOfAlternateCodingSystem { get; set; }

    public string? Obr156SpecimenSourceCollectionModifierMethodCode { get; set; }

    public string? Obr1571SpecimenSourceSpecimenRoleIdentifier { get; set; }

    public string? Obr1572SpecimenSourceSpecimenRoleText { get; set; }

    public string? Obr1573SpecimenSourceSpecimenRoleNameOfCodingSystem { get; set; }

    public string? Obr1574SpecimenSourceSpecimenRoleAlternateIdentifier { get; set; }

    public string? Obr1575SpecimenSourceSpecimenRoleAlternateText { get; set; }

    public string? Obr1576SpecimenSourceSpecimenRoleNameOfAlternateCodingSystem { get; set; }

    public string? Obr161OrderingProviderIdNumber { get; set; }

    public string? Obr1621OrderingProviderFamilyNameSurname { get; set; }

    public string? Obr1622OrderingProviderFamilyNameOwnSurnamePrefix { get; set; }

    public string? Obr1623OrderingProviderFamilyNameOwnSurname { get; set; }

    public string? Obr1624OrderingProviderFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Obr1625OrderingProviderFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Obr163OrderingProviderGivenName { get; set; }

    public string? Obr164OrderingProviderSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr165OrderingProviderSuffix { get; set; }

    public string? Obr166OrderingProviderPrefix { get; set; }

    public string? Obr167OrderingProviderDegree { get; set; }

    public string? Obr168OrderingProviderSourceTable { get; set; }

    public string? Obr1691OrderingProviderAssigningAuthorityNamespaceId { get; set; }

    public string? Obr1692OrderingProviderAssigningAuthorityUniversalId { get; set; }

    public string? Obr1693OrderingProviderAssigningAuthorityUniversalIdType { get; set; }

    public string? Obr1610OrderingProviderNameTypeCode { get; set; }

    public string? Obr1611OrderingProviderIdentifierCheckDigit { get; set; }

    public string? Obr1612OrderingProviderCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Obr1613OrderingProviderIdentifierTypeCode { get; set; }

    public string? Obr16141OrderingProviderAssigningFacilityNamespaceId { get; set; }

    public string? Obr16142OrderingProviderAssigningFacilityUniversalId { get; set; }

    public string? Obr16143OrderingProviderAssigningFacilityUniversalIdType { get; set; }

    public string? Obr1615OrderingProviderNameRepresentationCode { get; set; }

    public string? Obr16161OrderingProviderNameContextIdentifier { get; set; }

    public string? Obr16162OrderingProviderNameContextText { get; set; }

    public string? Obr16163OrderingProviderNameContextNameOfCodingSystem { get; set; }

    public string? Obr16164OrderingProviderNameContextAlternateIdentifier { get; set; }

    public string? Obr16165OrderingProviderNameContextAlternateText { get; set; }

    public string? Obr16166OrderingProviderNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Obr16171OrderingProviderNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Obr16172OrderingProviderNameValidityRangeRangeEndDateTime { get; set; }

    public string? Obr1618OrderingProviderNameAssemblyOrder { get; set; }

    public string? Obr171OrderCallbackPhoneNumberTelephoneNumber { get; set; }

    public string? Obr172OrderCallbackPhoneNumberTelecommunicationUseCode { get; set; }

    public string? Obr173OrderCallbackPhoneNumberTelecommunicationEquipmentType { get; set; }

    public string? Obr174OrderCallbackPhoneNumberEmailAddress { get; set; }

    public string? Obr175OrderCallbackPhoneNumberCountryCode { get; set; }

    public string? Obr176OrderCallbackPhoneNumberAreaCityCode { get; set; }

    public string? Obr177OrderCallbackPhoneNumberPhoneNumber { get; set; }

    public string? Obr178OrderCallbackPhoneNumberExtension { get; set; }

    public string? Obr179OrderCallbackPhoneNumberAnyText { get; set; }

    public string? Obr18PlacerField1 { get; set; }

    public string? Obr19PlacerField2 { get; set; }

    public string? Obr20FillerField1 { get; set; }

    public string? Obr21FillerField2 { get; set; }

    public string? Obr221ResultsRptStatusChngDateTimeOfAnEvent { get; set; }

    public string? Obr222ResultsRptStatusChngDateTimeDegreeOfPrecision { get; set; }

    public decimal? Obr2311ChargetoPracticeMocDollarAmountQuantity { get; set; }

    public string? Obr2312ChargetoPracticeMocDollarAmountDenomination { get; set; }

    public string? Obr2321ChargetoPracticeMocChargeCodeIdentifier { get; set; }

    public string? Obr2322ChargetoPracticeMocChargeCodeText { get; set; }

    public string? Obr2323ChargetoPracticeMocChargeCodeNameOfCodingSystem { get; set; }

    public string? Obr2324ChargetoPracticeMocChargeCodeAlternateIdentifier { get; set; }

    public string? Obr2325ChargetoPracticeMocChargeCodeAlternateText { get; set; }

    public string? Obr2326ChargetoPracticeMocChargeCodeNameOfAlternateCodingSystem { get; set; }

    public string? Obr24DiagnosticServSectId { get; set; }

    public string? Obr25ResultStatus { get; set; }

    public string? Obr2611ParentResultObx3observationIdentifierOfParentResultIdentifier { get; set; }

    public string? Obr2612ParentResultObx3observationIdentifierOfParentResultText { get; set; }

    public string? Obr2613ParentResultObx3observationIdentifierOfParentResultNameOfCodingSystem { get; set; }

    public string? Obr2614ParentResultObx3observationIdentifierOfParentResultAlternateIdentifier { get; set; }

    public string? Obr2615ParentResultObx3observationIdentifierOfParentResultAlternateText { get; set; }

    public string? Obr2616ParentResultObx3observationIdentifierOfParentResultNameOfAlternateCodingSystem { get; set; }

    public string? Obr262ParentResultObx4subIdofParentResult { get; set; }

    public string? Obr263ParentResultPartOfObx5observationResultFromParent { get; set; }

    public decimal? Obr2711QuantityTimingQuantityQuantity { get; set; }

    public string? Obr2712QuantityTimingQuantityUnits { get; set; }

    public string? Obr2721QuantityTimingIntervalRepeatPattern { get; set; }

    public string? Obr2722QuantityTimingIntervalExplicitTimeInterval { get; set; }

    public string? Obr273QuantityTimingDuration { get; set; }

    public DateTime? Obr274QuantityTimingStartDatetime { get; set; }

    public DateTime? Obr275QuantityTimingEndDatetime { get; set; }

    public string? Obr276QuantityTimingPriority { get; set; }

    public string? Obr277QuantityTimingCondition { get; set; }

    public string? Obr278QuantityTimingText { get; set; }

    public string? Obr279QuantityTimingConjunctionComponent { get; set; }

    public string? Obr27101QuantityTimingOrderSequencingSequenceResultsFlag { get; set; }

    public string? Obr27102QuantityTimingOrderSequencingPlaceOrderNumberEntityIdentifier { get; set; }

    public string? Obr27103QuantityTimingOrderSequencingPlaceOrderNumberNamespaceId { get; set; }

    public string? Obr27104QuantityTimingOrderSequencingFillerOrderNumberEntityIdentifier { get; set; }

    public string? Obr27105QuantityTimingOrderSequencingFillerOrderNumberNamespaceId { get; set; }

    public string? Obr27106QuantityTimingOrderSequencingSequenceConditionValue { get; set; }

    public string? Obr27107QuantityTimingOrderSequencingMaximumNumberOfRepeats { get; set; }

    public string? Obr27108QuantityTimingOrderSequencingPlaceOrderNumberUniversalId { get; set; }

    public string? Obr27109QuantityTimingOrderSequencingPlaceOrderNumberUniversalIdType { get; set; }

    public string? Obr271010QuantityTimingOrderSequencingFillerOrderNumberUniversalId { get; set; }

    public string? Obr271011QuantityTimingOrderSequencingFillerOrderNumberUniversaldType { get; set; }

    public string? Obr27111QuantityTimingOccurrenceDurationIdentifier { get; set; }

    public string? Obr27112QuantityTimingOccurrenceDurationText { get; set; }

    public string? Obr27113QuantityTimingOccurrenceDurationNameOfCodingSystem { get; set; }

    public string? Obr27114QuantityTimingOccurrenceDurationIdentifierAlternateIdentifier { get; set; }

    public string? Obr27115QuantityTimingOccurrenceDurationIdentifierAlternateText { get; set; }

    public string? Obr27116QuantityTimingOccurrenceDurationIdentifierNameOfAlternateCodingSystem { get; set; }

    public decimal? Obr2712QuantityTimingTotalOccurences { get; set; }

    public string? Obr281ResultCopiesToIdNumber { get; set; }

    public string? Obr2821ResultCopiesToFamilyNameSurname { get; set; }

    public string? Obr2822ResultCopiesToFamilyNameOwnSurnamePrefix { get; set; }

    public string? Obr2823ResultCopiesToFamilyNameOwnSurname { get; set; }

    public string? Obr2824ResultCopiesToFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Obr2825ResultCopiesToFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Obr283ResultCopiesToGivenName { get; set; }

    public string? Obr284ResultCopiesToSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr285ResultCopiesToSuffix { get; set; }

    public string? Obr286ResultCopiesToPrefix { get; set; }

    public string? Obr287ResultCopiesToDegree { get; set; }

    public string? Obr288ResultCopiesToSourceTable { get; set; }

    public string? Obr2891ResultCopiesToAssigningAuthorityNamespaceId { get; set; }

    public string? Obr2892ResultCopiesToAssigningAuthorityUniversalId { get; set; }

    public string? Obr2893ResultCopiesToAssigningAuthorityUniversalIdType { get; set; }

    public string? Obr2810ResultCopiesToNameTypeCode { get; set; }

    public string? Obr2811ResultCopiesToIdentifierCheckDigit { get; set; }

    public string? Obr2812ResultCopiesToCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Obr2813ResultCopiesToIdentifierTypeCode { get; set; }

    public string? Obr28141ResultCopiesToAssigningFacilityNamespaceId { get; set; }

    public string? Obr28142ResultCopiesToAssigningFacilityUniversalId { get; set; }

    public string? Obr28143ResultCopiesToAssigningFacilityUniversalIdType { get; set; }

    public string? Obr2815ResultCopiesToNameRepresentationCode { get; set; }

    public string? Obr28161ResultCopiesToNameContextIdentifier { get; set; }

    public string? Obr28162ResultCopiesToNameContextText { get; set; }

    public string? Obr28163ResultCopiesToNameContextNameOfCodingSystem { get; set; }

    public string? Obr28164ResultCopiesToNameContextAlternateIdentifier { get; set; }

    public string? Obr28165ResultCopiesToNameContextAlternateText { get; set; }

    public string? Obr28166ResultCopiesToNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Obr28171ResultCopiesToNameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Obr28172ResultCopiesToNameValidityRangeRangeEndDateTime { get; set; }

    public string? Obr2818ResultCopiesToNameAssemblyOrder { get; set; }

    public string? Obr291ParentNumberParentsPlacerOrderNumber { get; set; }

    public string? Obr292ParentNumberParentsFillerOrderNumber { get; set; }

    public string? Obr30TransportationMode { get; set; }

    public string? Obr311ReasonforStudyIdentifier { get; set; }

    public string? Obr312ReasonForStudyText { get; set; }

    public string? Obr313ReasonforStudyNameOfCodingSystem { get; set; }

    public string? Obr314ReasonforStudyAlternateIdentifier { get; set; }

    public string? Obr315ReasonforStudyAlternateExt { get; set; }

    public string? Obr316ReasonforStudyNameOfAlternateCodingSystem { get; set; }

    public string? Obr3211PrincipalResultInterpreterOpnameIdnumber { get; set; }

    public string? Obr3212PrincipalResultInterpreterOpnameFamilyName { get; set; }

    public string? Obr3213PrincipalResultInterpreterOpnameGivenName { get; set; }

    public string? Obr3214PrincipalResultInterpreterOpnameSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr3215PrincipalResultInterpreterOpnameSuffix { get; set; }

    public string? Obr3216PrincipalResultInterpreterOpnamePrefix { get; set; }

    public string? Obr3217PrincipalResultInterpreterOpnameDegree { get; set; }

    public string? Obr3218PrincipalResultInterpreterOpnameSourceTable { get; set; }

    public string? Obr3219PrincipalResultInterpreterOpnameAssigningAuthorityNamespaceId { get; set; }

    public string? Obr32110PrincipalResultInterpreterOpnameAssigningAuthorityUniversalId { get; set; }

    public string? Obr32111PrincipalResultInterpreterOpnameAssigningAuthorityUniversalIdtype { get; set; }

    public DateTime? Obr322PrincipalResultInterpreterStartDatetime { get; set; }

    public DateTime? Obr323PrincipalResultInterpreterEndDatetime { get; set; }

    public string? Obr324PrincipalResultInterpreterPointOfCare { get; set; }

    public string? Obr325PrincipalResultInterpreterRoom { get; set; }

    public string? Obr326PrincipalResultInterpreterBed { get; set; }

    public string? Obr3271PrincipalResultInterpreterFacilityNamespaceId { get; set; }

    public string? Obr3272PrincipalResultInterpreterFacilityUniversalId { get; set; }

    public string? Obr3273PrincipalResultInterpreterFacilityUniversalIdType { get; set; }

    public string? Obr328PrincipalResultInterpreterLocationStatus { get; set; }

    public string? Obr329PrincipalResultInterpreterPersonLocationType { get; set; }

    public string? Obr3210PrincipalResultInterpreterBuilding { get; set; }

    public string? Obr3211PrincipalResultInterpreterFloor { get; set; }

    public string? Obr3311AssistantResultInterpreterOpnameIdnumber { get; set; }

    public string? Obr3312AssistantResultInterpreterOpnameFamilyName { get; set; }

    public string? Obr3313AssistantResultInterpreterOpnameGivenName { get; set; }

    public string? Obr3314AssistantResultInterpreterOpnameSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr3315AssistantResultInterpreterOpnameSuffix { get; set; }

    public string? Obr3316AssistantResultInterpreterOpnamePrefix { get; set; }

    public string? Obr3317AssistantResultInterpreterOpnameDegree { get; set; }

    public string? Obr3318AssistantResultInterpreterOpnameSourceTable { get; set; }

    public string? Obr3319AssistantResultInterpreterOpnameAssigningAuthorityNamespaceId { get; set; }

    public string? Obr33110AssistantResultInterpreterOpnameAssigningAuthorityUniversalId { get; set; }

    public string? Obr33111AssistantResultInterpreterOpnameAssigningAuthorityUniversalIdtype { get; set; }

    public DateTime? Obr332AssistantResultInterpreterStartDatetime { get; set; }

    public DateTime? Obr333AssistantResultInterpreterEndDatetime { get; set; }

    public string? Obr334AssistantResultInterpreterPointOfCare { get; set; }

    public string? Obr335AssistantResultInterpreterRoom { get; set; }

    public string? Obr336AssistantResultInterpreterBed { get; set; }

    public string? Obr3371AssistantResultInterpreterFacilityNamespaceId { get; set; }

    public string? Obr3372AssistantResultInterpreterFacilityUniversalId { get; set; }

    public string? Obr3373AssistantResultInterpreterFacilityUniversalIdtype { get; set; }

    public string? Obr338AssistantResultInterpreterLocationStatus { get; set; }

    public string? Obr339AssistantResultInterpreterPersonLocationType { get; set; }

    public string? Obr3310AssistantResultInterpreterBuilding { get; set; }

    public string? Obr3311AssistantResultInterpreterFloor { get; set; }

    public string? Obr3411TechnicianOpnameIdnumber { get; set; }

    public string? Obr3412TechnicianOpnameFamilyName { get; set; }

    public string? Obr3413TechnicianOpnameGivenName { get; set; }

    public string? Obr3414TechnicianOpnameSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr3415TechnicianOpnameSuffix { get; set; }

    public string? Obr3416TechnicianOpnamePrefix { get; set; }

    public string? Obr3417TechnicianOpnameDegree { get; set; }

    public string? Obr3418TechnicianOpnameSourceTable { get; set; }

    public string? Obr3419TechnicianOpnameAssigningAuthorityNamespaceId { get; set; }

    public string? Obr34110TechnicianOpnameAssigningAuthorityUniversalId { get; set; }

    public string? Obr34111TechnicianOpnameAssigningAuthorityUniversalIdtype { get; set; }

    public DateTime? Obr342TechnicianStartDateTime { get; set; }

    public DateTime? Obr343TechnicianEndDateTime { get; set; }

    public string? Obr344TechnicianPointOfCare { get; set; }

    public string? Obr345TechnicianRoom { get; set; }

    public string? Obr346TechnicianBed { get; set; }

    public string? Obr3471TechnicianFacilityNamespaceId { get; set; }

    public string? Obr3472TechnicianFacilityUniversalId { get; set; }

    public string? Obr3473TechnicianFacilityUniversalIdtype { get; set; }

    public string? Obr348TechnicianLocationStatus { get; set; }

    public string? Obr349TechnicianPersonLocationType { get; set; }

    public string? Obr3410TechnicianBuilding { get; set; }

    public string? Obr3411TechnicianFloor { get; set; }

    public string? Obr3511TranscriptionistOpnameIdnumber { get; set; }

    public string? Obr3512TranscriptionistOpnameFamilyName { get; set; }

    public string? Obr3513TranscriptionistOpnameGivenName { get; set; }

    public string? Obr3514TranscriptionistOpnameSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obr3515TranscriptionistOpnameSuffix { get; set; }

    public string? Obr3516TranscriptionistOpnamePrefix { get; set; }

    public string? Obr3517TranscriptionistOpnameDegree { get; set; }

    public string? Obr3518TranscriptionistOpnameSourceTable { get; set; }

    public string? Obr3519TranscriptionistOpnameAssigningAuthorityNamespaceId { get; set; }

    public string? Obr35110TranscriptionistOpnameAssigningAuthorityUniversalId { get; set; }

    public DateTime? Obr352TranscriptionistStartDatetime { get; set; }

    public DateTime? Obr353TranscriptionistEndDatetime { get; set; }

    public string? Obr354TranscriptionistPointOfCare { get; set; }

    public string? Obr355TranscriptionistRoom { get; set; }

    public string? Obr356TranscriptionistBed { get; set; }

    public string? Obr3571TranscriptionistFacilityNamespaceId { get; set; }

    public string? Obr3572TranscriptionistFacilityUniversalId { get; set; }

    public string? Obr3573TranscriptionistFacilityUniversalIdtype { get; set; }

    public string? Obr358TranscriptionistLocationStatus { get; set; }

    public string? Obr359TranscriptionistPersonLocationType { get; set; }

    public string? Obr3510TranscriptionistBuilding { get; set; }

    public string? Obr3511TranscriptionistFloor { get; set; }

    public DateTime? Obr36ScheduledDateTime { get; set; }

    public string? Obr37NumberOfSampleContainers { get; set; }

    public string? Obr381TransportLogisticsofCollectedSampleIdentifier { get; set; }

    public string? Obr382TransportLogisticsofCollectedSampleText { get; set; }

    public string? Obr383TransportLogisticsofCollectedSampleNameOfCodingSystem { get; set; }

    public string? Obr384TransportLogisticsofCollectedSampleAlternateIdentifier { get; set; }

    public string? Obr385TransportLogisticsofCollectedSampleAlternateText { get; set; }

    public string? Obr386TransportLogisticsofCollectedSampleNameOfAlternateCodingSystem { get; set; }

    public string? Obr391CollectorsCommentIdentifier { get; set; }

    public string? Obr392CollectorsCommentText { get; set; }

    public string? Obr393CollectorsCommentNameOfCodingSystem { get; set; }

    public string? Obr394CollectorsCommentAlternateIdentifier { get; set; }

    public string? Obr395CollectorsCommentAlternateText { get; set; }

    public string? Obr396CollectorsCommentNameOfAlternateCodingSystem { get; set; }

    public string? Obr401TransportArrangementResponsibilityIdentifier { get; set; }

    public string? Obr402TransportArrangementResponsibilityText { get; set; }

    public string? Obr403TransportArrangementResponsibilityNameOfCodingSystem { get; set; }

    public string? Obr404TransportArrangementResponsibilityAlternateIdentifier { get; set; }

    public string? Obr405TransportArrangementResponsibilityAlternateText { get; set; }

    public string? Obr406TransportArrangementResponsibilityNameOfAlternateCodingSystem { get; set; }

    public string? Obr41TransportArranged { get; set; }

    public string? Obr42EscortRequired { get; set; }

    public string? Obr431PlannedPatientTransportCommentIdentifier { get; set; }

    public string? Obr432PlannedPatientTransportCommentText { get; set; }

    public string? Obr433PlannedPatientTransportCommentNameOfCodingSystem { get; set; }

    public string? Obr434PlannedPatientTransportCommentAlternateIdentifierr { get; set; }

    public string? Obr435PlannedPatientTransportCommentAlternateText { get; set; }

    public string? Obr436PlannedPatientTransportCommentNameOfAlternateCodingSystem { get; set; }

    public string? Obr441ProcedureCodeIdentifier { get; set; }

    public string? Obr442ProcedureCodeText { get; set; }

    public string? Obr443ProcedureCodeNameOfCodingSystem { get; set; }

    public string? Obr444ProcedureCodeAlternateIdentifier { get; set; }

    public string? Obr445ProcedureCodeAlternateText { get; set; }

    public string? Obr446ProcedureCodeNameOfAlternateCodingSystem { get; set; }

    public string? Obr451ProcedureCodeModifierIdentifier { get; set; }

    public string? Obr452ProcedureCodeModifierText { get; set; }

    public string? Obr453ProcedureCodeModifierNameOfCodingSystem { get; set; }

    public string? Obr454ProcedureCodeModifierAlternateIdentifier { get; set; }

    public string? Obr455ProcedureCodeModifierAlternateText { get; set; }

    public string? Obr456ProcedureCodeModifierNameOfAlternateCodingSystem { get; set; }

    public string? Obr461PlacerSupplementalServiceInformationIdentifier { get; set; }

    public string? Obr462PlacerSupplementalServiceInformationText { get; set; }

    public string? Obr463PlacerSupplementalServiceInformationNameOfAlternateCodingSystem { get; set; }

    public string? Obr464PlacerSupplementalServiceInformationAlternateIdentifier { get; set; }

    public string? Obr465PlacerSupplementalServiceInformationAlternateText { get; set; }

    public string? Obr466PlacerSupplementalServiceInformationNameOfCodingSystem { get; set; }

    public string? Obr471FillerSupplementalServiceInformationIdentifier { get; set; }

    public string? Obr472FillerSupplementalServiceInformationText { get; set; }

    public string? Obr473FillerSupplementalServiceInformationNameOfCodingSystem { get; set; }

    public string? Obr474FillerSupplementalServiceInformationAlternateIdentifier { get; set; }

    public string? Obr475FillerSupplementalServiceInformationAlternateText { get; set; }

    public string? Obr476FillerSupplementalServiceInformationNameOfAlternateCodingSystem { get; set; }

    public DateTime DateTimeInserted { get; set; }

    public virtual OrcCommonOrder FkOrc { get; set; } = null!;

    public virtual ICollection<NteNotesAndComment> NteNotesAndComments { get; set; } = new List<NteNotesAndComment>();

    public virtual ICollection<ObxObservationOriginalLabMessage> ObxObservationOriginalLabMessages { get; set; } = new List<ObxObservationOriginalLabMessage>();

    public virtual ICollection<ObxObservationResult> ObxObservationResults { get; set; } = new List<ObxObservationResult>();
}
