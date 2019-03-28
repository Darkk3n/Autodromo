using FluentNHibernate.Mapping;
using System;

namespace Autodromo.Data.VO
{
    public class Corredor : BaseBusinessObject
    {
        public virtual Int32 ID { get; set; }
        public virtual String Nombre { get; set; }
        public virtual String ApellidoPaterno { get; set; }
        public virtual String ApellidoMaterno { get; set; }
        public virtual String NombreCompleto { get; set; }
        public virtual String Imagen { get; set; }
        public virtual Boolean Estatus { get; set; }
        public virtual Club Club { get; set; }

    }
    public class CorredorMap : ClassMap<Corredor>
    {
        public CorredorMap()
        {
            Id(x => x.ID).Column("ID").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.Nombre).Not.Nullable().Length(50);
            Map(x => x.ApellidoPaterno).Not.Nullable().Length(50);
            Map(x => x.ApellidoMaterno).Not.Nullable().Length(50);
            Map(x => x.NombreCompleto).Not.Nullable().Length(50);
            Map(x => x.Imagen).Nullable().Length(50);
            References(x => x.Club).Column("ClubID").Not.Nullable().ForeignKey("FK_Corredor_Club");

            Map(x => x.Estatus).Nullable();

            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();
            Version(x => x.Version).Not.Nullable();
        }
    }
}
