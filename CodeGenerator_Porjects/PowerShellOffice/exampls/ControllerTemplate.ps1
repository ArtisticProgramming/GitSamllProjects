#****************************  config variables  ****************************
$BaseName = "Instruction"
#*****  DTO  *********
$ModelDTO_FileName="Instruction"+"ModelDto"
$ModelDB_FileName= "TemplateFile"

#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#****************************  APLICATION START  ****************************
$projectFile= "C:\Users\jafar\Source\Repos\BCMLogic core\BcmWebExtension\Model\Model.csproj"
$tmplateBasePath = "D:\GitProject\CSharpCodeGenerator\PowerShellTest\ccgTemplate\Model\"
$baseNameSpace ="Model."
#*************************************************************
$ModelInterface_tempName="ModelInterfaceTmpl"
$ModelImplementation_tempName="ModelImplementationTmpl"
$ModelDto_tempName="DtoTempl"
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%
#--------------------------------------  Model DTO  ----------------------------------------------------
$ModelDto_fileDirectoryPath="\DTO\"
# ----------argument----------
$ModelDto_ns = $baseNameSpace +"DTO.Models"
$ModelDto_cl =$ModelDTO_FileName


#########################################__Model Interfaces__#######################################
$ModelInterface_fileDirectoryPath ="\Models\Interfaces\"
$ModelInterface_ns = $baseNameSpace +"Models"
$ModelInterface_in ="I"+$BaseName+"Model"
$ModelInterface_ModelDto =$ModelDto_ns+"."+$ModelDTO_FileName
$ModelInterface_ModelDB =$ModelDB_FileName

#########################################__Model Implementation__###################################
$ModelImp_fileDirectoryPath ="\Models\Implementation\"
$ModelImp_ns = $baseNameSpace +"Implementation" 
$ModelImp_cs = $BaseName+"Model"
$ModelImp_in = $ModelInterface_in
$ModelImp_ModelDto =$ModelDto_ns+"."+$ModelDTO_FileName
$ModelImp_ModelDB =$ModelDB_FileName


#############################################__ARGUMENTS__######################################################
$ModelInterface_argument =
	"ns:" + $ModelInterface_ns  +
    ",in: " + $ModelInterface_in +                     
    ",modeldto: " + $ModelInterface_ModelDto  +
     ",dbModel: " + $ModelInterface_ModelDB 
# -----------------------------
$ModelImplementation_argument=
   "ns:" + $ModelImp_ns+
    ",cl:" + $ModelImp_cs  +                        
    ",in:" + $ModelImp_in  +                       
    ",modeldto:" + $ModelImp_ModelDto +
    ",dbModel:" + $ModelImp_ModelDB 
# -----------------------------
$ModelDto_argument=
 "ns:" + $ModelDto_ns + 
  ","+"cl:" + $ModelDto_cl

###########################################################_Prepeare Varible_#################################################
$ModelDto_fileFullName = $ModelDto_fileDirectoryPath + $ModelDTO_FileName+".cs"
#----------------------------------

$ModelInterface_fileFullName = $ModelInterface_fileDirectoryPath + "I"+$BaseName+"Model"+".cs"

$ModelImplementation_fileFullName = $ModelImp_fileDirectoryPath + $BaseName+"Model"+".cs"
#----------------------------------

$entryDto_templateFileName= $tmplateBasePath + $ModelDto_tempName +".txt"

$ModelInterface_templateFileName= $tmplateBasePath + $ModelInterface_tempName +".txt"

$ModelImplementation_templateFileName= $tmplateBasePath + $ModelImplementation_tempName +".txt"

################################################################_EXECUTION_####################################################

D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $ModelDto_fileFullName  -t $entrydto_templatefilename -p $projectfile -a $ModelDto_argument

D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $ModelInterface_fileFullName  -t $Modelinterface_templatefilename -p $projectfile -a $ModelInterface_argument

D:\GitProject\CSharpCodeGenerator\src\CSharpCodeGenerator\bin\Debug\ccg.exe gdf -f $Modelimplementation_filefullname  -t $Modelimplementation_templatefilename -p $projectfile -a $ModelImplementation_argument

