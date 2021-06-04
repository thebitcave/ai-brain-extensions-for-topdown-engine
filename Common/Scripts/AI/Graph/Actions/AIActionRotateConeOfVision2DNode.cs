using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionRotateConeOfVision2D"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/2D/Rotate Cone of Vision")]
    public class AIActionRotateConeOfVision2DNode : AIActionNode
    {
        public AIActionRotateConeOfVision2D.Modes mode = AIActionRotateConeOfVision2D.Modes.Movement;

        public bool interpolate = false;
        public float interpolateRate = 5f;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionRotateConeOfVision2D>();
            action.Label = label;
            action.Mode = mode;
            action.Interpolate = interpolate;
            action.InterpolateRate = interpolateRate;
            return action;
        }
    }
}