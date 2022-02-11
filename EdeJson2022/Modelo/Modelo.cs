using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EdeJson2022.Modelo
{
    public class Modelo
    {   

    public class _Personas
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<Person>? Person { get; set; }
        public List<PersonIdentifier>? PersonIdentifier { get; set; }
        public List<PersonBirthplace>? PersonBirthplace { get; set; }
        public List<PersonAddress>? PersonAddress { get; set; }
        public List<PersonEmailAddress>? PersonEmailAddress { get; set; }
        public List<PersonTelephone>? PersonTelephone { get; set; }
        public List<PersonStatus>? PersonStatus { get; set; }
        public List<PersonLanguage>? PersonLanguage { get; set; }
        public List<PersonDisability>? PersonDisability { get; set; }
        public List<PersonRelationship>? PersonRelationship { get; set; }
        public List<PersonSindromes>? PersonSindromes { get; set; }
        public List<PersonDegreeOrCertificate>? PersonDegreeOrCertificate { get; set; }

    }

            public class Person
            {
                public int PersonId { get; set; }
                public string? FirstName { get; set; }

                public string? MiddleName { get; set; }

                public string? LastName { get; set; }

                public string? SecondLastName { get; set; }

                public int GenerationCode { get; set; }

                public int Prefix { get; set; }

                public string? Birthdate { get; set; }

                public int RefSexId { get; set; }

                public Boolean? HispanicLatinoEthnicity { get; set; }

                public int? RefUSCitizenshipStatusId { get; set; }

                public int? RefVisaTypeId { get; set; }

                public int? RefStateOfResidenceId { get; set; }
                public int? RefProofOfResidencyTypeId { get; set; }

                public int? RefHighestEducationLevelCompletedId { get; set; }

                public int? RefPersonalInformationVerificationId { get; set; }

                public string? BirthdateVerification { get; set; }

                public int RefTribalAffiliationId { get; set; }

            }

            public class PersonIdentifier
            {
                public int PersonIdentifierId { get; set; }
                public int PersonId { get; set; }
                public string? Identifier { get; set; }
                public int RefPersonIdentificationSystemId { get; set; }
                public int RefPersonalInformationVerificationId { get; set; }

            }

            public class PersonBirthplace
            {
                public int PersonId { get; set; }
                public string? City { get; set; }
                public int RefStateId { get; set; }
                public int RefCountryId { get; set; }

            }

            public class PersonAddress
            {
                public int PersonAddressId { get; set; }
                public int PersonId { get; set; }
                public int? RefPersonLocationTypeId { get; set; }
                public string? StreetNumberAndName { get; set; }
                public string? ApartmentRoomOrSuiteNumber { get; set; }
                public string? City { get; set; }
                public int RefStateId { get; set; }
                public int PostalCode { get; set; }
                public string? AddressCountyName { get; set; }
                public int RefCountyId { get; set; }
                public string? Latitude { get; set; }
                public string? Longitude { get; set; }
                public int? RefPersonalInformationVerificationId { get; set; }

            }

            public class PersonEmailAddress
            {
                public int PersonEmailAddressId { get; set; }

                public int PersonId { get; set; }

                public int? EmailAddress { get; set; }

                public int? RefEmailTypeId { get; set; }

            }

            public class PersonTelephone
            {

                public int PersonTelephoneId { get; set; }
                public int PersonId { get; set; }
                public string? TelephoneNumber { get; set; }
                public string? PrimaryTelephoneNumberIndicator { get; set; }
                public int? RefPersonTelephoneNumberTypeId { get; set; }


            }

            public class PersonStatus
            {

                public int PersonStatusId { get; set; }

                public int PersonId { get; set; }

                public int? RefPersonStatusTypeId { get; set; }

                public string? StatusValue { get; set; }

                public string? StatusStartDate { get; set; }

                public string? StatusEndDate { get; set; }
            }

            public class PersonLanguage
            {
                public int PersonLanguageId { get; set; }

                public int PersonId { get; set; }

                public int? RefLanguageId { get; set; }

                public int? RefLanguageUseTypeId { get; set; }

            }

            public class PersonDisability
            {
                public int PersonId { get; set; }
                public int PrimaryDisabilityTypeId { get; set; }
                public string? DisabilityStatus { get; set; }
                public int? RefAccommodationsNeededTypeId { get; set; }
                public int? RefDisabilityConditionTypeId { get; set; }
                public int? RefDisabilityDeterminationSourceTypeId { get; set; }
                public int? RefDisabilityConditionStatusCodeId { get; set; }
                public int? RefIDEADisabilityTypeI { get; set; }
                public string? SignificantCognitiveDisabilityIndicator { get; set; }

            }

            public class PersonRelationship
            {
                public int PersonRelationshipId { get; set; }
                public int PersonId { get; set; }
                public int RelatedPersonId { get; set; }
                public int RefPersonRelationshipId { get; set; }
                public string? CustodialRelationshipIndicator { get; set; }
                public string? EmergencyContactInd { get; set; }
                public string? ContactPriorityNumber { get; set; }
                public string? ContactRestrictions { get; set; }
                public string? LivesWithIndicator { get; set; }
                public string? PrimaryContactIndicator { get; set; }

            }

            public class PersonSindromes
            {
                public int PersonRelationshipId { get; set; }
                public int PersonId { get; set; }
                public int RelatedPersonId { get; set; }
                public int RefPersonRelationshipId { get; set; }
                public string? CustodialRelationshipIndicator { get; set; }
                public string? EmergencyContactInd { get; set; }
                public string? ContactPriorityNumber { get; set; }
                public string? ContactRestrictions { get; set; }
                public string? LivesWithIndicator { get; set; }
                public string? PrimaryContactIndicator { get; set; }

            }

            public class PersonDegreeOrCertificate
            {
                public int PersonDegreeOrCertificateId { get; set; }
                public int PersonId { get; set; }
                public int? DegreeOrCertificateTitleOrSubject { get; set; }
                public int? RefDegreeOrCertificateTypeId { get; set; }
                public string? AwardDate { get; set; }
                public string? NameOfInstitution { get; set; }
                public int RefHigherEducationInstitutionAccreditationStatusId { get; set; }
                public int RefEducationVerificationMethodId { get; set; }

            }

    public class _Organizaciones
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<Organization>? Organization { get; set; }
        public List<OrganizationLocation>? OrganizationLocation { get; set; }
        public List<OrganizationTelephone>? OrganizationTelephone { get; set; }
        public List<OrganizationEmail>? OrganizationEmail { get; set; }
        public List<OrganizationWebsite>? OrganizationWebsite { get; set; }
        public List<OrganizationIdentifier>? OrganizationIdentifier { get; set; }
        public List<OrganizationOperationalStatus>? OrganizationOperationalStatus { get; set; }
        public List<RefOrganizationRelationship>? RefOrganizationRelationship { get; set; }
        public List<OrganizationRelationship>? OrganizationRelationship { get; set; }

    }

            public class Organization
            {
                public int OrganizationId { get; set; }
                public string? Name { get; set; }
                public int RefOrganizationTypeId { get; set; }
                public string? ShortName { get; set; }
                public string? RegionGeoJSON { get; set; }
            }

            public class OrganizationLocation
            {
                public int OrganizationLocationId { get; set; }

                public int OrganizationId { get; set; }

                public int LocationId { get; set; }

                public string? RefOrganizationLocationTypeId { get; set; }
            }

            public class OrganizationTelephone
            {
                public int OrganizationTelephoneId { get; set; }

                public int OrganizationId { get; set; }

                public string? TelephoneNumber { get; set; }

                public string? PrimaryTelephoneNumberIndicator { get; set; }

                public int? RefInstitutionTelephoneTypeId { get; set; }
            }

            public class OrganizationEmail
            {
                public int OrganizationEmailId { get; set; }

                public int OrganizationId { get; set; }

                public string? ElectronicMailAddress { get; set; }

                public int? RefEmailTypeId { get; set; }
            }

            public class OrganizationWebsite
            {
                public int OrganizationId { get; set; }

                public string? Website { get; set; }
            }

            public class OrganizationIdentifier
            {
            }

            public class OrganizationOperationalStatus
                {
            }

            public class RefOrganizationRelationship
            {
                public int RefOrganizationRelationshipId { get; set; }
                public string? Description { get; set; }
                public string? Code { get; set; }
                public string? Definition { get; set; }
                public int RefJurisdictionId { get; set; }
                public int SortOrder { get; set; }

            }

            public class OrganizationRelationship
            {
                public int OrganizationRelationshipId { get; set; }

                public int Parent_OrganizationId { get; set; }

                public int OrganizationId { get; set; }

                public int RefOrganizationRelationshipId { get; set; }
            }

    public class _Establecimientos
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<K12SchoolCorrectiveAction>? K12SchoolCorrectiveAction { get; set; }
        public List<K12School>? K12School { get; set; }
        public List<K12SchoolStatus>? K12SchoolStatus { get; set; }
        public List<K12SchoolGradeOffered>? K12SchoolGradeOffered { get; set; }
        public List<K12SchoolImprovement>? K12SchoolImprovement { get; set; }
        public List<OrganizationIdentifier>? OrganizationIdentifier { get; set; }
        public List<OrganizationOperationalStatus>? OrganizationOperationalStatus { get; set; }
        public List<RefOrganizationRelationship>? RefOrganizationRelationship { get; set; }
        public List<OrganizationRelationship>? OrganizationRelationship { get; set; }

    }

    
            public class K12SchoolCorrectiveAction
            {
                public int OrganizationId { get; set; }
                public int RefSchoolTypeId { get; set; }
                public int? RefSchoolLevelId { get; set; }
                public int? RefAdministrativeFundingControlId { get; set; }
                public Boolean? CharterSchoolIndicator { get; set; }
                public int? RefCharterSchoolTypeId { get; set; }
                public int? RefIncreasedLearningTimeTypeId { get; set; }
                public int? RefStatePovertyDesignationId { get; set; }
                public int? CharterSchoolApprovalYear { get; set; }
                public int? RefCharterSchoolApprovalAgencyTypeId { get; set; }
                public int? AccreditationAgencyName { get; set; }
                public int? CharterSchoolOpenEnrollmentIndicator { get; set; }
                public int? CharterSchoolContractApprovalDate { get; set; }
                public int? CharterSchoolContractIdNumber { get; set; }
                public int? CharterSchoolContractRenewalDate { get; set; }
                public int? RefCharterSchoolManagementOrganizationTypeId { get; set; }

            }

            public class K12School
            {
                public int OrganizationId { get; set; }
                public int RefSchoolTypeId { get; set; }
                public int? RefSchoolLevelId { get; set; }
                public int? RefAdministrativeFundingControlId { get; set; }
                public Boolean? CharterSchoolIndicator { get; set; }
                public int? RefCharterSchoolTypeId { get; set; }
                public int? RefIncreasedLearningTimeTypeId { get; set; }
                public int? RefStatePovertyDesignationId { get; set; }
                public int? CharterSchoolApprovalYear { get; set; }
                public int? RefCharterSchoolApprovalAgencyTypeId { get; set; }
                public int? AccreditationAgencyName { get; set; }
                public int? CharterSchoolOpenEnrollmentIndicator { get; set; }
                public int? CharterSchoolContractApprovalDate { get; set; }
                public int? CharterSchoolContractIdNumber { get; set; }
                public int? CharterSchoolContractRenewalDate { get; set; }
                public int? RefCharterSchoolManagementOrganizationTypeId { get; set; }

            }

            public class K12SchoolStatus
            {
                public int OrganizationId { get; set; }
                public int? RefMagnetSpecialProgramId { get; set; }
                public int? RefAlternativeSchoolFocusId { get; set; }
                public int? RefInternetAccessId { get; set; }
                public int? RefRestructuringActionId { get; set; }
                public int? RefTitleISchoolStatusId { get; set; }
                public string? ConsolidatedMepFundsStatus { get; set; }
                public string? RefNationalSchoolLunchProgramStatusId { get; set; }
                public int RefVirtualSchoolStatusId { get; set; }


            }

            public class K12SchoolGradeOffered
            {
                public int K12SchoolGradeOfferedId { get; set; }

                public int OrganizationId { get; set; }

                public int RefGradeLevelId { get; set; }
            }

            public class K12SchoolImprovement
            {
                public int K12SchoolGradeOfferedId { get; set; }

                public int OrganizationId { get; set; }

                public int RefGradeLevelId { get; set; }
            }

    public class _Calendarios
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<OrganizationCalendar>? OrganizationCalendar { get; set; }
        public List<OrganizationCalendarDay>? OrganizationCalendarDay { get; set; }
        public List<OrganizationCalendarCrisis>? OrganizationCalendarCrisis { get; set; }
        public List<OrganizationCalendarSession>? OrganizationCalendarSession { get; set; }
        public List<OrganizationCalendarEvent>? OrganizationCalendarEvent { get; set; }

    }

            public class OrganizationCalendar
            {

                public int OrganizationCalendarId { get; set; }
                public int OrganizationId { get; set; }
                public string? CalendarCode { get; set; }
                public string? CalendarDescription { get; set; }
                public string? CalendarYear { get; set; }
            }

            public class OrganizationCalendarDay
            {
            }

            public class OrganizationCalendarCrisis
            {
                public int OrganizationCalendarCrisisId { get; set; }
                public int OrganizationId { get; set; }
                public string? Code { get; set; }
                public string? Name { get; set; }
                public string? StartDate { get; set; }
                public string? EndDate { get; set; }
                public string? Type { get; set; }
                public string? CrisisDescription { get; set; }
                public string? CrisisEndDate { get; set; }

            }

            public class OrganizationCalendarSession
            {
                public int OrganizationCalendarSessionId { get; set; }
                public string? Designator { get; set; }
                public string? BeginDate { get; set; }
                public string? EndDate { get; set; }
                public string? RefSessionTypeId { get; set; }
                public string? InstructionalMinutes { get; set; }
                public string? Code { get; set; }
                public string? Description { get; set; }
                public string? MarkingTermIndicator { get; set; }
                public string? SchedulingTermIndicator { get; set; }
                public string? AttendanceTermIndicator { get; set; }
                public string? OrganizationCalendarId { get; set; }
                public string? DaysInSession { get; set; }
                public string? FirstInstructionDate { get; set; }
                public string? LastInstructionDate { get; set; }
                public string? MinutesPerDay { get; set; }
                public string? SessionStartTime { get; set; }
                public string? SessionEndTime { get; set; }

            }

            public class OrganizationCalendarEvent
            {
                public int OrganizationCalendarEventId { get; set; }
                public int OrganizationCalendarId { get; set; }
                public string? Name { get; set; }
                public string? EventDate { get; set; }
                public string? RefCalendarEventType { get; set; }
                public string? eventDescription { get; set; }

            }

    public class _Cursos
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<Location>? Location { get; set; }
        public List<LocationAddress>? LocationAddress { get; set; }
        public List<Facility>? Facility { get; set; }
        public List<FacilityLocation>? FacilityLocation { get; set; }
        public List<Classroom>? Classroom { get; set; }
        public List<K12Course>? K12Course { get; set; }
        public List<CourseSectionLocation>? CourseSectionLocation { get; set; }
        public List<Course>? Course { get; set; }
        public List<CourseSectionSchedule>? CourseSectionSchedule { get; set; }
        public List<CourseSection>? CourseSection { get; set; }

    }

            public class Location
            {
                public int LocationId { get; set; }
            }

            public class LocationAddress
            {
                public int LocationId { get; set; }
                public string? StreetNumberAndName { get; set; }
                public string? ApartmentRoomOrSuiteNumber { get; set; }
                public string? BuildingSiteNumber { get; set; }
                public string? City { get; set; }
                public int? RefStateId { get; set; }
                public string? PostalCode { get; set; }
                public string? CountyName { get; set; }
                public int? RefCountyId { get; set; }
                public string? Latitude { get; set; }
                public string? Longitude { get; set; }
                public int? RefERSRuralUrbanContinuumCodeId { get; set; }
                public string? FacilityBlockNumberArea { get; set; }
                public string? FacilityCensusTract { get; set; }

            }

            public class FacilityLocation
            {
                public int FacilityLocationId { get; set; }

                public int FacilityId { get; set; }

                public int LocationId { get; set; }
            }

            public class Classroom
            {
                public int LocationId { get; set; }

                public string? ClassroomIdentifier { get; set; }
            }

            public class K12Course
            {
            }

            public class CourseSectionLocation
            {
                public int CourseSectionLocationId { get; set; }
            }

            public class Facility
            {
                public int FacilityId { get; set; }
            }

            public class Course
            {

            }

            public class CourseSection
            {

            }
            public class CourseSectionSchedule
            {

            }
            public class PIECourseOrganization
            {

            }

    public class _Incidentes
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<Incident>? Incident { get; set; }
        public List<K12StudentDiscipline>? K12StudentDiscipline { get; set; }
        public List<IncidentPerson>? IncidentPerson { get; set; }


    }

            public class Incident
            {
                public int IncidentId { get; set; }
                public string? IncidentIdentifier { get; set; }
                public string? IncidentDate { get; set; }
                public string? IncidentTime { get; set; }
                public int RefIncidentTimeDescriptionCodeId { get; set; }
                public string? IncidentDescription { get; set; }
                public int RefIncidentBehaviorId { get; set; }
                public string? RefIncidentBehaviorSecondaryId { get; set; }
                public int RefIncidentInjuryTypeId { get; set; }
                public int RefWeaponTypeId { get; set; }
                public string? IncidentCost { get; set; }
                public int OrganizationPersonRoleId { get; set; }
                public int IncidentReporterId { get; set; }
                public int RefIncidentReporterTypeId { get; set; }
                public int RefIncidentLocationId { get; set; }
                public string? RefFirearmTypeId { get; set; }
                public Boolean? RelatedToDisabilityManifestationInd { get; set; }
                public Boolean? ReportedToLawEnforcementInd { get; set; }
                public int RefIncidentMultipleOffenseTypeId { get; set; }
                public int RefIncidentPerpetratorInjuryTypeId { get; set; }

            }
            public class K12StudentDiscipline

            {
                public int K12StudentDisciplineId { get; set; }
                public int PersonId { get; set; }
                public int? OrganizationPersonRoleId { get; set; }
                public int RefDisciplineReasonId { get; set; }
                public int RefDisciplinaryActionTakenId { get; set; }
                public string? DisciplinaryActionStartDate { get; set; }
                public string? DisciplinaryActionEndDate { get; set; }
                public string? DurationOfDisciplinaryAction { get; set; }
                public string? RefDisciplineLengthDifferenceReasonId { get; set; }
                public Boolean? FullYearExpulsion { get; set; }
                public Boolean? ShortenedExpulsion { get; set; }
                public string? EducationalServicesAfterRemoval { get; set; }
                public string? RefIdeaInterimRemovalId { get; set; }
                public string? RefIdeaInterimRemovalReasonId { get; set; }
                public Boolean? RelatedToZeroTolerancePolicy { get; set; }
                public int? IncidentId { get; set; }
                public string? IEPPlacementMeetingIndicator { get; set; }
                public int? RefDisciplineMethodFirearmsId { get; set; }
                public int? RefDisciplineMethodOfCwdId { get; set; }
                public int? RefIDEADisciplineMethodFirearmId { get; set; }
            }
            public class IncidentPerson
            {
                public int IncidentId { get; set; }
                public int PersonId { get; set; }
                public string? Identifier { get; set; }
                public int RefIncidentPersonRoleTypeId { get; set; }
                public int RefIncidentPersonTypeId { get; set; }
                public string? DATE { get; set; }
                public string? digitalRandomKey { get; set; }
                public string? fileScanBase64 { get; set; }
            }

    public class _ComunidadEducativa
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public List<OrganizationPersonRole>? OrganizationPersonRole { get; set; }
        public List<RoleAttendanceEvent>? RoleAttendanceEvent { get; set; }


    }

                public class OrganizationPersonRole
                {
                    public int OrganizationPersonRoleId { get; set; }
                    public int OrganizationId { get; set; }
                    public int PersonId { get; set; }
                    public int RoleId { get; set; }
                    public string? EntryDate { get; set; }
                    public string? ExitDate { get; set; }

                }

                public class RoleAttendanceEvent
                {
                    public int RoleAttendanceEventId { get; set; }
                    public int OrganizationPersonRoleId { get; set; }
                    public string? Date { get; set; }
                    public string? RefAttendanceEventTypeId { get; set; }
                    public string? RefAttendanceStatusId { get; set; }
                    public string? RefAbsentAttendanceCategoryId { get; set; }
                    public string? RefPresentAttendanceCategoryId { get; set; }
                    public string? RefLeaveEventTypeId { get; set; }
                    public int? digitalRandomKey { get; set; }
                    public string? fileScanBase64 { get; set; }
                    public string? Observaciones { get; set; }
                }

    public class _Auditoria
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }

    }

    public class _Evaluaciones
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }

    }

    public class _Comunes
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }

    }

}

}
