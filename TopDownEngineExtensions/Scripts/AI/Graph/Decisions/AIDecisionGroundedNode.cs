using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionGrounded"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Grounded")]
    public class AIDecisionGroundedNode : AIDecisionNode
    {
        public float groundedBufferDelay = 0.2f;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionGrounded>();
            decision.Label = label;
            decision.GroundedBufferDelay = groundedBufferDelay;
            return decision;
        }
    }
}