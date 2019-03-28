using FluentNHibernate.Mapping;
using System;

namespace Autodromo.Data.VO
{
    public class Usuario : BaseBusinessObject
    {
        public virtual int Id { get; set; }
        public virtual String UserName { get; set; }
        public virtual String Password { get; set; }
        public virtual Boolean Estatus { get; set; }
    }
    public class UsuarioMap : ClassMap<Usuario>
    {
        public UsuarioMap()
        {
            Id(x => x.Id).Column("Id").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.UserName).Nullable().Length(50);
            Map(x => x.Password).Not.Nullable().Length(50);
            Map(x => x.Estatus).Nullable();

            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();
            Version(x => x.Version).Not.Nullable();
        }
    }
}
