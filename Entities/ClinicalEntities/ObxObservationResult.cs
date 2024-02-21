using System;
using System.Collections.Generic;

namespace IMTSchedulerWorkerService.Entities.ClinicalEntities;

public partial class ObxObservationResult
{
    public int PkObxId { get; set; }

    public int FkObrId { get; set; }

    public Guid Hl7uniqueIdentifier { get; set; }

    public long Hl7personLogId { get; set; }

    public long Obx1SetIdobx { get; set; }

    public string? Obx2ValueType { get; set; }

    public string? Obx31ObservationIdentifier { get; set; }

    public string? Obx32ObservationIdentifierText { get; set; }

    public string? Obx33ObservationIdentifierNameOfCodingSystem { get; set; }

    public string? Obx34ObservationIdentifierAlternateIdentifier { get; set; }

    public string? Obx35ObservationIdentifierAlternateText { get; set; }

    public string? Obx36ObservationIdentifierNameOfAlternateCodingSystem { get; set; }

    public string? Obx4ObservationSubId { get; set; }

    public string? Obx5ObservationValue { get; set; }

    public string? Obx61UnitsIdentifier { get; set; }

    public string? Obx62UnitsText { get; set; }

    public string? Obx63UnitsNameOfCodingSystem { get; set; }

    public string? Obx64UnitsAlternateIdentifier { get; set; }

    public string? Obx65UnitsAlternateText { get; set; }

    public string? Obx66UnitsNameOfAlternateCodingSystem { get; set; }

    public string? Obx7ReferenceRange { get; set; }

    public string? Obx8AbnormalFlags { get; set; }

    public decimal? Obx9Probability { get; set; }

    public string? Obx10NatureOfAbnormalText { get; set; }

    public string? Obx11ObservationResultStatus { get; set; }

    public string? Obx121DateLastObservationNormalValueTimeOfEvent { get; set; }

    public string? Obx122DateLastObservationNormalValueDegreeOfPrecision { get; set; }

    public string? Obx13UserDefindedAccessChecks { get; set; }

    public string? Obx141DateTimeOfObservationTimeOfEvent { get; set; }

    public string? Obx142DateTimeOfObservationDegreeOfPrecision { get; set; }

    public string? Obx151ProducersIdIdentifier { get; set; }

    public string? Obx152ProducersIdText { get; set; }

    public string? Obx153ProducersIdNameOfCodingSystem { get; set; }

    public string? Obx154ProducersIdAlternateIdentifier { get; set; }

    public string? Obx155ProducersIdAlternateText { get; set; }

    public string? Obx156ProducersIdNameOfAlternateCodingSystem { get; set; }

    public string? Obx161ResponsibleObserverIdnumber { get; set; }

    public string? Obx1621ResponsibleObserverFamilyNameSurname { get; set; }

    public string? Obx1622ResponsibleObserverFamilyNameOwnSurnamePrefix { get; set; }

    public string? Obx1623ResponsibleObserverFamilyNameOwnSurname { get; set; }

    public string? Obx1624ResponsibleObserverFamilyNameSurnamePrefixFromPartnerSpouse { get; set; }

    public string? Obx1625ResponsibleObserverFamilyNameSurnameFromPartnerSpouse { get; set; }

    public string? Obx163ResponsibleObserverGivenName { get; set; }

    public string? Obx164ResponsibleObserverSecondAndFurtherGivenNamesOrInitialsThereof { get; set; }

    public string? Obx165ResponsibleObserverSuffix { get; set; }

    public string? Obx166ResponsibleObserverPrefix { get; set; }

    public string? Obx167ResponsibleObserverDegree { get; set; }

    public string? Obx168ResponsibleObserverSourceTable { get; set; }

    public string? Obx1691ResponsibleObserverAssigningAuthorityNamespaceId { get; set; }

    public string? Obx1692ResponsibleObserverAssigningAuthorityUniversalId { get; set; }

    public string? Obx1693ResponsibleObserverAssigningAuthorityUniversalIdType { get; set; }

    public string? Obx1610ResponsibleObserverNameTypeCode { get; set; }

    public string? Obx1611ResponsibleObserverIdentifierCheckDigit { get; set; }

    public string? Obx1612ResponsibleObserverCodeIdentifyingTheCheckDigitSchemeEmployed { get; set; }

    public string? Obx1613ResponsibleObserverIdentifierTypeCode { get; set; }

    public string? Obx16141ResponsibleObserverAssigningFacilityNamespaceId { get; set; }

    public string? Obx16142ResponsibleObserverAssigningFacilityUniversalId { get; set; }

    public string? Obx16143ResponsibleObserverAssigningFacilityUniversalIdType { get; set; }

    public string? Obx1615ResponsibleObserverNameRepresentationCode { get; set; }

    public string? Obx16161ResponsibleObserverNameContextIdentifier { get; set; }

    public string? Obx16162ResponsibleObserverNameContextText { get; set; }

    public string? Obx16163ResponsibleObserverNameContextNameOfCodingSystem { get; set; }

    public string? Obx16164ResponsibleObserverNameContextAlternateIdentifier { get; set; }

    public string? Obx16165ResponsibleObserverNameContextAlternateText { get; set; }

    public string? Obx16166ResponsibleObserverNameContextNameOfAlternateCodingSystem { get; set; }

    public DateTime? Obx16171NameValidityRangeRangeStartDateTime { get; set; }

    public DateTime? Obx16172NameValidityRangeRangeEndDateTime { get; set; }

    public string? Obx1618NameAssemblyOrder { get; set; }

    public string? Obx171ObservationMethodIdentifier { get; set; }

    public string? Obx172ObservationMethodText { get; set; }

    public string? Obx173ObservationMethodNameOfCodingSystem { get; set; }

    public string? Obx174ObservationMethodAlternateIdentifier { get; set; }

    public string? Obx175ObservationMethodAlternateText { get; set; }

    public string? Obx176ObservationMethodNameOfAlternateCodingSystem { get; set; }

    public string? Obx181EquipmentInstanceIdentifierEntityIdentifier { get; set; }

    public string? Obx182EquipmentInstanceIdentifierNamespaceId { get; set; }

    public string? Obx183EquipmentInstanceIdentifierUniversalId { get; set; }

    public string? Obx184EquipmentInstanceIdentifierUniversalIdType { get; set; }

    public string? Obx191DateTimeOfAnalysisTimeOfEvent { get; set; }

    public string? Obx192DateTimeOfAnalysis2DegreeOfPrecision { get; set; }

    public virtual ObrObservationRequest FkObr { get; set; } = null!;

    public virtual ICollection<NteNotesAndComment> NteNotesAndComments { get; set; } = new List<NteNotesAndComment>();
}
