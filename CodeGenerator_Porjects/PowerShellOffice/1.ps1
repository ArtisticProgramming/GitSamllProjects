param ($GetActionData,$IGetActionQuery, $ActionQueryParam )

#***************  Global paramters  *********************
$projectFile= "C:\temp\TempFolder\"
$tmplateBasePath = "C:\temp\Templates\"
$GetActionData_tempName="GetActionData"
$currentDateTime=Get-Date -Format "yyyy-MM-dd_HH-mm-ss"
$directoryPath="$currentDateTime" + "_List" 

#---------------------------------------------------------------------------------------------
#--------Check User Paramters----------
if([string]::IsNullOrEmpty($GetActionData))
{
  $GetActionData = Read-Host -Prompt 'Input your GetActionData [Get****Data]'
}

if([string]::IsNullOrEmpty($IGetActionQuery))
{
 $IGetActionQuery = Read-Host -Prompt 'Input your IGetActionQuery [IGet***Query]'
}

if([string]::IsNullOrEmpty($ActionQueryParam))
{
 $ActionQueryParam = Read-Host -Prompt 'Input your ActionQueryParam [***QueryParamDto]'
}

#write-host "GetActionData:" $GetActionData 
#write-host "IGetActionQuery:" $IGetActionQuery 
#write-host "ActionQueryParam:" $ActionQueryParam

write-host "--------Generating Get***Data Action for Data Table List -----------"
#############################################__ARGUMENTS__####################################################
[array]$paramArray = ("GetActionData:" + $GetActionData) ,("IGetActionQuery:" + $IGetActionQuery) ,("ActionQueryParam:"+$ActionQueryParam)
[string]$GetActionDataArguments = $null
$GetActionDataArguments = $paramArray -join ","

###########################################_Prepeare Varible_#################################################
$EntryGetActionData_fileFullName = $tmplateBasePath + $GetActionData_tempName+".txt"
$GetActionData_fileFullName = $directoryPath+"\"+ $GetActionData_tempName+".cs"

################################################################_EXECUTION_###################################
write-host "ccg.exe" "gf" " -f " $GetActionData_fileFullName  " -t " $EntryGetActionData_fileFullName " -p " $projectfile " -a " $GetActionDataArguments

ccg.exe gf -f $GetActionData_fileFullName  -t $EntryGetActionData_fileFullName -p $projectfile -a $GetActionDataArguments

type ($projectFile + $GetActionData_fileFullName)

###--Open Folder---###
Invoke-Item ($projectFile + $directoryPath)



#[System.Windows.MessageBox]::Show('Success')


#$msgBoxInput =  [System.Windows.MessageBox]::Show('Would you like to play a game?','Game  input','YesNoCancel','Info')
# switch  ($msgBoxInput) { 'Yes' {  Do something }'No' { }}
 

#[System.Reflection.Assembly]::LoadWithPartialName('Microsoft.VisualBasic') | Out-Null
#$computer = [Microsoft.VisualBasic.Interaction]::InputBox("Enter a computer name", "Computer", "$env:computername")

write-host "----------------------------------------"

#--------Check User Paramters----------
# if([string]::IsNullOrEmpty($GetActionData))
# {
#   $GetActionData = Read-Host -Prompt 'Input your GetActionData '
# }

# if([string]::IsNullOrEmpty($IGetActionQuery))
# {
#  $IGetActionQuery = Read-Host -Prompt 'Input your IGetActionQuery '
# }

# if([string]::IsNullOrEmpty($ActionQueryParam))
# {
#  $ActionQueryParam = Read-Host -Prompt 'Input your ActionQueryParam '
# }

