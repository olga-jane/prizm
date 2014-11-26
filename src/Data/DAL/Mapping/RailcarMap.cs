﻿using Domain.Entity.Mill;
using FluentNHibernate.Mapping;

namespace Data.DAL.Mapping
{
    public class RailcarMap : SubclassMap<Railcar>
    {
        public RailcarMap()
        {
            Table("Railcar");
            Map(x => x.Number).Column("number");
            Map(_ => _.Destination, "destination");
            Map(_ => _.Certificate, "certificate");
	        Map(_ => _.ShippingDate, "shippingDate");
            Map(_ => _.IsShipped, "isShipped");
            HasMany(_ => _.Pipes).KeyColumn("railcarId");
        }
    }
}