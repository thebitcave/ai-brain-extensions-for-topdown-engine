using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionCrouchStart"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Crouch Start")]
    public class AIActionCrouchStartNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionCrouchStart>();
            action.Label = label;
            return action;
        }
    }
}