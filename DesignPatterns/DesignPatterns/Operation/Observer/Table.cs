using System;

namespace DesignPatterns.Structural.Observer
{
    /// <summary>
    /// concrete observer
    /// </summary>
    public class Table : Observer
    {
        private readonly DataModel _dataModel;

        public Table(DataModel dataModel)
        {
            this._dataModel = dataModel;
        }

        public override void Update()
        {
            DrawTable();
        }

        public void DrawTable()
        {
            // draw table from data model
        }
    }
}
