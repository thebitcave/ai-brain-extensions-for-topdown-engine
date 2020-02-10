using MoreMountains.TopDownEngine;
using MoreMountains.Tools;
using TheBitCave.MMToolsExtensions.AI.Graph;
using UnityEngine;

namespace TheBitCave.TopDownEngineExensions.AI.Graph
{
    /// <summary>
    /// A node representing a TopDown Engine <see cref="MoreMountains.TopDownEngine.AIActionCrouchStop"/> action.
    /// </summary>
    [CreateNodeMenu("AI/Action/Crouch Stop")]
    public class AIActionCrouchStopNode : AIActionNode
    {
        public override AIAction AddActionComponent(GameObject go)
        {
            var action = go.AddComponent<AIActionCrouchStop>();
            action.Label = label;
            return action;
        }
    }
}