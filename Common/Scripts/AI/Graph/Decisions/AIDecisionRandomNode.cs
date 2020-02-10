using UnityEngine;
using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIDecisionRandom"/> decision.
    /// </summary>
    [CreateNodeMenu("AI/Decision/Random")]
    public class AIDecisionRandomNode : AIDecisionNode
    {
        public int totalChance = 10;
        public int odds = 4;

        public override AIDecision AddDecisionComponent(GameObject go)
        {
            var decision = go.AddComponent<AIDecisionRandom>();
            decision.Label = label;
            decision.TotalChance = totalChance;
            decision.Odds = odds;
            return decision;
        }
    }
}