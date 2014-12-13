﻿using Domain.Entity.Construction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Construction
{
    public interface IComponentRepository : IRepository<Guid, Component>
    {
        IList<Component> GetActiveByNumber(Component component);
    }
}
