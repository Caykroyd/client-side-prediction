using System;
using UnityEngine;

namespace ClientSidePrediction.TR
{
    [System.Serializable]
    public struct TransformState: IEquatable<TransformState>, INetworkedClientState
    {
        public uint LastProcessedInputTick => lastProcessedInput;
        
        public Vector3 position;
        public uint lastProcessedInput;

        public TransformState(Vector3 position, uint lastProcessedInput)
        {
            this.position = position;
            this.lastProcessedInput = lastProcessedInput;
        }

        public bool Equals(TransformState other)
        {
            return position.Equals(other.position) && lastProcessedInput == other.lastProcessedInput;
        }

        public bool Equals(INetworkedClientState other)
        {
            return other is TransformState __other && Equals(__other);
        }
    }
}