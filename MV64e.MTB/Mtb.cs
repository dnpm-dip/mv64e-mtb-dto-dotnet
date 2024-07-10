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

        [JsonProperty("consent", Required = Required.Always)]
        public Consent Consent { get; set; }

        [JsonProperty("diagnoses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbDiagnosis> Diagnoses { get; set; }

        [JsonProperty("ecogStatus", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<PerformanceStatus> EcogStatus { get; set; }

        [JsonProperty("episode", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public MtbEpisode Episode { get; set; }

        [JsonProperty("geneticCounsellingRequests", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<GeneticCounselingRecommendation> GeneticCounsellingRequests { get; set; }

        [JsonProperty("histologyReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<HistologyReport> HistologyReports { get; set; }

        [JsonProperty("lastGuidelineTherapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationTherapy> LastGuidelineTherapies { get; set; }

        [JsonProperty("molecularTherapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MolecularTherapy> MolecularTherapies { get; set; }

        [JsonProperty("ngsReports", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<SomaticNgsReport> NgsReports { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public MtbPatient Patient { get; set; }

        [JsonProperty("previousGuidelineTherapies", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationTherapy> PreviousGuidelineTherapies { get; set; }

        [JsonProperty("recommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<MtbMedicationRecommendation> Recommendations { get; set; }

        [JsonProperty("responses", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Response> Responses { get; set; }

        [JsonProperty("specimens", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<TumorSpecimen> Specimens { get; set; }

        [JsonProperty("studyInclusionRequests", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StudyEnrollmentRecommendation> StudyInclusionRequests { get; set; }
    }

    public partial class MtbCarePlan
    {
        [JsonProperty("description", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Diagnosis { get; set; }

        [JsonProperty("geneticCounsellingRequest", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string GeneticCounsellingRequest { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("noTargetFinding", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public NoTargetFinding NoTargetFinding { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("recommendations", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Recommendations { get; set; }

        [JsonProperty("studyInclusionRequests", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> StudyInclusionRequests { get; set; }
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

    public partial class Patient
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public PatientType Type { get; set; }
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

        [JsonProperty("reason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ClaimResponseStatusReason? Reason { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public CodingClaimResponseStatus Status { get; set; }
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

    public partial class Claim
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("therapy", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Therapy { get; set; }
    }

    public partial class Consent
    {
        [JsonProperty("id", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        [JsonProperty("patient", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Patient Patient { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public ConsentStatus? Status { get; set; }
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

        [JsonProperty("statusHistory", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<StatusHistory> StatusHistory { get; set; }

        [JsonProperty("whoGrade", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding WhoGrade { get; set; }
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

    public partial class StatusHistory
    {
        [JsonProperty("date", Required = Required.Always)]
        public DateTimeOffset Date { get; set; }

        [JsonProperty("status", Required = Required.Always)]
        public MtbDiagnosisTumorSpread Status { get; set; }
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
        public PurpleCode Code { get; set; }

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

    public partial class GeneticCounselingRecommendation
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public string Reason { get; set; }
    }

    public partial class HistologyReport
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issuedOn", Required = Required.Always)]
        public DateTimeOffset IssuedOn { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public HistologyReportSpecimen Specimen { get; set; }

        [JsonProperty("tumorCellContent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TumorCellContent TumorCellContent { get; set; }

        [JsonProperty("tumorMorphology", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TumorMorphology TumorMorphology { get; set; }
    }

    public partial class HistologyReportSpecimen
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public SpecimenType Type { get; set; }
    }

    public partial class TumorCellContent
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("method", Required = Required.Always)]
        public TumorCellContentMethod Method { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public string Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public double Value { get; set; }
    }

    public partial class TumorMorphology
    {
        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("note", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public string Specimen { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public Coding Value { get; set; }
    }

    public partial class MtbMedicationTherapy
    {
        [JsonProperty("basedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string BasedOn { get; set; }

        [JsonProperty("diagnosis", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("medication", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Coding> Medication { get; set; }

        [JsonProperty("notDoneReason", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatusReason NotDoneReason { get; set; }

        [JsonProperty("note", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("period", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public PeriodLocalDate Period { get; set; }

        [JsonProperty("reasonStopped", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public CodingTherapyStatusReason ReasonStopped { get; set; }

        [JsonProperty("recordedOn", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? RecordedOn { get; set; }

        [JsonProperty("status", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TherapyStatus? Status { get; set; }

        [JsonProperty("therapyLine", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TherapyLine { get; set; }
    }

    public partial class CodingTherapyStatusReason
    {
        [JsonProperty("code", Required = Required.Always)]
        public NotDoneReasonCode Code { get; set; }

        [JsonProperty("display", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Display { get; set; }

        [JsonProperty("system", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string System { get; set; }

        [JsonProperty("version", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }
    }

    public partial class MolecularTherapy
    {
        [JsonProperty("history", Required = Required.Always)]
        public List<MtbMedicationTherapy> History { get; set; }
    }

    public partial class SomaticNgsReport
    {
        [JsonProperty("brcaness", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Brcaness { get; set; }

        [JsonProperty("copyNumberVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Cnv> CopyNumberVariants { get; set; }

        [JsonProperty("dnaFusions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<DnaFusion> DnaFusions { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("issueDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IssueDate { get; set; }

        [JsonProperty("metadata", Required = Required.Always)]
        public List<Metadatum> Metadata { get; set; }

        [JsonProperty("msi", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Msi { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("rnaFusions", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<RnaFusion> RnaFusions { get; set; }

        [JsonProperty("rnaSeqs", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<RnaSeq> RnaSeqs { get; set; }

        [JsonProperty("sequencingType", Required = Required.Always)]
        public Coding SequencingType { get; set; }

        [JsonProperty("simpleVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<Snv> SimpleVariants { get; set; }

        [JsonProperty("specimen", Required = Required.Always)]
        public NgsReportSpecimen Specimen { get; set; }

        [JsonProperty("tmb", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tmb { get; set; }

        [JsonProperty("tumorCellContent", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public TumorCellContent TumorCellContent { get; set; }
    }

    public partial class Cnv
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("cnA", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnA { get; set; }

        [JsonProperty("cnB", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? CnB { get; set; }

        [JsonProperty("copyNumberNeutralLoH", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<CopyNumberNeutralLoH> CopyNumberNeutralLoH { get; set; }

        [JsonProperty("endRange", Required = Required.Always)]
        public EndRange EndRange { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("relativeCopyNumber", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? RelativeCopyNumber { get; set; }

        [JsonProperty("reportedAffectedGenes", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<ReportedAffectedGene> ReportedAffectedGenes { get; set; }

        [JsonProperty("reportedFocality", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string ReportedFocality { get; set; }

        [JsonProperty("startRange", Required = Required.Always)]
        public StartRange StartRange { get; set; }

        [JsonProperty("totalCopyNumber", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public long? TotalCopyNumber { get; set; }

        [JsonProperty("type", Required = Required.Always)]
        public CnvType Type { get; set; }
    }

    public partial class CopyNumberNeutralLoH
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class EndRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
    }

    public partial class ReportedAffectedGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class StartRange
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
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
        public Chromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public PurpleGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class PurpleGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class DnaFusionFusionPartner5Prime
    {
        [JsonProperty("chromosome", Required = Required.Always)]
        public Chromosome Chromosome { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public FluffyGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }
    }

    public partial class FluffyGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
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
        public TentacledGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public string TranscriptId { get; set; }
    }

    public partial class TentacledGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class RnaFusionFusionPartner5Prime
    {
        [JsonProperty("exon", Required = Required.Always)]
        public string Exon { get; set; }

        [JsonProperty("gene", Required = Required.Always)]
        public StickyGene Gene { get; set; }

        [JsonProperty("position", Required = Required.Always)]
        public double Position { get; set; }

        [JsonProperty("strand", Required = Required.Always)]
        public RnaFusionStrand Strand { get; set; }

        [JsonProperty("transcriptId", Required = Required.Always)]
        public string TranscriptId { get; set; }
    }

    public partial class StickyGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
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
        public RnaSeqGene Gene { get; set; }

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

    public partial class RnaSeqGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
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
        public Chromosome Chromosome { get; set; }

        [JsonProperty("cosmicId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string CosmicId { get; set; }

        [JsonProperty("dbSNPId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string DbSnpId { get; set; }

        [JsonProperty("dnaChange", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding DnaChange { get; set; }

        [JsonProperty("gene", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public SimpleVariantGene Gene { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("interpretation", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Interpretation { get; set; }

        [JsonProperty("readDepth", Required = Required.Always)]
        public long ReadDepth { get; set; }

        [JsonProperty("refAllele", Required = Required.Always)]
        public string RefAllele { get; set; }

        [JsonProperty("startEnd", Required = Required.Always)]
        public StartEnd StartEnd { get; set; }
    }

    public partial class SimpleVariantGene
    {
        [JsonProperty("ensemblId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string EnsemblId { get; set; }

        [JsonProperty("hgncId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string HgncId { get; set; }
    }

    public partial class StartEnd
    {
        [JsonProperty("end", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public double? End { get; set; }

        [JsonProperty("start", Required = Required.Always)]
        public double Start { get; set; }
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

        [JsonProperty("birthDate", Required = Required.Always)]
        public DateTimeOffset BirthDate { get; set; }

        [JsonProperty("dateOfDeath", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateOfDeath { get; set; }

        [JsonProperty("gender", Required = Required.Always)]
        public CodingGender Gender { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

        [JsonProperty("insurance", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public string Insurance { get; set; }
    }

    public partial class Address
    {
        [JsonProperty("municipalityCode", Required = Required.Always)]
        public string MunicipalityCode { get; set; }
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

    public partial class MtbMedicationRecommendation
    {
        [JsonProperty("diagnosis", Required = Required.Always)]
        public string Diagnosis { get; set; }

        [JsonProperty("id", Required = Required.Always)]
        public string Id { get; set; }

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
        public TherapyRecommendationPriority? Priority { get; set; }

        [JsonProperty("supportingVariants", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public List<string> SupportingVariants { get; set; }
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
        public SystemEnum? System { get; set; }

        [JsonProperty("value", Required = Required.Always)]
        public string Value { get; set; }
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
        public FluffyCode Code { get; set; }

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

        [JsonProperty("icd10", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public Coding Icd10 { get; set; }

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

    public partial class CodingTumorSpecimenType
    {
        [JsonProperty("code", Required = Required.Always)]
        public TumorSpecimenType Code { get; set; }

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

        [JsonProperty("nctNumber", Required = Required.Always)]
        public string NctNumber { get; set; }

        [JsonProperty("patient", Required = Required.Always)]
        public Patient Patient { get; set; }

        [JsonProperty("reason", Required = Required.Always)]
        public string Reason { get; set; }
    }

    public enum PatientType { Patient };

    public enum ClaimResponseClaimType { Claim };

    public enum ClaimResponseStatusReason { ApprovalRevocation, FormalReasons, InclusionInStudy, InsufficientEvidence, Other, OtherTherapyRecommended, StandardTherapyNotExhausted, Unknown };

    public enum ClaimResponseStatus { Accepted, Rejected, Unknown };

    public enum ConsentStatus { Active, Rejected };

    public enum MtbDiagnosisTumorSpread { Local, Metastasized, TumorFree, Unknown };

    public enum PurpleCode { Code0, Code1, Code2, Code3, Code4 };

    public enum SpecimenType { TumorSpecimen };

    public enum TumorCellContentMethod { Bioinformatic, Histologic };

    public enum NotDoneReasonCode { ChronicRemission, ContinuedExternally, Deterioration, LostToFu, MedicalReason, NoIndication, Other, OtherTherapyChosen, PatientDeath, PatientRefusal, PatientWish, PaymentEnded, PaymentPending, PaymentRefused, Progression, Toxicity, Unknown };

    public enum TherapyStatus { Completed, NotDone, OnGoing, Stopped, Unknown };

    public enum Chromosome { Chr1, Chr10, Chr11, Chr12, Chr13, Chr14, Chr15, Chr16, Chr17, Chr18, Chr19, Chr2, Chr20, Chr21, Chr22, Chr3, Chr4, Chr5, Chr6, Chr7, Chr8, Chr9, ChrX, ChrY };

    public enum CnvType { HighLevelGain, Loss, LowLevelGain };

    public enum RnaFusionStrand { Empty, RnaFusionStrand };

    public enum Gender { Female, Male, Other, Unknown };

    public enum AddendumCode { Is, Iv, R, Z };

    public enum GradingCode { M1A, M1B, M1C, M2A, M2B, M2C, M3, M4, Undefined };

    public enum SystemEnum { HttpsPubmedNcbiNlmNihGov };

    public enum TherapyRecommendationPriority { Priority1, Priority2, Priority3, Priority4 };

    public enum ResponseTherapyType { MtbMedicationTherapy };

    public enum FluffyCode { Cr, Mr, Na, Nya, Pd, Pr, Sd };

    public enum TumorSpecimenCollectionLocalization { Metastasis, PrimaryTumor, Unknown };

    public enum TumorSpecimenCollectionMethod { Biopsy, Cytology, LiquidBiopsy, Resection, Unknown };

    public enum TumorSpecimenType { CryoFrozen, Ffpe, FreshTissue, LiquidBiopsy, Unknown };

    public partial class Mtb
    {
        public static Mtb FromJson(string json) => JsonConvert.DeserializeObject<Mtb>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Mtb self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                PatientTypeConverter.Singleton,
                ClaimResponseClaimTypeConverter.Singleton,
                ClaimResponseStatusReasonConverter.Singleton,
                ClaimResponseStatusConverter.Singleton,
                ConsentStatusConverter.Singleton,
                MtbDiagnosisTumorSpreadConverter.Singleton,
                PurpleCodeConverter.Singleton,
                SpecimenTypeConverter.Singleton,
                TumorCellContentMethodConverter.Singleton,
                NotDoneReasonCodeConverter.Singleton,
                TherapyStatusConverter.Singleton,
                ChromosomeConverter.Singleton,
                CnvTypeConverter.Singleton,
                RnaFusionStrandConverter.Singleton,
                GenderConverter.Singleton,
                AddendumCodeConverter.Singleton,
                GradingCodeConverter.Singleton,
                SystemEnumConverter.Singleton,
                TherapyRecommendationPriorityConverter.Singleton,
                ResponseTherapyTypeConverter.Singleton,
                FluffyCodeConverter.Singleton,
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

    internal class ConsentStatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ConsentStatus) || t == typeof(ConsentStatus?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "active":
                    return ConsentStatus.Active;
                case "rejected":
                    return ConsentStatus.Rejected;
            }
            throw new Exception("Cannot unmarshal type ConsentStatus");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ConsentStatus)untypedValue;
            switch (value)
            {
                case ConsentStatus.Active:
                    serializer.Serialize(writer, "active");
                    return;
                case ConsentStatus.Rejected:
                    serializer.Serialize(writer, "rejected");
                    return;
            }
            throw new Exception("Cannot marshal type ConsentStatus");
        }

        public static readonly ConsentStatusConverter Singleton = new ConsentStatusConverter();
    }

    internal class MtbDiagnosisTumorSpreadConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MtbDiagnosisTumorSpread) || t == typeof(MtbDiagnosisTumorSpread?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "local":
                    return MtbDiagnosisTumorSpread.Local;
                case "metastasized":
                    return MtbDiagnosisTumorSpread.Metastasized;
                case "tumor-free":
                    return MtbDiagnosisTumorSpread.TumorFree;
                case "unknown":
                    return MtbDiagnosisTumorSpread.Unknown;
            }
            throw new Exception("Cannot unmarshal type MtbDiagnosisTumorSpread");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MtbDiagnosisTumorSpread)untypedValue;
            switch (value)
            {
                case MtbDiagnosisTumorSpread.Local:
                    serializer.Serialize(writer, "local");
                    return;
                case MtbDiagnosisTumorSpread.Metastasized:
                    serializer.Serialize(writer, "metastasized");
                    return;
                case MtbDiagnosisTumorSpread.TumorFree:
                    serializer.Serialize(writer, "tumor-free");
                    return;
                case MtbDiagnosisTumorSpread.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type MtbDiagnosisTumorSpread");
        }

        public static readonly MtbDiagnosisTumorSpreadConverter Singleton = new MtbDiagnosisTumorSpreadConverter();
    }

    internal class PurpleCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(PurpleCode) || t == typeof(PurpleCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "0":
                    return PurpleCode.Code0;
                case "1":
                    return PurpleCode.Code1;
                case "2":
                    return PurpleCode.Code2;
                case "3":
                    return PurpleCode.Code3;
                case "4":
                    return PurpleCode.Code4;
            }
            throw new Exception("Cannot unmarshal type PurpleCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (PurpleCode)untypedValue;
            switch (value)
            {
                case PurpleCode.Code0:
                    serializer.Serialize(writer, "0");
                    return;
                case PurpleCode.Code1:
                    serializer.Serialize(writer, "1");
                    return;
                case PurpleCode.Code2:
                    serializer.Serialize(writer, "2");
                    return;
                case PurpleCode.Code3:
                    serializer.Serialize(writer, "3");
                    return;
                case PurpleCode.Code4:
                    serializer.Serialize(writer, "4");
                    return;
            }
            throw new Exception("Cannot marshal type PurpleCode");
        }

        public static readonly PurpleCodeConverter Singleton = new PurpleCodeConverter();
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

    internal class NotDoneReasonCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(NotDoneReasonCode) || t == typeof(NotDoneReasonCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "chronic-remission":
                    return NotDoneReasonCode.ChronicRemission;
                case "continued-externally":
                    return NotDoneReasonCode.ContinuedExternally;
                case "deterioration":
                    return NotDoneReasonCode.Deterioration;
                case "lost-to-fu":
                    return NotDoneReasonCode.LostToFu;
                case "medical-reason":
                    return NotDoneReasonCode.MedicalReason;
                case "no-indication":
                    return NotDoneReasonCode.NoIndication;
                case "other":
                    return NotDoneReasonCode.Other;
                case "other-therapy-chosen":
                    return NotDoneReasonCode.OtherTherapyChosen;
                case "patient-death":
                    return NotDoneReasonCode.PatientDeath;
                case "patient-refusal":
                    return NotDoneReasonCode.PatientRefusal;
                case "patient-wish":
                    return NotDoneReasonCode.PatientWish;
                case "payment-ended":
                    return NotDoneReasonCode.PaymentEnded;
                case "payment-pending":
                    return NotDoneReasonCode.PaymentPending;
                case "payment-refused":
                    return NotDoneReasonCode.PaymentRefused;
                case "progression":
                    return NotDoneReasonCode.Progression;
                case "toxicity":
                    return NotDoneReasonCode.Toxicity;
                case "unknown":
                    return NotDoneReasonCode.Unknown;
            }
            throw new Exception("Cannot unmarshal type NotDoneReasonCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (NotDoneReasonCode)untypedValue;
            switch (value)
            {
                case NotDoneReasonCode.ChronicRemission:
                    serializer.Serialize(writer, "chronic-remission");
                    return;
                case NotDoneReasonCode.ContinuedExternally:
                    serializer.Serialize(writer, "continued-externally");
                    return;
                case NotDoneReasonCode.Deterioration:
                    serializer.Serialize(writer, "deterioration");
                    return;
                case NotDoneReasonCode.LostToFu:
                    serializer.Serialize(writer, "lost-to-fu");
                    return;
                case NotDoneReasonCode.MedicalReason:
                    serializer.Serialize(writer, "medical-reason");
                    return;
                case NotDoneReasonCode.NoIndication:
                    serializer.Serialize(writer, "no-indication");
                    return;
                case NotDoneReasonCode.Other:
                    serializer.Serialize(writer, "other");
                    return;
                case NotDoneReasonCode.OtherTherapyChosen:
                    serializer.Serialize(writer, "other-therapy-chosen");
                    return;
                case NotDoneReasonCode.PatientDeath:
                    serializer.Serialize(writer, "patient-death");
                    return;
                case NotDoneReasonCode.PatientRefusal:
                    serializer.Serialize(writer, "patient-refusal");
                    return;
                case NotDoneReasonCode.PatientWish:
                    serializer.Serialize(writer, "patient-wish");
                    return;
                case NotDoneReasonCode.PaymentEnded:
                    serializer.Serialize(writer, "payment-ended");
                    return;
                case NotDoneReasonCode.PaymentPending:
                    serializer.Serialize(writer, "payment-pending");
                    return;
                case NotDoneReasonCode.PaymentRefused:
                    serializer.Serialize(writer, "payment-refused");
                    return;
                case NotDoneReasonCode.Progression:
                    serializer.Serialize(writer, "progression");
                    return;
                case NotDoneReasonCode.Toxicity:
                    serializer.Serialize(writer, "toxicity");
                    return;
                case NotDoneReasonCode.Unknown:
                    serializer.Serialize(writer, "unknown");
                    return;
            }
            throw new Exception("Cannot marshal type NotDoneReasonCode");
        }

        public static readonly NotDoneReasonCodeConverter Singleton = new NotDoneReasonCodeConverter();
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
            }
            throw new Exception("Cannot marshal type Chromosome");
        }

        public static readonly ChromosomeConverter Singleton = new ChromosomeConverter();
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

    internal class SystemEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SystemEnum) || t == typeof(SystemEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "https://pubmed.ncbi.nlm.nih.gov/")
            {
                return SystemEnum.HttpsPubmedNcbiNlmNihGov;
            }
            throw new Exception("Cannot unmarshal type SystemEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SystemEnum)untypedValue;
            if (value == SystemEnum.HttpsPubmedNcbiNlmNihGov)
            {
                serializer.Serialize(writer, "https://pubmed.ncbi.nlm.nih.gov/");
                return;
            }
            throw new Exception("Cannot marshal type SystemEnum");
        }

        public static readonly SystemEnumConverter Singleton = new SystemEnumConverter();
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
                    return TherapyRecommendationPriority.Priority1;
                case "2":
                    return TherapyRecommendationPriority.Priority2;
                case "3":
                    return TherapyRecommendationPriority.Priority3;
                case "4":
                    return TherapyRecommendationPriority.Priority4;
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
                case TherapyRecommendationPriority.Priority1:
                    serializer.Serialize(writer, "1");
                    return;
                case TherapyRecommendationPriority.Priority2:
                    serializer.Serialize(writer, "2");
                    return;
                case TherapyRecommendationPriority.Priority3:
                    serializer.Serialize(writer, "3");
                    return;
                case TherapyRecommendationPriority.Priority4:
                    serializer.Serialize(writer, "4");
                    return;
            }
            throw new Exception("Cannot marshal type TherapyRecommendationPriority");
        }

        public static readonly TherapyRecommendationPriorityConverter Singleton = new TherapyRecommendationPriorityConverter();
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

    internal class FluffyCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(FluffyCode) || t == typeof(FluffyCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "CR":
                    return FluffyCode.Cr;
                case "MR":
                    return FluffyCode.Mr;
                case "NA":
                    return FluffyCode.Na;
                case "NYA":
                    return FluffyCode.Nya;
                case "PD":
                    return FluffyCode.Pd;
                case "PR":
                    return FluffyCode.Pr;
                case "SD":
                    return FluffyCode.Sd;
            }
            throw new Exception("Cannot unmarshal type FluffyCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (FluffyCode)untypedValue;
            switch (value)
            {
                case FluffyCode.Cr:
                    serializer.Serialize(writer, "CR");
                    return;
                case FluffyCode.Mr:
                    serializer.Serialize(writer, "MR");
                    return;
                case FluffyCode.Na:
                    serializer.Serialize(writer, "NA");
                    return;
                case FluffyCode.Nya:
                    serializer.Serialize(writer, "NYA");
                    return;
                case FluffyCode.Pd:
                    serializer.Serialize(writer, "PD");
                    return;
                case FluffyCode.Pr:
                    serializer.Serialize(writer, "PR");
                    return;
                case FluffyCode.Sd:
                    serializer.Serialize(writer, "SD");
                    return;
            }
            throw new Exception("Cannot marshal type FluffyCode");
        }

        public static readonly FluffyCodeConverter Singleton = new FluffyCodeConverter();
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
