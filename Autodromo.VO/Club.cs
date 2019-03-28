using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodromo.Data.VO
{
    public class Club:BaseBusinessObject
    {
        public virtual int ID { get; set; }
        public virtual string Nombre { get; set; }
    }
    public class ClubMap : ClassMap<Club>
    {
        public ClubMap()
        {
            Id(x => x.ID).Column("ID").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.Nombre).Not.Nullable();


            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();

            Version(x => x.Version).Not.Nullable();
        }
    }
}
