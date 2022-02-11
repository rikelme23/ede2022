// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using EdeJson2022.Modelo;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Linq;
using Npgsql;
using System.Data;
using static EdeJson2022.Modelo.Modelo;

// conexion 
/*
NpgsqlConnection conn = new NpgsqlConnection("Server=pgsql-cl-dev.postgres.database.azure.com;User Id=lirmi;Password=rF4oA8lJ8fJ5tX2y;Database=lirmi_cl_dev;");
conn.Open();

// Define a query returning a single row result set
NpgsqlCommand command = new NpgsqlCommand("select now();", conn);

// Execute the query and obtain the value of the first column of the first row
var aaa = command.ExecuteScalar();

// query ejemplo
NpgsqlCommand command2 = new NpgsqlCommand(@"select * from profile_establecimientos where id = 9979; ", conn);

var dr = command2.ExecuteReader();

while (dr.Read())
{
    //int establecimiento_id = (int)dr[0];
    int establecimiento_id = Convert.ToInt32(dr[0]);

    Console.Write("{0}\t{1} \n", establecimiento_id, dr[1]);
}

conn.Close();
 */

namespace EdeJson2022
{
    class Program
    {
        // Crea archivo Json
        private static string _path = @"C:\Users\rikelme23\source\repos\PruebaJson\PruebaJson\Ede2022.json";

        static void Main(string[] args)
        {
            var datos = GetDatos();
            SerilizeJsonFile(datos);
            Console.WriteLine(datos);

        }
        public static void SerilizeJsonFile(List<object> datos)
        {
            string datosJson = JsonConvert.SerializeObject(datos);
            Console.WriteLine(datosJson);
            File.WriteAllText(_path, datosJson);
        }

