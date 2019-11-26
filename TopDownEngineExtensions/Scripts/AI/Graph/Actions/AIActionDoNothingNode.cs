using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionDoNothing"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Do Nothing")]
    public class AIActionDoNothingNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionDoNothing>();
            action.Label = label;
            return action;
        }
    }
}