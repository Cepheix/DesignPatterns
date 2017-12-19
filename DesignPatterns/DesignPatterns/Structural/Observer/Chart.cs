using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Observer
{
    public abstract class Chart : Observer
    {
        protected DataModel _dataModel;

        protected Chart(DataModel dataModel)
        {
            this._dataModel = dataModel;
        }

        public abstract void DrawChart();

        public override void Update()
        {

        }
    }
}
