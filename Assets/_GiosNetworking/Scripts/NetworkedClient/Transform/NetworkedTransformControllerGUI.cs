using UnityEngine;

namespace ClientSidePrediction.TR
{
    public class NetworkedTransformControllerGUI : NetworkedClientGUI
    {
        protected override void DrawStats()
        {
            base.DrawStats();
            GUILayout.Label($"Nothing to draw.");
        }

        protected override void SetPhantomState(GameObject phantom, INetworkedClientState state)
        {
            var __state = (TransformState) state;
            phantom.transform.position = __state.position;
        }
    }
}