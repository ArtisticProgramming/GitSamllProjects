import re

template = """

        public  GeneralSubject { get; set; }
        public  NoteType { get; set; }
        public  SpecificSubject { get; set; }
        public  Project { get; set; }
        public  User { get; set; }
"""


text = re.sub(r'public|Guid|long|string|char|float|int|byte|double|bool|short|DateTimeOffset|{ get; set; }|class.*|{|} |using.*|namespace.*|}| |Nullable<.*>|\?', '', template)

textArr=text.split('\n')
print("")
for x in textArr:
        if x:
           print(x)
print("--------------------------OR------------------------")        
for x in textArr:
        if x:
           print(x +' = source.'+ x+ " ,")  
print("")
