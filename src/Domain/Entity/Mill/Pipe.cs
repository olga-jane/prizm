﻿using System;
using Domain.Entity.Setup;
using System.Collections.Generic;

namespace Domain.Entity.Mill
{
    public class Pipe : PipelinePiece
    {
        public Pipe()
        {
            this.Welds = new List<Weld>();
            this.Coats = new List<Coat>();
            this.PipeTestResult = new List<PipeTestResult>();

            this.Plate = new Plate() { Pipe = this };
        }


        public virtual Plate Plate { get; set; }

        public virtual string Mill { get; set; }
        public virtual int Diameter { get; set; }
        public virtual int WallThickness { get; set; }
        public virtual int Weight { get; set; }
        public virtual DateTime ProductionDate { get; set; }

        public virtual PipeMillSizeType Type { get; set; }

        public virtual Railcar Railcar { get; set; }

        public virtual PurchaseOrder PurchaseOrder { get; set; }

        public virtual ChemicalComposition ChemicalComposition { get; set; }

        public virtual IList<Weld> Welds { get; set; }
        public virtual IList<PipeTestResult> PipeTestResult { get; set; }
        public virtual IList<Coat> Coats { get; set; }

        //enum
        public virtual PipeMillStatus Status { get; set; }
    }
}