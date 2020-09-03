import subprocess, sys

str = "ccg.exe gf  -f  'sdfsdfsdfsfsdf_List\\GetActionData.cs'  -t  'C:\\temp\\Templates\\GetActionData.txt'  -p  'C:\\temp\\TempFolder\\'  -a  GetActionData:Hello,IGetActionQuery:Hellao,ActionQueryParam:Hello"

process= subprocess.Popen(["powershell",str],stdout=subprocess.PIPE);
result=process.communicate()[0]
print (result)


