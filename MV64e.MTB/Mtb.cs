#pragma warning disable CS8765
#pragma warning disable CS8618

namespace MV64e.MTB
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Mtb
    {
        [JsonProperty("carePlans", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbCarePlan> CarePlans { get; set; }

        [JsonProperty("claimResponses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<ClaimResponse> ClaimResponses { get; set; }

        [JsonProperty("claims", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Claim> Claims { get; set; }

        [JsonProperty("diagnoses", Required = Required.Always)]
        public List<MtbDiagnosis> Diagnoses { get; set; }

        [JsonProperty("episodesOfCare", Required = Required.Always)]
        public List<MtbEpisodeOfCare> EpisodesOfCare { get; set; }

        [JsonProperty("familyMemberHistories", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<FamilyMemberHistory> FamilyMemberHistories { get; set; }

        [JsonProperty("followUps", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<FollowUp> FollowUps { get; set; }

        [JsonProperty("guidelineProcedures", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<OncoProcedure> GuidelineProcedures { get; set; }

        [JsonProperty("guidelineTherapies", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbSystemicTherapy> GuidelineTherapies { get; set; }

        [JsonProperty("histologyReports", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<HistologyReport> HistologyReports { get; set; }

        [JsonProperty("ihcReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<IhcReport> IhcReports { get; set; }

        [JsonProperty("metadata", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MvhMetadata Metadata { get; set; }

        [JsonProperty("msiFindings", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Msi> MsiFindings { get; set; }

        [JsonProperty("ngsReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SomaticNgsReport> NgsReports { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("performanceStatus", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<PerformanceStatus> PerformanceStatus { get; set; }

        [JsonProperty("priorDiagnosticReports", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<PriorDiagnosticReport> PriorDiagnosticReports { get; set; }

        [JsonProperty("responses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Response> Responses { get; set; }

        [JsonProperty("specimens", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<TumorSpecimen> Specimens { get; set; }

        [JsonProperty("systemicTherapies", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<SystemicTherapy> SystemicTherapies { get; set; }
    }

    public partial class MtbCarePlan
    {
        [JsonProperty("geneticCounselingRecommendation", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public GeneticCounselingRecommendation GeneticCounselingRecommendation { get; set; }

        [JsonProperty("histologyReevaluationRequests", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<HistologyReevaluationRequest> HistologyReevaluationRequests { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("medicationRecommendations", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationRecommendation> MedicationRecommendations { get; set; }

        [JsonProperty("noSequencingPerformedReason", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public CarePlanNoSequencingPerformedReasonCoding NoSequencingPerformedReason { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("procedureRecommendations", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<ProcedureRecommendation> ProcedureRecommendations { get; set; }

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reason { get; set; }

        [JsonProperty("rebiopsyRequests", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<RebiopsyRequest> RebiopsyRequests { get; set; }

        [JsonProperty("recommendationsMissingReason", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public MtbCarePlanRecommendationsMissingReasonCoding RecommendationsMissingReason { get; set; }

        [JsonProperty("studyEnrollmentRecommendations", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbStudyEnrollmentRecommendation> StudyEnrollmentRecommendations { get; set; }
    }

    public partial class GeneticCounselingRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public GeneticCounselingRecommendationReasonCoding Reason { get; set; }
    }

    public partial class Reference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class GeneticCounselingRecommendationReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public GeneticCounselingRecommendationReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HistologyReevaluationRequest
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }
    }

    public partial class MtbMedicationRecommendation
    {
        [JsonProperty("category", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationRecommendationCategoryCoding> Category { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("levelOfEvidence", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public LevelOfEvidence LevelOfEvidence { get; set; }

        [JsonProperty("medication", Required = Required.Always)]
        public List<AtcUnregisteredMedicationCoding> Medication { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("priority", Required = Required.Always)]
        public RecommendationPriorityCoding Priority { get; set; }

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reason { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneAlterationReference> SupportingVariants { get; set; }

        [JsonProperty("useType", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbMedicationRecommendationUseTypeCoding UseType { get; set; }
    }

    public partial class MtbMedicationRecommendationCategoryCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbMedicationRecommendationCategoryCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class LevelOfEvidence
    {
        [JsonProperty("addendums", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<LevelOfEvidenceAddendumCoding> Addendums { get; set; }

        [JsonProperty("grading", Required = Required.Always)]
        public LevelOfEvidenceGradingCoding Grading { get; set; }

        [JsonProperty("publications", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PublicationReference> Publications { get; set; }
    }

    public partial class LevelOfEvidenceAddendumCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public LevelOfEvidenceAddendumCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class LevelOfEvidenceGradingCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public LevelOfEvidenceGradingCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class PublicationReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public PublicationSystem System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class AtcUnregisteredMedicationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public RequestedMedicationSystem System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RecommendationPriorityCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RecommendationPriorityCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class GeneAlterationReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("gene", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Gene { get; set; }

        [JsonProperty("variant", Required = Required.Always)]
        public Reference Variant { get; set; }
    }

    public partial class Coding
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbMedicationRecommendationUseTypeCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbMedicationRecommendationUseTypeCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CarePlanNoSequencingPerformedReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public NoSequencingPerformedReasonCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ProcedureRecommendation
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbProcedureRecommendationCategoryCoding Code { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("levelOfEvidence", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public LevelOfEvidence LevelOfEvidence { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("priority", Required = Required.Always)]
        public RecommendationPriorityCoding Priority { get; set; }

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reason { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneAlterationReference> SupportingVariants { get; set; }
    }

    public partial class MtbProcedureRecommendationCategoryCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbProcedureRecommendationCategoryCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RebiopsyRequest
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("tumorEntity", Required = Required.Always)]
        public Reference TumorEntity { get; set; }
    }

    public partial class MtbCarePlanRecommendationsMissingReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbCarePlanRecommendationsMissingReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbStudyEnrollmentRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("levelOfEvidence", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public LevelOfEvidence LevelOfEvidence { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<AtcUnregisteredMedicationCoding> Medication { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("priority", Required = Required.Always)]
        public RecommendationPriorityCoding Priority { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public Reference Reason { get; set; }

        [JsonProperty("study", Required = Required.Always)]
        public List<StudyReference> Study { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneAlterationReference> SupportingVariants { get; set; }
    }

    public partial class StudyReference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("system", Required = Required.Always)]
        public StudySystem System { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class ClaimResponse
    {
        [JsonProperty("claim", Required = Required.Always)]
        public Reference Claim { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClaimResponseStatusCoding Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<ClaimResponseStatusReasonCoding> StatusReason { get; set; }
    }

    public partial class ClaimResponseStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClaimResponseStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ClaimResponseStatusReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClaimResponseStatusReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Claim
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("recommendation", Required = Required.Always)]
        public Reference Recommendation { get; set; }

        [JsonProperty("requestedMedication", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<AtcUnregisteredMedicationCoding> RequestedMedication { get; set; }

        [JsonProperty("stage", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClaimStageCoding Stage { get; set; }
    }

    public partial class ClaimStageCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClaimStageCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbDiagnosis
    {
        [JsonProperty("code", Required = Required.Always)]
        public Coding Code { get; set; }

        [JsonProperty("germlineCodes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> GermlineCodes { get; set; }

        [JsonProperty("grading", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Grading Grading { get; set; }

        [JsonProperty("guidelineTreatmentStatus", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public MtbDiagnosisGuidelineTreatmentStatusCoding GuidelineTreatmentStatus { get; set; }

        [JsonProperty("histology", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> Histology { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("recordedOn", Required = Required.Always)]
        public DateTimeOffset RecordedOn { get; set; }

        [JsonProperty("staging", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Staging Staging { get; set; }

        [JsonProperty("topography", Required = Required.Always)]
        public Coding Topography { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public TypeClass Type { get; set; }
    }

    public partial class Grading
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<TumorGrading> History { get; set; }
    }

    public partial class TumorGrading
    {
        [JsonProperty("codes", Required = Required.Always)]
        public List<Coding> Codes { get; set; }

        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }
    }

    public partial class MtbDiagnosisGuidelineTreatmentStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbDiagnosisGuidelineTreatmentStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Staging
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<TumorStaging> History { get; set; }
    }

    public partial class TumorStaging
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public TumorStagingMethodCoding Method { get; set; }

        [JsonProperty("otherClassifications", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> OtherClassifications { get; set; }

        [JsonProperty("tnmClassification", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public TnmClassification TnmClassification { get; set; }
    }

    public partial class TumorStagingMethodCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorStagingMethodCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TnmClassification
    {
        [JsonProperty("metastasis", Required = Required.Always)]
        public Coding Metastasis { get; set; }

        [JsonProperty("nodes", Required = Required.Always)]
        public Coding Nodes { get; set; }

        [JsonProperty("tumor", Required = Required.Always)]
        public Coding Tumor { get; set; }
    }

    public partial class TypeClass
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<History> History { get; set; }
    }

    public partial class History
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public MtbDiagnosisCoding Value { get; set; }
    }

    public partial class MtbDiagnosisCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ValueCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbEpisodeOfCare
    {
        [JsonProperty("diagnoses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> Diagnoses { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.Always)]
        public PeriodDate Period { get; set; }
    }

    public partial class PeriodDate
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public DateTimeOffset Start { get; set; }
    }

    public partial class FamilyMemberHistory
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("relationship", Required = Required.Always)]
        public FamilyMemberHistoryRelationshipTypeCoding Relationship { get; set; }
    }

    public partial class FamilyMemberHistoryRelationshipTypeCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public FamilyMemberHistoryRelationshipTypeCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class FollowUp
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("lastContactDate", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastContactDate { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("patientStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public FollowUpPatientStatusCoding PatientStatus { get; set; }
    }

    public partial class FollowUpPatientStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public FollowUpPatientStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class OncoProcedure
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference BasedOn { get; set; }

        [JsonProperty("code", Required = Required.Always)]
        public OncoProcedureCoding Code { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("intent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbTherapyIntentCoding Intent { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodDate Period { get; set; }

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reason { get; set; }

        [JsonProperty("recordedOn", Required = Required.Always)]
        public DateTimeOffset RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public TherapyStatusCoding Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbTherapyStatusReasonCoding StatusReason { get; set; }

        [JsonProperty("therapyLine", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TherapyLine { get; set; }
    }

    public partial class OncoProcedureCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public OncoProcedureCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbTherapyIntentCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbTherapyIntentCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TherapyStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TherapyStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbTherapyStatusReasonCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbTherapyStatusReasonCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbSystemicTherapy
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference BasedOn { get; set; }

        [JsonProperty("category", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbSystemicTherapyCategoryCoding Category { get; set; }

        [JsonProperty("dosage", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbSystemicTherapyDosageDensityCoding Dosage { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("intent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbTherapyIntentCoding Intent { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<AtcUnregisteredMedicationCoding> Medication { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodDate Period { get; set; }

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reason { get; set; }

        [JsonProperty("recommendationFulfillmentStatus", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public MtbSystemicTherapyRecommendationFulfillmentStatusCoding RecommendationFulfillmentStatus { get; set; }

        [JsonProperty("recordedOn", Required = Required.Always)]
        public DateTimeOffset RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public TherapyStatusCoding Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbTherapyStatusReasonCoding StatusReason { get; set; }

        [JsonProperty("therapyLine", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TherapyLine { get; set; }
    }

    public partial class MtbSystemicTherapyCategoryCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbSystemicTherapyCategoryCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbSystemicTherapyDosageDensityCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbSystemicTherapyDosageDensityCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbSystemicTherapyRecommendationFulfillmentStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HistologyReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public HistologyReportResults Results { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }
    }

    public partial class HistologyReportResults
    {
        [JsonProperty("tumorCellContent", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public TumorCellContent TumorCellContent { get; set; }

        [JsonProperty("tumorMorphology", Required = Required.Always)]
        public TumorMorphology TumorMorphology { get; set; }
    }

    public partial class TumorCellContent
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public TumorCellContentMethodCoding Method { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class TumorCellContentMethodCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorCellContentMethodCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TumorMorphology
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("note", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public Coding Value { get; set; }
    }

    public partial class IhcReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public IhcReportResults Results { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }
    }

    public partial class IhcReportResults
    {
        [JsonProperty("msiMmr", Required = Required.Always)]
        public List<ProteinExpression> MsiMmr { get; set; }

        [JsonProperty("proteinExpression", Required = Required.Always)]
        public List<ProteinExpression> ProteinExpression { get; set; }
    }

    public partial class ProteinExpressionIcScoreCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ProteinExpressionIcScoreCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ProteinExpressionTcScoreCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ProteinExpressionTcScoreCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ProteinExpressionResultCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ProteinExpressionResultCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ProteinExpression
    {
        [JsonProperty("icScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ProteinExpressionIcScoreCoding IcScore { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("protein", Required = Required.Always)]
        public Coding Protein { get; set; }

        [JsonProperty("tcScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ProteinExpressionTcScoreCoding TcScore { get; set; }

        [JsonProperty("tpsScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TpsScore { get; set; }

        [JsonProperty("cpsScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? CpsScore { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public ProteinExpressionResultCoding Value { get; set; }
    }

    public partial class MvhMetadata
    {
        [JsonProperty("modelProjectConsent", Required = Required.Always)]
        public ModelProjectConsent ModelProjectConsent { get; set; }

        [JsonProperty("researchConsents", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<Dictionary<string, object>> ResearchConsents { get; set; }

        [JsonProperty("transferTAN", Required = Required.Always)]
        public string TransferTan { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public MvhSubmissionType Type { get; set; }
    }

    public partial class ModelProjectConsent
    {
        [JsonProperty("date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("provisions", Required = Required.Always)]
        public List<Provision> Provisions { get; set; }

        [JsonProperty("version", Required = Required.Always)]
        public string Version { get; set; }
    }

    public partial class Msi
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.Always)]
        public MsiInterpretationCoding Interpretation { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public MsiMethodCoding Method { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class MsiInterpretationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MsiInterpretationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MsiMethodCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MsiMethodCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Provision
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("purpose", Required = Required.Always)]
        public ModelProjectConsentPurpose Purpose { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public ConsentProvision Type { get; set; }
    }

    public partial class SomaticNgsReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("metadata", Required = Required.Always)]
        public List<NgsReportMetadata> Metadata { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public NgsReportResults Results { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public NgsReportCoding Type { get; set; }
    }

    public partial class NgsReportMetadata
    {
        [JsonProperty("kitManufacturer", Required = Required.Always)]
        public string KitManufacturer { get; set; }

        [JsonProperty("kitType", Required = Required.Always)]
        public string KitType { get; set; }

        [JsonProperty("pipeline", Required = Required.Always)]
        public Uri Pipeline { get; set; }

        [JsonProperty("referenceGenome", Required = Required.Always)]
        public string ReferenceGenome { get; set; }

        [JsonProperty("sequencer", Required = Required.Always)]
        public string Sequencer { get; set; }
    }

    public partial class NgsReportResults
    {
        [JsonProperty("brcaness", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Brcaness Brcaness { get; set; }

        [JsonProperty("copyNumberVariants", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<Cnv> CopyNumberVariants { get; set; }

        [JsonProperty("dnaFusions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<DnaFusion> DnaFusions { get; set; }

        [JsonProperty("hrdScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public HrdScore HrdScore { get; set; }

        [JsonProperty("rnaFusions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<RnaFusion> RnaFusions { get; set; }

        [JsonProperty("rnaSeqs", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<RnaSeq> RnaSeqs { get; set; }

        [JsonProperty("simpleVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Snv> SimpleVariants { get; set; }

        [JsonProperty("tmb", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Tmb Tmb { get; set; }

        [JsonProperty("tumorCellContent", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public TumorCellContent TumorCellContent { get; set; }
    }

    public partial class Brcaness
    {
        [JsonProperty("confidenceRange", Required = Required.Always)]
        public ConfidenceRange ConfidenceRange { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class ConfidenceRange
    {
        [JsonProperty("max", Required = Required.Always)]
        public double Max { get; set; }

        [JsonProperty("min", Required = Required.Always)]
        public double Min { get; set; }
    }

    public partial class Cnv
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("cnA", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnA { get; set; }

        [JsonProperty("cnB", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnB { get; set; }

        [JsonProperty("copyNumberNeutralLoH", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> CopyNumberNeutralLoH { get; set; }

        [JsonProperty("endRange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public EndRange EndRange { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<VariantExternalId> ExternalIds { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("relativeCopyNumber", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public double? RelativeCopyNumber { get; set; }

        [JsonProperty("reportedAffectedGenes", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> ReportedAffectedGenes { get; set; }

        [JsonProperty("reportedFocality", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public string ReportedFocality { get; set; }

        [JsonProperty("startRange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public StartRange StartRange { get; set; }

        [JsonProperty("totalCopyNumber", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCopyNumber { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public CnvCoding Type { get; set; }
    }

    public partial class EndRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class VariantExternalId
    {
        [JsonProperty("system", Required = Required.Always)]
        public ExternalIdSystem System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class BaseVariantLocalizationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public BaseVariantLocalizationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class StartRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class CnvCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public CnvCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class DnaFusion
    {
        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<VariantExternalId> ExternalIds { get; set; }

        [JsonProperty("fusionPartner3prime", Required = Required.Always)]
        public DnaFusionFusionPartner3Prime FusionPartner3Prime { get; set; }

        [JsonProperty("fusionPartner5prime", Required = Required.Always)]
        public DnaFusionFusionPartner5Prime FusionPartner5Prime { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("reportedNumReads", Required = Required.Always)]
        public long ReportedNumReads { get; set; }
    }

    public partial class DnaFusionFusionPartner3Prime
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Coding Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class DnaFusionFusionPartner5Prime
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Coding Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class HrdScore
    {
        [JsonProperty("components", Required = Required.Always)]
        public Components Components { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public HrdScoreInterpretationCoding Interpretation { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class Components
    {
        [JsonProperty("loh", Required = Required.Always)]
        public double Loh { get; set; }

        [JsonProperty("lst", Required = Required.Always)]
        public double Lst { get; set; }

        [JsonProperty("tai", Required = Required.Always)]
        public double Tai { get; set; }
    }

    public partial class HrdScoreInterpretationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public InterpretationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RnaFusion
    {
        [JsonProperty("effect", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<VariantExternalId> ExternalIds { get; set; }

        [JsonProperty("fusionPartner3prime", Required = Required.Always)]
        public RnaFusionFusionPartner3Prime FusionPartner3Prime { get; set; }

        [JsonProperty("fusionPartner5prime", Required = Required.Always)]
        public RnaFusionFusionPartner5Prime FusionPartner5Prime { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("reportedNumReads", Required = Required.Always)]
        public long ReportedNumReads { get; set; }
    }

    public partial class RnaFusionFusionPartner3Prime
    {
        [JsonProperty("exonId", Required = Required.Always)]
        public string ExonId { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Coding Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public TranscriptId TranscriptId { get; set; }
    }

    public partial class TranscriptId
    {
        [JsonProperty("system", Required = Required.Always)]
        public TranscriptIdSystem System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class RnaFusionFusionPartner5Prime
    {
        [JsonProperty("exonId", Required = Required.Always)]
        public string ExonId { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Coding Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public TranscriptId TranscriptId { get; set; }
    }

    public partial class RnaSeq
    {
        [JsonProperty("cohortRanking", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? CohortRanking { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<VariantExternalId> ExternalIds { get; set; }

        [JsonProperty("gene", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Gene { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("librarySize", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? LibrarySize { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("rawCounts", Required = Required.Always)]
        public long RawCounts { get; set; }

        [JsonProperty("tissueCorrectedExpression", Required = Required.DisallowNull,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? TissueCorrectedExpression { get; set; }

        [JsonProperty("transcriptId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TranscriptId TranscriptId { get; set; }

        [JsonProperty("transcriptsPerMillion", Required = Required.Always)]
        public double TranscriptsPerMillion { get; set; }

        [JsonProperty("variant", Required = Required.Always)]
        public Reference Variant { get; set; }
    }

    public partial class Snv
    {
        [JsonProperty("allelicFrequency", Required = Required.Always)]
        public double AllelicFrequency { get; set; }

        [JsonProperty("altAllele", Required = Required.Always)]
        public string AltAllele { get; set; }

        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("dnaChange", Required = Required.Always)]
        public string DnaChange { get; set; }

        [JsonProperty("exonId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ExonId { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<VariantExternalId> ExternalIds { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Coding Gene { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClinVarCoding Interpretation { get; set; }

        [JsonProperty("localization", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<BaseVariantLocalizationCoding> Localization { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public Position Position { get; set; }

        [JsonProperty("proteinChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ProteinChange { get; set; }

        [JsonProperty("readDepth", Required = Required.Always)]
        public long ReadDepth { get; set; }

        [JsonProperty("refAllele", Required = Required.Always)]
        public string RefAllele { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public TranscriptId TranscriptId { get; set; }
    }

    public partial class ClinVarCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClinVarCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Position
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class Tmb
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TmbInterpretationCoding Interpretation { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public TmbResult Value { get; set; }
    }

    public partial class TmbInterpretationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public InterpretationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TmbResult
    {
        [JsonProperty("unit", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Unit { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class NgsReportCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public NgsReportCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Patient
    {
        [JsonProperty("address", Required = Required.Always)]
        public Address Address { get; set; }

        [JsonProperty("age", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Age Age { get; set; }

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("dateOfDeath", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfDeath { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public GenderCoding Gender { get; set; }

        [JsonProperty("healthInsurance", Required = Required.Always)]
        public HealthInsurance HealthInsurance { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("managingSite", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding ManagingSite { get; set; }

        [JsonProperty("vitalStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VitalStatusCoding VitalStatus { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("municipalityCode", Required = Required.Always)]
        public string MunicipalityCode { get; set; }
    }

    public partial class Age
    {
        [JsonProperty("unit", Required = Required.Always)]
        public Unit Unit { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class GenderCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public GenderCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HealthInsurance
    {
        [JsonProperty("reference", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Reference { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public HealthInsuranceCoding Type { get; set; }
    }

    public partial class HealthInsuranceCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public HealthInsuranceCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class VitalStatusCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public VitalStatusCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class PerformanceStatus
    {
        [JsonProperty("effectiveDate", Required = Required.Always)]
        public DateTimeOffset EffectiveDate { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public EcogCoding Value { get; set; }
    }

    public partial class EcogCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public EcogCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class PriorDiagnosticReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("performer", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Performer { get; set; }

        [JsonProperty("results", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Results { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public MolecularDiagnosticReportCoding Type { get; set; }
    }

    public partial class MolecularDiagnosticReportCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public MolecularDiagnosticReportCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class Response
    {
        [JsonProperty("effectiveDate", Required = Required.Always)]
        public DateTimeOffset EffectiveDate { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public ResponseMethodCoding Method { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("therapy", Required = Required.Always)]
        public Reference Therapy { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public RecistCoding Value { get; set; }
    }

    public partial class ResponseMethodCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public ResponseMethodCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class RecistCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public RecistCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TumorSpecimen
    {
        [JsonProperty("collection", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Collection Collection { get; set; }

        [JsonProperty("diagnosis", Required = Required.Always)]
        public Reference Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public TumorSpecimenCoding Type { get; set; }
    }

    public partial class Collection
    {
        [JsonProperty("date", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; }

        [JsonProperty("localization", Required = Required.Always)]
        public TumorSpecimenCollectionLocalizationCoding Localization { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public TumorSpecimenCollectionMethodCoding Method { get; set; }
    }

    public partial class TumorSpecimenCollectionLocalizationCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenCollectionLocalizationCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TumorSpecimenCollectionMethodCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenCollectionMethodCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class TumorSpecimenCoding
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenCodingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class SystemicTherapy
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<MtbSystemicTherapy> History { get; set; }
    }

    public enum GeneticCounselingRecommendationReasonCodingCode
    {
        FamilyAnamnesis,
        Other,
        SecondaryTumor,
        SelfAnamnesis,
        Unknown
    };

    public enum MtbMedicationRecommendationCategoryCodingCode
    {
        Ch,
        Ho,
        Im,
        So,
        Sz,
        Zs
    };

    public enum LevelOfEvidenceAddendumCodingCode
    {
        Is,
        Iv,
        R,
        Z
    };

    public enum LevelOfEvidenceGradingCodingCode
    {
        M1A,
        M1B,
        M1C,
        M2A,
        M2B,
        M2C,
        M3,
        M4,
        Undefined
    };

    public enum PublicationSystem
    {
        PubmedNcbiNlmNihGov,
        DoiOrg
    };

    public enum RequestedMedicationSystem
    {
        HttpFhirDeCodeSystemBfarmAtc,
        Undefined
    };

    public enum RecommendationPriorityCodingCode
    {
        Code1,
        Code2,
        Code3,
        Code4
    };

    public enum MtbMedicationRecommendationUseTypeCodingCode
    {
        Compassionate,
        InLabel,
        OffLabel,
        SecPreventive,
        Unknown
    };

    public enum NoSequencingPerformedReasonCode
    {
        NonGeneticCause,
        NotRareDisease,
        Other,
        Psychosomatic,
        TargetedDiagnosticsRecommended
    };

    public enum MtbProcedureRecommendationCategoryCodingCode
    {
        As,
        Op,
        So,
        St,
        Ws,
        Ww
    };

    public enum MtbCarePlanRecommendationsMissingReasonCodingCode
    {
        NoTarget
    };

    public enum StudySystem
    {
        Drks,
        Eudamed,
        EudraCt,
        Nct
    };

    public enum ClaimResponseStatusCodingCode
    {
        Accepted,
        Rejected,
        Unknown
    };

    public enum ClaimResponseStatusReasonCodingCode
    {
        ApprovalRevocation,
        FormalReasons,
        InclusionInStudy,
        InsufficientEvidence,
        Other,
        OtherTherapyRecommended,
        StandardTherapyNotExhausted,
        Unknown
    };

    public enum ClaimStageCodingCode
    {
        FollowUpClaim,
        InitialClaim,
        Revocation,
        Unknown
    };

    public enum MtbDiagnosisGuidelineTreatmentStatusCodingCode
    {
        Exhausted,
        Impossible,
        NoGuidelinesAvailable,
        NonExhausted,
        Unknown
    };

    public enum TumorStagingMethodCodingCode
    {
        Clinical,
        Pathologic
    };

    public enum ValueCode
    {
        Main,
        Metachronous,
        Secondary
    };

    public enum FamilyMemberHistoryRelationshipTypeCodingCode
    {
        Ext,
        Fammemb
    };

    public enum FollowUpPatientStatusCodingCode
    {
        LostToFu
    };

    public enum OncoProcedureCodingCode
    {
        NuclearMedicine,
        RadioTherapy,
        Surgery
    };

    public enum MtbTherapyIntentCodingCode
    {
        K,
        P,
        S,
        X
    };

    public enum TherapyStatusCodingCode
    {
        Completed,
        NotDone,
        OnGoing,
        Stopped,
        Unknown
    };

    public enum MtbTherapyStatusReasonCodingCode
    {
        BestSupportiveCare,
        ChronicRemission,
        Deterioration,
        LostToFu,
        MedicalReasons,
        NoIndication,
        Other,
        OtherTherapyChosen,
        PatientDeath,
        PatientRefusal,
        PatientWish,
        PaymentEnded,
        PaymentPending,
        PaymentRefused,
        Progression,
        RegularCompletion,
        RegularCompletionWithDosageReduction,
        RegularCompletionWithSubstanceChange,
        Toxicity
    };

    public enum MtbSystemicTherapyCategoryCodingCode
    {
        A,
        I,
        N,
        O,
        S
    };

    public enum MtbSystemicTherapyDosageDensityCodingCode
    {
        Over50,
        Under50
    };

    public enum MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode
    {
        Complete,
        Partial
    };

    public enum TumorCellContentMethodCodingCode
    {
        Bioinformatic,
        Histologic
    };

    public enum ProteinExpressionIcScoreCodingCode
    {
        Code0,
        Code1,
        Code2,
        Code3
    };

    public enum ProteinExpressionTcScoreCodingCode
    {
        Code0,
        Code1,
        Code2,
        Code3,
        Code4,
        Code5,
        Code6
    };

    public enum ProteinExpressionResultCodingCode
    {
        Exp,
        NotExp,
        Code1Plus,
        Code2Plus,
        Code3Plus,
        Unknown
    };

    public enum ModelProjectConsentPurpose
    {
        CaseIdentification,
        Reidentification,
        Sequencing
    };

    public enum ConsentProvision
    {
        Deny,
        Permit
    };

    public enum MvhSubmissionType
    {
        Addition,
        Correction,
        Followup,
        Initial,
        Test
    };

    public enum MsiInterpretationCodingCode
    {
        MmrDeficient,
        MmrProficient,
        MsiHigh,
        MsiLow,
        Stable,
        Unknown
    };

    public enum MsiMethodCodingCode
    {
        Bioinformatic,
        Ihc,
        Pcr
    };

    public enum Chromosome
    {
        Chr1,
        Chr10,
        Chr11,
        Chr12,
        Chr13,
        Chr14,
        Chr15,
        Chr16,
        Chr17,
        Chr18,
        Chr19,
        Chr2,
        Chr20,
        Chr21,
        Chr22,
        Chr3,
        Chr4,
        Chr5,
        Chr6,
        Chr7,
        Chr8,
        Chr9,
        ChrX,
        ChrY,
        ChrMt
    };

    public enum ExternalIdSystem
    {
        CancerSangerAcUkCosmic,
        EnsemblOrg,
        NcbiNlmNihGovEntrez,
        NcbiNlmNihGovSnp
    };

    public enum BaseVariantLocalizationCodingCode
    {
        CodingRegion,
        Intergenic,
        Intronic,
        RegulatoryRegion,
        SplicingRegion
    };

    public enum CnvCodingCode
    {
        HighLevelGain,
        Loss,
        LowLevelGain
    };

    public enum InterpretationCodingCode
    {
        High,
        Intermediate,
        Low
    };

    public enum RnaFusionStrand
    {
        Empty,
        RnaFusionStrand
    };

    public enum TranscriptIdSystem
    {
        EnsemblOrg,
        NcbiNlmNihGovRefseq
    };

    public enum ClinVarCodingCode
    {
        Code1,
        Code2,
        Code3,
        Code4,
        Code5
    };

    public enum NgsReportCodingCode
    {
        Array,
        Exome,
        GenomeLongRead,
        GenomeShortRead,
        Karyotyping,
        Other,
        Panel,
        Single
    };

    public enum Unit
    {
        Months,
        Years
    };

    public enum GenderCodingCode
    {
        Female,
        Male,
        Other,
        Unknown
    };

    public enum HealthInsuranceCodingCode
    {
        Bei,
        Bg,
        Gkv,
        Gpv,
        Pkv,
        Ppv,
        Sel,
        Skt,
        Soz,
        Unk
    };

    public enum VitalStatusCodingCode
    {
        Alive,
        Deceased
    };

    public enum EcogCodingCode
    {
        Code0,
        Code1,
        Code2,
        Code3,
        Code4,
        Code5
    };

    public enum MolecularDiagnosticReportCodingCode
    {
        Array,
        Exome,
        Fish,
        FusionPanel,
        GenePanel,
        GenomeLongRead,
        GenomeShortRead,
        Karyotyping,
        Other,
        Panel,
        Pcr,
        Single
    };

    public enum ResponseMethodCodingCode
    {
        Rano,
        Recist
    };

    public enum RecistCodingCode
    {
        Cr,
        Mr,
        Na,
        Pd,
        Pr,
        Sd
    };

    public enum TumorSpecimenCollectionLocalizationCodingCode
    {
        CellfreeDna,
        LocalRecurrence,
        Metastasis,
        PrimaryTumor,
        RegionalLymphNodes,
        Unknown
    };

    public enum TumorSpecimenCollectionMethodCodingCode
    {
        Biopsy,
        Cytology,
        LiquidBiopsy,
        Resection,
        Unknown
    };

    public enum TumorSpecimenCodingCode
    {
        CryoFrozen,
        Ffpe,
        FreshTissue,
        LiquidBiopsy,
        Unknown
    };

    public partial class Mtb
    {
        public static Mtb FromJson(string json) =>
            JsonConvert.DeserializeObject<Mtb>(json, MV64e.MTB.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Mtb self) => JsonConvert.SerializeObject(self, MV64e.MTB.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            MissingMemberHandling = MissingMemberHandling.Error,
            Converters =
            {
                GeneticCounselingRecommendationReasonCodingCodeConverter.Singleton,
                MtbMedicationRecommendationCategoryCodingCodeConverter.Singleton,
                LevelOfEvidenceAddendumCodingCodeConverter.Singleton,
                LevelOfEvidenceGradingCodingCodeConverter.Singleton,
                PublicationSystemConverter.Singleton,
                RequestedMedicationSystemConverter.Singleton,
                RecommendationPriorityCodingCodeConverter.Singleton,
                MtbMedicationRecommendationUseTypeCodingCodeConverter.Singleton,
                NoSequencingPerformedReasonCodeConverter.Singleton,
                MtbProcedureRecommendationCategoryCodingCodeConverter.Singleton,
                MtbCarePlanRecommendationsMissingReasonCodingCodeConverter.Singleton,
                StudySystemConverter.Singleton,
                ClaimResponseStatusCodingCodeConverter.Singleton,
                ClaimResponseStatusReasonCodingCodeConverter.Singleton,
                ClaimStageCodingCodeConverter.Singleton,
                MtbDiagnosisGuidelineTreatmentStatusCodingCodeConverter.Singleton,
                TumorStagingMethodCodingCodeConverter.Singleton,
                ValueCodeConverter.Singleton,
                FamilyMemberHistoryRelationshipTypeCodingCodeConverter.Singleton,
                FollowUpPatientStatusCodingCodeConverter.Singleton,
                OncoProcedureCodingCodeConverter.Singleton,
                MtbTherapyIntentCodingCodeConverter.Singleton,
                TherapyStatusCodingCodeConverter.Singleton,
                MtbTherapyStatusReasonCodingCodeConverter.Singleton,
                MtbSystemicTherapyCategoryCodingCodeConverter.Singleton,
                MtbSystemicTherapyDosageDensityCodingCodeConverter.Singleton,
                MtbSystemicTherapyRecommendationFulfillmentStatusCodingCodeConverter.Singleton,
                TumorCellContentMethodCodingCodeConverter.Singleton,
                ProteinExpressionIcScoreCodingCodeConverter.Singleton,
                ProteinExpressionTcScoreCodingCodeConverter.Singleton,
                ProteinExpressionResultCodingCodeConverter.Singleton,
                ModelProjectConsentPurposeConverter.Singleton,
                ConsentProvisionConverter.Singleton,
                MvhSubmissionTypeConverter.Singleton,
                MsiInterpretationCodingCodeConverter.Singleton,
                MsiMethodCodingCodeConverter.Singleton,
                ChromosomeConverter.Singleton,
                ExternalIdSystemConverter.Singleton,
                BaseVariantLocalizationCodingCodeConverter.Singleton,
                CnvCodingCodeConverter.Singleton,
                InterpretationCodingCodeConverter.Singleton,
                RnaFusionStrandConverter.Singleton,
                TranscriptIdSystemConverter.Singleton,
                ClinVarCodingCodeConverter.Singleton,
                NgsReportCodingCodeConverter.Singleton,
                UnitConverter.Singleton,
                GenderCodingCodeConverter.Singleton,
                HealthInsuranceCodingCodeConverter.Singleton,
                VitalStatusCodingCodeConverter.Singleton,
                EcogCodingCodeConverter.Singleton,
                MolecularDiagnosticReportCodingCodeConverter.Singleton,
                ResponseMethodCodingCodeConverter.Singleton,
                RecistCodingCodeConverter.Singleton,
                TumorSpecimenCollectionLocalizationCodingCodeConverter.Singleton,
                TumorSpecimenCollectionMethodCodingCodeConverter.Singleton,
                TumorSpecimenCodingCodeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class GeneticCounselingRecommendationReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GeneticCounselingRecommendationReasonCodingCode) ||
                                                   t == typeof(GeneticCounselingRecommendationReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "family-anamnesis":
                    return GeneticCounselingRecommendationReasonCodingCode.FamilyAnamnesis;
                case "other":
                    return GeneticCounselingRecommendationReasonCodingCode.Other;
                case "secondary-tumor":
                    return GeneticCounselingRecommendationReasonCodingCode.SecondaryTumor;
                case "self-anamnesis":
                    return GeneticCounselingRecommendationReasonCodingCode.SelfAnamnesis;
                case "unknown":
                    return GeneticCounselingRecommendationReasonCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type GeneticCounselingRecommendationReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (GeneticCounselingRecommendationReasonCodingCode)untypedValue;
            switch (value)
            {
                case GeneticCounselingRecommendationReasonCodingCode.FamilyAnamnesis:
                    serializer.Serialize(writer, "family-anamnesis");
                    return;
                case GeneticCounselingRecommendationReasonCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case GeneticCounselingRecommendationReasonCodingCode.SecondaryTumor:
                    serializer.Serialize(writer, "secondary-tumor");
                    return;
                case GeneticCounselingRecommendationReasonCodingCode.SelfAnamnesis:
                    serializer.Serialize(writer, "self-anamnesis");
                    return;
                case GeneticCounselingRecommendationReasonCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type GeneticCounselingRecommendationReasonCodingCode");
        }

        public static readonly GeneticCounselingRecommendationReasonCodingCodeConverter Singleton =
            new GeneticCounselingRecommendationReasonCodingCodeConverter();
    }

    internal class MtbMedicationRecommendationCategoryCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbMedicationRecommendationCategoryCodingCode) ||
                                                   t == typeof(MtbMedicationRecommendationCategoryCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CH":
                    return MtbMedicationRecommendationCategoryCodingCode.Ch;
                case "HO":
                    return MtbMedicationRecommendationCategoryCodingCode.Ho;
                case "IM":
                    return MtbMedicationRecommendationCategoryCodingCode.Im;
                case "SO":
                    return MtbMedicationRecommendationCategoryCodingCode.So;
                case "SZ":
                    return MtbMedicationRecommendationCategoryCodingCode.Sz;
                case "ZS":
                    return MtbMedicationRecommendationCategoryCodingCode.Zs;
            }

            throw new Exception("Cannot unmarshal type MtbMedicationRecommendationCategoryCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbMedicationRecommendationCategoryCodingCode)untypedValue;
            switch (value)
            {
                case MtbMedicationRecommendationCategoryCodingCode.Ch:
                    serializer.Serialize(writer, "CH");
                    return;
                case MtbMedicationRecommendationCategoryCodingCode.Ho:
                    serializer.Serialize(writer, "HO");
                    return;
                case MtbMedicationRecommendationCategoryCodingCode.Im:
                    serializer.Serialize(writer, "IM");
                    return;
                case MtbMedicationRecommendationCategoryCodingCode.So:
                    serializer.Serialize(writer, "SO");
                    return;
                case MtbMedicationRecommendationCategoryCodingCode.Sz:
                    serializer.Serialize(writer, "SZ");
                    return;
                case MtbMedicationRecommendationCategoryCodingCode.Zs:
                    serializer.Serialize(writer, "ZS");
                    return;
            }

            throw new Exception("Cannot marshal type MtbMedicationRecommendationCategoryCodingCode");
        }

        public static readonly MtbMedicationRecommendationCategoryCodingCodeConverter Singleton =
            new MtbMedicationRecommendationCategoryCodingCodeConverter();
    }

    internal class LevelOfEvidenceAddendumCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LevelOfEvidenceAddendumCodingCode) ||
                                                   t == typeof(LevelOfEvidenceAddendumCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "R":
                    return LevelOfEvidenceAddendumCodingCode.R;
                case "Z":
                    return LevelOfEvidenceAddendumCodingCode.Z;
                case "is":
                    return LevelOfEvidenceAddendumCodingCode.Is;
                case "iv":
                    return LevelOfEvidenceAddendumCodingCode.Iv;
            }

            throw new Exception("Cannot unmarshal type LevelOfEvidenceAddendumCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (LevelOfEvidenceAddendumCodingCode)untypedValue;
            switch (value)
            {
                case LevelOfEvidenceAddendumCodingCode.R:
                    serializer.Serialize(writer, "R");
                    return;
                case LevelOfEvidenceAddendumCodingCode.Z:
                    serializer.Serialize(writer, "Z");
                    return;
                case LevelOfEvidenceAddendumCodingCode.Is:
                    serializer.Serialize(writer, "is");
                    return;
                case LevelOfEvidenceAddendumCodingCode.Iv:
                    serializer.Serialize(writer, "iv");
                    return;
            }

            throw new Exception("Cannot marshal type LevelOfEvidenceAddendumCodingCode");
        }

        public static readonly LevelOfEvidenceAddendumCodingCodeConverter Singleton =
            new LevelOfEvidenceAddendumCodingCodeConverter();
    }

    internal class LevelOfEvidenceGradingCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LevelOfEvidenceGradingCodingCode) ||
                                                   t == typeof(LevelOfEvidenceGradingCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "m1A":
                    return LevelOfEvidenceGradingCodingCode.M1A;
                case "m1B":
                    return LevelOfEvidenceGradingCodingCode.M1B;
                case "m1C":
                    return LevelOfEvidenceGradingCodingCode.M1C;
                case "m2A":
                    return LevelOfEvidenceGradingCodingCode.M2A;
                case "m2B":
                    return LevelOfEvidenceGradingCodingCode.M2B;
                case "m2C":
                    return LevelOfEvidenceGradingCodingCode.M2C;
                case "m3":
                    return LevelOfEvidenceGradingCodingCode.M3;
                case "m4":
                    return LevelOfEvidenceGradingCodingCode.M4;
                case "undefined":
                    return LevelOfEvidenceGradingCodingCode.Undefined;
            }

            throw new Exception("Cannot unmarshal type LevelOfEvidenceGradingCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (LevelOfEvidenceGradingCodingCode)untypedValue;
            switch (value)
            {
                case LevelOfEvidenceGradingCodingCode.M1A:
                    serializer.Serialize(writer, "m1A");
                    return;
                case LevelOfEvidenceGradingCodingCode.M1B:
                    serializer.Serialize(writer, "m1B");
                    return;
                case LevelOfEvidenceGradingCodingCode.M1C:
                    serializer.Serialize(writer, "m1C");
                    return;
                case LevelOfEvidenceGradingCodingCode.M2A:
                    serializer.Serialize(writer, "m2A");
                    return;
                case LevelOfEvidenceGradingCodingCode.M2B:
                    serializer.Serialize(writer, "m2B");
                    return;
                case LevelOfEvidenceGradingCodingCode.M2C:
                    serializer.Serialize(writer, "m2C");
                    return;
                case LevelOfEvidenceGradingCodingCode.M3:
                    serializer.Serialize(writer, "m3");
                    return;
                case LevelOfEvidenceGradingCodingCode.M4:
                    serializer.Serialize(writer, "m4");
                    return;
                case LevelOfEvidenceGradingCodingCode.Undefined:
                    serializer.Serialize(writer, "undefined");
                    return;
            }

            throw new Exception("Cannot marshal type LevelOfEvidenceGradingCodingCode");
        }

        public static readonly LevelOfEvidenceGradingCodingCodeConverter Singleton =
            new LevelOfEvidenceGradingCodingCodeConverter();
    }

    internal class PublicationSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PublicationSystem) || t == typeof(PublicationSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://pubmed.ncbi.nlm.nih.gov":
                    return PublicationSystem.PubmedNcbiNlmNihGov;
                case "https://www.doi.org":
                    return PublicationSystem.DoiOrg;
            }

            throw new Exception("Cannot unmarshal type PublicationSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (PublicationSystem)untypedValue;
            switch (value)
            {
                case PublicationSystem.PubmedNcbiNlmNihGov:
                    serializer.Serialize(writer, "https://pubmed.ncbi.nlm.nih.gov");
                    return;
                case PublicationSystem.DoiOrg:
                    serializer.Serialize(writer, "https://www.doi.org");
                    return;
            }

            throw new Exception("Cannot marshal type PublicationSystem");
        }

        public static readonly PublicationSystemConverter Singleton = new PublicationSystemConverter();
    }

    internal class RequestedMedicationSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(RequestedMedicationSystem) || t == typeof(RequestedMedicationSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "http://fhir.de/CodeSystem/bfarm/atc":
                    return RequestedMedicationSystem.HttpFhirDeCodeSystemBfarmAtc;
                case "undefined":
                    return RequestedMedicationSystem.Undefined;
            }

            throw new Exception("Cannot unmarshal type RequestedMedicationSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (RequestedMedicationSystem)untypedValue;
            switch (value)
            {
                case RequestedMedicationSystem.HttpFhirDeCodeSystemBfarmAtc:
                    serializer.Serialize(writer, "http://fhir.de/CodeSystem/bfarm/atc");
                    return;
                case RequestedMedicationSystem.Undefined:
                    serializer.Serialize(writer, "undefined");
                    return;
            }

            throw new Exception("Cannot marshal type RequestedMedicationSystem");
        }

        public static readonly RequestedMedicationSystemConverter Singleton = new RequestedMedicationSystemConverter();
    }

    internal class RecommendationPriorityCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RecommendationPriorityCodingCode) ||
                                                   t == typeof(RecommendationPriorityCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1":
                    return RecommendationPriorityCodingCode.Code1;
                case "2":
                    return RecommendationPriorityCodingCode.Code2;
                case "3":
                    return RecommendationPriorityCodingCode.Code3;
                case "4":
                    return RecommendationPriorityCodingCode.Code4;
            }

            throw new Exception("Cannot unmarshal type RecommendationPriorityCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (RecommendationPriorityCodingCode)untypedValue;
            switch (value)
            {
                case RecommendationPriorityCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case RecommendationPriorityCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case RecommendationPriorityCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case RecommendationPriorityCodingCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
            }

            throw new Exception("Cannot marshal type RecommendationPriorityCodingCode");
        }

        public static readonly RecommendationPriorityCodingCodeConverter Singleton =
            new RecommendationPriorityCodingCodeConverter();
    }

    internal class MtbMedicationRecommendationUseTypeCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbMedicationRecommendationUseTypeCodingCode) ||
                                                   t == typeof(MtbMedicationRecommendationUseTypeCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "compassionate":
                    return MtbMedicationRecommendationUseTypeCodingCode.Compassionate;
                case "in-label":
                    return MtbMedicationRecommendationUseTypeCodingCode.InLabel;
                case "off-label":
                    return MtbMedicationRecommendationUseTypeCodingCode.OffLabel;
                case "sec-preventive":
                    return MtbMedicationRecommendationUseTypeCodingCode.SecPreventive;
                case "unknown":
                    return MtbMedicationRecommendationUseTypeCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type MtbMedicationRecommendationUseTypeCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbMedicationRecommendationUseTypeCodingCode)untypedValue;
            switch (value)
            {
                case MtbMedicationRecommendationUseTypeCodingCode.Compassionate:
                    serializer.Serialize(writer, "compassionate");
                    return;
                case MtbMedicationRecommendationUseTypeCodingCode.InLabel:
                    serializer.Serialize(writer, "in-label");
                    return;
                case MtbMedicationRecommendationUseTypeCodingCode.OffLabel:
                    serializer.Serialize(writer, "off-label");
                    return;
                case MtbMedicationRecommendationUseTypeCodingCode.SecPreventive:
                    serializer.Serialize(writer, "sec-preventive");
                    return;
                case MtbMedicationRecommendationUseTypeCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type MtbMedicationRecommendationUseTypeCodingCode");
        }

        public static readonly MtbMedicationRecommendationUseTypeCodingCodeConverter Singleton =
            new MtbMedicationRecommendationUseTypeCodingCodeConverter();
    }

    internal class NoSequencingPerformedReasonCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NoSequencingPerformedReasonCode) ||
                                                   t == typeof(NoSequencingPerformedReasonCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "non-genetic-cause":
                    return NoSequencingPerformedReasonCode.NonGeneticCause;
                case "not-rare-disease":
                    return NoSequencingPerformedReasonCode.NotRareDisease;
                case "other":
                    return NoSequencingPerformedReasonCode.Other;
                case "psychosomatic":
                    return NoSequencingPerformedReasonCode.Psychosomatic;
                case "targeted-diagnostics-recommended":
                    return NoSequencingPerformedReasonCode.TargetedDiagnosticsRecommended;
            }

            throw new Exception("Cannot unmarshal type NoSequencingPerformedReasonCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (NoSequencingPerformedReasonCode)untypedValue;
            switch (value)
            {
                case NoSequencingPerformedReasonCode.NonGeneticCause:
                    serializer.Serialize(writer, "non-genetic-cause");
                    return;
                case NoSequencingPerformedReasonCode.NotRareDisease:
                    serializer.Serialize(writer, "not-rare-disease");
                    return;
                case NoSequencingPerformedReasonCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case NoSequencingPerformedReasonCode.Psychosomatic:
                    serializer.Serialize(writer, "psychosomatic");
                    return;
                case NoSequencingPerformedReasonCode.TargetedDiagnosticsRecommended:
                    serializer.Serialize(writer, "targeted-diagnostics-recommended");
                    return;
            }

            throw new Exception("Cannot marshal type NoSequencingPerformedReasonCode");
        }

        public static readonly NoSequencingPerformedReasonCodeConverter Singleton =
            new NoSequencingPerformedReasonCodeConverter();
    }

    internal class MtbProcedureRecommendationCategoryCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbProcedureRecommendationCategoryCodingCode) ||
                                                   t == typeof(MtbProcedureRecommendationCategoryCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "AS":
                    return MtbProcedureRecommendationCategoryCodingCode.As;
                case "OP":
                    return MtbProcedureRecommendationCategoryCodingCode.Op;
                case "SO":
                    return MtbProcedureRecommendationCategoryCodingCode.So;
                case "ST":
                    return MtbProcedureRecommendationCategoryCodingCode.St;
                case "WS":
                    return MtbProcedureRecommendationCategoryCodingCode.Ws;
                case "WW":
                    return MtbProcedureRecommendationCategoryCodingCode.Ww;
            }

            throw new Exception("Cannot unmarshal type MtbProcedureRecommendationCategoryCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbProcedureRecommendationCategoryCodingCode)untypedValue;
            switch (value)
            {
                case MtbProcedureRecommendationCategoryCodingCode.As:
                    serializer.Serialize(writer, "AS");
                    return;
                case MtbProcedureRecommendationCategoryCodingCode.Op:
                    serializer.Serialize(writer, "OP");
                    return;
                case MtbProcedureRecommendationCategoryCodingCode.So:
                    serializer.Serialize(writer, "SO");
                    return;
                case MtbProcedureRecommendationCategoryCodingCode.St:
                    serializer.Serialize(writer, "ST");
                    return;
                case MtbProcedureRecommendationCategoryCodingCode.Ws:
                    serializer.Serialize(writer, "WS");
                    return;
                case MtbProcedureRecommendationCategoryCodingCode.Ww:
                    serializer.Serialize(writer, "WW");
                    return;
            }

            throw new Exception("Cannot marshal type MtbProcedureRecommendationCategoryCodingCode");
        }

        public static readonly MtbProcedureRecommendationCategoryCodingCodeConverter Singleton =
            new MtbProcedureRecommendationCategoryCodingCodeConverter();
    }

    internal class MtbCarePlanRecommendationsMissingReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbCarePlanRecommendationsMissingReasonCodingCode) ||
                                                   t == typeof(MtbCarePlanRecommendationsMissingReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "no-target")
            {
                return MtbCarePlanRecommendationsMissingReasonCodingCode.NoTarget;
            }

            throw new Exception("Cannot unmarshal type MtbCarePlanRecommendationsMissingReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbCarePlanRecommendationsMissingReasonCodingCode)untypedValue;
            if (value == MtbCarePlanRecommendationsMissingReasonCodingCode.NoTarget)
            {
                serializer.Serialize(writer, "no-target");
                return;
            }

            throw new Exception("Cannot marshal type MtbCarePlanRecommendationsMissingReasonCodingCode");
        }

        public static readonly MtbCarePlanRecommendationsMissingReasonCodingCodeConverter Singleton =
            new MtbCarePlanRecommendationsMissingReasonCodingCodeConverter();
    }

    internal class StudySystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StudySystem) || t == typeof(StudySystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "DRKS":
                    return StudySystem.Drks;
                case "EUDAMED":
                    return StudySystem.Eudamed;
                case "Eudra-CT":
                    return StudySystem.EudraCt;
                case "NCT":
                    return StudySystem.Nct;
            }

            throw new Exception("Cannot unmarshal type StudySystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (StudySystem)untypedValue;
            switch (value)
            {
                case StudySystem.Drks:
                    serializer.Serialize(writer, "DRKS");
                    return;
                case StudySystem.Eudamed:
                    serializer.Serialize(writer, "EUDAMED");
                    return;
                case StudySystem.EudraCt:
                    serializer.Serialize(writer, "Eudra-CT");
                    return;
                case StudySystem.Nct:
                    serializer.Serialize(writer, "NCT");
                    return;
            }

            throw new Exception("Cannot marshal type StudySystem");
        }

        public static readonly StudySystemConverter Singleton = new StudySystemConverter();
    }

    internal class ClaimResponseStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(ClaimResponseStatusCodingCode) || t == typeof(ClaimResponseStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "accepted":
                    return ClaimResponseStatusCodingCode.Accepted;
                case "rejected":
                    return ClaimResponseStatusCodingCode.Rejected;
                case "unknown":
                    return ClaimResponseStatusCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type ClaimResponseStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ClaimResponseStatusCodingCode)untypedValue;
            switch (value)
            {
                case ClaimResponseStatusCodingCode.Accepted:
                    serializer.Serialize(writer, "accepted");
                    return;
                case ClaimResponseStatusCodingCode.Rejected:
                    serializer.Serialize(writer, "rejected");
                    return;
                case ClaimResponseStatusCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type ClaimResponseStatusCodingCode");
        }

        public static readonly ClaimResponseStatusCodingCodeConverter Singleton =
            new ClaimResponseStatusCodingCodeConverter();
    }

    internal class ClaimResponseStatusReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClaimResponseStatusReasonCodingCode) ||
                                                   t == typeof(ClaimResponseStatusReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "approval-revocation":
                    return ClaimResponseStatusReasonCodingCode.ApprovalRevocation;
                case "formal-reasons":
                    return ClaimResponseStatusReasonCodingCode.FormalReasons;
                case "inclusion-in-study":
                    return ClaimResponseStatusReasonCodingCode.InclusionInStudy;
                case "insufficient-evidence":
                    return ClaimResponseStatusReasonCodingCode.InsufficientEvidence;
                case "other":
                    return ClaimResponseStatusReasonCodingCode.Other;
                case "other-therapy-recommended":
                    return ClaimResponseStatusReasonCodingCode.OtherTherapyRecommended;
                case "standard-therapy-not-exhausted":
                    return ClaimResponseStatusReasonCodingCode.StandardTherapyNotExhausted;
                case "unknown":
                    return ClaimResponseStatusReasonCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type ClaimResponseStatusReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ClaimResponseStatusReasonCodingCode)untypedValue;
            switch (value)
            {
                case ClaimResponseStatusReasonCodingCode.ApprovalRevocation:
                    serializer.Serialize(writer, "approval-revocation");
                    return;
                case ClaimResponseStatusReasonCodingCode.FormalReasons:
                    serializer.Serialize(writer, "formal-reasons");
                    return;
                case ClaimResponseStatusReasonCodingCode.InclusionInStudy:
                    serializer.Serialize(writer, "inclusion-in-study");
                    return;
                case ClaimResponseStatusReasonCodingCode.InsufficientEvidence:
                    serializer.Serialize(writer, "insufficient-evidence");
                    return;
                case ClaimResponseStatusReasonCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case ClaimResponseStatusReasonCodingCode.OtherTherapyRecommended:
                    serializer.Serialize(writer, "other-therapy-recommended");
                    return;
                case ClaimResponseStatusReasonCodingCode.StandardTherapyNotExhausted:
                    serializer.Serialize(writer, "standard-therapy-not-exhausted");
                    return;
                case ClaimResponseStatusReasonCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type ClaimResponseStatusReasonCodingCode");
        }

        public static readonly ClaimResponseStatusReasonCodingCodeConverter Singleton =
            new ClaimResponseStatusReasonCodingCodeConverter();
    }

    internal class ClaimStageCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(ClaimStageCodingCode) || t == typeof(ClaimStageCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "follow-up-claim":
                    return ClaimStageCodingCode.FollowUpClaim;
                case "initial-claim":
                    return ClaimStageCodingCode.InitialClaim;
                case "revocation":
                    return ClaimStageCodingCode.Revocation;
                case "unknown":
                    return ClaimStageCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type ClaimStageCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ClaimStageCodingCode)untypedValue;
            switch (value)
            {
                case ClaimStageCodingCode.FollowUpClaim:
                    serializer.Serialize(writer, "follow-up-claim");
                    return;
                case ClaimStageCodingCode.InitialClaim:
                    serializer.Serialize(writer, "initial-claim");
                    return;
                case ClaimStageCodingCode.Revocation:
                    serializer.Serialize(writer, "revocation");
                    return;
                case ClaimStageCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type ClaimStageCodingCode");
        }

        public static readonly ClaimStageCodingCodeConverter Singleton = new ClaimStageCodingCodeConverter();
    }

    internal class MtbDiagnosisGuidelineTreatmentStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbDiagnosisGuidelineTreatmentStatusCodingCode) ||
                                                   t == typeof(MtbDiagnosisGuidelineTreatmentStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "exhausted":
                    return MtbDiagnosisGuidelineTreatmentStatusCodingCode.Exhausted;
                case "impossible":
                    return MtbDiagnosisGuidelineTreatmentStatusCodingCode.Impossible;
                case "no-guidelines-available":
                    return MtbDiagnosisGuidelineTreatmentStatusCodingCode.NoGuidelinesAvailable;
                case "non-exhausted":
                    return MtbDiagnosisGuidelineTreatmentStatusCodingCode.NonExhausted;
                case "unknown":
                    return MtbDiagnosisGuidelineTreatmentStatusCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type MtbDiagnosisGuidelineTreatmentStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbDiagnosisGuidelineTreatmentStatusCodingCode)untypedValue;
            switch (value)
            {
                case MtbDiagnosisGuidelineTreatmentStatusCodingCode.Exhausted:
                    serializer.Serialize(writer, "exhausted");
                    return;
                case MtbDiagnosisGuidelineTreatmentStatusCodingCode.Impossible:
                    serializer.Serialize(writer, "impossible");
                    return;
                case MtbDiagnosisGuidelineTreatmentStatusCodingCode.NoGuidelinesAvailable:
                    serializer.Serialize(writer, "no-guidelines-available");
                    return;
                case MtbDiagnosisGuidelineTreatmentStatusCodingCode.NonExhausted:
                    serializer.Serialize(writer, "non-exhausted");
                    return;
                case MtbDiagnosisGuidelineTreatmentStatusCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type MtbDiagnosisGuidelineTreatmentStatusCodingCode");
        }

        public static readonly MtbDiagnosisGuidelineTreatmentStatusCodingCodeConverter Singleton =
            new MtbDiagnosisGuidelineTreatmentStatusCodingCodeConverter();
    }

    internal class TumorStagingMethodCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(TumorStagingMethodCodingCode) || t == typeof(TumorStagingMethodCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "clinical":
                    return TumorStagingMethodCodingCode.Clinical;
                case "pathologic":
                    return TumorStagingMethodCodingCode.Pathologic;
            }

            throw new Exception("Cannot unmarshal type TumorStagingMethodCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TumorStagingMethodCodingCode)untypedValue;
            switch (value)
            {
                case TumorStagingMethodCodingCode.Clinical:
                    serializer.Serialize(writer, "clinical");
                    return;
                case TumorStagingMethodCodingCode.Pathologic:
                    serializer.Serialize(writer, "pathologic");
                    return;
            }

            throw new Exception("Cannot marshal type TumorStagingMethodCodingCode");
        }

        public static readonly TumorStagingMethodCodingCodeConverter Singleton =
            new TumorStagingMethodCodingCodeConverter();
    }

    internal class ValueCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ValueCode) || t == typeof(ValueCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "main":
                    return ValueCode.Main;
                case "metachronous":
                    return ValueCode.Metachronous;
                case "secondary":
                    return ValueCode.Secondary;
            }

            throw new Exception("Cannot unmarshal type ValueCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ValueCode)untypedValue;
            switch (value)
            {
                case ValueCode.Main:
                    serializer.Serialize(writer, "main");
                    return;
                case ValueCode.Metachronous:
                    serializer.Serialize(writer, "metachronous");
                    return;
                case ValueCode.Secondary:
                    serializer.Serialize(writer, "secondary");
                    return;
            }

            throw new Exception("Cannot marshal type ValueCode");
        }

        public static readonly ValueCodeConverter Singleton = new ValueCodeConverter();
    }

    internal class FamilyMemberHistoryRelationshipTypeCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FamilyMemberHistoryRelationshipTypeCodingCode) ||
                                                   t == typeof(FamilyMemberHistoryRelationshipTypeCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "EXT":
                    return FamilyMemberHistoryRelationshipTypeCodingCode.Ext;
                case "FAMMEMB":
                    return FamilyMemberHistoryRelationshipTypeCodingCode.Fammemb;
            }

            throw new Exception("Cannot unmarshal type FamilyMemberHistoryRelationshipTypeCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (FamilyMemberHistoryRelationshipTypeCodingCode)untypedValue;
            switch (value)
            {
                case FamilyMemberHistoryRelationshipTypeCodingCode.Ext:
                    serializer.Serialize(writer, "EXT");
                    return;
                case FamilyMemberHistoryRelationshipTypeCodingCode.Fammemb:
                    serializer.Serialize(writer, "FAMMEMB");
                    return;
            }

            throw new Exception("Cannot marshal type FamilyMemberHistoryRelationshipTypeCodingCode");
        }

        public static readonly FamilyMemberHistoryRelationshipTypeCodingCodeConverter Singleton =
            new FamilyMemberHistoryRelationshipTypeCodingCodeConverter();
    }

    internal class FollowUpPatientStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FollowUpPatientStatusCodingCode) ||
                                                   t == typeof(FollowUpPatientStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "lost-to-fu")
            {
                return FollowUpPatientStatusCodingCode.LostToFu;
            }

            throw new Exception("Cannot unmarshal type FollowUpPatientStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (FollowUpPatientStatusCodingCode)untypedValue;
            if (value == FollowUpPatientStatusCodingCode.LostToFu)
            {
                serializer.Serialize(writer, "lost-to-fu");
                return;
            }

            throw new Exception("Cannot marshal type FollowUpPatientStatusCodingCode");
        }

        public static readonly FollowUpPatientStatusCodingCodeConverter Singleton =
            new FollowUpPatientStatusCodingCodeConverter();
    }

    internal class OncoProcedureCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(OncoProcedureCodingCode) || t == typeof(OncoProcedureCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "nuclear-medicine":
                    return OncoProcedureCodingCode.NuclearMedicine;
                case "radio-therapy":
                    return OncoProcedureCodingCode.RadioTherapy;
                case "surgery":
                    return OncoProcedureCodingCode.Surgery;
            }

            throw new Exception("Cannot unmarshal type OncoProcedureCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (OncoProcedureCodingCode)untypedValue;
            switch (value)
            {
                case OncoProcedureCodingCode.NuclearMedicine:
                    serializer.Serialize(writer, "nuclear-medicine");
                    return;
                case OncoProcedureCodingCode.RadioTherapy:
                    serializer.Serialize(writer, "radio-therapy");
                    return;
                case OncoProcedureCodingCode.Surgery:
                    serializer.Serialize(writer, "surgery");
                    return;
            }

            throw new Exception("Cannot marshal type OncoProcedureCodingCode");
        }

        public static readonly OncoProcedureCodingCodeConverter Singleton = new OncoProcedureCodingCodeConverter();
    }

    internal class MtbTherapyIntentCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(MtbTherapyIntentCodingCode) || t == typeof(MtbTherapyIntentCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "K":
                    return MtbTherapyIntentCodingCode.K;
                case "P":
                    return MtbTherapyIntentCodingCode.P;
                case "S":
                    return MtbTherapyIntentCodingCode.S;
                case "X":
                    return MtbTherapyIntentCodingCode.X;
            }

            throw new Exception("Cannot unmarshal type MtbTherapyIntentCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbTherapyIntentCodingCode)untypedValue;
            switch (value)
            {
                case MtbTherapyIntentCodingCode.K:
                    serializer.Serialize(writer, "K");
                    return;
                case MtbTherapyIntentCodingCode.P:
                    serializer.Serialize(writer, "P");
                    return;
                case MtbTherapyIntentCodingCode.S:
                    serializer.Serialize(writer, "S");
                    return;
                case MtbTherapyIntentCodingCode.X:
                    serializer.Serialize(writer, "X");
                    return;
            }

            throw new Exception("Cannot marshal type MtbTherapyIntentCodingCode");
        }

        public static readonly MtbTherapyIntentCodingCodeConverter
            Singleton = new MtbTherapyIntentCodingCodeConverter();
    }

    internal class TherapyStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(TherapyStatusCodingCode) || t == typeof(TherapyStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "completed":
                    return TherapyStatusCodingCode.Completed;
                case "not-done":
                    return TherapyStatusCodingCode.NotDone;
                case "on-going":
                    return TherapyStatusCodingCode.OnGoing;
                case "stopped":
                    return TherapyStatusCodingCode.Stopped;
                case "unknown":
                    return TherapyStatusCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type TherapyStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TherapyStatusCodingCode)untypedValue;
            switch (value)
            {
                case TherapyStatusCodingCode.Completed:
                    serializer.Serialize(writer, "completed");
                    return;
                case TherapyStatusCodingCode.NotDone:
                    serializer.Serialize(writer, "not-done");
                    return;
                case TherapyStatusCodingCode.OnGoing:
                    serializer.Serialize(writer, "on-going");
                    return;
                case TherapyStatusCodingCode.Stopped:
                    serializer.Serialize(writer, "stopped");
                    return;
                case TherapyStatusCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type TherapyStatusCodingCode");
        }

        public static readonly TherapyStatusCodingCodeConverter Singleton = new TherapyStatusCodingCodeConverter();
    }

    internal class MtbTherapyStatusReasonCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbTherapyStatusReasonCodingCode) ||
                                                   t == typeof(MtbTherapyStatusReasonCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "best-supportive-care":
                    return MtbTherapyStatusReasonCodingCode.BestSupportiveCare;
                case "chronic-remission":
                    return MtbTherapyStatusReasonCodingCode.ChronicRemission;
                case "deterioration":
                    return MtbTherapyStatusReasonCodingCode.Deterioration;
                case "lost-to-fu":
                    return MtbTherapyStatusReasonCodingCode.LostToFu;
                case "medical-reasons":
                    return MtbTherapyStatusReasonCodingCode.MedicalReasons;
                case "no-indication":
                    return MtbTherapyStatusReasonCodingCode.NoIndication;
                case "other":
                    return MtbTherapyStatusReasonCodingCode.Other;
                case "other-therapy-chosen":
                    return MtbTherapyStatusReasonCodingCode.OtherTherapyChosen;
                case "patient-death":
                    return MtbTherapyStatusReasonCodingCode.PatientDeath;
                case "patient-refusal":
                    return MtbTherapyStatusReasonCodingCode.PatientRefusal;
                case "patient-wish":
                    return MtbTherapyStatusReasonCodingCode.PatientWish;
                case "payment-ended":
                    return MtbTherapyStatusReasonCodingCode.PaymentEnded;
                case "payment-pending":
                    return MtbTherapyStatusReasonCodingCode.PaymentPending;
                case "payment-refused":
                    return MtbTherapyStatusReasonCodingCode.PaymentRefused;
                case "progression":
                    return MtbTherapyStatusReasonCodingCode.Progression;
                case "regular-completion":
                    return MtbTherapyStatusReasonCodingCode.RegularCompletion;
                case "regular-completion-with-dosage-reduction":
                    return MtbTherapyStatusReasonCodingCode.RegularCompletionWithDosageReduction;
                case "regular-completion-with-substance-change":
                    return MtbTherapyStatusReasonCodingCode.RegularCompletionWithSubstanceChange;
                case "toxicity":
                    return MtbTherapyStatusReasonCodingCode.Toxicity;
            }

            throw new Exception("Cannot unmarshal type MtbTherapyStatusReasonCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbTherapyStatusReasonCodingCode)untypedValue;
            switch (value)
            {
                case MtbTherapyStatusReasonCodingCode.BestSupportiveCare:
                    serializer.Serialize(writer, "best-supportive-care");
                    return;
                case MtbTherapyStatusReasonCodingCode.ChronicRemission:
                    serializer.Serialize(writer, "chronic-remission");
                    return;
                case MtbTherapyStatusReasonCodingCode.Deterioration:
                    serializer.Serialize(writer, "deterioration");
                    return;
                case MtbTherapyStatusReasonCodingCode.LostToFu:
                    serializer.Serialize(writer, "lost-to-fu");
                    return;
                case MtbTherapyStatusReasonCodingCode.MedicalReasons:
                    serializer.Serialize(writer, "medical-reasons");
                    return;
                case MtbTherapyStatusReasonCodingCode.NoIndication:
                    serializer.Serialize(writer, "no-indication");
                    return;
                case MtbTherapyStatusReasonCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case MtbTherapyStatusReasonCodingCode.OtherTherapyChosen:
                    serializer.Serialize(writer, "other-therapy-chosen");
                    return;
                case MtbTherapyStatusReasonCodingCode.PatientDeath:
                    serializer.Serialize(writer, "patient-death");
                    return;
                case MtbTherapyStatusReasonCodingCode.PatientRefusal:
                    serializer.Serialize(writer, "patient-refusal");
                    return;
                case MtbTherapyStatusReasonCodingCode.PatientWish:
                    serializer.Serialize(writer, "patient-wish");
                    return;
                case MtbTherapyStatusReasonCodingCode.PaymentEnded:
                    serializer.Serialize(writer, "payment-ended");
                    return;
                case MtbTherapyStatusReasonCodingCode.PaymentPending:
                    serializer.Serialize(writer, "payment-pending");
                    return;
                case MtbTherapyStatusReasonCodingCode.PaymentRefused:
                    serializer.Serialize(writer, "payment-refused");
                    return;
                case MtbTherapyStatusReasonCodingCode.Progression:
                    serializer.Serialize(writer, "progression");
                    return;
                case MtbTherapyStatusReasonCodingCode.RegularCompletion:
                    serializer.Serialize(writer, "regular-completion");
                    return;
                case MtbTherapyStatusReasonCodingCode.RegularCompletionWithDosageReduction:
                    serializer.Serialize(writer, "regular-completion-with-dosage-reduction");
                    return;
                case MtbTherapyStatusReasonCodingCode.RegularCompletionWithSubstanceChange:
                    serializer.Serialize(writer, "regular-completion-with-substance-change");
                    return;
                case MtbTherapyStatusReasonCodingCode.Toxicity:
                    serializer.Serialize(writer, "toxicity");
                    return;
            }

            throw new Exception("Cannot marshal type MtbTherapyStatusReasonCodingCode");
        }

        public static readonly MtbTherapyStatusReasonCodingCodeConverter Singleton =
            new MtbTherapyStatusReasonCodingCodeConverter();
    }

    internal class MtbSystemicTherapyCategoryCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbSystemicTherapyCategoryCodingCode) ||
                                                   t == typeof(MtbSystemicTherapyCategoryCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "A":
                    return MtbSystemicTherapyCategoryCodingCode.A;
                case "I":
                    return MtbSystemicTherapyCategoryCodingCode.I;
                case "N":
                    return MtbSystemicTherapyCategoryCodingCode.N;
                case "O":
                    return MtbSystemicTherapyCategoryCodingCode.O;
                case "S":
                    return MtbSystemicTherapyCategoryCodingCode.S;
            }

            throw new Exception("Cannot unmarshal type MtbSystemicTherapyCategoryCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbSystemicTherapyCategoryCodingCode)untypedValue;
            switch (value)
            {
                case MtbSystemicTherapyCategoryCodingCode.A:
                    serializer.Serialize(writer, "A");
                    return;
                case MtbSystemicTherapyCategoryCodingCode.I:
                    serializer.Serialize(writer, "I");
                    return;
                case MtbSystemicTherapyCategoryCodingCode.N:
                    serializer.Serialize(writer, "N");
                    return;
                case MtbSystemicTherapyCategoryCodingCode.O:
                    serializer.Serialize(writer, "O");
                    return;
                case MtbSystemicTherapyCategoryCodingCode.S:
                    serializer.Serialize(writer, "S");
                    return;
            }

            throw new Exception("Cannot marshal type MtbSystemicTherapyCategoryCodingCode");
        }

        public static readonly MtbSystemicTherapyCategoryCodingCodeConverter Singleton =
            new MtbSystemicTherapyCategoryCodingCodeConverter();
    }

    internal class MtbSystemicTherapyDosageDensityCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbSystemicTherapyDosageDensityCodingCode) ||
                                                   t == typeof(MtbSystemicTherapyDosageDensityCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "over-50%":
                    return MtbSystemicTherapyDosageDensityCodingCode.Over50;
                case "under-50%":
                    return MtbSystemicTherapyDosageDensityCodingCode.Under50;
            }

            throw new Exception("Cannot unmarshal type MtbSystemicTherapyDosageDensityCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbSystemicTherapyDosageDensityCodingCode)untypedValue;
            switch (value)
            {
                case MtbSystemicTherapyDosageDensityCodingCode.Over50:
                    serializer.Serialize(writer, "over-50%");
                    return;
                case MtbSystemicTherapyDosageDensityCodingCode.Under50:
                    serializer.Serialize(writer, "under-50%");
                    return;
            }

            throw new Exception("Cannot marshal type MtbSystemicTherapyDosageDensityCodingCode");
        }

        public static readonly MtbSystemicTherapyDosageDensityCodingCodeConverter Singleton =
            new MtbSystemicTherapyDosageDensityCodingCodeConverter();
    }

    internal class MtbSystemicTherapyRecommendationFulfillmentStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode) ||
            t == typeof(MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "complete":
                    return MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode.Complete;
                case "partial":
                    return MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode.Partial;
            }

            throw new Exception("Cannot unmarshal type MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode)untypedValue;
            switch (value)
            {
                case MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode.Complete:
                    serializer.Serialize(writer, "complete");
                    return;
                case MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode.Partial:
                    serializer.Serialize(writer, "partial");
                    return;
            }

            throw new Exception("Cannot marshal type MtbSystemicTherapyRecommendationFulfillmentStatusCodingCode");
        }

        public static readonly MtbSystemicTherapyRecommendationFulfillmentStatusCodingCodeConverter Singleton =
            new MtbSystemicTherapyRecommendationFulfillmentStatusCodingCodeConverter();
    }

    internal class TumorCellContentMethodCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorCellContentMethodCodingCode) ||
                                                   t == typeof(TumorCellContentMethodCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bioinformatic":
                    return TumorCellContentMethodCodingCode.Bioinformatic;
                case "histologic":
                    return TumorCellContentMethodCodingCode.Histologic;
            }

            throw new Exception("Cannot unmarshal type TumorCellContentMethodCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TumorCellContentMethodCodingCode)untypedValue;
            switch (value)
            {
                case TumorCellContentMethodCodingCode.Bioinformatic:
                    serializer.Serialize(writer, "bioinformatic");
                    return;
                case TumorCellContentMethodCodingCode.Histologic:
                    serializer.Serialize(writer, "histologic");
                    return;
            }

            throw new Exception("Cannot marshal type TumorCellContentMethodCodingCode");
        }

        public static readonly TumorCellContentMethodCodingCodeConverter Singleton =
            new TumorCellContentMethodCodingCodeConverter();
    }

    internal class ProteinExpressionIcScoreCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProteinExpressionIcScoreCodingCode) ||
                                                   t == typeof(ProteinExpressionIcScoreCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return ProteinExpressionIcScoreCodingCode.Code0;
                case "1":
                    return ProteinExpressionIcScoreCodingCode.Code1;
                case "2":
                    return ProteinExpressionIcScoreCodingCode.Code2;
                case "3":
                    return ProteinExpressionIcScoreCodingCode.Code3;
            }

            throw new Exception("Cannot unmarshal type ProteinExpressionIcScoreCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ProteinExpressionIcScoreCodingCode)untypedValue;
            switch (value)
            {
                case ProteinExpressionIcScoreCodingCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case ProteinExpressionIcScoreCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case ProteinExpressionIcScoreCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case ProteinExpressionIcScoreCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
            }

            throw new Exception("Cannot marshal type ProteinExpressionIcScoreCodingCode");
        }

        public static readonly ProteinExpressionIcScoreCodingCodeConverter Singleton =
            new ProteinExpressionIcScoreCodingCodeConverter();
    }

    internal class ProteinExpressionTcScoreCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProteinExpressionTcScoreCodingCode) ||
                                                   t == typeof(ProteinExpressionTcScoreCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return ProteinExpressionTcScoreCodingCode.Code0;
                case "1":
                    return ProteinExpressionTcScoreCodingCode.Code1;
                case "2":
                    return ProteinExpressionTcScoreCodingCode.Code2;
                case "3":
                    return ProteinExpressionTcScoreCodingCode.Code3;
                case "4":
                    return ProteinExpressionTcScoreCodingCode.Code4;
                case "5":
                    return ProteinExpressionTcScoreCodingCode.Code5;
                case "6":
                    return ProteinExpressionTcScoreCodingCode.Code6;
            }

            throw new Exception("Cannot unmarshal type ProteinExpressionTcScoreCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ProteinExpressionTcScoreCodingCode)untypedValue;
            switch (value)
            {
                case ProteinExpressionTcScoreCodingCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code5:
                    serializer.Serialize(writer, "5");
                    return;
                case ProteinExpressionTcScoreCodingCode.Code6:
                    serializer.Serialize(writer, "6");
                    return;
            }

            throw new Exception("Cannot marshal type ProteinExpressionTcScoreCodingCode");
        }

        public static readonly ProteinExpressionTcScoreCodingCodeConverter Singleton =
            new ProteinExpressionTcScoreCodingCodeConverter();
    }

    internal class ProteinExpressionResultCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProteinExpressionResultCodingCode) ||
                                                   t == typeof(ProteinExpressionResultCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1+":
                    return ProteinExpressionResultCodingCode.Code1Plus;
                case "2+":
                    return ProteinExpressionResultCodingCode.Code2Plus;
                case "3+":
                    return ProteinExpressionResultCodingCode.Code3Plus;
                case "exp":
                    return ProteinExpressionResultCodingCode.Exp;
                case "not-exp":
                    return ProteinExpressionResultCodingCode.NotExp;
                case "unknown":
                    return ProteinExpressionResultCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type ProteinExpressionResultCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ProteinExpressionResultCodingCode)untypedValue;
            switch (value)
            {
                case ProteinExpressionResultCodingCode.Code1Plus:
                    serializer.Serialize(writer, "1+");
                    return;
                case ProteinExpressionResultCodingCode.Code2Plus:
                    serializer.Serialize(writer, "2+");
                    return;
                case ProteinExpressionResultCodingCode.Code3Plus:
                    serializer.Serialize(writer, "3+");
                    return;
                case ProteinExpressionResultCodingCode.Exp:
                    serializer.Serialize(writer, "exp");
                    return;
                case ProteinExpressionResultCodingCode.NotExp:
                    serializer.Serialize(writer, "not-exp");
                    return;
                case ProteinExpressionResultCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type ProteinExpressionResultCodingCode");
        }

        public static readonly ProteinExpressionResultCodingCodeConverter Singleton =
            new ProteinExpressionResultCodingCodeConverter();
    }

    internal class ModelProjectConsentPurposeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(ModelProjectConsentPurpose) || t == typeof(ModelProjectConsentPurpose?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "case-identification":
                    return ModelProjectConsentPurpose.CaseIdentification;
                case "reidentification":
                    return ModelProjectConsentPurpose.Reidentification;
                case "sequencing":
                    return ModelProjectConsentPurpose.Sequencing;
            }

            throw new Exception("Cannot unmarshal type ModelProjectConsentPurpose");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ModelProjectConsentPurpose)untypedValue;
            switch (value)
            {
                case ModelProjectConsentPurpose.CaseIdentification:
                    serializer.Serialize(writer, "case-identification");
                    return;
                case ModelProjectConsentPurpose.Reidentification:
                    serializer.Serialize(writer, "reidentification");
                    return;
                case ModelProjectConsentPurpose.Sequencing:
                    serializer.Serialize(writer, "sequencing");
                    return;
            }

            throw new Exception("Cannot marshal type ModelProjectConsentPurpose");
        }

        public static readonly ModelProjectConsentPurposeConverter
            Singleton = new ModelProjectConsentPurposeConverter();
    }

    internal class ConsentProvisionConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConsentProvision) || t == typeof(ConsentProvision?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "deny":
                    return ConsentProvision.Deny;
                case "permit":
                    return ConsentProvision.Permit;
            }

            throw new Exception("Cannot unmarshal type ConsentProvision");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ConsentProvision)untypedValue;
            switch (value)
            {
                case ConsentProvision.Deny:
                    serializer.Serialize(writer, "deny");
                    return;
                case ConsentProvision.Permit:
                    serializer.Serialize(writer, "permit");
                    return;
            }

            throw new Exception("Cannot marshal type ConsentProvision");
        }

        public static readonly ConsentProvisionConverter Singleton = new ConsentProvisionConverter();
    }

    internal class MvhSubmissionTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MvhSubmissionType) || t == typeof(MvhSubmissionType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "addition":
                    return MvhSubmissionType.Addition;
                case "correction":
                    return MvhSubmissionType.Correction;
                case "followup":
                    return MvhSubmissionType.Followup;
                case "initial":
                    return MvhSubmissionType.Initial;
                case "test":
                    return MvhSubmissionType.Test;
            }

            throw new Exception("Cannot unmarshal type MvhSubmissionType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MvhSubmissionType)untypedValue;
            switch (value)
            {
                case MvhSubmissionType.Addition:
                    serializer.Serialize(writer, "addition");
                    return;
                case MvhSubmissionType.Correction:
                    serializer.Serialize(writer, "correction");
                    return;
                case MvhSubmissionType.Followup:
                    serializer.Serialize(writer, "followup");
                    return;
                case MvhSubmissionType.Initial:
                    serializer.Serialize(writer, "initial");
                    return;
                case MvhSubmissionType.Test:
                    serializer.Serialize(writer, "test");
                    return;
            }

            throw new Exception("Cannot marshal type MvhSubmissionType");
        }

        public static readonly MvhSubmissionTypeConverter Singleton = new MvhSubmissionTypeConverter();
    }

    internal class MsiInterpretationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(MsiInterpretationCodingCode) || t == typeof(MsiInterpretationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "mmr-deficient":
                    return MsiInterpretationCodingCode.MmrDeficient;
                case "mmr-proficient":
                    return MsiInterpretationCodingCode.MmrProficient;
                case "msi-high":
                    return MsiInterpretationCodingCode.MsiHigh;
                case "msi-low":
                    return MsiInterpretationCodingCode.MsiLow;
                case "stable":
                    return MsiInterpretationCodingCode.Stable;
                case "unknown":
                    return MsiInterpretationCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type MsiInterpretationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MsiInterpretationCodingCode)untypedValue;
            switch (value)
            {
                case MsiInterpretationCodingCode.MmrDeficient:
                    serializer.Serialize(writer, "mmr-deficient");
                    return;
                case MsiInterpretationCodingCode.MmrProficient:
                    serializer.Serialize(writer, "mmr-proficient");
                    return;
                case MsiInterpretationCodingCode.MsiHigh:
                    serializer.Serialize(writer, "msi-high");
                    return;
                case MsiInterpretationCodingCode.MsiLow:
                    serializer.Serialize(writer, "msi-low");
                    return;
                case MsiInterpretationCodingCode.Stable:
                    serializer.Serialize(writer, "stable");
                    return;
                case MsiInterpretationCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type MsiInterpretationCodingCode");
        }

        public static readonly MsiInterpretationCodingCodeConverter Singleton =
            new MsiInterpretationCodingCodeConverter();
    }

    internal class MsiMethodCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(MsiMethodCodingCode) || t == typeof(MsiMethodCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "IHC":
                    return MsiMethodCodingCode.Ihc;
                case "PCR":
                    return MsiMethodCodingCode.Pcr;
                case "bioinformatic":
                    return MsiMethodCodingCode.Bioinformatic;
            }

            throw new Exception("Cannot unmarshal type MsiMethodCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MsiMethodCodingCode)untypedValue;
            switch (value)
            {
                case MsiMethodCodingCode.Ihc:
                    serializer.Serialize(writer, "IHC");
                    return;
                case MsiMethodCodingCode.Pcr:
                    serializer.Serialize(writer, "PCR");
                    return;
                case MsiMethodCodingCode.Bioinformatic:
                    serializer.Serialize(writer, "bioinformatic");
                    return;
            }

            throw new Exception("Cannot marshal type MsiMethodCodingCode");
        }

        public static readonly MsiMethodCodingCodeConverter Singleton = new MsiMethodCodingCodeConverter();
    }

    internal class ChromosomeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Chromosome) || t == typeof(Chromosome?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "chr1":
                    return Chromosome.Chr1;
                case "chr10":
                    return Chromosome.Chr10;
                case "chr11":
                    return Chromosome.Chr11;
                case "chr12":
                    return Chromosome.Chr12;
                case "chr13":
                    return Chromosome.Chr13;
                case "chr14":
                    return Chromosome.Chr14;
                case "chr15":
                    return Chromosome.Chr15;
                case "chr16":
                    return Chromosome.Chr16;
                case "chr17":
                    return Chromosome.Chr17;
                case "chr18":
                    return Chromosome.Chr18;
                case "chr19":
                    return Chromosome.Chr19;
                case "chr2":
                    return Chromosome.Chr2;
                case "chr20":
                    return Chromosome.Chr20;
                case "chr21":
                    return Chromosome.Chr21;
                case "chr22":
                    return Chromosome.Chr22;
                case "chr3":
                    return Chromosome.Chr3;
                case "chr4":
                    return Chromosome.Chr4;
                case "chr5":
                    return Chromosome.Chr5;
                case "chr6":
                    return Chromosome.Chr6;
                case "chr7":
                    return Chromosome.Chr7;
                case "chr8":
                    return Chromosome.Chr8;
                case "chr9":
                    return Chromosome.Chr9;
                case "chrX":
                    return Chromosome.ChrX;
                case "chrY":
                    return Chromosome.ChrY;
                case "chrMT":
                    return Chromosome.ChrMt;
            }

            throw new Exception("Cannot unmarshal type Chromosome");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (Chromosome)untypedValue;
            switch (value)
            {
                case Chromosome.Chr1:
                    serializer.Serialize(writer, "chr1");
                    return;
                case Chromosome.Chr10:
                    serializer.Serialize(writer, "chr10");
                    return;
                case Chromosome.Chr11:
                    serializer.Serialize(writer, "chr11");
                    return;
                case Chromosome.Chr12:
                    serializer.Serialize(writer, "chr12");
                    return;
                case Chromosome.Chr13:
                    serializer.Serialize(writer, "chr13");
                    return;
                case Chromosome.Chr14:
                    serializer.Serialize(writer, "chr14");
                    return;
                case Chromosome.Chr15:
                    serializer.Serialize(writer, "chr15");
                    return;
                case Chromosome.Chr16:
                    serializer.Serialize(writer, "chr16");
                    return;
                case Chromosome.Chr17:
                    serializer.Serialize(writer, "chr17");
                    return;
                case Chromosome.Chr18:
                    serializer.Serialize(writer, "chr18");
                    return;
                case Chromosome.Chr19:
                    serializer.Serialize(writer, "chr19");
                    return;
                case Chromosome.Chr2:
                    serializer.Serialize(writer, "chr2");
                    return;
                case Chromosome.Chr20:
                    serializer.Serialize(writer, "chr20");
                    return;
                case Chromosome.Chr21:
                    serializer.Serialize(writer, "chr21");
                    return;
                case Chromosome.Chr22:
                    serializer.Serialize(writer, "chr22");
                    return;
                case Chromosome.Chr3:
                    serializer.Serialize(writer, "chr3");
                    return;
                case Chromosome.Chr4:
                    serializer.Serialize(writer, "chr4");
                    return;
                case Chromosome.Chr5:
                    serializer.Serialize(writer, "chr5");
                    return;
                case Chromosome.Chr6:
                    serializer.Serialize(writer, "chr6");
                    return;
                case Chromosome.Chr7:
                    serializer.Serialize(writer, "chr7");
                    return;
                case Chromosome.Chr8:
                    serializer.Serialize(writer, "chr8");
                    return;
                case Chromosome.Chr9:
                    serializer.Serialize(writer, "chr9");
                    return;
                case Chromosome.ChrX:
                    serializer.Serialize(writer, "chrX");
                    return;
                case Chromosome.ChrY:
                    serializer.Serialize(writer, "chrY");
                    return;
                case Chromosome.ChrMt:
                    serializer.Serialize(writer, "chrMT");
                    return;
            }

            throw new Exception("Cannot marshal type Chromosome");
        }

        public static readonly ChromosomeConverter Singleton = new ChromosomeConverter();
    }

    internal class ExternalIdSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExternalIdSystem) || t == typeof(ExternalIdSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://cancer.sanger.ac.uk/cosmic":
                    return ExternalIdSystem.CancerSangerAcUkCosmic;
                case "https://www.ensembl.org":
                    return ExternalIdSystem.EnsemblOrg;
                case "https://www.ncbi.nlm.nih.gov/entrez":
                    return ExternalIdSystem.NcbiNlmNihGovEntrez;
                case "https://www.ncbi.nlm.nih.gov/snp":
                    return ExternalIdSystem.NcbiNlmNihGovSnp;
            }

            throw new Exception("Cannot unmarshal type ExternalIdSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ExternalIdSystem)untypedValue;
            switch (value)
            {
                case ExternalIdSystem.CancerSangerAcUkCosmic:
                    serializer.Serialize(writer, "https://cancer.sanger.ac.uk/cosmic");
                    return;
                case ExternalIdSystem.EnsemblOrg:
                    serializer.Serialize(writer, "https://www.ensembl.org");
                    return;
                case ExternalIdSystem.NcbiNlmNihGovEntrez:
                    serializer.Serialize(writer, "https://www.ncbi.nlm.nih.gov/entrez");
                    return;
                case ExternalIdSystem.NcbiNlmNihGovSnp:
                    serializer.Serialize(writer, "https://www.ncbi.nlm.nih.gov/snp");
                    return;
            }

            throw new Exception("Cannot marshal type ExternalIdSystem");
        }

        public static readonly ExternalIdSystemConverter Singleton = new ExternalIdSystemConverter();
    }

    internal class BaseVariantLocalizationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BaseVariantLocalizationCodingCode) ||
                                                   t == typeof(BaseVariantLocalizationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "coding-region":
                    return BaseVariantLocalizationCodingCode.CodingRegion;
                case "intergenic":
                    return BaseVariantLocalizationCodingCode.Intergenic;
                case "intronic":
                    return BaseVariantLocalizationCodingCode.Intronic;
                case "regulatory-region":
                    return BaseVariantLocalizationCodingCode.RegulatoryRegion;
                case "splicing-region":
                    return BaseVariantLocalizationCodingCode.SplicingRegion;
            }

            throw new Exception("Cannot unmarshal type BaseVariantLocalizationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (BaseVariantLocalizationCodingCode)untypedValue;
            switch (value)
            {
                case BaseVariantLocalizationCodingCode.CodingRegion:
                    serializer.Serialize(writer, "coding-region");
                    return;
                case BaseVariantLocalizationCodingCode.Intergenic:
                    serializer.Serialize(writer, "intergenic");
                    return;
                case BaseVariantLocalizationCodingCode.Intronic:
                    serializer.Serialize(writer, "intronic");
                    return;
                case BaseVariantLocalizationCodingCode.RegulatoryRegion:
                    serializer.Serialize(writer, "regulatory-region");
                    return;
                case BaseVariantLocalizationCodingCode.SplicingRegion:
                    serializer.Serialize(writer, "splicing-region");
                    return;
            }

            throw new Exception("Cannot marshal type BaseVariantLocalizationCodingCode");
        }

        public static readonly BaseVariantLocalizationCodingCodeConverter Singleton =
            new BaseVariantLocalizationCodingCodeConverter();
    }

    internal class CnvCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CnvCodingCode) || t == typeof(CnvCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "high-level-gain":
                    return CnvCodingCode.HighLevelGain;
                case "loss":
                    return CnvCodingCode.Loss;
                case "low-level-gain":
                    return CnvCodingCode.LowLevelGain;
            }

            throw new Exception("Cannot unmarshal type CnvCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (CnvCodingCode)untypedValue;
            switch (value)
            {
                case CnvCodingCode.HighLevelGain:
                    serializer.Serialize(writer, "high-level-gain");
                    return;
                case CnvCodingCode.Loss:
                    serializer.Serialize(writer, "loss");
                    return;
                case CnvCodingCode.LowLevelGain:
                    serializer.Serialize(writer, "low-level-gain");
                    return;
            }

            throw new Exception("Cannot marshal type CnvCodingCode");
        }

        public static readonly CnvCodingCodeConverter Singleton = new CnvCodingCodeConverter();
    }

    internal class InterpretationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(InterpretationCodingCode) || t == typeof(InterpretationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "high":
                    return InterpretationCodingCode.High;
                case "intermediate":
                    return InterpretationCodingCode.Intermediate;
                case "low":
                    return InterpretationCodingCode.Low;
            }

            throw new Exception("Cannot unmarshal type InterpretationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (InterpretationCodingCode)untypedValue;
            switch (value)
            {
                case InterpretationCodingCode.High:
                    serializer.Serialize(writer, "high");
                    return;
                case InterpretationCodingCode.Intermediate:
                    serializer.Serialize(writer, "intermediate");
                    return;
                case InterpretationCodingCode.Low:
                    serializer.Serialize(writer, "low");
                    return;
            }

            throw new Exception("Cannot marshal type InterpretationCodingCode");
        }

        public static readonly InterpretationCodingCodeConverter Singleton = new InterpretationCodingCodeConverter();
    }

    internal class RnaFusionStrandConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RnaFusionStrand) || t == typeof(RnaFusionStrand?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "+":
                    return RnaFusionStrand.Empty;
                case "-":
                    return RnaFusionStrand.RnaFusionStrand;
            }

            throw new Exception("Cannot unmarshal type RnaFusionStrand");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (RnaFusionStrand)untypedValue;
            switch (value)
            {
                case RnaFusionStrand.Empty:
                    serializer.Serialize(writer, "+");
                    return;
                case RnaFusionStrand.RnaFusionStrand:
                    serializer.Serialize(writer, "-");
                    return;
            }

            throw new Exception("Cannot marshal type RnaFusionStrand");
        }

        public static readonly RnaFusionStrandConverter Singleton = new RnaFusionStrandConverter();
    }

    internal class TranscriptIdSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TranscriptIdSystem) || t == typeof(TranscriptIdSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "https://www.ensembl.org":
                    return TranscriptIdSystem.EnsemblOrg;
                case "https://www.ncbi.nlm.nih.gov/refseq":
                    return TranscriptIdSystem.NcbiNlmNihGovRefseq;
            }

            throw new Exception("Cannot unmarshal type TranscriptIdSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TranscriptIdSystem)untypedValue;
            switch (value)
            {
                case TranscriptIdSystem.EnsemblOrg:
                    serializer.Serialize(writer, "https://www.ensembl.org");
                    return;
                case TranscriptIdSystem.NcbiNlmNihGovRefseq:
                    serializer.Serialize(writer, "https://www.ncbi.nlm.nih.gov/refseq");
                    return;
            }

            throw new Exception("Cannot marshal type TranscriptIdSystem");
        }

        public static readonly TranscriptIdSystemConverter Singleton = new TranscriptIdSystemConverter();
    }

    internal class ClinVarCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClinVarCodingCode) || t == typeof(ClinVarCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1":
                    return ClinVarCodingCode.Code1;
                case "2":
                    return ClinVarCodingCode.Code2;
                case "3":
                    return ClinVarCodingCode.Code3;
                case "4":
                    return ClinVarCodingCode.Code4;
                case "5":
                    return ClinVarCodingCode.Code5;
            }

            throw new Exception("Cannot unmarshal type ClinVarCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ClinVarCodingCode)untypedValue;
            switch (value)
            {
                case ClinVarCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case ClinVarCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case ClinVarCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case ClinVarCodingCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
                case ClinVarCodingCode.Code5:
                    serializer.Serialize(writer, "5");
                    return;
            }

            throw new Exception("Cannot marshal type ClinVarCodingCode");
        }

        public static readonly ClinVarCodingCodeConverter Singleton = new ClinVarCodingCodeConverter();
    }

    internal class NgsReportCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(NgsReportCodingCode) || t == typeof(NgsReportCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return NgsReportCodingCode.Array;
                case "exome":
                    return NgsReportCodingCode.Exome;
                case "genome-long-read":
                    return NgsReportCodingCode.GenomeLongRead;
                case "genome-short-read":
                    return NgsReportCodingCode.GenomeShortRead;
                case "karyotyping":
                    return NgsReportCodingCode.Karyotyping;
                case "other":
                    return NgsReportCodingCode.Other;
                case "panel":
                    return NgsReportCodingCode.Panel;
                case "single":
                    return NgsReportCodingCode.Single;
            }

            throw new Exception("Cannot unmarshal type NgsReportCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (NgsReportCodingCode)untypedValue;
            switch (value)
            {
                case NgsReportCodingCode.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case NgsReportCodingCode.Exome:
                    serializer.Serialize(writer, "exome");
                    return;
                case NgsReportCodingCode.GenomeLongRead:
                    serializer.Serialize(writer, "genome-long-read");
                    return;
                case NgsReportCodingCode.GenomeShortRead:
                    serializer.Serialize(writer, "genome-short-read");
                    return;
                case NgsReportCodingCode.Karyotyping:
                    serializer.Serialize(writer, "karyotyping");
                    return;
                case NgsReportCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case NgsReportCodingCode.Panel:
                    serializer.Serialize(writer, "panel");
                    return;
                case NgsReportCodingCode.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }

            throw new Exception("Cannot marshal type NgsReportCodingCode");
        }

        public static readonly NgsReportCodingCodeConverter Singleton = new NgsReportCodingCodeConverter();
    }

    internal class UnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Unit) || t == typeof(Unit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "Months":
                    return Unit.Months;
                case "Years":
                    return Unit.Years;
            }

            throw new Exception("Cannot unmarshal type Unit");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (Unit)untypedValue;
            switch (value)
            {
                case Unit.Months:
                    serializer.Serialize(writer, "Months");
                    return;
                case Unit.Years:
                    serializer.Serialize(writer, "Years");
                    return;
            }

            throw new Exception("Cannot marshal type Unit");
        }

        public static readonly UnitConverter Singleton = new UnitConverter();
    }

    internal class GenderCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GenderCodingCode) || t == typeof(GenderCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return GenderCodingCode.Female;
                case "male":
                    return GenderCodingCode.Male;
                case "other":
                    return GenderCodingCode.Other;
                case "unknown":
                    return GenderCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type GenderCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (GenderCodingCode)untypedValue;
            switch (value)
            {
                case GenderCodingCode.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case GenderCodingCode.Male:
                    serializer.Serialize(writer, "male");
                    return;
                case GenderCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case GenderCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type GenderCodingCode");
        }

        public static readonly GenderCodingCodeConverter Singleton = new GenderCodingCodeConverter();
    }

    internal class HealthInsuranceCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(HealthInsuranceCodingCode) || t == typeof(HealthInsuranceCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BEI":
                    return HealthInsuranceCodingCode.Bei;
                case "BG":
                    return HealthInsuranceCodingCode.Bg;
                case "GKV":
                    return HealthInsuranceCodingCode.Gkv;
                case "GPV":
                    return HealthInsuranceCodingCode.Gpv;
                case "PKV":
                    return HealthInsuranceCodingCode.Pkv;
                case "PPV":
                    return HealthInsuranceCodingCode.Ppv;
                case "SEL":
                    return HealthInsuranceCodingCode.Sel;
                case "SKT":
                    return HealthInsuranceCodingCode.Skt;
                case "SOZ":
                    return HealthInsuranceCodingCode.Soz;
                case "UNK":
                    return HealthInsuranceCodingCode.Unk;
            }

            throw new Exception("Cannot unmarshal type HealthInsuranceCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (HealthInsuranceCodingCode)untypedValue;
            switch (value)
            {
                case HealthInsuranceCodingCode.Bei:
                    serializer.Serialize(writer, "BEI");
                    return;
                case HealthInsuranceCodingCode.Bg:
                    serializer.Serialize(writer, "BG");
                    return;
                case HealthInsuranceCodingCode.Gkv:
                    serializer.Serialize(writer, "GKV");
                    return;
                case HealthInsuranceCodingCode.Gpv:
                    serializer.Serialize(writer, "GPV");
                    return;
                case HealthInsuranceCodingCode.Pkv:
                    serializer.Serialize(writer, "PKV");
                    return;
                case HealthInsuranceCodingCode.Ppv:
                    serializer.Serialize(writer, "PPV");
                    return;
                case HealthInsuranceCodingCode.Sel:
                    serializer.Serialize(writer, "SEL");
                    return;
                case HealthInsuranceCodingCode.Skt:
                    serializer.Serialize(writer, "SKT");
                    return;
                case HealthInsuranceCodingCode.Soz:
                    serializer.Serialize(writer, "SOZ");
                    return;
                case HealthInsuranceCodingCode.Unk:
                    serializer.Serialize(writer, "UNK");
                    return;
            }

            throw new Exception("Cannot marshal type HealthInsuranceCodingCode");
        }

        public static readonly HealthInsuranceCodingCodeConverter Singleton = new HealthInsuranceCodingCodeConverter();
    }

    internal class VitalStatusCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(VitalStatusCodingCode) || t == typeof(VitalStatusCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alive":
                    return VitalStatusCodingCode.Alive;
                case "deceased":
                    return VitalStatusCodingCode.Deceased;
            }

            throw new Exception("Cannot unmarshal type VitalStatusCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (VitalStatusCodingCode)untypedValue;
            switch (value)
            {
                case VitalStatusCodingCode.Alive:
                    serializer.Serialize(writer, "alive");
                    return;
                case VitalStatusCodingCode.Deceased:
                    serializer.Serialize(writer, "deceased");
                    return;
            }

            throw new Exception("Cannot marshal type VitalStatusCodingCode");
        }

        public static readonly VitalStatusCodingCodeConverter Singleton = new VitalStatusCodingCodeConverter();
    }

    internal class EcogCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EcogCodingCode) || t == typeof(EcogCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return EcogCodingCode.Code0;
                case "1":
                    return EcogCodingCode.Code1;
                case "2":
                    return EcogCodingCode.Code2;
                case "3":
                    return EcogCodingCode.Code3;
                case "4":
                    return EcogCodingCode.Code4;
                case "5":
                    return EcogCodingCode.Code5;
            }

            throw new Exception("Cannot unmarshal type EcogCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (EcogCodingCode)untypedValue;
            switch (value)
            {
                case EcogCodingCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case EcogCodingCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case EcogCodingCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case EcogCodingCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case EcogCodingCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
                case EcogCodingCode.Code5:
                    serializer.Serialize(writer, "5");
                    return;
            }

            throw new Exception("Cannot marshal type EcogCodingCode");
        }

        public static readonly EcogCodingCodeConverter Singleton = new EcogCodingCodeConverter();
    }

    internal class MolecularDiagnosticReportCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MolecularDiagnosticReportCodingCode) ||
                                                   t == typeof(MolecularDiagnosticReportCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FISH":
                    return MolecularDiagnosticReportCodingCode.Fish;
                case "PCR":
                    return MolecularDiagnosticReportCodingCode.Pcr;
                case "array":
                    return MolecularDiagnosticReportCodingCode.Array;
                case "exome":
                    return MolecularDiagnosticReportCodingCode.Exome;
                case "fusion-panel":
                    return MolecularDiagnosticReportCodingCode.FusionPanel;
                case "gene-panel":
                    return MolecularDiagnosticReportCodingCode.GenePanel;
                case "genome-long-read":
                    return MolecularDiagnosticReportCodingCode.GenomeLongRead;
                case "genome-short-read":
                    return MolecularDiagnosticReportCodingCode.GenomeShortRead;
                case "karyotyping":
                    return MolecularDiagnosticReportCodingCode.Karyotyping;
                case "other":
                    return MolecularDiagnosticReportCodingCode.Other;
                case "panel":
                    return MolecularDiagnosticReportCodingCode.Panel;
                case "single":
                    return MolecularDiagnosticReportCodingCode.Single;
            }

            throw new Exception("Cannot unmarshal type MolecularDiagnosticReportCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (MolecularDiagnosticReportCodingCode)untypedValue;
            switch (value)
            {
                case MolecularDiagnosticReportCodingCode.Fish:
                    serializer.Serialize(writer, "FISH");
                    return;
                case MolecularDiagnosticReportCodingCode.Pcr:
                    serializer.Serialize(writer, "PCR");
                    return;
                case MolecularDiagnosticReportCodingCode.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case MolecularDiagnosticReportCodingCode.Exome:
                    serializer.Serialize(writer, "exome");
                    return;
                case MolecularDiagnosticReportCodingCode.FusionPanel:
                    serializer.Serialize(writer, "fusion-panel");
                    return;
                case MolecularDiagnosticReportCodingCode.GenePanel:
                    serializer.Serialize(writer, "gene-panel");
                    return;
                case MolecularDiagnosticReportCodingCode.GenomeLongRead:
                    serializer.Serialize(writer, "genome-long-read");
                    return;
                case MolecularDiagnosticReportCodingCode.GenomeShortRead:
                    serializer.Serialize(writer, "genome-short-read");
                    return;
                case MolecularDiagnosticReportCodingCode.Karyotyping:
                    serializer.Serialize(writer, "karyotyping");
                    return;
                case MolecularDiagnosticReportCodingCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case MolecularDiagnosticReportCodingCode.Panel:
                    serializer.Serialize(writer, "panel");
                    return;
                case MolecularDiagnosticReportCodingCode.Single:
                    serializer.Serialize(writer, "single");
                    return;
            }

            throw new Exception("Cannot marshal type MolecularDiagnosticReportCodingCode");
        }

        public static readonly MolecularDiagnosticReportCodingCodeConverter Singleton =
            new MolecularDiagnosticReportCodingCodeConverter();
    }

    internal class ResponseMethodCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(ResponseMethodCodingCode) || t == typeof(ResponseMethodCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "RANO":
                    return ResponseMethodCodingCode.Rano;
                case "RECIST":
                    return ResponseMethodCodingCode.Recist;
            }

            throw new Exception("Cannot unmarshal type ResponseMethodCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (ResponseMethodCodingCode)untypedValue;
            switch (value)
            {
                case ResponseMethodCodingCode.Rano:
                    serializer.Serialize(writer, "RANO");
                    return;
                case ResponseMethodCodingCode.Recist:
                    serializer.Serialize(writer, "RECIST");
                    return;
            }

            throw new Exception("Cannot marshal type ResponseMethodCodingCode");
        }

        public static readonly ResponseMethodCodingCodeConverter Singleton = new ResponseMethodCodingCodeConverter();
    }

    internal class RecistCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RecistCodingCode) || t == typeof(RecistCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CR":
                    return RecistCodingCode.Cr;
                case "MR":
                    return RecistCodingCode.Mr;
                case "NA":
                    return RecistCodingCode.Na;
                case "PD":
                    return RecistCodingCode.Pd;
                case "PR":
                    return RecistCodingCode.Pr;
                case "SD":
                    return RecistCodingCode.Sd;
            }

            throw new Exception("Cannot unmarshal type RecistCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (RecistCodingCode)untypedValue;
            switch (value)
            {
                case RecistCodingCode.Cr:
                    serializer.Serialize(writer, "CR");
                    return;
                case RecistCodingCode.Mr:
                    serializer.Serialize(writer, "MR");
                    return;
                case RecistCodingCode.Na:
                    serializer.Serialize(writer, "NA");
                    return;
                case RecistCodingCode.Pd:
                    serializer.Serialize(writer, "PD");
                    return;
                case RecistCodingCode.Pr:
                    serializer.Serialize(writer, "PR");
                    return;
                case RecistCodingCode.Sd:
                    serializer.Serialize(writer, "SD");
                    return;
            }

            throw new Exception("Cannot marshal type RecistCodingCode");
        }

        public static readonly RecistCodingCodeConverter Singleton = new RecistCodingCodeConverter();
    }

    internal class TumorSpecimenCollectionLocalizationCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorSpecimenCollectionLocalizationCodingCode) ||
                                                   t == typeof(TumorSpecimenCollectionLocalizationCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "cellfree-dna":
                    return TumorSpecimenCollectionLocalizationCodingCode.CellfreeDna;
                case "local-recurrence":
                    return TumorSpecimenCollectionLocalizationCodingCode.LocalRecurrence;
                case "metastasis":
                    return TumorSpecimenCollectionLocalizationCodingCode.Metastasis;
                case "primary-tumor":
                    return TumorSpecimenCollectionLocalizationCodingCode.PrimaryTumor;
                case "regional-lymph-nodes":
                    return TumorSpecimenCollectionLocalizationCodingCode.RegionalLymphNodes;
                case "unknown":
                    return TumorSpecimenCollectionLocalizationCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type TumorSpecimenCollectionLocalizationCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TumorSpecimenCollectionLocalizationCodingCode)untypedValue;
            switch (value)
            {
                case TumorSpecimenCollectionLocalizationCodingCode.CellfreeDna:
                    serializer.Serialize(writer, "cellfree-dna");
                    return;
                case TumorSpecimenCollectionLocalizationCodingCode.LocalRecurrence:
                    serializer.Serialize(writer, "local-recurrence");
                    return;
                case TumorSpecimenCollectionLocalizationCodingCode.Metastasis:
                    serializer.Serialize(writer, "metastasis");
                    return;
                case TumorSpecimenCollectionLocalizationCodingCode.PrimaryTumor:
                    serializer.Serialize(writer, "primary-tumor");
                    return;
                case TumorSpecimenCollectionLocalizationCodingCode.RegionalLymphNodes:
                    serializer.Serialize(writer, "regional-lymph-nodes");
                    return;
                case TumorSpecimenCollectionLocalizationCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type TumorSpecimenCollectionLocalizationCodingCode");
        }

        public static readonly TumorSpecimenCollectionLocalizationCodingCodeConverter Singleton =
            new TumorSpecimenCollectionLocalizationCodingCodeConverter();
    }

    internal class TumorSpecimenCollectionMethodCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorSpecimenCollectionMethodCodingCode) ||
                                                   t == typeof(TumorSpecimenCollectionMethodCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "biopsy":
                    return TumorSpecimenCollectionMethodCodingCode.Biopsy;
                case "cytology":
                    return TumorSpecimenCollectionMethodCodingCode.Cytology;
                case "liquid-biopsy":
                    return TumorSpecimenCollectionMethodCodingCode.LiquidBiopsy;
                case "resection":
                    return TumorSpecimenCollectionMethodCodingCode.Resection;
                case "unknown":
                    return TumorSpecimenCollectionMethodCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type TumorSpecimenCollectionMethodCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TumorSpecimenCollectionMethodCodingCode)untypedValue;
            switch (value)
            {
                case TumorSpecimenCollectionMethodCodingCode.Biopsy:
                    serializer.Serialize(writer, "biopsy");
                    return;
                case TumorSpecimenCollectionMethodCodingCode.Cytology:
                    serializer.Serialize(writer, "cytology");
                    return;
                case TumorSpecimenCollectionMethodCodingCode.LiquidBiopsy:
                    serializer.Serialize(writer, "liquid-biopsy");
                    return;
                case TumorSpecimenCollectionMethodCodingCode.Resection:
                    serializer.Serialize(writer, "resection");
                    return;
                case TumorSpecimenCollectionMethodCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type TumorSpecimenCollectionMethodCodingCode");
        }

        public static readonly TumorSpecimenCollectionMethodCodingCodeConverter Singleton =
            new TumorSpecimenCollectionMethodCodingCodeConverter();
    }

    internal class TumorSpecimenCodingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) =>
            t == typeof(TumorSpecimenCodingCode) || t == typeof(TumorSpecimenCodingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FFPE":
                    return TumorSpecimenCodingCode.Ffpe;
                case "cryo-frozen":
                    return TumorSpecimenCodingCode.CryoFrozen;
                case "fresh-tissue":
                    return TumorSpecimenCodingCode.FreshTissue;
                case "liquid-biopsy":
                    return TumorSpecimenCodingCode.LiquidBiopsy;
                case "unknown":
                    return TumorSpecimenCodingCode.Unknown;
            }

            throw new Exception("Cannot unmarshal type TumorSpecimenCodingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            var value = (TumorSpecimenCodingCode)untypedValue;
            switch (value)
            {
                case TumorSpecimenCodingCode.Ffpe:
                    serializer.Serialize(writer, "FFPE");
                    return;
                case TumorSpecimenCodingCode.CryoFrozen:
                    serializer.Serialize(writer, "cryo-frozen");
                    return;
                case TumorSpecimenCodingCode.FreshTissue:
                    serializer.Serialize(writer, "fresh-tissue");
                    return;
                case TumorSpecimenCodingCode.LiquidBiopsy:
                    serializer.Serialize(writer, "liquid-biopsy");
                    return;
                case TumorSpecimenCodingCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }

            throw new Exception("Cannot marshal type TumorSpecimenCodingCode");
        }

        public static readonly TumorSpecimenCodingCodeConverter Singleton = new TumorSpecimenCodingCodeConverter();
    }
}