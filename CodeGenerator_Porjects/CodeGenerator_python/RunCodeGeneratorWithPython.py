import Clean.Moduls.ExecuterModule as exe
import Clean.Moduls.Utilities as util

print(__name__)

BaseName = input("Enter Base Name: ") 
print(BaseName)
OutPutBasePath=  exe.GlobalOption.OutPutBasePath

TemplatePath = exe.GlobalOption.TemplatePath+"GetActionData.txt"
OutPutPath =util.GeneratetCurrentDateTime()+'\\'+"Get"+BaseName+"Data.cs"

paramArray =[]
paramArray.append(exe.MakeParam("Get"+BaseName+"Data" ,"1"))  
paramArray.append(exe.MakeParam("IGet"+BaseName+"Query" ,"2"))
paramArray.append(exe.MakeParam(BaseName+"QueryParam" ,"3"))
Param =  exe.sep.join(paramArray)

exe.executor(OutPutPath,TemplatePath,OutPutBasePath,Param)

#exe.OpenFolder(OutPutBasePath+OutPutPath)
