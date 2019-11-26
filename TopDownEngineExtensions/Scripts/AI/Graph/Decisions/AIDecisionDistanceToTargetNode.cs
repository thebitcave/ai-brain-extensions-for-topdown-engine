using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionDistanceToTarget"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Distance To Target")]
    public class AIDecisionDistanceToTargetNode : AIDecisionNode
    {
        public AIDecisionDistanceToTarget.ComparisonModes comparisonMode = AIDecisionDistanceToTarget.ComparisonModes.GreatherThan;
        public float distance;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionDistanceToTarget>();
            decision.Label = label;
            decision.ComparisonMode = comparisonMode;
            decision.Distance = distance;
            return decision;
        }
    }
}