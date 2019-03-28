using FluentNHibernate.Mapping;
using System;

namespace Autodromo.Data.VO
{
    public class Categoria : BaseBusinessObject
    {
        public virtual Int32 ID { get; set; }
        public virtual String Nombre { get; set; }

    }
    public class CategoriaMap : ClassMap<Categoria>
    {
        public CategoriaMap()
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
