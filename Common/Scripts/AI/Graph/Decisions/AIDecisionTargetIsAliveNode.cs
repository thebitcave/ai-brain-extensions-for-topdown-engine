using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionTargetIsAlive"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Target Is Alive")]
    public class AIDecisionTargetIsAliveNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTargetIsAlive>();
            decision.Label = label;
            return decision;
        }
    }
}