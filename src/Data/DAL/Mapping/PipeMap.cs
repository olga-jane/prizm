﻿using Domain.Entity.Mill;
using FluentNHibernate.Mapping;
using NHibernate.Mapping.ByCode.Conformist;

namespace Data.DAL.Mapping
{
    public class PipeMap : SubclassMap<Pipe>
    {
        public PipeMap()
        {
            Map(_ => _.Mill).Column("mill");
            Map(_ => _.WallThickness, "wallThickness");
            Map(_ => _.Weight, "weight"); 
            Map(_ => _.Diameter).Column("diameter");

            References<Railcar>(x => x.Railcar).Column("railcarId");
            References<PurchaseOrder>(x => x.PurchaseOrder).Column("purchaseOrderId");
            References<Plate>(x => x.Plate).Column("plateId");
        }
    }
}