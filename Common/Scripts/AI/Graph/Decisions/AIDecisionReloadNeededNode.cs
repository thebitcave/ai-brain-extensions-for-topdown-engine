using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionReloadNeeded"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Reload Needed")]
    public class AIDecisionReloadNeededNode : AIDecisionNode
    {
        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionReloadNeeded>();
            decision.Label = label;
            return decision;
        }
    }
}
