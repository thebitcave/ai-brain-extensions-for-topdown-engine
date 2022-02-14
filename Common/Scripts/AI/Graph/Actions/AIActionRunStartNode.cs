using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionRunStart"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/RunStart")]
    public class AIActionRunStartNode : AIActionNode
    {
        public bool onlyRunOnce = true;

        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionRunStart>();
            action.Label = label;
            action.OnlyRunOnce = onlyRunOnce;
            
            return action;
        }
    }
}