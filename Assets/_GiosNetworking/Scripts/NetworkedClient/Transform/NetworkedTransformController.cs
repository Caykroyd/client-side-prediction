using UnityEngine;

namespace ClientSidePrediction.TR
{
    public class NetworkedTransformController : NetworkedClient<TransformInput, TransformState>
    {
        [Header("CharacterController/Settings")]
        [SerializeField] float speed = 10f;

        public override void SetState(TransformState state)
        {
            transform.position = state.position;
        }

        public override void ProcessInput(TransformInput input)
        {
            Vector2 velocity = Vector2.ClampMagnitude(input.input, 1f) * speed;
            transform.Translate(velocity * input.deltaTime);
        }

        protected override TransformState RecordState(uint lastProcessedInputTick)
        {
            return new TransformState(transform.position, lastProcessedInputTick);   
        }
    }
}