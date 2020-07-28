using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayanTextNomalize.BusinessLayer
{
    public class CommentModel
    {
        public void Get()
        {
            using (Model.Model1 db = new Model.Model1())
            {
                var data = db.MemberComment_W.Take(1000);

            }
        }
    }
}
