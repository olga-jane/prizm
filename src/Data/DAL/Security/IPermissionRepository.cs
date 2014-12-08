﻿using Domain.Entity.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DAL.Security
{
   public interface IPermissionRepository : IRepository<Guid, Permission>
   {
   }
}
