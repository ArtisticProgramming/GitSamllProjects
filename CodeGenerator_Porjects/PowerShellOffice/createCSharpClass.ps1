#--------------------------------------------------APLICATION START---------------------------------------------
$projectFile= "C:\Users\jafar\Source\Repos\BCMLogic core\BcmWebExtension\Model\Model.csproj"
$tmplateBasePath = "D:\GitProject\CSharpCodeGenerator\PowerShellTest\ccgTemplate\"

#-------config variables------------------
    $BasedirctoryName = "Vendor"
    $DTOBasedirctoryName = "Vendor"                                   # Folder
    $ReturnDTOFileName   = "l888999"+"Dto"                   # File Return Model

# -------------------------------------------Rerturn DTO MODEL----------------------------------------------------------
$returnDto_tempName="DtoTempl"
$returnDto_fileDirectoryPath="\DTO\Models\"+ $DTOBasedirctoryName +"\"
$returnDto_templateFileName= $tmplateBasePath + $returnDto_tempName +".txt"
$returnDto_fileFullName = $returnDto_fileDirectoryPath + $ReturnDTOFileName+".cs"

#--------argument-----------
$returnDto_ns = "Model.DTO.Models."+$BasedirctoryName
$returnDto_cl =$ReturnDTOFileName
$returnDto_argument="ns:" + $returnDto_ns +  ",cl:" + $returnDto_cl

# -----------------------------------------------------------------------------------------------------

ccg.exe gdf -f $returndto_filefullname  -t $returndto_templatefilename -p $projectfile -a $returndto_argument
