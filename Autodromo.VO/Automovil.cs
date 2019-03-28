using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autodromo.Data.VO
{
    public class Automovil : BaseBusinessObject
    {
        public virtual Int32 ID { get; set; }
        public virtual Int32 Numero { get; set; }
        public virtual String Cilindrada { get; set; }
        public virtual String TipoMotor { get; set; }
        public virtual String Marca { get; set; }
        public virtual Int32 Modelo { get; set; }
        public virtual String Imagen { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Club Club { get; set; }

        public virtual Boolean Estatus { get; set; }
    }
    public class AutomovilMap : ClassMap<Automovil>
    {
        public AutomovilMap()
        {
            Id(x => x.ID).Column("ID").GeneratedBy.Assigned().GeneratedBy.Identity();
            Map(x => x.Numero).Not.Nullable();
            Map(x => x.Marca).Not.Nullable().Length(50);
            Map(x => x.Modelo).Not.Nullable().Length(50);
            Map(x => x.Imagen).Nullable().Length(50);
            Map(x => x.Cilindrada).Not.Nullable().Length(10);
            Map(x => x.TipoMotor).Not.Nullable().Length(20);
            References(x => x.Categoria).Column("CategoriaID").Not.Nullable().ForeignKey("FK_Automovil_Categoria");
            References(x => x.Club).Column("ClubID").Not.Nullable().ForeignKey("FK_Automovil_Club");


            Map(x => x.Estatus).Nullable();

            Map(x => x.CreatedBy).Nullable().Length(25);
            Map(x => x.UpdatedBy).Nullable().Length(25);
            Map(x => x.CreatedDT).Nullable();
            Map(x => x.UpdatedDT).Nullable();
            Version(x => x.Version).Not.Nullable();

        }
    }
}
