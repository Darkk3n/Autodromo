using FluentNHibernate.Mapping;
using System;

namespace Autodromo.Data.VO
{
    public class Carrera : BaseBusinessObject
    {
        public virtual Int32 ID { get; set; }
        public virtual Evento Evento { get; set; }
        public virtual Corredor Corredor { get; set; }
        public virtual Automovil Automovil { get; set; }
        public virtual TimeSpan Tiempo { get; set; }
        public virtual Boolean Estatus { get; set; }

    }
    public class CarreraMap : ClassMap<Carrera>
    {
        public CarreraMap()
        {
            Id(x => x.ID).Column("ID").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.Tiempo).CustomType("TimeAsTimeSpan").Not.Nullable();
            Map(x => x.Estatus).Nullable();
            References(x => x.Automovil).Column("AutomovilID").Not.Nullable().ForeignKey("FK_Automovil_Carrera");
            References(x => x.Corredor).Column("CorredorID").Not.Nullable().ForeignKey("FK_Corredor_Carrera");
            References(x => x.Evento).Column("EventoID").Not.Nullable().ForeignKey("FK_Evento_Carrera");


            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();

            Version(x => x.Version).Not.Nullable();

        }
    }
}