namespace DesignPatterns.Structural.Observer
{
    /// <summary>
    /// concrete subject
    /// </summary>
    public class DataModel : Subject
    {
        private int[,] _tableData;

        public int[,] GetData()
        {
            return this._tableData;
        }

        public void SetData(int[,] data)
        {
            this._tableData = data;
            this.Notify();
        }
    }
}
