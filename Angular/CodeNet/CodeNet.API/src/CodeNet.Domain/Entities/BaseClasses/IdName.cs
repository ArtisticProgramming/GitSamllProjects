using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Entities.BaseClasses
{
    public abstract class IdName
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }
}
