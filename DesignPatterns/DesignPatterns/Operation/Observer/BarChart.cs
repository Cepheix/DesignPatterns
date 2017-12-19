using System;

namespace DesignPatterns.Structural.Observer
{
    /// <summary>
    /// concrete observer
    /// </summary>
    public class BarChart : Chart
    {
        public BarChart(DataModel dataModel) : base(dataModel)
        {
        }

        public override void DrawChart()
        {
            throw new NotImplementedException();
        }
    }
}
