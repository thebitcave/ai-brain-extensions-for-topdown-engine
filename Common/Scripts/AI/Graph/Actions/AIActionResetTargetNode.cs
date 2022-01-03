using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionResetTarget"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Reset Target")]
    public class AIActionResetTargetNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionResetTarget>();
            action.Label = label;
            
            return action;
        }
    }
}