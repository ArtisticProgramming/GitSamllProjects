using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayanTextNomalize.Dto
{
    public class CommentDto
    {
        public Guid MemberCommentId { get; set; }
        public string Body { get; set; }
        public string Body_After_Standardization { get; set; }
        public string Body_After_Cleaning { get; set; }
        public string Body_After_Steaming{ get; set; }
        public string Body_After_RemovingStopWords { get; set; }

    }
}
