namespace DesignPatterns.Operation.State
{
    /// <summary>
    /// concrete state
    /// </summary>
    public class TCPClosed : TCPState
    {
        public override void Open(TCPConnection connection)
        {
            //implementation here
            connection.SetState(new TCPEstablished());
        }
    }
}
