using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionTargetFacingAI2D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/2D/Target Facing AI")]
    public class AIDecisionTargetFacingAI2DNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTargetFacingAI2D>();
            decision.Label = label;
            return decision;
        }
    }
}