        public static List<Object> GetDatos()
        {
            List<Object> datos = new List<Object>
            {
                //_personas
                new Person { PersonId = 23,
                    FirstName = "Seba",
                    MiddleName = "Ignacio",
                    LastName = "Riquelme",
                    SecondLastName = "Lizama",
                    GenerationCode = 23,
                    Prefix = 1,
                    Birthdate= "2008, 01, 05",
                    RefSexId = 2,
                    HispanicLatinoEthnicity= true,
                    RefUSCitizenshipStatusId= null,
                    RefVisaTypeId= null,
                    RefStateOfResidenceId= null,
                    RefProofOfResidencyTypeId= null,
                    RefHighestEducationLevelCompletedId= null,
                    RefPersonalInformationVerificationId= null,
                    BirthdateVerification= "Y",
                    RefTribalAffiliationId= 5
                 },
                 new PersonIdentifier{
                     PersonIdentifierId = 1,
                    PersonId = 1,
                    Identifier = "9999999-0",
                    RefPersonIdentificationSystemId = 1,
                    RefPersonalInformationVerificationId = 10
                 },
                 new PersonBirthplace{
                    PersonId = 1,
                    City = ".",
                    RefStateId = 1,
                    RefCountryId = 1
                 },
                  new PersonAddress{
                    PersonAddressId = 1,
                    PersonId = 1,
                    RefPersonLocationTypeId = null,
                    StreetNumberAndName = "Santo Domingo 3030",
                    ApartmentRoomOrSuiteNumber = "55-b",
                    City = "Santiago",
                    RefStateId = 2,
                    PostalCode = 5000000,
                    AddressCountyName = "Santiago",
                    RefCountyId = 15,
                    Latitude = null,
                    Longitude = null,
                    RefPersonalInformationVerificationId = null
                 },
                    new PersonEmailAddress{
                    PersonEmailAddressId = 1,
                    PersonId = 1,
                    EmailAddress = 1,
                    RefEmailTypeId = null
                 },
                    new PersonTelephone{
                    PersonTelephoneId = 1,
                    PersonId = 1,
                    TelephoneNumber = "123",
                    PrimaryTelephoneNumberIndicator = null,
                    RefPersonTelephoneNumberTypeId = null
                 },
                    new PersonStatus{
                    PersonStatusId = 1,
                    PersonId = 1,
                    RefPersonStatusTypeId = null,
                    StatusValue = null,
                    StatusStartDate = "2021-12-01",
                    StatusEndDate = "2021-12-01"
                 },
                    new PersonStatus{
                    PersonStatusId = 1,
                    PersonId = 1,
                    RefPersonStatusTypeId = null,
                    StatusValue = null,
                    StatusStartDate = "2021-12-01",
                    StatusEndDate = "2021-12-01"
                 },
                    new PersonLanguage{
                    PersonLanguageId = 1,
                    PersonId = 1,
                    RefLanguageId = null,
                    RefLanguageUseTypeId = null
                 },
                    new PersonDisability{
                    PersonId = 1,
                    PrimaryDisabilityTypeId = 1,
                    DisabilityStatus = null,
                    RefAccommodationsNeededTypeId = null,
                    RefDisabilityConditionTypeId = 1,
                    RefDisabilityDeterminationSourceTypeId = 1,
                    RefDisabilityConditionStatusCodeId = null
                 },
                    new PersonRelationship{
                    PersonRelationshipId = 1,
                    PersonId = 2,
                    RelatedPersonId = 1,
                    RefPersonRelationshipId = 7,
                    CustodialRelationshipIndicator = "true",
                    EmergencyContactInd = "true",
                    ContactPriorityNumber = "985402444",
                    ContactRestrictions = "Preguntar por Maria",
                    LivesWithIndicator = "true",
                    PrimaryContactIndicator = "true",
                 },
                    new PersonDegreeOrCertificate{
                    PersonDegreeOrCertificateId = 1,
                    PersonId = 1,
                    DegreeOrCertificateTitleOrSubject = null,
                    RefDegreeOrCertificateTypeId = 15,
                    AwardDate = "0000-00-00",
                    NameOfInstitution = "nombre prueba",
                    RefHigherEducationInstitutionAccreditationStatusId = 6,
                    RefEducationVerificationMethodId = 5,
                 }, 
                 //_Organizacion
                    new Organization{
                    OrganizationId = 1,
                    Name = "Colegio Cristiano Belén",
                    RefOrganizationTypeId = 10,
                    ShortName = "RBD10492",
                    RegionGeoJSON = null
                 },
                    new OrganizationLocation{
                    OrganizationLocationId = 1,
                    OrganizationId = 2,
                    LocationId = 1,
                    RefOrganizationLocationTypeId = null
                 },
                    new OrganizationTelephone{
                    OrganizationTelephoneId = 1,
                    OrganizationId = 2,
                    TelephoneNumber = "12345678",
                    PrimaryTelephoneNumberIndicator = null,
                    RefInstitutionTelephoneTypeId = null
                 },
                    new OrganizationEmail{
                    OrganizationEmailId = 1,
                    OrganizationId = 2,
                    ElectronicMailAddress = "cristianobelen@test.com",
                    RefEmailTypeId = null
                 },
                    new OrganizationWebsite{
                    OrganizationId = 1,
                    Website = "cristianobelen.com"
                 },
                    new RefOrganizationRelationship{
                    RefOrganizationRelationshipId = 1,
                    Description = "some description",
                    Code = "some code",
                    Definition = "some definition",
                    RefJurisdictionId = 1,
                    SortOrder = 1
                 },
                    new OrganizationRelationship{
                    OrganizationRelationshipId = 1,
                    Parent_OrganizationId = 1,
                    OrganizationId = 2,
                    RefOrganizationRelationshipId = 3
                 },
                 //_Establecimientos
                    new K12School{
                    OrganizationId = 2,
                    RefSchoolTypeId = 7,
                    RefSchoolLevelId = null,
                    RefAdministrativeFundingControlId = 3,
                    CharterSchoolIndicator = true,
                    RefCharterSchoolTypeId = 1,
                    RefIncreasedLearningTimeTypeId = 7,
                    RefStatePovertyDesignationId = 11,
                    CharterSchoolApprovalYear = 2000,
                    RefCharterSchoolApprovalAgencyTypeId = null,
                    AccreditationAgencyName = null,
                    CharterSchoolOpenEnrollmentIndicator = null,
                    CharterSchoolContractApprovalDate = null,
                    CharterSchoolContractIdNumber = null,
                    CharterSchoolContractRenewalDate = null,
                    RefCharterSchoolManagementOrganizationTypeId = 3
                 },
                    new K12SchoolStatus{
                    OrganizationId = 2,
                    RefMagnetSpecialProgramId = null,
                    RefAlternativeSchoolFocusId = null,
                    RefInternetAccessId = 1,
                    RefRestructuringActionId = null,
                    RefTitleISchoolStatusId = null,
                    ConsolidatedMepFundsStatus = null,
                    RefNationalSchoolLunchProgramStatusId = null,
                    RefVirtualSchoolStatusId = 3
                 },
                    new K12SchoolGradeOffered{
                    K12SchoolGradeOfferedId = 1,
                    OrganizationId = 2,
                    RefGradeLevelId = 375
                 },
                //_Calendarios
                    new OrganizationCalendar{
                    OrganizationCalendarId = 1,
                    OrganizationId = 2,
                    CalendarCode = "3232323abc",
                    CalendarDescription = "Calendario del establecimiento",
                    CalendarYear = "2020"
                 },
                    new OrganizationCalendarCrisis{
                    OrganizationCalendarCrisisId = 1,
                    OrganizationId = 2,
                    Code = "COVID-19-School-Fase1",
                    Name = "Cuarentena Fase 1",
                    StartDate = "2020-03-09",
                    EndDate = "2020-03-09",
                    Type = "Pandemia COVID-19",
                    CrisisDescription = "Pandemia COVID-19 obliga a los establecimientos a cerrar para evitar contagios masivos y cuidar a la cuidadanía. Año escolar termina y pandemia continúa.",
                    CrisisEndDate = null
                 },
                    new OrganizationCalendarSession{
                    OrganizationCalendarSessionId = 1,
                    Designator = "2020-03",
                    BeginDate = null,
                    EndDate = null,
                    RefSessionTypeId = null,
                    InstructionalMinutes = null,
                    Code = null,
                    Description = null,
                    MarkingTermIndicator = null,
                    SchedulingTermIndicator = null,
                    AttendanceTermIndicator = null,
                    OrganizationCalendarId = null,
                    DaysInSession = null,
                    FirstInstructionDate = null,
                    LastInstructionDate = null,
                    MinutesPerDay = null,
                    SessionStartTime = null,
                    SessionEndTime = null
                 },
                    new OrganizationCalendarEvent{
                    OrganizationCalendarEventId = 1,
                    OrganizationCalendarId = 1,
                    Name = "Manifestaciones",
                    EventDate = "2020-09-11",
                    RefCalendarEventType = "6",
                    eventDescription = "Retiro anticipado para evitar manifestaciones"
                 },
                 //_Cursos
                    new Location{
                    LocationId = 1
                 },
                    new LocationAddress{
                    LocationId = 1,
                    StreetNumberAndName = "Calle camino angosto 0777",
                    ApartmentRoomOrSuiteNumber = null,
                    BuildingSiteNumber = null,
                    City = null,
                    RefStateId = null,
                    PostalCode = null,
                    CountyName = null,
                    RefCountyId = null,
                    Latitude = null,
                    Longitude = null,
                    RefERSRuralUrbanContinuumCodeId = null,
                    FacilityBlockNumberArea = null,
                    FacilityCensusTract = null
                 },
                    new LocationAddress{
                    LocationId = 1,
                    StreetNumberAndName = "Calle camino angosto 0777",
                    ApartmentRoomOrSuiteNumber = null,
                    BuildingSiteNumber = null,
                    City = null,
                    RefStateId = null,
                    PostalCode = null,
                    CountyName = null,
                    RefCountyId = null,
                    Latitude = null,
                    Longitude = null,
                    RefERSRuralUrbanContinuumCodeId = null,
                    FacilityBlockNumberArea = null,
                    FacilityCensusTract = null
                 },
                    new FacilityLocation{
                    FacilityLocationId = 1,
                    FacilityId = 1,
                    LocationId = 1
                 },
                    new Classroom{
                    LocationId = 1,
                    ClassroomIdentifier ="some classroom identifier"
                 },
                    new CourseSectionLocation{
                    CourseSectionLocationId = 1
                 },
                    new Facility{
                    FacilityId = 1
                 },
                //_Incidentes
                 new Incident{
                    IncidentId = 1,
                    IncidentIdentifier = "323232abc",
                    IncidentDate = "2020-03-02",
                    IncidentTime = "9:15:00",
                    RefIncidentTimeDescriptionCodeId = 3,
                    IncidentDescription = "Los estudiantes se ponen a pelear en la sala de clases, por recillas anteriores ocurridas en el lugar donde viven.",
                    RefIncidentBehaviorId = 8,
                    RefIncidentBehaviorSecondaryId = null,
                    RefIncidentInjuryTypeId = 2,
                    RefWeaponTypeId = 14,
                    IncidentCost = "No aplica para el caso informado. Sin costos asociados.",
                    OrganizationPersonRoleId = 2,
                    IncidentReporterId = 3,
                    RefIncidentReporterTypeId = 7,
                    RefIncidentLocationId = 4,
                    RefFirearmTypeId = null,
                    RelatedToDisabilityManifestationInd = false,
                    ReportedToLawEnforcementInd = false,
                    RefIncidentMultipleOffenseTypeId = 1,
                    RefIncidentPerpetratorInjuryTypeId = 3
                 },

                 new K12StudentDiscipline{
                    K12StudentDisciplineId = 1,
                    PersonId = 2,
                    OrganizationPersonRoleId =2,
                    RefDisciplineReasonId = 4,
                    RefDisciplinaryActionTakenId = 7,
                    DisciplinaryActionStartDate = "2020-03-02",
                    DisciplinaryActionEndDate = "2020-03-02",
                    DurationOfDisciplinaryAction = "1",
                    RefDisciplineLengthDifferenceReasonId = null,
                    FullYearExpulsion = false,
                    ShortenedExpulsion = false,
                    EducationalServicesAfterRemoval = null,
                    RefIdeaInterimRemovalId = null,
                    RefIdeaInterimRemovalReasonId = null,
                    RelatedToZeroTolerancePolicy = false,
                    IncidentId = 1,
                    IEPPlacementMeetingIndicator = null,
                    RefDisciplineMethodFirearmsId = null,
                    RefDisciplineMethodOfCwdId = null,
                    RefIDEADisciplineMethodFirearmId = null
                 },

                 new IncidentPerson{
                    IncidentId = 1,
                    PersonId = 1,
                    Identifier = null,
                    RefIncidentPersonRoleTypeId = 1,
                    RefIncidentPersonTypeId = 45,
                    DATE = "2020-03-02T09:15:00-03:00",
                    digitalRandomKey = "1",
                    fileScanBase64 = "1"
                 },
                 // _ComunidadEducativa
                 new OrganizationPersonRole{
                    OrganizationPersonRoleId = 1,
                    OrganizationId = 1,
                    PersonId = 2,
                    RoleId = 5,
                    EntryDate = "2020-02-21T08:00:00-03:00",
                    ExitDate = "2020-03-02T09:15:00-03:00"
                 },
                 new RoleAttendanceEvent{
                    RoleAttendanceEventId = 1,
                    OrganizationPersonRoleId = 1,
                    Date = "2020-02-21T08:00:00-03:00",
                    RefAttendanceEventTypeId = null,
                    RefAttendanceStatusId = null,
                    RefAbsentAttendanceCategoryId = null,
                    RefPresentAttendanceCategoryId = null,
                    RefLeaveEventTypeId = null,
                    digitalRandomKey = 789546,
                    fileScanBase64 = null,
                    Observaciones = null
                 },
                 //_Auditoria
                 //_Evaluaciones
                 //_Comunes

            };

            return datos;
        } 


    }
}