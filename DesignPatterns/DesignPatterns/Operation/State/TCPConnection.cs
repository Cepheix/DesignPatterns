namespace DesignPatterns.Operation.State
{
    /// <summary>
    /// context
    /// </summary>
    public class TCPConnection
    {
        private TCPState _state;

        public void Open()
        {
            this._state.Open(this);
        }

        public void Acknowledge()
        {
            this._state.Acknowledge(this);
        }

        public void Close()
        {
            this._state.Close(this);
        }

        public void SetState(TCPState state)
        {
            this._state = state;
        }
    }
}
