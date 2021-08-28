import subprocess, sys
import os

print(__name__)
# class Untility:
#     @staticmethod
#     def MakeParam(key , value):
#         return key +":"+value

sep ="," 

    # def __init__(self):

def executor(OutPutPath,TemplatePath, OutPutBasePath, Param):
    command = "ccg.exe gf -f "+OutPutPath+" -t "+TemplatePath+" -p "+OutPutBasePath+" -a "+ Param
    process = subprocess.Popen(["powershell",command],stdout=subprocess.PIPE)
    result = process.communicate()[0]
    print (result)

def MakeParam(key , value):
        return key +":"+value    

def OpenFolder(path):
    path = os.path.realpath(path)
    os.startfile(path)

def createParamtersString(dictionaryParam):
    paramArray =[]
    for x in dictionaryParam:
        paramArray.append(MakeParam(x,dictionaryParam[x]))  
    Param =  sep.join(paramArray)
    return Param