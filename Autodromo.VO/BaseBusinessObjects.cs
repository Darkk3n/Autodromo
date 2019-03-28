using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodromo.Data.VO
{
    public class BaseBusinessObject
    {
        public virtual String CreatedBy { get; set; }
        public virtual String UpdatedBy { get; set; }
        public virtual DateTime? CreatedDT { get; set; }
        public virtual DateTime? UpdatedDT { get; set; }
        public virtual Int32 Version { get; set; }
    }
}
