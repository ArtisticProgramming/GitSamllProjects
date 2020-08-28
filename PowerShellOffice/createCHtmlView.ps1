#--------------------------------------------------APLICATION START---------------------------------------------
$projectFile=  "C:\Users\jafar\Source\Repos\BCMLogic core\BcmWebExtension\BcmWebExtension\BcmWebExtension.csproj"

$tmplateBasePath = "D:\GitProject\CSharpCodeGenerator\PowerShellTest\ccgTemplate\"

#-------config variables------------------
    $ViewFolderName = "Vendor"                                  # Folder
    $FileName   = "_TransparentDataApi_p22"                   # File Return Model

# -------------------------------------------Rerturn DTO MODEL----------------------------------------------------------
$templName="ListView"

$DirectoryPath="\Views\"+ $ViewFolderName +"\"

$templatePath= $tmplateBasePath + $templName +".txt"

$path = $DirectoryPath + $FileName+".cshtml"

#--------argument-----------
$returnDto_argument= "ns:0"

# -----------------------------------------------------------------------------------------------------
Write-Host  "gdf" "-f"  $path  "-t" '$templatePath' "-p" $projectfile "-a" $returndto_argument

D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $path  -t $templatePath -p $projectfile -a $returndto_argument


