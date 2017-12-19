namespace DesignPatterns.Operation.State
{
    /// <summary>
    /// concrete state
    /// </summary>
    public class TCPListen : TCPState
    {
        public override void Close(TCPConnection connection)
        {
            //implementation here
            connection.SetState(new TCPClosed());
        }
    }
}
