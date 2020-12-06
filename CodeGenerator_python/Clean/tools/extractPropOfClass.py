import re

template = """
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long IsActive { get; set; }
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
