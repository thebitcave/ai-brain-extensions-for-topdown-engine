using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionHealth"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Health")]
    public class AIDecisionHealthNode : AIDecisionNode
    {
        [NodeEnum] public AIDecisionHealth.ComparisonModes trueIfHealthIs;
        public int healthValue;
        public bool onlyOnce = true;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionHealth>();
            decision.Label = label;
            decision.TrueIfHealthIs = trueIfHealthIs;
            decision.HealthValue = healthValue;
            decision.OnlyOnce = onlyOnce;
            return decision;
        }
    }
}
