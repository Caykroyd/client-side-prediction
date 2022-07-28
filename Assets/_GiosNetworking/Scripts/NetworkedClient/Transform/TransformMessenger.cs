using System;
using Mirror;

namespace ClientSidePrediction.TR
{
    public class TransformMessenger : NetworkBehaviour, INetworkedClientMessenger<TransformInput, TransformState>
    {
        public event Action<TransformInput> OnInputReceived;

        public TransformState LatestServerState => _latestServerState;

        TransformState _latestServerState;
        
        public void SendState(TransformState state)
        {
            RpcSendState(state);
        }

        public void SendInput(TransformInput input)
        {
            CmdSendInput(input);
        }
        
        [ClientRpc(channel = Channels.Unreliable)]
        void RpcSendState(TransformState state)
        {
            _latestServerState = state;
        }
        
        [Command(channel = Channels.Unreliable)]
        void CmdSendInput(TransformInput input)
        {
            OnInputReceived?.Invoke(input);
        }
    }
}