import core_module.ExecuterModule as exe

print(__name__)

class GlobalOption:
    # Class attribute
    repositoryClassTemplateBasePath = "C:\\home\\GitSamllProjects\\Angular\\CodeNet\\templates\\"
    repositoryInterfaceTemplateBasePath = "C:\\home\\GitSamllProjects\\Angular\\CodeNet\\templates\\"
    outPutBasePath_repositoryClass= "C:\\home\\GitSamllProjects\\Angular\\CodeNet\\CodeNet.API\\src\\CodeNet.Infrastructure\\Repositories\\"
    outPutBasePath_repositoryInterface= r"C:\home\GitSamllProjects\Angular\CodeNet\CodeNet.API\src\CodeNet.Domain\Repositories"


def createRepositoryClassTemplate(baseName, outPutBasePath):
    templatePath = GlobalOption.repositoryClassTemplateBasePath+"repositoryClassTempl.txt"
    className =baseName+"Repository"

    paramDic = {
        "in":"I"+className,
        "cl":className,
        "ns":"CodeNet.Infrastructure.Repositories"   
    }

    OutPutPath ='\\'+className+".cs"
    param = exe.createParamtersString(paramDic)
    #exe.executor(OutPutPath,templatePath,outPutBasePath,param)

def createRepositoryInterfaceTemplate(baseName, outPutBasePath):
    templatePath = GlobalOption.repositoryInterfaceTemplateBasePath +"repositoryInterfaceTempl.txt"
    className =baseName+"Repository"

    paramDic = {
        "in":"I"+className,
        "ns":"CodeNet.Domain.Repositories"   
    }

    OutPutPath ='\\I'+className+".cs"
    param = exe.createParamtersString(paramDic)
  #  exe.executor(OutPutPath,templatePath,outPutBasePath,param)

def cgRunner():
    outPutBasePath_repositoryClass =  GlobalOption.outPutBasePath_repositoryClass
    outPutBasePath_repositoryInterface =  GlobalOption.outPutBasePath_repositoryInterface
    arrName= [
        "CodeNote"                 ,
        "CodeNoteDetail"           ,
        "GeneralSubject"           ,
        "NoteType"                 ,
        "ProgrammingLanguage"      ,
        "Project"                  ,
        "SpecificSubject"          ,
        "User"                     
    ]
    for baseName in arrName:
        createRepositoryClassTemplate(baseName,outPutBasePath_repositoryClass)
        createRepositoryInterfaceTemplate(baseName,outPutBasePath_repositoryInterface)
    print("---------Finish----------")

if (__name__ == "__main__"):
    cgRunner()
   