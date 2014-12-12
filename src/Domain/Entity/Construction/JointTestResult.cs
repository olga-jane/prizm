﻿using Domain.Entity.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity.Construction
{
    public class JointTestResult : TestResult <JointTestResultStatus>
    {
        public virtual Joint Joint { get; set; }
        public virtual JointOperation Operation { get; set; }
    }
}
