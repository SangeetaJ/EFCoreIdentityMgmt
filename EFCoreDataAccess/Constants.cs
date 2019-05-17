/*****************************************************************************************************************************  
**� 2019 Datamatics Robotics Software Limited, Inc, All Rights Reserved 
* Datamatics Robotics Software Limited Group, Inc. (Encounter Data Manager) Proprietary Product Software *
* Not to be modified by customer *  
* Not Customer maintainable *
** AUTHOR:			Datamatics Robotics Software Limited.   
** CREATED ON:		2/13/2019
** CREATED BY:		TruBot
** Description:   
** 
** Revision History:
**
** Date     Author      Description   
*******************************************************************************************************************************/

using System;

namespace EFCore.DataAccess
{
    public static class Constants
    {
        public const string BotFolderName = "Bots";
        public const string JobFolderName = "Jobs";
        public const string uzTempFolder = "Temp/Unzip";
        public const string JobTempFolder = "Temp/Job";
        public const string ErrorLogFolder = "ErrorLog";
        public const string BotLogFolder = "BotLogs";

        public const string ActiveStatus = "Active";
        public const string InActiveStatus = "InActive";
        public const string AdministratorRole = "administrator";
        public const string GroupAdministratorRole = "group administrator";

        public const string RoleTypeAdministrator = "Administrator";
        public const string RoleTypeGroupAdministrator = "GroupAdministrator";

        public const string ExecutorRole = "executor";
        public const string BotParameterFileName = "Variables.xml";

        public const string SelectBotStations = "Please select bot stations.";
        public const string SelectBots = "Please select bots.";
        public const string SelectProcesses = "Please select processes.";

        public const string InvalidScheduleFrequency = "Invalid Schedule Frequency.";

        public const string BCC = "umesh.pandey@datamatics.com";

        #region Account Controller Messages
        public const string UserExists = "User already exists";
        public const string UserNotExists = "User does not exist.";
        public const string UserSecurityStamp = "SAIPPPUUZ7LRLVRJEV5TGSOHYVTXM6G5";
        public const string UserActiveKey = "5d51c86f-6d03-4cc6-aedd-36df404d8a67";
        public const string UserInactiveKey = "dad52cc8-371c-4b12-a56d-b801d1e99061";
        public const string AccountInactiveOrExpired = "Your account is Inactive or Expired, Please contact system administrator";
        public const string AccountNotAccessible = "You do not have access to this system";
        public const string UsernameOrPasswordIncorrect = "The user name or password is incorrect. Please try again.";
        public const string LdapServerUnavailable = "There was a system error. Please contact system administrator -LDAP Server is unavailable";
        public const string NoResultsFound = "No Results Found";
        public const string JwtTokenFormatIncorrect = "The token doesn't seem to be in a proper JWT format.";
        public const string RoleInactiveOrExpired = "Your account role is Inactive or Expired, Please contact system administrator";
        public const string LicenseExpired = "Your license is expired.";
        public const string LicenseFileNotFound = "License file not found.";
        public const string HardwareNotMatched = "Not valid machine for license.";
        public const string LicenseSvcNotFound = "License service is missing.";
        public const string LicenseSvcNotRunning = "License service is not running.";
        #endregion

        #region Common Messages
        public const string Successfull = "Successfull";
        public const string DataUpdated = "Data sucessfully updated.";
        public const string Admin = "Admin";
        public const string System = "SYSTEM";
        public const string SuccessfullySaved = "Successfully saved";
        public const string SystemError = "This action can't be completed. Please try again or contact the system administrator.";
        public const string DependancyValidation = "This action can't be completed because of linked resources. Delink the resources and try again.";
        public const string SavedSuccessfully = "Saved Successfully";
        public const string IdNotExist = "Id does not exist.";
        public const string DuplicateKeys = "Please remove duplicate parameter.";
        public const string FileNotExist = "File does not exists.";
        public const string ProvideParamValues = "Please provide value for parameters.";
        public const string ProvideParams = "Please provide parameters.";
        #endregion

