namespace DesignPatterns.Operation.State
{
    /// <summary>
    /// state
    /// </summary>
    public abstract class TCPState
    {
        public virtual void Open(TCPConnection connection)
        { }

        public virtual void Close(TCPConnection connection)
        { }

        public virtual void Acknowledge(TCPConnection connection)
        { }
    }
}
