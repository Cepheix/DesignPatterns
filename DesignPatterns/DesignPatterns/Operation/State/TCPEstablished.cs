namespace DesignPatterns.Operation.State
{
    /// <summary>
    /// concrete state
    /// </summary>
    public class TCPEstablished : TCPState
    {
        public override void Acknowledge(TCPConnection connection)
        {
            //implementation here
            connection.SetState(new TCPListen());
        }
    }
}
