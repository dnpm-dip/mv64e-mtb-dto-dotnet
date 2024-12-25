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

        [JsonProperty("diagnoses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbDiagnosis> Diagnoses { get; set; }

        [JsonProperty("episode", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbEpisode Episode { get; set; }

        [JsonProperty("episodesOfCare", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<EpisodeOfCare> EpisodesOfCare { get; set; }

        [JsonProperty("geneticCounsellingRequests", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneticCounselingRecommendation> GeneticCounsellingRequests { get; set; }

        [JsonProperty("guidelineProcedures", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<OncoProdecure> GuidelineProcedures { get; set; }

        [JsonProperty("guidelineTherapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationTherapy> GuidelineTherapies { get; set; }

        [JsonProperty("histologyReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<HistologyReport> HistologyReports { get; set; }

        [JsonProperty("ihcReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<IhcReport> IhcReports { get; set; }

        [JsonProperty("molecularTherapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MolecularTherapy> MolecularTherapies { get; set; }

        [JsonProperty("ngsReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SomaticNgsReport> NgsReports { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public MtbPatient Patient { get; set; }

        [JsonProperty("performanceStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PerformanceStatus> PerformanceStatus { get; set; }

        [JsonProperty("recommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationRecommendation> Recommendations { get; set; }

        [JsonProperty("responses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Response> Responses { get; set; }

        [JsonProperty("specimens", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<TumorSpecimen> Specimens { get; set; }

        [JsonProperty("studyInclusionRequests", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StudyEnrollmentRecommendation> StudyInclusionRequests { get; set; }

        [JsonProperty("therapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Therapy> Therapies { get; set; }
    }

    public partial class MtbCarePlan
    {
        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Diagnosis { get; set; }

        [JsonProperty("geneticCounselingRecommendation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public GeneticCounselingRecommendation GeneticCounselingRecommendation { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("indication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Indication { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("medicationRecommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationRecommendation> MedicationRecommendations { get; set; }

        [JsonProperty("noTargetFinding", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public NoTargetFinding NoTargetFinding { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingCarePlanStatusReason StatusReason { get; set; }

        [JsonProperty("studyEnrollmentRecommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StudyEnrollmentRecommendation> StudyEnrollmentRecommendations { get; set; }
    }

    public partial class GeneticCounselingRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public Coding Reason { get; set; }
    }

    public partial class Patient
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public PatientType Type { get; set; }
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

    public partial class Reference
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }
    }

    public partial class MtbMedicationRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("indication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Indication { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("levelOfEvidence", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public LevelOfEvidence LevelOfEvidence { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Medication { get; set; }

        [JsonProperty("ngsReport", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string NgsReport { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("priority", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyRecommendationPriority Priority { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> SupportingVariants { get; set; }
    }

    public partial class LevelOfEvidence
    {
        [JsonProperty("addendums", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CodingLevelOfEvidenceAddendum> Addendums { get; set; }

        [JsonProperty("grading", Required = Required.Always)]
        public CodingLevelOfEvidenceGrading Grading { get; set; }

        [JsonProperty("publications", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<ReferencePublication> Publications { get; set; }
    }

    public partial class CodingLevelOfEvidenceAddendum
    {
        [JsonProperty("code", Required = Required.Always)]
        public AddendumCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CodingLevelOfEvidenceGrading
    {
        [JsonProperty("code", Required = Required.Always)]
        public GradingCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ReferencePublication
    {
        [JsonProperty("extId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ExtId ExtId { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("uri", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Uri { get; set; }
    }

    public partial class ExtId
    {
        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ExtIdSystem? System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class CodingTherapyRecommendationPriority
    {
        [JsonProperty("code", Required = Required.Always)]
        public TherapyRecommendationPriority Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class NoTargetFinding
    {
        [JsonProperty("diagnosis", Required = Required.Always)]
        public string Diagnosis { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }
    }

    public partial class CodingCarePlanStatusReason
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class StudyEnrollmentRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("levelOfEvidence", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding LevelOfEvidence { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public Reference Reason { get; set; }

        [JsonProperty("studies", Required = Required.Always)]
        public List<Study> Studies { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> SupportingVariants { get; set; }
    }

    public partial class Study
    {
        [JsonProperty("system", Required = Required.Always)]
        public string System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class ClaimResponse
    {
        [JsonProperty("claim", Required = Required.Always)]
        public ClaimResponseClaim Claim { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public CodingClaimResponseStatus Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingClaimResponseStatusReason StatusReason { get; set; }
    }

    public partial class ClaimResponseClaim
    {
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClaimResponseClaimType? Type { get; set; }
    }

    public partial class CodingClaimResponseStatus
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClaimResponseStatus Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class CodingClaimResponseStatusReason
    {
        [JsonProperty("code", Required = Required.Always)]
        public ClaimResponseStatusReason Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class Claim
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("recommendation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Recommendation Recommendation { get; set; }

        [JsonProperty("stage", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Stage { get; set; }
    }

    public partial class Recommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }
    }

    public partial class MtbDiagnosis
    {
        [JsonProperty("code", Required = Required.Always)]
        public Coding Code { get; set; }

        [JsonProperty("guidelineTreatmentStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding GuidelineTreatmentStatus { get; set; }

        [JsonProperty("histologyResults", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> HistologyResults { get; set; }

        [JsonProperty("icdO3T", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding IcdO3T { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("recordedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordedOn { get; set; }

        [JsonProperty("stageHistory", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StageHistory> StageHistory { get; set; }

        [JsonProperty("topography", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Topography { get; set; }

        [JsonProperty("tumorGrade", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTumorGrade TumorGrade { get; set; }

        [JsonProperty("whoGrade", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding WhoGrade { get; set; }

        [JsonProperty("whoGrading", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding WhoGrading { get; set; }
    }

    public partial class StageHistory
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("stage", Required = Required.Always)]
        public CodingTumorSpread Stage { get; set; }
    }

    public partial class CodingTumorSpread
    {
        [JsonProperty("code", Required = Required.Always)]
        public StageCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class CodingTumorGrade
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorGradeCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbEpisode
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("period", Required = Required.Always)]
        public PeriodLocalDate Period { get; set; }
    }

    public partial class PeriodLocalDate
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public DateTimeOffset Start { get; set; }
    }

    public partial class EpisodeOfCare
    {
        [JsonProperty("diagnoses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Reference> Diagnoses { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("period", Required = Required.Always)]
        public PeriodLocalDate Period { get; set; }
    }

    public partial class OncoProdecure
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BasedOn { get; set; }

        [JsonProperty("code", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Code { get; set; }

        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("indication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Indication { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodLocalDate Period { get; set; }

        [JsonProperty("recordedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatus Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatusReason StatusReason { get; set; }

        [JsonProperty("therapyLine", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TherapyLine { get; set; }
    }

    public partial class CodingTherapyStatus
    {
        [JsonProperty("code", Required = Required.Always)]
        public TherapyStatus Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class CodingTherapyStatusReason
    {
        [JsonProperty("code", Required = Required.Always)]
        public StatusReasonCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MtbMedicationTherapy
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference BasedOn { get; set; }

        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("indication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Indication { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Medication { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodLocalDate Period { get; set; }

        [JsonProperty("recordedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatus Status { get; set; }

        [JsonProperty("statusReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatusReason StatusReason { get; set; }

        [JsonProperty("therapyLine", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TherapyLine { get; set; }
    }

    public partial class HistologyReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("results", Required = Required.Always)]
        public HistologyReportResults Results { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public HistologyReportSpecimen Specimen { get; set; }
    }

    public partial class HistologyReportResults
    {
        [JsonProperty("tumorCellContent", Required = Required.Always)]
        public TumorCellContent TumorCellContent { get; set; }

        [JsonProperty("tumorMorphology", Required = Required.Always)]
        public TumorMorphology TumorMorphology { get; set; }
    }

    public partial class TumorCellContent
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public CodingTumorCellContentMethod Method { get; set; }

        [JsonProperty("patient", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Patient Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public TumorCellContentSpecimen Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class CodingTumorCellContentMethod
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorCellContentMethod Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class TumorCellContentSpecimen
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public SpecimenType Type { get; set; }
    }

    public partial class TumorMorphology
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("notes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Notes { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public TumorMorphologySpecimen Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public Coding Value { get; set; }
    }

    public partial class TumorMorphologySpecimen
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public SpecimenType Type { get; set; }
    }

    public partial class HistologyReportSpecimen
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public SpecimenType Type { get; set; }
    }

    public partial class IhcReport
    {
        [JsonProperty("blockId", Required = Required.Always)]
        public ExternalId BlockId { get; set; }

        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("journalId", Required = Required.Always)]
        public ExternalId JournalId { get; set; }

        [JsonProperty("msiMmrResults", Required = Required.Always)]
        public List<MsiMmrResult> MsiMmrResults { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("proteinExpressionResults", Required = Required.Always)]
        public List<ProteinExpressionResult> ProteinExpressionResults { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }
    }

    public partial class ExternalId
    {
        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
    }

    public partial class MsiMmrResult
    {
        [JsonProperty("icScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingProteinExpressionIcScore IcScore { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("protein", Required = Required.Always)]
        public Coding Protein { get; set; }

        [JsonProperty("tcScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingProteinExpressionTcScore TcScore { get; set; }

        [JsonProperty("tpsScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TpsScore { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public CodingProteinExpressionResult Value { get; set; }
    }

    public partial class CodingProteinExpressionIcScore
    {
        [JsonProperty("code", Required = Required.Always)]
        public IcScoreCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CodingProteinExpressionTcScore
    {
        [JsonProperty("code", Required = Required.Always)]
        public TcScoreCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class CodingProteinExpressionResult
    {
        [JsonProperty("code", Required = Required.Always)]
        public ProteinExpressionResultCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class ProteinExpressionResult
    {
        [JsonProperty("icScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingProteinExpressionIcScore IcScore { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("protein", Required = Required.Always)]
        public Coding Protein { get; set; }

        [JsonProperty("tcScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingProteinExpressionTcScore TcScore { get; set; }

        [JsonProperty("tpsScore", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TpsScore { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public CodingProteinExpressionResult Value { get; set; }
    }

    public partial class MolecularTherapy
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<MtbMedicationTherapy> History { get; set; }
    }

    public partial class SomaticNgsReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("metadata", Required = Required.Always)]
        public List<Metadatum> Metadata { get; set; }

        [JsonProperty("msi", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Msi { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("results", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public NgsReportResults Results { get; set; }

        [JsonProperty("sequencingType", Required = Required.Always)]
        public Coding SequencingType { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public NgsReportSpecimen Specimen { get; set; }
    }

    public partial class Metadatum
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
        public BrcAness Brcaness { get; set; }

        [JsonProperty("copyNumberVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
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

        [JsonProperty("tumorCellContent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TumorCellContent TumorCellContent { get; set; }
    }

    public partial class BrcAness
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
        public CodingChromosome Chromosome { get; set; }

        [JsonProperty("cnA", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnA { get; set; }

        [JsonProperty("cnB", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnB { get; set; }

        [JsonProperty("copyNumberNeutralLoH", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CodingGene> CopyNumberNeutralLoH { get; set; }

        [JsonProperty("endRange", Required = Required.Always)]
        public EndRange EndRange { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("indication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Reference Indication { get; set; }

        [JsonProperty("patient", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Patient Patient { get; set; }

        [JsonProperty("relativeCopyNumber", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? RelativeCopyNumber { get; set; }

        [JsonProperty("reportedAffectedGenes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CodingGene> ReportedAffectedGenes { get; set; }

        [JsonProperty("reportedFocality", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ReportedFocality { get; set; }

        [JsonProperty("startRange", Required = Required.Always)]
        public StartRange StartRange { get; set; }

        [JsonProperty("totalCopyNumber", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCopyNumber { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public CodingCnvType Type { get; set; }
    }

    public partial class CodingChromosome
    {
        [JsonProperty("code", Required = Required.Always)]
        public ChromosomeCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ChromosomeSystem? System { get; set; }
    }

    public partial class CodingGene
    {
        [JsonProperty("code", Required = Required.Always)]
        public string Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public GeneSystem? System { get; set; }
    }

    public partial class EndRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class StartRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class CodingCnvType
    {
        [JsonProperty("code", Required = Required.Always)]
        public CnvType Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class DnaFusion
    {
        [JsonProperty("fusionPartner3prime", Required = Required.Always)]
        public DnaFusionFusionPartner3Prime FusionPartner3Prime { get; set; }

        [JsonProperty("fusionPartner5prime", Required = Required.Always)]
        public DnaFusionFusionPartner5Prime FusionPartner5Prime { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("reportedNumReads", Required = Required.Always)]
        public long ReportedNumReads { get; set; }
    }

    public partial class DnaFusionFusionPartner3Prime
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public CodingChromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public CodingGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class DnaFusionFusionPartner5Prime
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public CodingChromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public Gene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class Gene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class HrdScore
    {
        [JsonProperty("components", Required = Required.Always)]
        public Components Components { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Interpretation { get; set; }

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

    public partial class RnaFusion
    {
        [JsonProperty("cosmicId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CosmicId { get; set; }

        [JsonProperty("effect", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Effect { get; set; }

        [JsonProperty("fusionPartner3prime", Required = Required.Always)]
        public RnaFusionFusionPartner3Prime FusionPartner3Prime { get; set; }

        [JsonProperty("fusionPartner5prime", Required = Required.Always)]
        public RnaFusionFusionPartner5Prime FusionPartner5Prime { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("reportedNumReads", Required = Required.Always)]
        public long ReportedNumReads { get; set; }
    }

    public partial class RnaFusionFusionPartner3Prime
    {
        [JsonProperty("exon", Required = Required.Always)]
        public string Exon { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public CodingGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public string TranscriptId { get; set; }
    }

    public partial class RnaFusionFusionPartner5Prime
    {
        [JsonProperty("exon", Required = Required.Always)]
        public string Exon { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public CodingGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public string TranscriptId { get; set; }
    }

    public partial class RnaSeq
    {
        [JsonProperty("cohortRanking", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? CohortRanking { get; set; }

        [JsonProperty("ensemblId", Required = Required.Always)]
        public string EnsemblId { get; set; }

        [JsonProperty("entrezId", Required = Required.Always)]
        public string EntrezId { get; set; }

        [JsonProperty("fragmentsPerKilobaseMillion", Required = Required.Always)]
        public double FragmentsPerKilobaseMillion { get; set; }

        [JsonProperty("fromNGS", Required = Required.Always)]
        public bool FromNgs { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public CodingGene Gene { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("librarySize", Required = Required.Always)]
        public long LibrarySize { get; set; }

        [JsonProperty("rawCounts", Required = Required.Always)]
        public long RawCounts { get; set; }

        [JsonProperty("tissueCorrectedExpression", Required = Required.Always)]
        public bool TissueCorrectedExpression { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public string TranscriptId { get; set; }
    }

    public partial class Snv
    {
        [JsonProperty("allelicFrequency", Required = Required.Always)]
        public double AllelicFrequency { get; set; }

        [JsonProperty("altAllele", Required = Required.Always)]
        public string AltAllele { get; set; }

        [JsonProperty("aminoAcidChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding AminoAcidChange { get; set; }

        [JsonProperty("chromosome", Required = Required.Always)]
        public CodingChromosome Chromosome { get; set; }

        [JsonProperty("cosmicId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CosmicId { get; set; }

        [JsonProperty("dbSNPId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DbSnpId { get; set; }

        [JsonProperty("dnaChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding DnaChange { get; set; }

        [JsonProperty("externalIds", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<ExternalId> ExternalIds { get; set; }

        [JsonProperty("gene", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingGene Gene { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Interpretation { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public Position Position { get; set; }

        [JsonProperty("proteinChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding ProteinChange { get; set; }

        [JsonProperty("readDepth", Required = Required.Always)]
        public long ReadDepth { get; set; }

        [JsonProperty("refAllele", Required = Required.Always)]
        public string RefAllele { get; set; }

        [JsonProperty("transcriptId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalId TranscriptId { get; set; }
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
        public Coding Interpretation { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Reference Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public Reference Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public Value Value { get; set; }
    }

    public partial class Value
    {
        [JsonProperty("unit", Required = Required.Always)]
        public string Unit { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double ValueValue { get; set; }
    }

    public partial class NgsReportSpecimen
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public SpecimenType Type { get; set; }
    }

    public partial class MtbPatient
    {
        [JsonProperty("address", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Address Address { get; set; }

        [JsonProperty("age", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ValueWithUnit Age { get; set; }

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("dateOfDeath", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfDeath { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public CodingGender Gender { get; set; }

        [JsonProperty("healthInsurance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public HealthInsurance HealthInsurance { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("vitalStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public VitalStatus VitalStatus { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("municipalityCode", Required = Required.Always)]
        public string MunicipalityCode { get; set; }
    }

    public partial class ValueWithUnit
    {
        [JsonProperty("unit", Required = Required.Always)]
        public Unit Unit { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class CodingGender
    {
        [JsonProperty("code", Required = Required.Always)]
        public Gender Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class HealthInsurance
    {
        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("extId", Required = Required.Always)]
        public ExternalId ExtId { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum? Type { get; set; }
    }

    public partial class VitalStatus
    {
        [JsonProperty("code", Required = Required.Always)]
        public VitalStatusCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class PerformanceStatus
    {
        [JsonProperty("effectiveDate", Required = Required.Always)]
        public DateTimeOffset EffectiveDate { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public CodingEcog Value { get; set; }
    }

    public partial class CodingEcog
    {
        [JsonProperty("code", Required = Required.Always)]
        public EcogCode Code { get; set; }

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

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("therapy", Required = Required.Always)]
        public ResponseTherapy Therapy { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public CodingRecist Value { get; set; }
    }

    public partial class ResponseTherapy
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public ResponseTherapyType Type { get; set; }
    }

    public partial class CodingRecist
    {
        [JsonProperty("code", Required = Required.Always)]
        public RecistCode Code { get; set; }

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

        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Diagnosis Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("type", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTumorSpecimenType Type { get; set; }
    }

    public partial class Collection
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("localization", Required = Required.Always)]
        public CodingTumorSpecimenCollectionLocalization Localization { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public CodingTumorSpecimenCollectionMethod Method { get; set; }
    }

    public partial class CodingTumorSpecimenCollectionLocalization
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenCollectionLocalization Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class CodingTumorSpecimenCollectionMethod
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenCollectionMethod Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class Diagnosis
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public string Type { get; set; }
    }

    public partial class CodingTumorSpecimenType
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenType Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }
    }

    public partial class Therapy
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<MtbMedicationTherapy> History { get; set; }
    }

    public enum PatientType { Patient };

    public enum AddendumCode { Is, Iv, R, Z };

    public enum GradingCode { M1A, M1B, M1C, M2A, M2B, M2C, M3, M4, Undefined };

    public enum ExtIdSystem { HttpsPubmedNcbiNlmNihGov };

    public enum TherapyRecommendationPriority { Prio1, Prio2, Prio3, Prio4 };

    public enum ClaimResponseClaimType { Claim };

    public enum ClaimResponseStatus { Accepted, Rejected, Unknown };

    public enum ClaimResponseStatusReason { ApprovalRevocation, FormalReasons, InclusionInStudy, InsufficientEvidence, Other, OtherTherapyRecommended, StandardTherapyNotExhausted, Unknown };

    public enum StageCode { Local, Metastasized, TumorFree, Unknown };

    public enum TumorGradeCode { G1, G2, G3, G4, Gx };

    public enum TherapyStatus { Completed, NotDone, OnGoing, Stopped, Unknown };

    public enum StatusReasonCode { ChronicRemission, ContinuedExternally, Deterioration, LostToFu, MedicalReason, NoIndication, Other, OtherTherapyChosen, PatientDeath, PatientRefusal, PatientWish, PaymentEnded, PaymentPending, PaymentRefused, Progression, Toxicity, Unknown };

    public enum TumorCellContentMethod { Bioinformatic, Histologic };

    public enum SpecimenType { TumorSpecimen };

    public enum IcScoreCode { Code0, Code1, Code2, Code3 };

    public enum TcScoreCode { Code0, Code1, Code2, Code3, Code4, Code5, Code6 };

    public enum ProteinExpressionResultCode { Exp, NotExp, Code1Plus, Code2Plus, Code3Plus, Unknown };

    public enum ChromosomeCode { Chr1, Chr10, Chr11, Chr12, Chr13, Chr14, Chr15, Chr16, Chr17, Chr18, Chr19, Chr2, Chr20, Chr21, Chr22, Chr3, Chr4, Chr5, Chr6, Chr7, Chr8, Chr9, ChrX, ChrY };

    public enum ChromosomeSystem { Chromosome };

    public enum GeneSystem { HttpsWwwGenenamesOrg };

    public enum CnvType { HighLevelGain, Loss, LowLevelGain };

    public enum RnaFusionStrand { Empty, RnaFusionStrand };

    public enum Unit { Years };

    public enum Gender { Female, Male, Other, Unknown };

    public enum TypeEnum { Organization };

    public enum VitalStatusCode { Alive, Deceased };

    public enum EcogCode { Code0, Code1, Code2, Code3, Code4 };

    public enum ResponseTherapyType { MtbMedicationTherapy };

    public enum RecistCode { Cr, Mr, Na, Nya, Pd, Pr, Sd };

    public enum TumorSpecimenCollectionLocalization { Metastasis, PrimaryTumor, Unknown };

    public enum TumorSpecimenCollectionMethod { Biopsy, Cytology, LiquidBiopsy, Resection, Unknown };

    public enum TumorSpecimenType { CryoFrozen, Ffpe, FreshTissue, LiquidBiopsy, Unknown };

    public partial class Mtb
    {
        public static Mtb FromJson(string json) => JsonConvert.DeserializeObject<Mtb>(json, MV64e.MTB.Converter.Settings);
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
                PatientTypeConverter.Singleton,
                AddendumCodeConverter.Singleton,
                GradingCodeConverter.Singleton,
                ExtIdSystemConverter.Singleton,
                TherapyRecommendationPriorityConverter.Singleton,
                ClaimResponseClaimTypeConverter.Singleton,
                ClaimResponseStatusConverter.Singleton,
                ClaimResponseStatusReasonConverter.Singleton,
                StageCodeConverter.Singleton,
                TumorGradeCodeConverter.Singleton,
                TherapyStatusConverter.Singleton,
                StatusReasonCodeConverter.Singleton,
                TumorCellContentMethodConverter.Singleton,
                SpecimenTypeConverter.Singleton,
                IcScoreCodeConverter.Singleton,
                TcScoreCodeConverter.Singleton,
                ProteinExpressionResultCodeConverter.Singleton,
                ChromosomeCodeConverter.Singleton,
                ChromosomeSystemConverter.Singleton,
                GeneSystemConverter.Singleton,
                CnvTypeConverter.Singleton,
                RnaFusionStrandConverter.Singleton,
                UnitConverter.Singleton,
                GenderConverter.Singleton,
                TypeEnumConverter.Singleton,
                VitalStatusCodeConverter.Singleton,
                EcogCodeConverter.Singleton,
                ResponseTherapyTypeConverter.Singleton,
                RecistCodeConverter.Singleton,
                TumorSpecimenCollectionLocalizationConverter.Singleton,
                TumorSpecimenCollectionMethodConverter.Singleton,
                TumorSpecimenTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PatientTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PatientType) || t == typeof(PatientType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Patient")
            {
                return PatientType.Patient;
            }
            throw new Exception("Cannot unmarshal type PatientType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PatientType)untypedValue;
            if (value == PatientType.Patient)
            {
                serializer.Serialize(writer, "Patient");
                return;
            }
            throw new Exception("Cannot marshal type PatientType");
        }

        public static readonly PatientTypeConverter Singleton = new PatientTypeConverter();
    }

    internal class AddendumCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AddendumCode) || t == typeof(AddendumCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "R":
                    return AddendumCode.R;
                case "Z":
                    return AddendumCode.Z;
                case "is":
                    return AddendumCode.Is;
                case "iv":
                    return AddendumCode.Iv;
            }
            throw new Exception("Cannot unmarshal type AddendumCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AddendumCode)untypedValue;
            switch (value)
            {
                case AddendumCode.R:
                    serializer.Serialize(writer, "R");
                    return;
                case AddendumCode.Z:
                    serializer.Serialize(writer, "Z");
                    return;
                case AddendumCode.Is:
                    serializer.Serialize(writer, "is");
                    return;
                case AddendumCode.Iv:
                    serializer.Serialize(writer, "iv");
                    return;
            }
            throw new Exception("Cannot marshal type AddendumCode");
        }

        public static readonly AddendumCodeConverter Singleton = new AddendumCodeConverter();
    }

    internal class GradingCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GradingCode) || t == typeof(GradingCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "m1A":
                    return GradingCode.M1A;
                case "m1B":
                    return GradingCode.M1B;
                case "m1C":
                    return GradingCode.M1C;
                case "m2A":
                    return GradingCode.M2A;
                case "m2B":
                    return GradingCode.M2B;
                case "m2C":
                    return GradingCode.M2C;
                case "m3":
                    return GradingCode.M3;
                case "m4":
                    return GradingCode.M4;
                case "undefined":
                    return GradingCode.Undefined;
            }
            throw new Exception("Cannot unmarshal type GradingCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GradingCode)untypedValue;
            switch (value)
            {
                case GradingCode.M1A:
                    serializer.Serialize(writer, "m1A");
                    return;
                case GradingCode.M1B:
                    serializer.Serialize(writer, "m1B");
                    return;
                case GradingCode.M1C:
                    serializer.Serialize(writer, "m1C");
                    return;
                case GradingCode.M2A:
                    serializer.Serialize(writer, "m2A");
                    return;
                case GradingCode.M2B:
                    serializer.Serialize(writer, "m2B");
                    return;
                case GradingCode.M2C:
                    serializer.Serialize(writer, "m2C");
                    return;
                case GradingCode.M3:
                    serializer.Serialize(writer, "m3");
                    return;
                case GradingCode.M4:
                    serializer.Serialize(writer, "m4");
                    return;
                case GradingCode.Undefined:
                    serializer.Serialize(writer, "undefined");
                    return;
            }
            throw new Exception("Cannot marshal type GradingCode");
        }

        public static readonly GradingCodeConverter Singleton = new GradingCodeConverter();
    }

    internal class ExtIdSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExtIdSystem) || t == typeof(ExtIdSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "https://pubmed.ncbi.nlm.nih.gov/")
            {
                return ExtIdSystem.HttpsPubmedNcbiNlmNihGov;
            }
            throw new Exception("Cannot unmarshal type ExtIdSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ExtIdSystem)untypedValue;
            if (value == ExtIdSystem.HttpsPubmedNcbiNlmNihGov)
            {
                serializer.Serialize(writer, "https://pubmed.ncbi.nlm.nih.gov/");
                return;
            }
            throw new Exception("Cannot marshal type ExtIdSystem");
        }

        public static readonly ExtIdSystemConverter Singleton = new ExtIdSystemConverter();
    }

    internal class TherapyRecommendationPriorityConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TherapyRecommendationPriority) || t == typeof(TherapyRecommendationPriority?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1":
                    return TherapyRecommendationPriority.Prio1;
                case "2":
                    return TherapyRecommendationPriority.Prio2;
                case "3":
                    return TherapyRecommendationPriority.Prio3;
                case "4":
                    return TherapyRecommendationPriority.Prio4;
            }
            throw new Exception("Cannot unmarshal type TherapyRecommendationPriority");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TherapyRecommendationPriority)untypedValue;
            switch (value)
            {
                case TherapyRecommendationPriority.Prio1:
                    serializer.Serialize(writer, "1");
                    return;
                case TherapyRecommendationPriority.Prio2:
                    serializer.Serialize(writer, "2");
                    return;
                case TherapyRecommendationPriority.Prio3:
                    serializer.Serialize(writer, "3");
                    return;
                case TherapyRecommendationPriority.Prio4:
                    serializer.Serialize(writer, "4");
                    return;
            }
            throw new Exception("Cannot marshal type TherapyRecommendationPriority");
        }

        public static readonly TherapyRecommendationPriorityConverter Singleton = new TherapyRecommendationPriorityConverter();
    }

    internal class ClaimResponseClaimTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClaimResponseClaimType) || t == typeof(ClaimResponseClaimType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Claim")
            {
                return ClaimResponseClaimType.Claim;
            }
            throw new Exception("Cannot unmarshal type ClaimResponseClaimType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClaimResponseClaimType)untypedValue;
            if (value == ClaimResponseClaimType.Claim)
            {
                serializer.Serialize(writer, "Claim");
                return;
            }
            throw new Exception("Cannot marshal type ClaimResponseClaimType");
        }

        public static readonly ClaimResponseClaimTypeConverter Singleton = new ClaimResponseClaimTypeConverter();
    }

    internal class ClaimResponseStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClaimResponseStatus) || t == typeof(ClaimResponseStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "accepted":
                    return ClaimResponseStatus.Accepted;
                case "rejected":
                    return ClaimResponseStatus.Rejected;
                case "unknown":
                    return ClaimResponseStatus.Unknown;
            }
            throw new Exception("Cannot unmarshal type ClaimResponseStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClaimResponseStatus)untypedValue;
            switch (value)
            {
                case ClaimResponseStatus.Accepted:
                    serializer.Serialize(writer, "accepted");
                    return;
                case ClaimResponseStatus.Rejected:
                    serializer.Serialize(writer, "rejected");
                    return;
                case ClaimResponseStatus.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type ClaimResponseStatus");
        }

        public static readonly ClaimResponseStatusConverter Singleton = new ClaimResponseStatusConverter();
    }

    internal class ClaimResponseStatusReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ClaimResponseStatusReason) || t == typeof(ClaimResponseStatusReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "approval-revocation":
                    return ClaimResponseStatusReason.ApprovalRevocation;
                case "formal-reasons":
                    return ClaimResponseStatusReason.FormalReasons;
                case "inclusion-in-study":
                    return ClaimResponseStatusReason.InclusionInStudy;
                case "insufficient-evidence":
                    return ClaimResponseStatusReason.InsufficientEvidence;
                case "other":
                    return ClaimResponseStatusReason.Other;
                case "other-therapy-recommended":
                    return ClaimResponseStatusReason.OtherTherapyRecommended;
                case "standard-therapy-not-exhausted":
                    return ClaimResponseStatusReason.StandardTherapyNotExhausted;
                case "unknown":
                    return ClaimResponseStatusReason.Unknown;
            }
            throw new Exception("Cannot unmarshal type ClaimResponseStatusReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ClaimResponseStatusReason)untypedValue;
            switch (value)
            {
                case ClaimResponseStatusReason.ApprovalRevocation:
                    serializer.Serialize(writer, "approval-revocation");
                    return;
                case ClaimResponseStatusReason.FormalReasons:
                    serializer.Serialize(writer, "formal-reasons");
                    return;
                case ClaimResponseStatusReason.InclusionInStudy:
                    serializer.Serialize(writer, "inclusion-in-study");
                    return;
                case ClaimResponseStatusReason.InsufficientEvidence:
                    serializer.Serialize(writer, "insufficient-evidence");
                    return;
                case ClaimResponseStatusReason.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case ClaimResponseStatusReason.OtherTherapyRecommended:
                    serializer.Serialize(writer, "other-therapy-recommended");
                    return;
                case ClaimResponseStatusReason.StandardTherapyNotExhausted:
                    serializer.Serialize(writer, "standard-therapy-not-exhausted");
                    return;
                case ClaimResponseStatusReason.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type ClaimResponseStatusReason");
        }

        public static readonly ClaimResponseStatusReasonConverter Singleton = new ClaimResponseStatusReasonConverter();
    }

    internal class StageCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StageCode) || t == typeof(StageCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "local":
                    return StageCode.Local;
                case "metastasized":
                    return StageCode.Metastasized;
                case "tumor-free":
                    return StageCode.TumorFree;
                case "unknown":
                    return StageCode.Unknown;
            }
            throw new Exception("Cannot unmarshal type StageCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StageCode)untypedValue;
            switch (value)
            {
                case StageCode.Local:
                    serializer.Serialize(writer, "local");
                    return;
                case StageCode.Metastasized:
                    serializer.Serialize(writer, "metastasized");
                    return;
                case StageCode.TumorFree:
                    serializer.Serialize(writer, "tumor-free");
                    return;
                case StageCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type StageCode");
        }

        public static readonly StageCodeConverter Singleton = new StageCodeConverter();
    }

    internal class TumorGradeCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorGradeCode) || t == typeof(TumorGradeCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "G1":
                    return TumorGradeCode.G1;
                case "G2":
                    return TumorGradeCode.G2;
                case "G3":
                    return TumorGradeCode.G3;
                case "G4":
                    return TumorGradeCode.G4;
                case "GX":
                    return TumorGradeCode.Gx;
            }
            throw new Exception("Cannot unmarshal type TumorGradeCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TumorGradeCode)untypedValue;
            switch (value)
            {
                case TumorGradeCode.G1:
                    serializer.Serialize(writer, "G1");
                    return;
                case TumorGradeCode.G2:
                    serializer.Serialize(writer, "G2");
                    return;
                case TumorGradeCode.G3:
                    serializer.Serialize(writer, "G3");
                    return;
                case TumorGradeCode.G4:
                    serializer.Serialize(writer, "G4");
                    return;
                case TumorGradeCode.Gx:
                    serializer.Serialize(writer, "GX");
                    return;
            }
            throw new Exception("Cannot marshal type TumorGradeCode");
        }

        public static readonly TumorGradeCodeConverter Singleton = new TumorGradeCodeConverter();
    }

    internal class TherapyStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TherapyStatus) || t == typeof(TherapyStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "completed":
                    return TherapyStatus.Completed;
                case "not-done":
                    return TherapyStatus.NotDone;
                case "on-going":
                    return TherapyStatus.OnGoing;
                case "stopped":
                    return TherapyStatus.Stopped;
                case "unknown":
                    return TherapyStatus.Unknown;
            }
            throw new Exception("Cannot unmarshal type TherapyStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TherapyStatus)untypedValue;
            switch (value)
            {
                case TherapyStatus.Completed:
                    serializer.Serialize(writer, "completed");
                    return;
                case TherapyStatus.NotDone:
                    serializer.Serialize(writer, "not-done");
                    return;
                case TherapyStatus.OnGoing:
                    serializer.Serialize(writer, "on-going");
                    return;
                case TherapyStatus.Stopped:
                    serializer.Serialize(writer, "stopped");
                    return;
                case TherapyStatus.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type TherapyStatus");
        }

        public static readonly TherapyStatusConverter Singleton = new TherapyStatusConverter();
    }

    internal class StatusReasonCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StatusReasonCode) || t == typeof(StatusReasonCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "chronic-remission":
                    return StatusReasonCode.ChronicRemission;
                case "continued-externally":
                    return StatusReasonCode.ContinuedExternally;
                case "deterioration":
                    return StatusReasonCode.Deterioration;
                case "lost-to-fu":
                    return StatusReasonCode.LostToFu;
                case "medical-reason":
                    return StatusReasonCode.MedicalReason;
                case "no-indication":
                    return StatusReasonCode.NoIndication;
                case "other":
                    return StatusReasonCode.Other;
                case "other-therapy-chosen":
                    return StatusReasonCode.OtherTherapyChosen;
                case "patient-death":
                    return StatusReasonCode.PatientDeath;
                case "patient-refusal":
                    return StatusReasonCode.PatientRefusal;
                case "patient-wish":
                    return StatusReasonCode.PatientWish;
                case "payment-ended":
                    return StatusReasonCode.PaymentEnded;
                case "payment-pending":
                    return StatusReasonCode.PaymentPending;
                case "payment-refused":
                    return StatusReasonCode.PaymentRefused;
                case "progression":
                    return StatusReasonCode.Progression;
                case "toxicity":
                    return StatusReasonCode.Toxicity;
                case "unknown":
                    return StatusReasonCode.Unknown;
            }
            throw new Exception("Cannot unmarshal type StatusReasonCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StatusReasonCode)untypedValue;
            switch (value)
            {
                case StatusReasonCode.ChronicRemission:
                    serializer.Serialize(writer, "chronic-remission");
                    return;
                case StatusReasonCode.ContinuedExternally:
                    serializer.Serialize(writer, "continued-externally");
                    return;
                case StatusReasonCode.Deterioration:
                    serializer.Serialize(writer, "deterioration");
                    return;
                case StatusReasonCode.LostToFu:
                    serializer.Serialize(writer, "lost-to-fu");
                    return;
                case StatusReasonCode.MedicalReason:
                    serializer.Serialize(writer, "medical-reason");
                    return;
                case StatusReasonCode.NoIndication:
                    serializer.Serialize(writer, "no-indication");
                    return;
                case StatusReasonCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case StatusReasonCode.OtherTherapyChosen:
                    serializer.Serialize(writer, "other-therapy-chosen");
                    return;
                case StatusReasonCode.PatientDeath:
                    serializer.Serialize(writer, "patient-death");
                    return;
                case StatusReasonCode.PatientRefusal:
                    serializer.Serialize(writer, "patient-refusal");
                    return;
                case StatusReasonCode.PatientWish:
                    serializer.Serialize(writer, "patient-wish");
                    return;
                case StatusReasonCode.PaymentEnded:
                    serializer.Serialize(writer, "payment-ended");
                    return;
                case StatusReasonCode.PaymentPending:
                    serializer.Serialize(writer, "payment-pending");
                    return;
                case StatusReasonCode.PaymentRefused:
                    serializer.Serialize(writer, "payment-refused");
                    return;
                case StatusReasonCode.Progression:
                    serializer.Serialize(writer, "progression");
                    return;
                case StatusReasonCode.Toxicity:
                    serializer.Serialize(writer, "toxicity");
                    return;
                case StatusReasonCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type StatusReasonCode");
        }

        public static readonly StatusReasonCodeConverter Singleton = new StatusReasonCodeConverter();
    }

    internal class TumorCellContentMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorCellContentMethod) || t == typeof(TumorCellContentMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "bioinformatic":
                    return TumorCellContentMethod.Bioinformatic;
                case "histologic":
                    return TumorCellContentMethod.Histologic;
            }
            throw new Exception("Cannot unmarshal type TumorCellContentMethod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TumorCellContentMethod)untypedValue;
            switch (value)
            {
                case TumorCellContentMethod.Bioinformatic:
                    serializer.Serialize(writer, "bioinformatic");
                    return;
                case TumorCellContentMethod.Histologic:
                    serializer.Serialize(writer, "histologic");
                    return;
            }
            throw new Exception("Cannot marshal type TumorCellContentMethod");
        }

        public static readonly TumorCellContentMethodConverter Singleton = new TumorCellContentMethodConverter();
    }

    internal class SpecimenTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SpecimenType) || t == typeof(SpecimenType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "TumorSpecimen")
            {
                return SpecimenType.TumorSpecimen;
            }
            throw new Exception("Cannot unmarshal type SpecimenType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SpecimenType)untypedValue;
            if (value == SpecimenType.TumorSpecimen)
            {
                serializer.Serialize(writer, "TumorSpecimen");
                return;
            }
            throw new Exception("Cannot marshal type SpecimenType");
        }

        public static readonly SpecimenTypeConverter Singleton = new SpecimenTypeConverter();
    }

    internal class IcScoreCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(IcScoreCode) || t == typeof(IcScoreCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return IcScoreCode.Code0;
                case "1":
                    return IcScoreCode.Code1;
                case "2":
                    return IcScoreCode.Code2;
                case "3":
                    return IcScoreCode.Code3;
            }
            throw new Exception("Cannot unmarshal type IcScoreCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (IcScoreCode)untypedValue;
            switch (value)
            {
                case IcScoreCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case IcScoreCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case IcScoreCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case IcScoreCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
            }
            throw new Exception("Cannot marshal type IcScoreCode");
        }

        public static readonly IcScoreCodeConverter Singleton = new IcScoreCodeConverter();
    }

    internal class TcScoreCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TcScoreCode) || t == typeof(TcScoreCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return TcScoreCode.Code0;
                case "1":
                    return TcScoreCode.Code1;
                case "2":
                    return TcScoreCode.Code2;
                case "3":
                    return TcScoreCode.Code3;
                case "4":
                    return TcScoreCode.Code4;
                case "5":
                    return TcScoreCode.Code5;
                case "6":
                    return TcScoreCode.Code6;
            }
            throw new Exception("Cannot unmarshal type TcScoreCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TcScoreCode)untypedValue;
            switch (value)
            {
                case TcScoreCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case TcScoreCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case TcScoreCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case TcScoreCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case TcScoreCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
                case TcScoreCode.Code5:
                    serializer.Serialize(writer, "5");
                    return;
                case TcScoreCode.Code6:
                    serializer.Serialize(writer, "6");
                    return;
            }
            throw new Exception("Cannot marshal type TcScoreCode");
        }

        public static readonly TcScoreCodeConverter Singleton = new TcScoreCodeConverter();
    }

    internal class ProteinExpressionResultCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProteinExpressionResultCode) || t == typeof(ProteinExpressionResultCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "1+":
                    return ProteinExpressionResultCode.Code1Plus;
                case "2+":
                    return ProteinExpressionResultCode.Code2Plus;
                case "3+":
                    return ProteinExpressionResultCode.Code3Plus;
                case "exp":
                    return ProteinExpressionResultCode.Exp;
                case "not-exp":
                    return ProteinExpressionResultCode.NotExp;
                case "unknown":
                    return ProteinExpressionResultCode.Unknown;
            }
            throw new Exception("Cannot unmarshal type ProteinExpressionResultCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProteinExpressionResultCode)untypedValue;
            switch (value)
            {
                case ProteinExpressionResultCode.Code1Plus:
                    serializer.Serialize(writer, "1+");
                    return;
                case ProteinExpressionResultCode.Code2Plus:
                    serializer.Serialize(writer, "2+");
                    return;
                case ProteinExpressionResultCode.Code3Plus:
                    serializer.Serialize(writer, "3+");
                    return;
                case ProteinExpressionResultCode.Exp:
                    serializer.Serialize(writer, "exp");
                    return;
                case ProteinExpressionResultCode.NotExp:
                    serializer.Serialize(writer, "not-exp");
                    return;
                case ProteinExpressionResultCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type ProteinExpressionResultCode");
        }

        public static readonly ProteinExpressionResultCodeConverter Singleton = new ProteinExpressionResultCodeConverter();
    }

    internal class ChromosomeCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChromosomeCode) || t == typeof(ChromosomeCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "chr1":
                    return ChromosomeCode.Chr1;
                case "chr10":
                    return ChromosomeCode.Chr10;
                case "chr11":
                    return ChromosomeCode.Chr11;
                case "chr12":
                    return ChromosomeCode.Chr12;
                case "chr13":
                    return ChromosomeCode.Chr13;
                case "chr14":
                    return ChromosomeCode.Chr14;
                case "chr15":
                    return ChromosomeCode.Chr15;
                case "chr16":
                    return ChromosomeCode.Chr16;
                case "chr17":
                    return ChromosomeCode.Chr17;
                case "chr18":
                    return ChromosomeCode.Chr18;
                case "chr19":
                    return ChromosomeCode.Chr19;
                case "chr2":
                    return ChromosomeCode.Chr2;
                case "chr20":
                    return ChromosomeCode.Chr20;
                case "chr21":
                    return ChromosomeCode.Chr21;
                case "chr22":
                    return ChromosomeCode.Chr22;
                case "chr3":
                    return ChromosomeCode.Chr3;
                case "chr4":
                    return ChromosomeCode.Chr4;
                case "chr5":
                    return ChromosomeCode.Chr5;
                case "chr6":
                    return ChromosomeCode.Chr6;
                case "chr7":
                    return ChromosomeCode.Chr7;
                case "chr8":
                    return ChromosomeCode.Chr8;
                case "chr9":
                    return ChromosomeCode.Chr9;
                case "chrX":
                    return ChromosomeCode.ChrX;
                case "chrY":
                    return ChromosomeCode.ChrY;
            }
            throw new Exception("Cannot unmarshal type ChromosomeCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChromosomeCode)untypedValue;
            switch (value)
            {
                case ChromosomeCode.Chr1:
                    serializer.Serialize(writer, "chr1");
                    return;
                case ChromosomeCode.Chr10:
                    serializer.Serialize(writer, "chr10");
                    return;
                case ChromosomeCode.Chr11:
                    serializer.Serialize(writer, "chr11");
                    return;
                case ChromosomeCode.Chr12:
                    serializer.Serialize(writer, "chr12");
                    return;
                case ChromosomeCode.Chr13:
                    serializer.Serialize(writer, "chr13");
                    return;
                case ChromosomeCode.Chr14:
                    serializer.Serialize(writer, "chr14");
                    return;
                case ChromosomeCode.Chr15:
                    serializer.Serialize(writer, "chr15");
                    return;
                case ChromosomeCode.Chr16:
                    serializer.Serialize(writer, "chr16");
                    return;
                case ChromosomeCode.Chr17:
                    serializer.Serialize(writer, "chr17");
                    return;
                case ChromosomeCode.Chr18:
                    serializer.Serialize(writer, "chr18");
                    return;
                case ChromosomeCode.Chr19:
                    serializer.Serialize(writer, "chr19");
                    return;
                case ChromosomeCode.Chr2:
                    serializer.Serialize(writer, "chr2");
                    return;
                case ChromosomeCode.Chr20:
                    serializer.Serialize(writer, "chr20");
                    return;
                case ChromosomeCode.Chr21:
                    serializer.Serialize(writer, "chr21");
                    return;
                case ChromosomeCode.Chr22:
                    serializer.Serialize(writer, "chr22");
                    return;
                case ChromosomeCode.Chr3:
                    serializer.Serialize(writer, "chr3");
                    return;
                case ChromosomeCode.Chr4:
                    serializer.Serialize(writer, "chr4");
                    return;
                case ChromosomeCode.Chr5:
                    serializer.Serialize(writer, "chr5");
                    return;
                case ChromosomeCode.Chr6:
                    serializer.Serialize(writer, "chr6");
                    return;
                case ChromosomeCode.Chr7:
                    serializer.Serialize(writer, "chr7");
                    return;
                case ChromosomeCode.Chr8:
                    serializer.Serialize(writer, "chr8");
                    return;
                case ChromosomeCode.Chr9:
                    serializer.Serialize(writer, "chr9");
                    return;
                case ChromosomeCode.ChrX:
                    serializer.Serialize(writer, "chrX");
                    return;
                case ChromosomeCode.ChrY:
                    serializer.Serialize(writer, "chrY");
                    return;
            }
            throw new Exception("Cannot marshal type ChromosomeCode");
        }

        public static readonly ChromosomeCodeConverter Singleton = new ChromosomeCodeConverter();
    }

    internal class ChromosomeSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ChromosomeSystem) || t == typeof(ChromosomeSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "chromosome")
            {
                return ChromosomeSystem.Chromosome;
            }
            throw new Exception("Cannot unmarshal type ChromosomeSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ChromosomeSystem)untypedValue;
            if (value == ChromosomeSystem.Chromosome)
            {
                serializer.Serialize(writer, "chromosome");
                return;
            }
            throw new Exception("Cannot marshal type ChromosomeSystem");
        }

        public static readonly ChromosomeSystemConverter Singleton = new ChromosomeSystemConverter();
    }

    internal class GeneSystemConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(GeneSystem) || t == typeof(GeneSystem?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "https://www.genenames.org/")
            {
                return GeneSystem.HttpsWwwGenenamesOrg;
            }
            throw new Exception("Cannot unmarshal type GeneSystem");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (GeneSystem)untypedValue;
            if (value == GeneSystem.HttpsWwwGenenamesOrg)
            {
                serializer.Serialize(writer, "https://www.genenames.org/");
                return;
            }
            throw new Exception("Cannot marshal type GeneSystem");
        }

        public static readonly GeneSystemConverter Singleton = new GeneSystemConverter();
    }

    internal class CnvTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CnvType) || t == typeof(CnvType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "high-level-gain":
                    return CnvType.HighLevelGain;
                case "loss":
                    return CnvType.Loss;
                case "low-level-gain":
                    return CnvType.LowLevelGain;
            }
            throw new Exception("Cannot unmarshal type CnvType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CnvType)untypedValue;
            switch (value)
            {
                case CnvType.HighLevelGain:
                    serializer.Serialize(writer, "high-level-gain");
                    return;
                case CnvType.Loss:
                    serializer.Serialize(writer, "loss");
                    return;
                case CnvType.LowLevelGain:
                    serializer.Serialize(writer, "low-level-gain");
                    return;
            }
            throw new Exception("Cannot marshal type CnvType");
        }

        public static readonly CnvTypeConverter Singleton = new CnvTypeConverter();
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

    internal class UnitConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Unit) || t == typeof(Unit?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Years")
            {
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
            if (value == Unit.Years)
            {
                serializer.Serialize(writer, "Years");
                return;
            }
            throw new Exception("Cannot marshal type Unit");
        }

        public static readonly UnitConverter Singleton = new UnitConverter();
    }

    internal class GenderConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Gender) || t == typeof(Gender?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "female":
                    return Gender.Female;
                case "male":
                    return Gender.Male;
                case "other":
                    return Gender.Other;
                case "unknown":
                    return Gender.Unknown;
            }
            throw new Exception("Cannot unmarshal type Gender");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Gender)untypedValue;
            switch (value)
            {
                case Gender.Female:
                    serializer.Serialize(writer, "female");
                    return;
                case Gender.Male:
                    serializer.Serialize(writer, "male");
                    return;
                case Gender.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case Gender.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type Gender");
        }

        public static readonly GenderConverter Singleton = new GenderConverter();
    }

    internal class TypeEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeEnum) || t == typeof(TypeEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Organization")
            {
                return TypeEnum.Organization;
            }
            throw new Exception("Cannot unmarshal type TypeEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeEnum)untypedValue;
            if (value == TypeEnum.Organization)
            {
                serializer.Serialize(writer, "Organization");
                return;
            }
            throw new Exception("Cannot marshal type TypeEnum");
        }

        public static readonly TypeEnumConverter Singleton = new TypeEnumConverter();
    }

    internal class VitalStatusCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(VitalStatusCode) || t == typeof(VitalStatusCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "alive":
                    return VitalStatusCode.Alive;
                case "deceased":
                    return VitalStatusCode.Deceased;
            }
            throw new Exception("Cannot unmarshal type VitalStatusCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (VitalStatusCode)untypedValue;
            switch (value)
            {
                case VitalStatusCode.Alive:
                    serializer.Serialize(writer, "alive");
                    return;
                case VitalStatusCode.Deceased:
                    serializer.Serialize(writer, "deceased");
                    return;
            }
            throw new Exception("Cannot marshal type VitalStatusCode");
        }

        public static readonly VitalStatusCodeConverter Singleton = new VitalStatusCodeConverter();
    }

    internal class EcogCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EcogCode) || t == typeof(EcogCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return EcogCode.Code0;
                case "1":
                    return EcogCode.Code1;
                case "2":
                    return EcogCode.Code2;
                case "3":
                    return EcogCode.Code3;
                case "4":
                    return EcogCode.Code4;
            }
            throw new Exception("Cannot unmarshal type EcogCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EcogCode)untypedValue;
            switch (value)
            {
                case EcogCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case EcogCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case EcogCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case EcogCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case EcogCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
            }
            throw new Exception("Cannot marshal type EcogCode");
        }

        public static readonly EcogCodeConverter Singleton = new EcogCodeConverter();
    }

    internal class ResponseTherapyTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ResponseTherapyType) || t == typeof(ResponseTherapyType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "MTBMedicationTherapy")
            {
                return ResponseTherapyType.MtbMedicationTherapy;
            }
            throw new Exception("Cannot unmarshal type ResponseTherapyType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ResponseTherapyType)untypedValue;
            if (value == ResponseTherapyType.MtbMedicationTherapy)
            {
                serializer.Serialize(writer, "MTBMedicationTherapy");
                return;
            }
            throw new Exception("Cannot marshal type ResponseTherapyType");
        }

        public static readonly ResponseTherapyTypeConverter Singleton = new ResponseTherapyTypeConverter();
    }

    internal class RecistCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(RecistCode) || t == typeof(RecistCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CR":
                    return RecistCode.Cr;
                case "MR":
                    return RecistCode.Mr;
                case "NA":
                    return RecistCode.Na;
                case "NYA":
                    return RecistCode.Nya;
                case "PD":
                    return RecistCode.Pd;
                case "PR":
                    return RecistCode.Pr;
                case "SD":
                    return RecistCode.Sd;
            }
            throw new Exception("Cannot unmarshal type RecistCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (RecistCode)untypedValue;
            switch (value)
            {
                case RecistCode.Cr:
                    serializer.Serialize(writer, "CR");
                    return;
                case RecistCode.Mr:
                    serializer.Serialize(writer, "MR");
                    return;
                case RecistCode.Na:
                    serializer.Serialize(writer, "NA");
                    return;
                case RecistCode.Nya:
                    serializer.Serialize(writer, "NYA");
                    return;
                case RecistCode.Pd:
                    serializer.Serialize(writer, "PD");
                    return;
                case RecistCode.Pr:
                    serializer.Serialize(writer, "PR");
                    return;
                case RecistCode.Sd:
                    serializer.Serialize(writer, "SD");
                    return;
            }
            throw new Exception("Cannot marshal type RecistCode");
        }

        public static readonly RecistCodeConverter Singleton = new RecistCodeConverter();
    }

    internal class TumorSpecimenCollectionLocalizationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorSpecimenCollectionLocalization) || t == typeof(TumorSpecimenCollectionLocalization?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "metastasis":
                    return TumorSpecimenCollectionLocalization.Metastasis;
                case "primary-tumor":
                    return TumorSpecimenCollectionLocalization.PrimaryTumor;
                case "unknown":
                    return TumorSpecimenCollectionLocalization.Unknown;
            }
            throw new Exception("Cannot unmarshal type TumorSpecimenCollectionLocalization");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TumorSpecimenCollectionLocalization)untypedValue;
            switch (value)
            {
                case TumorSpecimenCollectionLocalization.Metastasis:
                    serializer.Serialize(writer, "metastasis");
                    return;
                case TumorSpecimenCollectionLocalization.PrimaryTumor:
                    serializer.Serialize(writer, "primary-tumor");
                    return;
                case TumorSpecimenCollectionLocalization.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type TumorSpecimenCollectionLocalization");
        }

        public static readonly TumorSpecimenCollectionLocalizationConverter Singleton = new TumorSpecimenCollectionLocalizationConverter();
    }

    internal class TumorSpecimenCollectionMethodConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorSpecimenCollectionMethod) || t == typeof(TumorSpecimenCollectionMethod?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "biopsy":
                    return TumorSpecimenCollectionMethod.Biopsy;
                case "cytology":
                    return TumorSpecimenCollectionMethod.Cytology;
                case "liquid-biopsy":
                    return TumorSpecimenCollectionMethod.LiquidBiopsy;
                case "resection":
                    return TumorSpecimenCollectionMethod.Resection;
                case "unknown":
                    return TumorSpecimenCollectionMethod.Unknown;
            }
            throw new Exception("Cannot unmarshal type TumorSpecimenCollectionMethod");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TumorSpecimenCollectionMethod)untypedValue;
            switch (value)
            {
                case TumorSpecimenCollectionMethod.Biopsy:
                    serializer.Serialize(writer, "biopsy");
                    return;
                case TumorSpecimenCollectionMethod.Cytology:
                    serializer.Serialize(writer, "cytology");
                    return;
                case TumorSpecimenCollectionMethod.LiquidBiopsy:
                    serializer.Serialize(writer, "liquid-biopsy");
                    return;
                case TumorSpecimenCollectionMethod.Resection:
                    serializer.Serialize(writer, "resection");
                    return;
                case TumorSpecimenCollectionMethod.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type TumorSpecimenCollectionMethod");
        }

        public static readonly TumorSpecimenCollectionMethodConverter Singleton = new TumorSpecimenCollectionMethodConverter();
    }

    internal class TumorSpecimenTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TumorSpecimenType) || t == typeof(TumorSpecimenType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "FFPE":
                    return TumorSpecimenType.Ffpe;
                case "cryo-frozen":
                    return TumorSpecimenType.CryoFrozen;
                case "fresh-tissue":
                    return TumorSpecimenType.FreshTissue;
                case "liquid-biopsy":
                    return TumorSpecimenType.LiquidBiopsy;
                case "unknown":
                    return TumorSpecimenType.Unknown;
            }
            throw new Exception("Cannot unmarshal type TumorSpecimenType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TumorSpecimenType)untypedValue;
            switch (value)
            {
                case TumorSpecimenType.Ffpe:
                    serializer.Serialize(writer, "FFPE");
                    return;
                case TumorSpecimenType.CryoFrozen:
                    serializer.Serialize(writer, "cryo-frozen");
                    return;
                case TumorSpecimenType.FreshTissue:
                    serializer.Serialize(writer, "fresh-tissue");
                    return;
                case TumorSpecimenType.LiquidBiopsy:
                    serializer.Serialize(writer, "liquid-biopsy");
                    return;
                case TumorSpecimenType.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type TumorSpecimenType");
        }

        public static readonly TumorSpecimenTypeConverter Singleton = new TumorSpecimenTypeConverter();
    }
}
