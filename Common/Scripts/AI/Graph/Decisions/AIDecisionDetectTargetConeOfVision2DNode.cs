using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDetectTargetConeOfVision2D"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/2D/Detect Target Cone Of Vision")]
    public class AIDecisionDetectTargetConeOfVision2DNode : AIDecisionNode
    {

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDetectTargetConeOfVision2D>();
            decision.Label = label;
            return decision;
        }
    }
}