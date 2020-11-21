using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Domain.Entities.BaseClasses
{
    public abstract class IdName
    {
        public long Id { get; set; }
        public long Name { get; set; }
    }
}
