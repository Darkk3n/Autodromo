using FluentNHibernate.Mapping;
using System;

namespace Autodromo.Data.VO
{
    public class Evento : BaseBusinessObject
    {
        public virtual Int32 ID { get; set; }
        public virtual String Nombre { get; set; }
        public virtual DateTime Fecha { get; set; }

    }
    public class EventoMap : ClassMap<Evento>
    {
        public EventoMap()
        {
            Id(x => x.ID).Column("ID").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.Nombre).Not.Nullable().Length(50);
            Map(x => x.Fecha).Not.Nullable();

            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();

            Version(x => x.Version).Not.Nullable();
        }
    }
}