        #region Notify Messages
        public const string NotifySendBotStatusMessage = "SendBotStatusMessage";
        public const string NotifyUpdateUserChartData = "UpdateUserChartData";
        public const string NotifyUpdateBotStationChartData = "UpdateBotStationChartData";
        public const string NotifyUpdateBotChartData = "UpdateBotChartData";
        public const string NotifyUpdateJobChartData = "UpdateJobChartData";
        public const string NotifyUpdateJobDashboardData = "UpdateJobDashboardData";
        public const string NotifyUpdateJobCompleted = "UpdateJobCompleted";
        public const string NotifyUpdateNotificationData = "UpdateNotificationData";
        public const string NotifyUpdateJobCountData = "UpdateJobCountData";
        public const string NotifyDeletePushData = "DeletePushData";
        public const string NotifySavePushData = "SavePushData";


        #endregion

        #region Bot Log Controller Messages
        public const string JobExecutionStatusCompleted = "Completed";
        #endregion

        #region Bot Station Controller Messages
        public const string RegExIPAddress = "^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
        public const string FillRequiredFields = "Please fill all required fields.";
        public const string UnableToSaveRecord = "Unable to save the record";
        public const string UnableToSaveRecordException = "Unable to save the record: ";
        public const string BotstationNameExists = "Botstation name already exists";
        public const string BotstationIpAddressExists = "Botstation Ip Address already exists";
        public const string BotstationMacAddressExists = "Botstation Mac Address already exists";
        public const string InvalidIPAddress = "Invalid IP address";
        public const string BotstationIpAddressOffline = "Botstation with IP {0} is offline";
        public const string LocalhostIPAddress = "127.0.0.1";
        public const string AccessDeniedCheckCredentials = "Access is denied. Please check the credentials.";
        public const string BotstationUnableToConnect = "Unable to connect to the bot station";
        public const string BotstationNotExists = "Bot station not exists";
        public const string BotstationInvalidCredentials = "Please select valid credentials";
        public const string BotstationCredentialsExpired = "Credential is InActive. Please select active Credential.";
        public const string OperatingSystemQuery = "SELECT * FROM Win32_OperatingSystem";
        public const string ProcessorQuery = "SELECT * FROM Win32_Processor";
        public const string PhysicalMemoryQuery = "SELECT * FROM Win32_PhysicalMemory";
        public const string ComputerSystemQuery = "SELECT * FROM  Win32_ComputerSystem";
        public const string NetworkAdapterConfigurationQuery = "SELECT * FROM  Win32_NetworkAdapterConfiguration  where IPEnabled=true";
        public const string PowerShellUrl = "http://schemas.microsoft.com/powershell/Microsoft.PowerShell";
        #endregion

        #region Credential Manager Controller Messages
        public const string NameBlank = "Name cannot be blank.";
        public const string CredentialManagerNameExist = "Another Credential Manager already exists with this name.";
        public const string CredentialParameterMandatory = "Specify at least one Credential Parameter.";
        public const string ParameterKeyBlank = "Parameter Key cannot be blank.";
        public const string ParameterKeyDuplicate = "Parameter Keys cannot be duplicate.";
        public const string ParameterValueBlank = "Parameter Value cannot be blank.";
        public const string NoCredentialManagerForId = "Credential Manager does not exist for the specified Id {0}.";
        public const string CredentialParameterIdNotOfCredentialManager = "Credential Parameter Id {0} (Key: {1}) does not belong to the current Credential Manager.";
        public const string CredentialParameterPassword = "password";
        public const string EndDateGreaterThanStartDate = "End date must be greater than start date.";
        public const string CredentialGroupMandatory = "Please select group.";
        #endregion

        #region Group Controller Messages
        public const string DataInserted = "Data sucessfully Inserted.";
        #endregion

