import re

template = """
        public long UId { get; set; }
        public Nullable<long> ComponentUId { get; set; }
        public Nullable<long> Componentid { get; set; }
        public Nullable<bool> id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string status { get; set; }
        public string technology { get; set; }
        public string integrationTechnologyName { get; set; }
        public string descriptionEN { get; set; }

"""


text = re.sub(r'public|Guid|long|string|char|float|int|byte|double|bool|short|DateTimeOffset|{ get; set; }|class.*|{|} |using.*|namespace.*|}|Nullable<.*>|\?', '', template)

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
