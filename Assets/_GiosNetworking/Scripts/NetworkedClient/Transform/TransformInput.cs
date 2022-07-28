using UnityEngine;

namespace ClientSidePrediction.TR
{
    [System.Serializable]
    public struct TransformInput : INetworkedClientInput
    {
        public uint Tick => tick;
        public float DeltaTime => deltaTime;
        
        public uint tick;
        public Vector2 input;
        public float deltaTime;

        public TransformInput(Vector2 input, uint tick, float deltaTime)
        {
            this.input = input;
            this.tick = tick;
            this.deltaTime = deltaTime;
        }
    }
}