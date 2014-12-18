﻿using Prizm.Domain.Entity.Mill;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prizm.Data.DAL.Mill
{
    public interface IChemicalCompositionRepository : IRepository<Guid, ChemicalComposition>
    {
        IList<ChemicalComposition> GetByHeatId(Guid heatId);
    }
}
