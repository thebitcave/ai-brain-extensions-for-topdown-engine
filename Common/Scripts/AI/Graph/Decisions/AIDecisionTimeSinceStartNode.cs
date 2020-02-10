using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionTimeSinceStart"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Time Since Start")]
    public class AIDecisionTimeSinceStartNode : AIDecisionNode
    {
        public float afterTime;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionTimeSinceStart>();
            decision.Label = label;
            decision.AfterTime = afterTime;
            return decision;
        }
    }
}