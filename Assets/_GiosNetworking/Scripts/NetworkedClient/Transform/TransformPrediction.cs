using UnityEngine;

namespace ClientSidePrediction.TR
{
    public class TransformPrediction : ClientPrediction<TransformInput, TransformState> 
    {
        protected override TransformInput GetInput(float deltaTime, uint currentTick)
        {
            var __inputs = new Vector2
            {
                x = Input.GetAxis("Horizontal"),
                y = Input.GetAxis("Vertical")
            };
            
            return new TransformInput(__inputs, currentTick, deltaTime);
        }
    }
}