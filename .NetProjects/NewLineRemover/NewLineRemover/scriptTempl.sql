-- START: OPEN TRANSACTION 
BEGIN TRANSACTION
BEGIN TRY
-- START: SCRIPT HEADER-- START: SCRIPT HEADER
DECLARE @dbversion INT = #$ScriptNumber;  -- UPDATE DB VERSION
DECLARE @clientId NVARCHAR(10) = NULL;
DECLARE @result INT;
DECLARE @version NVARCHAR(10) = '3.67'; -- Version of application
DECLARE @TaskIdVSTS INT = 0; -- Number of VSTS Task
DECLARE @TaskDescription NVARCHAR(MAX) = N''; -- Description of task
DECLARE @ScriptName NVARCHAR(255) = N''; -- Name of script 
DECLARE @ScriptDescription NVARCHAR(MAX) = N''; -- Description of script
DECLARE @Session VARCHAR(50)
SET @Session = '1-'+ CAST(GETDATE()AS VARCHAR(50))

EXEC @result = StartScript_proc @dbversion, @clientId, @version;

IF (@result <> 0)

RETURN;
-- END: SCRIPT HEADER

SET QUOTED_IDENTIFIER OFF

#$Body

SET QUOTED_IDENTIFIER ON
-- START: SCRIPT FOOTER

EXEC EndScript_proc @dbversion,@version;

INSERT INTO dbo.DbVersionApp (TaskIdVSTS, TaskDescription, VersionDB, VersionApp, ScriptName, ScriptDescription, ClientId, [EndDate], UpdaterName, [FullResult])
VALUES (@TaskIdVSTS, @TaskDescription, @dbversion, @version, @ScriptName, @ScriptDescription, @clientId, GETDATE(), HOST_NAME(), 'Ended script no ' + CAST(@DbVersion AS NVARCHAR));

-- END: SCRIPT FOOTER
END TRY

-- START: CATCHING ANY ERRORS
BEGIN CATCH
ROLLBACK TRANSACTION
PRINT 'ERROR: ' + ERROR_MESSAGE();
INSERT INTO [dbo].[MessageLog] ([TypeId],[Source],[Session],[Message],[Timestamp]) VALUES (1, 'UPGRADE: SCRIPT No: '+ CAST(@dbversion AS VARCHAR(5)) +' FAILED', @Session, ERROR_MESSAGE(), GETDATE())
END CATCH
-- END: CATCHING ANY ERRORS

IF @@TRANCOUNT>0

COMMIT TRANSACTION
-- END: CLOSE TRANSACTION 


