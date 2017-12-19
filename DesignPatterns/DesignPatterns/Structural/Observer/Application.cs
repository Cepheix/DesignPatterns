using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Observer
{
    public class Application
    {
        public void Run()
        {
            DataModel data = new DataModel();

            BarChart barChart = new BarChart(data);
            PieChart pieChart = new PieChart(data);
            Table table = new Table(data);

            data.SetData(new int[2, 2] { { 1, 1}, { 2, 2} }); // charts will now redraw
        }
    }
}
