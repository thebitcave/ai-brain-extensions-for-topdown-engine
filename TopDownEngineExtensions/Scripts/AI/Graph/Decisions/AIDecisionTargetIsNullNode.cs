using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionTargetIsNull"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Target Is Null")]
    public class AIDecisionTargetIsNullNode : AIDecisionNode
    {
        public bool onlyOnce = true;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTargetIsNull>();
            decision.Label = label;
            return decision;
        }

    }
}