        #region Job Controller Messages
        public const string JobStatusIncomplete = "Incomplete";
        public const string JobStatusActive = "Active";
        public const string JobStatusInactive = "Inactive";
        public const string NoJobWithId = "No Such Job exists with Id = {0}";
        public const string JobAlreadyExists = "Job Already Exists";
        public const string NoBotWithId = "Bot does not exist with bot id: {0}.";
        public const string ZipFileExtension = ".zip";
        public const string BotPropertiesFileName = "bot.properties";
        public const string BotPackageFileNotExists = "Bot package file does not exists.";
        public const string BotStoppedSuccess = "Bot stopped successfully";
        public const string UnableToStopBot = "Unable to stop the bot";
        public const string InvalidJob = "Invalid Job";
        public const string UnableToStopBotException = "Unable to stop the bot : ";
        public const string InactiveProcessAtBotUpdate = "Process is InActive. Please select active process to add Bot.";
        public const string ExecutionStatusInProgress = "In Progress";
        public const string ExecutionStatusFailed = "Failed";
        public const string NotifyActionTransferringBot = "Transferring Bot files";
        public const string JobRunSuccessfully = "Run successfully";
        public const string UnableToRunBot = "Unable to run the Bot.";
        public const string CredentialParametersNotFound = "Credential parameters not found.";
        public const string UnableToCopyBot = "Unable to move the bot to the bot station.";
        public const string BotStationOffline = "BotStation is offline";
        public const string JobInactiveOrExpired = "Please Check Job is active or job period expired ? ";
        public const string BotStationExpiredOrInActive = "Please check Bot Station is in-active or Bot Station expired. ";
        public const string ProcessExpiredOrInActive = "Please check Process is in-active or expired. ";
        public const string UnableToRunBotException = "Unable to run the bot : ";
        public const string InputRequired = "Input required.";
        public const string JobNotExistWithId = "Job does not exist with job id: {0}.";
        public const string JobExecutionLogException = "Unable to save: ";
        public const string JobExecutionLogSaved = "Successfully saved.";
        public const string BotFileNameTemp = "FileNameTemp";
        public const string NotifyActionExtractingBotZip = "Extracting bot zip file";
        public const string NotifyActionExecutingBot = "Executing bot zip file";
        public const string NotifyActionBotStarted = "Bot execution started";
        public const string JobNotFound = "No such job exists";
        public const string VmIdentifier = ":";

        #endregion

        #region Dashboard


        public const string EntityTypeJob = "JOB";
        public const string EntityTypeBot = "BOT";
        public const string EntityTypeBotStation = "BOT-STATION";
        public const string EntityTypeUser = "USER";

        public const string ProcedureCallForCharts = "proc_Get_DashBoard_Data @P_ReportType,@P_From_Date, @P_To_Date, @ChartType, @Filter, @User_code";
        public const string ProcedureCallForUserActivity = "PROC_UPDATEONLINEOFFLINE_DATA @P_Date";

        public const string ProcedureCallForJobDetail = "PROC_GET_JOB_DETAIL @P_Notification_Id";

        public const string ParameterFromDate = "@P_From_Date";
        public const string ParameterToDate = "@P_To_Date";
        public const string ParameterReportType = "@P_ReportType";
        public const string ParameterFilter = "@Filter";
        public const string ParameterChartType = "@ChartType";
        public const string ParameterUserCode = "@User_code";
        public const string ParameterDate = "@P_Date";
        public const string ParameterNotificationId = "@P_Notification_Id";
        public const string Offline = "Offline";
        public const string Idle = "Idle";

        public const int DiffDataByHour = -3;

        public const string InitiatedNotification = "has been initiated successfully";
        public const string CompletedNotification = "has been completed successfully";
        public const string ExecutedNotification = "has been executed successfully";

        #endregion

        #region Bot
        public const string InvalidBotSupplied = "Invalid Bot supplied";
        public const string BotProd = ".Prod";
        #endregion

