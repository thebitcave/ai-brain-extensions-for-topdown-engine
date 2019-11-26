using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionNextFrame"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Next Frame")]
    public class AIDecisionNextFrameNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionNextFrame>();
            decision.Label = label;
            return decision;
        }
    }
}