#-------config variables--------------------------------------------------------------------------------------------------
$BaseName = "AuditPlanTemplatesActivitesAddOrUpdate"
$BasedirctoryName="Audit"
#---DTO---
$DTOBasedirctoryName="Audit"
$EntryDTOFileName=""

#--------------------------------------------------------------APLICATION START---------------------------------------------
$projectFile= "C:\Users\jafar\Source\Repos\BCMLogic core\BcmWebExtension\Model\Model.csproj"
$tmplateBasePath = "D:\GitProject\CSharpCodeGenerator\PowerShellTest\ccgTemplate\"
$baseNameSpace ="Model."
#------------------------------------------------------------------------------------------------------------------------
$CommandsInterface_tempName="CommandsInterfaceTmpl"
$CommandsImplementation_tempName="CommandsImplementationTmpl"
$entryDto_tempName="DtoTempl"
##################################################Entry DTO MODEL-----------------------------------------------------------------
$entryDto_dirctoryName = $DTOBasedirctoryName
$entryDto_fileDirectoryPath="\DTO\Models\"+ $entryDto_dirctoryName +"\"
$entryDto_fileName=$EntryDTOFileName
# ----------argument----------
$entryDto_ns = $baseNameSpace +"DTO.Models."+$BasedirctoryName
$entryDto_cl =$entryDto_fileName

##################################################__Commands Interfaces__#################################################
$CommandsInterface_dirctoryName =$BasedirctoryName
$CommandsInterface_fileDirectoryPath="\Commands\Interfaces\"+ $CommandsInterface_dirctoryName +"\"
$CommandsInterface_fileName="I"+$BaseName+"Command"
# ----------argument-----------
$CommandsInterface_ns = $baseNameSpace +"Commands.Interfaces."+$CommandsInterface_dirctoryName 
$CommandsInterface_in =$CommandsInterface_fileName
$CommandsInterface_entryDto =$entryDto_ns+"."+$entryDto_fileName

####################################################_Commands Implementation_#################################################
$CommandsImplementation_dirctoryName =$BasedirctoryName
$CommandsImplementation_fileDirectoryPath="\Commands\Implementation\"+ $CommandsImplementation_dirctoryName +"\"
$CommandsImplementation_fileName=""+$BaseName+"Command"
# ----------argument-----------
$CommandsImplementation_ns = $baseNameSpace +"Commands.Implementation."+$CommandsImplementation_dirctoryName 
$CommandsImplementation_cl =$CommandsImplementation_fileName
$CommandsImplementation_in =$CommandsInterface_ns+"."+ $CommandsInterface_fileName
#using Model.DTO.Models.Shared;
$CommandsImplementation_entryDto =$CommandsInterface_entryDto

############################################################__ARGUMENTS__######################################################
$CommandsInterface_argument="ns:" + $CommandsInterface_ns +
  ",in: " + $CommandsInterface_in                      +
  ",entrydto: " + $CommandsInterface_entryDto 
# -----------------------------
$CommandsImplementation_argument="ns:" + $CommandsImplementation_ns+
   ",cl:" + $CommandsImplementation_cl                          +
   ",in:" + $CommandsImplementation_in                          +
   ",entrydto:" + $CommandsImplementation_entryDto 
# -----------------------------
$entryDto_argument="ns:" + $entryDto_ns + 
 ",cl:" + $entryDto_cl

###########################################################_Prepeare Varible_#################################################
$CommandsInterface_fileFullName = $CommandsInterface_fileDirectoryPath + $CommandsInterface_fileName+".cs"
$CommandsInterface_templateFileName= $tmplateBasePath + $CommandsInterface_tempName +".txt"
#---------------
$CommandsImplementation_fileFullName = $CommandsImplementation_fileDirectoryPath + $CommandsImplementation_fileName+".cs"
$CommandsImplementation_templateFileName= $tmplateBasePath + $CommandsImplementation_tempName +".txt"
#---------------
$entryDto_fileFullName = $entryDto_fileDirectoryPath + $entryDto_fileName+".cs"
$entryDto_templateFileName= $tmplateBasePath + $entryDto_tempName +".txt"

################################################################_EXECUTION_####################################################
#D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $entrydto_filefullname  -t $entrydto_templatefilename -p $projectfile -a $entrydto_argument
D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $CommandsInterface_filefullname  -t $Commandsinterface_templatefilename -p $projectfile -a $Commandsinterface_argument
D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $Commandsimplementation_filefullname  -t $Commandsimplementation_templatefilename -p $projectfile -a $Commandsimplementation_argument