        #region SMSTemplateParameters
        public const string UserName = "#UserName#";
        public const string ProcessName = "#ProcessName#";
        public const string BotStationName = "#BotStationName#";
        public const string JobId = "#JobId#";
        public const string ProcessExecutionTime = "#ProcessExecutionTime#";
        public const string MobileNumber = "#MobileNumber#";
        public const string AddedDate = "#AddedDate#";
        public const string AddedTime = "#AddedTime#";
        public const string FromDate = "#FromDate#";
        public const string ToDate = "#FromDate#";
        public const string UpdatedDate = "#UpdatedDate#";
        public const string UpdatedTime = "#UpdatedTime#";
        public const string BotName = "#BotName#";
        public const string JobName = "#JobName#";
        public const string Error = "#Error#";

        #endregion

        #region SMSTemplateTypes
        public const string ProcessAddedSMS = "ProcessAdded";
        public const string BotStationOfflineSMS = "BotStationOffline";
        public const string BotStationOnlineSMS = "BotStationOnline";
        public const string JobFailedSMS = "JobFailed";
        public const string JobInProgressSMS = "JobInProgress";
        public const string JobPausedSMS = "JobPaused";
        public const string JobSuccessfulSMS = "JobSuccessful";
        public const string JobScheduledSMS = "JobScheduled";
        public const string ProcessDeactivatedSMS = "ProcessDeactivated";
        public const string BotStationDeactivatedSMS = "BotStationDeactivated";
        public const string BotStationUpdatedSMS = "BotStationUpdated";

        public const string HealthCheckInactivationFailed = "TruBot Modules Inactivation Failed";
        public const string HealthCheckParamDEPENDENCY = "#DEPENDENCY#";

        public const string QueueNameBlank = "Queue name cannot be blank";
        #endregion

        #region TruOCR
        public const string UnableToInvokeTruOcr = "Unable to invoke TruOCR";
        #endregion

        #region DefaultSMS Templates
        public const string ProcessAddedSMSTemplate = "Process #ProcessName# is added by #UserName# on #AddedDate# at #AddedTime#";
        public const string BotStationOfflineSMSTemplate = "Station #BotStationName# is offline";
        public const string BotStationOnlineSMSTemplate = "Station #BotStationName# is added successfully by #UserName# and available for Bot execution.";
        public const string JobFailedSMSTemplate = "Execution of Job ID #JobId# failed on station #BotStationName# at #ProcessExecutionTime#";
        public const string ProcessDeactivatedSMSTemplate = "Process #ProcessName# is deactivated by #UserName# on #UpdatedDate# at #UpdatedTime#.";
        public const string BotStationDeactivatedSMSTemplate = "Bot station #BotStationName# is deactivated by #UserName# on #UpdatedDate# at #UpdatedTime#.";
        public const string BotStationUpdatedSMSTemplate = "Ecosystem for bot #BotName# is modified by #UserName# on #UpdatedDate# at #UpdatedTime#.";
        public const string JobInProgressSMSTemplate = "Execution of Job ID #JobId# is in progress on station #BotStationName# at #ProcessExecutionTime#";
        public const string JobPausedSMSTemplate = "Execution of Job ID #JobId# is paused on station #BotStationName# at #ProcessExecutionTime#";
        public const string JobSuccessfulSMSTemplate = "Execution of Job ID #JobId# is successful on station #BotStationName# at #ProcessExecutionTime#";
        public const string JobScheduledSMSTemplate = "Execution of Job ID #JobId# is scheduled on station #BotStationName# at #ProcessExecutionTime#";
        #endregion

        public const string DefaultGroup = "AdminGroup";
        public const string DefaultEmailAddress = "admin@datamatics.com";

        public static string GetExceptionMessage(Exception ex, string prefix)
        {
            return prefix + ex.Message + (ex.InnerException != null ? " Inner Exception: " + ex.InnerException : string.Empty) + ex.StackTrace ?? "";
        }
    }
}
