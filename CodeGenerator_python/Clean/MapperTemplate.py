import core_module.ExecuterModule as exe

print(__name__)

class GlobalOption:
    # Class attribute
    base= r"C:\home\CodeNetPlus\CodeNet"   
    ClassTemplateBasePath =base +r'\templates\\mapperClassTempl.txt'
    InterfaceTemplateBasePath =base + r'\templates\mapperInterfaceTempl.txt'
    outPutBasePath_Class=base + r'\CodeNet.API\src\CodeNet.Domain\Mappers\\'
    outPutBasePath_Interface=base + r'\CodeNet.API\src\CodeNet.Domain\Mappers\Interfaces'
#-------------------------------------------------------------------------------------------------------

def createClassTemplate(baseName, outPutBasePath):
   
    paramDic = {
        "cl":baseName,
        "ns":"CodeNet.Domain.Mappers"   
    }

    templatePath =GlobalOption.ClassTemplateBasePath

    param = exe.createParamtersString(paramDic)

    className =baseName+"Mapper"
    OutPutPath ="\\"+className+".cs"

    exe.executor(OutPutPath,templatePath,outPutBasePath,param)

# //--------------------------------------------------------------------------------
def createInterfaceTemplate(baseName, outPutBasePath):

    paramDic = {
        "cl": baseName,
        "ns":"CodeNet.Domain.Mappers.Interfaces"   
    }

    templatePath = GlobalOption.InterfaceTemplateBasePath
    className =baseName+"Mapper"
    OutPutPath =r'\I'+className+'.cs'
    param = exe.createParamtersString(paramDic)
    exe.executor(OutPutPath,templatePath,outPutBasePath,param)

def cgRunner():
    outPutBasePath_Class =  GlobalOption.outPutBasePath_Class
    outPutBasePath_Interface =  GlobalOption.outPutBasePath_Interface
    arrName= [
        # "CodeNote"                 ,
        "CodeNoteDetail"           ,
        "GeneralSubject"           ,
        "NoteType"                 ,
        "ProgrammingLanguage"      ,
        "Project"                  ,
        "SpecificSubject"          ,
        "User"                     
    ]
    for baseName in arrName:
        createClassTemplate(baseName,outPutBasePath_Class)
        createInterfaceTemplate(baseName,outPutBasePath_Interface)
    print("---------Finish----------")

if (__name__ == "__main__"):
    cgRunner()
   