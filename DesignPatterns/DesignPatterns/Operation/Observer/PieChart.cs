using System;

namespace DesignPatterns.Structural.Observer
{
    /// <summary>
    /// concrete observer
    /// </summary>
    public class PieChart : Chart
    {
        public PieChart(DataModel dataModel) : base(dataModel)
        {
        }

        public override void DrawChart()
        {
            throw new NotImplementedException();
        }
    }
}
